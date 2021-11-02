using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class WeatherScreen : UserControl
    {
        /**
                Screen used for displaying any weather information, only one other screen is needed
        */

        // Variables
        int mode = 0; // 0 is current weather, 1 is weekly, 2 is search for location
        float selectBarX = 0;
        double rad2Deg = 180 / Math.PI;
        double t = 0;
        float nextDrop = 0;
        int theCondition = 800;
        int nextLightning = 60;
        Random randGen = new Random();
        int lightningX = 150;
        int nextCloud = 0;

        StringFormat centerFormat = new StringFormat(StringFormatFlags.NoClip);

        Image[] lightClouds = { Properties.Resources.cloud0, Properties.Resources.cloud1, Properties.Resources.cloud2 };
        Image[] grayClouds = { Properties.Resources.cloud3, Properties.Resources.cloud4, Properties.Resources.cloud5 };
        Image[] darkClouds = { Properties.Resources.cloud6, Properties.Resources.cloud7, Properties.Resources.cloud8 };

        Image[] snowParticles = { Properties.Resources.snow_0, Properties.Resources.snow_1, Properties.Resources.snow_2, Properties.Resources.snow_3 };

        Image cloudCover = Properties.Resources.cloudcover0;
        Image stormCover = Properties.Resources.cloudcover1;
        double cover1X = 0;
        double cover2X = -350;

        List<Particle> ps = new List<Particle>();

        Image ground = Properties.Resources.ground;
        Image moon = Properties.Resources.moon;
        Image lightning = Properties.Resources.lightning;

        string conditionToString(int condition)
        {
            if(condition >= 200 && condition <= 232)
            {
                return "Thunderstorm";
            }
            else if(condition >= 300 && condition <= 321)
            {
                return "Drizzle";
            }
            else if(condition == 500 || condition == 520)
            {
                return "Light Rain";
            }
            else if (condition == 502 || condition == 503 || condition == 504 || condition == 522 || condition == 531)
            {
                return "Heavy Rain";
            }
            else if(condition == 511)
            {
                return "Freezing Rain";
            }
            else if (condition == 501 || condition == 521)
            {
                return "Rain";
            }
            else if(condition == 600 || condition == 612 || condition == 620)
            {
                return "Flurries";
            }
            else if (condition == 602 || condition == 622)
            {
                return "Heavy Snow";
            }
            else if (condition == 601 || condition == 611 || condition == 613 || condition == 621)
            {
                return "Snow";
            }
            else if (condition == 615 || condition == 616)
            {
                return "Mixed Precipitation";
            }
            else if(condition == 701 || condition == 721 || condition == 741)
            {
                return "Fog";
            }
            else if (condition == 771)
            {
                return "Snow Squalls";
            }
            else if(condition == 800)
            {
                return "Clear";
            }
            else if (condition == 801)
            {
                return "Barely Cloudy";
            }
            else if (condition == 802)
            {
                return "Mainly Cloudy";
            }
            else if (condition == 803)
            {
                return "Partly Cloudy";
            }
            else if (condition == 804)
            {
                return "Overcast";
            }
            else
            {
                return "Death";
            }
        }

        double calculateSunHeight()
        {
            double returnValue = 0;

            // Get current hour/min/sec
            string currentHour = DateTime.Now.ToString("HH");
            string currentMin = DateTime.Now.ToString("mm");
            string currentSec = DateTime.Now.ToString("ss");

            // Get sunrise hour and min
            string sunriseHour = Convert.ToDateTime(Form1.days[0].sunrise).ToString("HH");
            string sunriseMin = Convert.ToDateTime(Form1.days[0].sunrise).ToString("mm");

            // Get sunset hour and min
            string sunsetHour = Convert.ToDateTime(Form1.days[0].sunset).ToString("HH");
            string sunsetMin = Convert.ToDateTime(Form1.days[0].sunset).ToString("mm");

            // Get sunrise and sunset variables
            double sunrise = Convert.ToDouble(sunriseHour) + (Convert.ToDouble(sunriseMin) / 60);
            sunrise += Form1.timezone;
            double sunset = Convert.ToDouble(sunsetHour) + (Convert.ToDouble(sunsetMin) / 60);
            sunset += Form1.timezone;

            // Get current time variable
            double curtime = Convert.ToDouble(currentHour) + (Convert.ToDouble(currentMin) / 60) + (Convert.ToDouble(currentSec) / 3600);
            //curtime = (t / 2) % 24;

            // Sunrise should be the zero
            curtime -= sunrise;
            sunset -= sunrise;
            sunrise = 0;

            if(sunset < 0)
            {
                sunset += 24;
            }
            if(curtime < 0)
            {
                curtime += 24;
            }

            if(curtime <= sunset)
            {
                returnValue = (curtime / sunset) * 180;
            }
            else
            {
                returnValue = 180 + ((curtime - sunset) / (24 - sunset)) * 180;
            }

            return returnValue;
        }

        Color lerpColor(Color c1, Color c2, double amt)
        {
            // c2.R = 50, c1.R = 30, amt = 0.5
            return Color.FromArgb(Convert.ToInt32(c1.R + (c2.R - c1.R) * amt), Convert.ToInt32(c1.G + (c2.G - c1.G) * amt), Convert.ToInt32(c1.B + (c2.B - c1.B) * amt));
        }

        public WeatherScreen()
        {
            InitializeComponent();
            centerFormat.LineAlignment = StringAlignment.Center;
            centerFormat.Alignment = StringAlignment.Center;
        }

        private void WeatherScreen_Paint(object sender, PaintEventArgs e)
        {

            if (mode == 0)
            {
                // Condition calculating

                // Sun height
                double sunSin = calculateSunHeight();

                if (theCondition >= 800 && theCondition <= 803)
                { // Clear skies
                    // Gradient
                    for (int i = 0; i < this.Height - 210; i += 2) // 440
                    {
                        Color skyColor = Color.FromArgb(64 + Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 4.78))), 110 + Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 5.56))), 201 + Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 8.8))));

                        Color sunsetColor = Color.FromArgb(136 + Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 3.79))), 120 + Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 7.72))), 255 - Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 1.75))));

                        Color nightColor = Color.FromArgb(Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 48.8))), Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 24.4))), Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 9.57))));

                        Color theColor = Color.FromArgb(0, 0, 0);

                        if (sunSin > 10 && sunSin < 160)
                        {
                            theColor = skyColor;
                        }
                        else if (sunSin >= 160 && sunSin < 180)
                        {
                            theColor = lerpColor(skyColor, sunsetColor, (sunSin - 160) / 20);
                        }
                        else if (sunSin >= 180 && sunSin < 220)
                        {
                            theColor = lerpColor(sunsetColor, nightColor, (sunSin - 180) / 40);
                        }
                        else if (sunSin >= 220 && sunSin < 350)
                        {
                            theColor = nightColor;
                        }
                        else if (sunSin >= 350 && sunSin <= 360)
                        {
                            theColor = lerpColor(nightColor, skyColor, (sunSin - 350) / 20);
                        }
                        else if (sunSin <= 10)
                        {
                            theColor = lerpColor(nightColor, skyColor, (sunSin + 10) / 20);
                        }

                        e.Graphics.FillRectangle(new SolidBrush(theColor), 0, Convert.ToSingle((i * 1.15) + 60), this.Width, 2.3f);
                    }

                    // Draw moon
                    double moonPosition = this.Height - 155 - Math.Sin((sunSin + 180) / rad2Deg) * 240;
                    e.Graphics.DrawImage(moon, this.Width / 2 - 21, Convert.ToSingle(moonPosition));


                    // Draw sun
                    double sunPosition = this.Height - 155 - Math.Sin(sunSin / rad2Deg) * 240;

                    e.Graphics.FillEllipse(new SolidBrush(Color.Yellow), this.Width / 2 - 25, Convert.ToSingle(sunPosition), 50, 50);
                }
                else
                {

                    if (conditionToString(theCondition) == "Thunderstorm" || conditionToString(theCondition) == "Heavy Rain" || conditionToString(theCondition) == "Heavy Snow" || conditionToString(theCondition) == "Snow Squalls")
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), 0, 60, this.Width, this.Height - 60);
                        e.Graphics.DrawImage(stormCover, Convert.ToSingle(cover1X), 55, this.Width + 2, 146);
                        e.Graphics.DrawImage(stormCover, Convert.ToSingle(cover2X) + this.Width, 55, -this.Width - 2, 146);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.Gray), 0, 60, this.Width, this.Height - 60);
                        e.Graphics.DrawImage(cloudCover, Convert.ToSingle(cover1X), 60, this.Width + 2, 126);
                        e.Graphics.DrawImage(cloudCover, Convert.ToSingle(cover2X) + this.Width, 60, -this.Width - 2, 126);
                    }
                    
                }

                // Ground
                e.Graphics.DrawImage(ground, 0, this.Height - 199);

                if(nextLightning <= 0)
                {
                    e.Graphics.DrawImage(lightning, lightningX, 70);
                }
                
                foreach (Particle p in ps)
                {
                    if (conditionToString(theCondition) == "Drizzle")
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 100, 200)), Convert.ToSingle(p.x - 2), 50 + Convert.ToSingle(p.y - 2), 4, 4);
                    }
                    else if (conditionToString(theCondition) == "Freezing Rain")
                    {
                        e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(120, 120, 200)), Convert.ToSingle(p.x - 2), 50 + Convert.ToSingle(p.y - 2), 4, 4);
                    }
                    else if(theCondition >= 800 && theCondition <= 803)
                    {
                        if (p.type >= 8) {
                            e.Graphics.DrawImage(darkClouds[p.type - 8], Convert.ToSingle(p.x), Convert.ToSingle(p.y) + 80, Convert.ToSingle(p.w), Convert.ToSingle(p.w / 1.5));
                        }
                        else
                        {
                            e.Graphics.DrawImage(lightClouds[p.type - 5], Convert.ToSingle(p.x), Convert.ToSingle(p.y) + 80, Convert.ToSingle(p.w), Convert.ToSingle(p.w / 1.5));
                        }
                    }
                    else
                    {
                        if (p.type == 0)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 100, 200)), Convert.ToSingle(p.x - 2), 50 + Convert.ToSingle(p.y - 2), 4, 10);
                        }
                        else
                        {
                            e.Graphics.DrawImage(snowParticles[p.type - 1], Convert.ToSingle(p.x - 8), 50 + Convert.ToSingle(p.y - 8));
                        }
                    }
                }


                // Location Label
                e.Graphics.DrawString($"{Form1.days[0].location}", new Font("Segoe UI", 12, FontStyle.Regular), new SolidBrush(Color.White), this.Width / 2, 90, centerFormat);

                // Temperature label
                e.Graphics.DrawString($"{Math.Round(Convert.ToDouble(Form1.days[0].currentTemp))}°", new Font("Segoe UI", 80, FontStyle.Bold), new SolidBrush(Color.White), this.Width / 2, 155, centerFormat);

                // Current Weather label
                e.Graphics.DrawString($"{conditionToString(Convert.ToInt16(Form1.days[0].condition))}", new Font("Segoe UI", 18, FontStyle.Bold), new SolidBrush(Color.White), this.Width / 2, 225, centerFormat);
            }

            // Select bar
            e.Graphics.FillRectangle(new SolidBrush(Color.White), selectBarX, 60, 118, 5);

        }

        private void updateTick_Tick(object sender, EventArgs e)
        {
            // Move select bar
            if(mode == 0)
            {
                selectBarX += (0 - selectBarX) / 5;
            }
            if (mode == 1)
            {
                selectBarX += (116 - selectBarX) / 5;
            }
            if (mode == 2)
            {
                selectBarX += (232 - selectBarX) / 5;
            }

            if (mode == 0)
            {
                cover1X += 0.2;
                cover2X += 0.2;
                if (cover1X >= 350)
                {
                    cover1X = -350;
                }
                if (cover2X >= 350)
                {
                    cover2X = -350;
                }
                t += 0.1;
                nextDrop--;

                //theCondition = Convert.ToInt16(Form1.days[0].condition);
                //theCondition = 202;
                if (conditionToString(theCondition) == "Drizzle")
                {
                    if (nextDrop <= 0)
                    {
                        ps.Add(new Particle(randGen.Next(-10, this.Width), 0, 0, 0, 7, 0));
                        nextDrop = 12;
                    }
                }
                else if (conditionToString(theCondition) == "Light Rain")
                {
                    if (nextDrop <= 0)
                    {
                        ps.Add(new Particle(randGen.Next(-10, this.Width), 0, 0, 1, 7, 0));
                        nextDrop = 8;
                    }
                }
                else if (conditionToString(theCondition) == "Rain" || conditionToString(theCondition) == "Freezing Rain")
                {
                    if (nextDrop <= 0)
                    {
                        ps.Add(new Particle(randGen.Next(-10, this.Width), 0, 0, 1, 7, 0));
                        nextDrop = 5;
                    }
                }
                else if (conditionToString(theCondition) == "Heavy Rain" || conditionToString(theCondition) == "Thunderstorm")
                {
                    if(conditionToString(theCondition) == "Thunderstorm")
                    {
                        nextLightning--;
                        if(nextLightning <= -5) {
                            nextLightning = randGen.Next(60, 600);
                            lightningX = randGen.Next(0, this.Width - 129);
                        }
                    }
                    if (nextDrop <= 0)
                    {
                        ps.Add(new Particle(randGen.Next(-10, this.Width), 0, 0, 1, 7, 0));
                        nextDrop = 3;
                    }
                }
                else if (conditionToString(theCondition) == "Heavy Snow" || conditionToString(theCondition) == "Snow Squalls")
                {
                    if (nextDrop <= 0)
                    {
                        ps.Add(new Particle(randGen.Next(-150, this.Width), 0, 2, 4, 7, randGen.Next(1, 5)));
                        nextDrop = 3;
                    }
                }
                else if (conditionToString(theCondition) == "Snow")
                {
                    if (nextDrop <= 0)
                    {
                        ps.Add(new Particle(randGen.Next(-150, this.Width), 0, 2, 4, 7, randGen.Next(1, 5)));
                        nextDrop = 5;
                    }
                }
                else if (conditionToString(theCondition) == "Flurries")
                {
                    if (nextDrop <= 0)
                    {
                        ps.Add(new Particle(randGen.Next(-150, this.Width), 0, 2, 4, 7, randGen.Next(1, 5)));
                        nextDrop = 8;
                    }
                }
                else if (conditionToString(theCondition) == "Mixed Precipitation")
                {
                    if (nextDrop <= 0)
                    {
                        ps.Add(new Particle(randGen.Next(-150, this.Width), 0, 0, 4, 7, randGen.Next(0, 2) == 1 ? randGen.Next(1, 5) : 0));
                        nextDrop = 5;
                    }
                }
                else if(theCondition >= 800 && theCondition <= 803)
                {
                    nextCloud--;
                    if(nextCloud <= 0 && randGen.Next(1, 1000) > Convert.ToInt32(Form1.days[0].cloudcover))
                    {
                        nextCloud = randGen.Next(60 - Convert.ToInt32(Convert.ToInt32(Form1.days[0].cloudcover) / 3), 200);
                        if (calculateSunHeight() <= 180)
                        {
                            ps.Add(new Particle(-100, randGen.Next(0, 400), Convert.ToDouble(randGen.Next(2, 5)) / 10, 0, 0, randGen.Next(5, 7)));
                            ps[ps.Count - 1].setWidth(randGen.Next(80, 180));
                            ps[ps.Count - 1].w = -ps[ps.Count - 1].w;
                        }
                        else
                        {
                            ps.Add(new Particle(-100, randGen.Next(0, 400), Convert.ToDouble(randGen.Next(2, 5)) / 10, 0, 0, randGen.Next(8, 10)));
                            ps[ps.Count - 1].setWidth(randGen.Next(80, 180));
                            ps[ps.Count - 1].x = -ps[ps.Count - 1].w;
                        }
                    }
                }

                foreach (Particle p in ps)
                {
                    p.Move();
                }

                for(int i = ps.Count - 1; i >= 0; i--)
                {
                    if (ps[i].x > 400)
                    {
                        ps.RemoveAt(i);
                        continue;
                    }
                    if (ps[i].y > 600)
                    {
                        ps.RemoveAt(i);
                        continue;
                    }
                }
            }


            this.Refresh();
        }

        private void locationButton_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void weekButton_Click(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            mode = 0;
        }
    }
}
