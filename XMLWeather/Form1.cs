using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();
        public static double timezone = 0;
        public static int maxID = 0;

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            WeatherScreen ws = new WeatherScreen();
            this.Controls.Add(ws);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                Day d = new Day();
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("number");

                reader.ReadToFollowing("precipitation");
                d.chanceofprep = reader.GetAttribute("probability");
                if (d.chanceofprep != "0") { 
                    d.precipitation = reader.GetAttribute("value");
                    if(d.precipitation == null)
                    {
                        d.precipitation = "";
                    }
                }

                reader.ReadToFollowing("windDirection");
                d.windDirection = reader.GetAttribute("code");

                reader.ReadToFollowing("windSpeed");
                d.windSpeed = reader.GetAttribute("mps");

                reader.ReadToFollowing("windGust");
                d.windGust = reader.GetAttribute("gust");


                reader.ReadToFollowing("temperature");
                d.afternoon = reader.GetAttribute("day");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");
                d.overnight = reader.GetAttribute("night");
                d.evening = reader.GetAttribute("eve");
                d.morning = reader.GetAttribute("morn");


                reader.ReadToFollowing("clouds");
                d.cloudcover = reader.GetAttribute("all");


                if (d != null)
                {
                    days.Add(d);
                }
            }

            reader.Close();
        }

        private void ExtractCurrent()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            for(int i = 1;i < days.Count;i++)
            {
                days[i].location = days[0].location;
            }

            reader.ReadToDescendant("timezone");
            timezone = Convert.ToDouble(reader.ReadString()) / 3600;

            reader.ReadToFollowing("sun");
            days[0].sunrise = reader.GetAttribute("rise");
            days[0].sunset = reader.GetAttribute("set");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");

            reader.ReadToFollowing("clouds");
            days[0].cloudcover = reader.GetAttribute("value");

            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("number");

            reader.ReadToFollowing("lastupdate");
            days[0].currentTime = reader.GetAttribute("value");

            reader.Close();
        }


    }
}
