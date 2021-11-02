using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windGust, windDirection, precipitation, cloudcover, morning, afternoon, evening, overnight, chanceofprep, sunrise, sunset, windCode;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windGust = windDirection = precipitation = cloudcover = morning = afternoon = evening = overnight = chanceofprep = sunrise = sunset = windCode = "";
        }
    }
}
