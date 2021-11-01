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

        StringFormat centerFormat = new StringFormat(StringFormatFlags.NoClip);

        string conditionToString(int condition)
        {
            if(condition >= 200 && condition <= 232)
            {
                return "Thunderstorms";
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
                // Gradient
                for(int i = 0;i < this.Height - 210;i+=2)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 100, 100 + Convert.ToInt32(Math.Floor(Convert.ToDouble(i / 4))))), 0, i + 60, this.Width, 2);
                }


                // Sunrise and sunset calculation
                string currentHour = Convert.ToDateTime(Form1.days[0].currentTime).ToString("HH");
                string currentMin = Convert.ToDateTime(Form1.days[0].currentTime).ToString("mm");

                string sunriseHour = Convert.ToDateTime(Form1.days[0].sunrise).ToString("HH");
                string sunriseMin = Convert.ToDateTime(Form1.days[0].sunrise).ToString("mm");

                string sunsetHour = Convert.ToDateTime(Form1.days[0].sunset).ToString("HH");
                string sunsetMin = Convert.ToDateTime(Form1.days[0].sunset).ToString("mm");

                double sunrise = Convert.ToDouble(sunriseHour) + (Convert.ToDouble(sunriseMin) / 60);
                double sunset = Convert.ToDouble(sunsetHour) + (Convert.ToDouble(sunsetMin) / 60);

                double curtime = Convert.ToDouble(currentHour) + (Convert.ToDouble(currentMin) / 60);

                if (sunset < sunrise)
                {
                    sunset += 24;
                }

                double sunSin = ((curtime - sunrise) / (sunset - sunrise)) * 180;
                double sunPosition = this.Height - 175 - Math.Sin(sunSin / rad2Deg) * 250;

                e.Graphics.FillEllipse(new SolidBrush(Color.Yellow), this.Width / 2 - 25, Convert.ToSingle(sunPosition), 50, 50);

                // Ground
                e.Graphics.FillRectangle(new SolidBrush(Color.DarkGreen), 0, this.Height - 150, this.Width, 150);

                // Temperature label
                e.Graphics.DrawString($"{Math.Round(Convert.ToDouble(Form1.days[0].currentTemp))}°", new Font("Segoe UI", 72, FontStyle.Bold), new SolidBrush(Color.White), this.Width / 2, 150, centerFormat);

                // Current Weather label
                e.Graphics.DrawString($"{conditionToString(Convert.ToInt16(Form1.days[0].condition))}", new Font("Segoe UI", 20, FontStyle.Bold), new SolidBrush(Color.White), this.Width / 2, 210, centerFormat);
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
