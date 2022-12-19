using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Project
{
    public static class IconHelper
    {
        

        public static Bitmap? GetIconPath(string iconName)
        {
            switch (iconName)
            {
                case"cloudy":
                    return Properties.Resources.cloudy;
                case "clear-day":
                    return Properties.Resources.clear_day;

                case "clear-night":
                    return Properties.Resources.clear_night;

                case "fog":
                    return Properties.Resources.fog;

                case "hail":
                    return Properties.Resources.hail;

                case "partly-cloudy-day":
                    return Properties.Resources.partly_cloudy_day;

                case "partly-cloudy-night":
                    return Properties.Resources.partly_cloudy_night;

                case "rain-snow":
                    return Properties.Resources.rain_snow;

                case "rain-snow-showers-day":
                    return Properties.Resources.rain_snow_showers_day;

                case "rain-snow-showers-night":
                    return Properties.Resources.rain_snow_showers_night;

                case "showers-day":
                    return Properties.Resources.showers_day;

                case "showers - night":
                    return Properties.Resources.showers_night;

                case "sleet":
                    return Properties.Resources.sleet;

                case "snow":
                    return Properties.Resources.snow;

                case "snow-showers-day":
                    return Properties.Resources.snow_showers_day;

                case "snow-showers-night":
                    return Properties.Resources.snow_showers_night;

                case "thunder":
                    return Properties.Resources.thunder;

                case "thunder-rain":
                    return Properties.Resources.thunder_rain;

                case "thunder-showers-day":
                    return Properties.Resources.thunder_showers_day;

                case "thunder-showers-night":
                    return Properties.Resources.thunder_showers_night;

                case "wind":
                    return Properties.Resources.wind;

                case "rain":
                    return Properties.Resources.rain;

                default:

                    return null;
            }


            
        }


    }
}
