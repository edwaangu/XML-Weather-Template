﻿using System;
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
        // List of days and time
        public static List<Day> days = new List<Day>();
        public static double timezone = 0;
        public static double defaultTimezone = -14400;
        public static string city = "Stratford, CA";

        public static int maxID = 0;

        public Form1()
        {
            InitializeComponent();
            
            // open weather screen for todays weather
            WeatherScreen ws = new WeatherScreen();
            this.Controls.Add(ws);
        }
    }
}
