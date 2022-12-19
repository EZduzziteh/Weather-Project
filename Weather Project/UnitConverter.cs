using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Project
{
    public static class UnitConverter
    {


        public static float FahrenheitToCelsius(double fahrenheitTemp) {

            //(32°F − 32) × 5 / 9 = 0°C
            double celsiusTemp = (fahrenheitTemp - 32.0f) * (5.0f / 9.0f);
            return (float)Math.Round(celsiusTemp * 100f) / 100f;

        }

        public static float CelsiusToFahrenheit(double celsiusTemp)
        {

            //(32°C × 9/5) + 32 = 89.6°F

            double fahrenheitTemp = (celsiusTemp * 90f / 50f) + 320f;
            return (float)Math.Round(fahrenheitTemp * 100f) / 100f;

        }

        public static float inchesToCentimetres(double inches)
        {
            // multiply the value by 2.54

            double centimetres = inches * 2.54f;
            return (float)Math.Round(centimetres * 100f) / 100f;
        }
        public static float centimetresToInches(double centimetres)
        {
            // multiply the value by 2.54

            if (centimetres == 0)
            {
                return 0;
            }
            else
            {
                double inches = centimetres / 2.54f;
                return (float)Math.Round(centimetres * 100f) / 100f;
            }
        }

        public static float mphToKph(double mph)
        {
            double kph = mph * 1.609f;
            return (float)Math.Round(kph * 100f) / 100f;

        }

        public static float kphToMph(double kph)
        {
            double mph = kph / 1.609f;
            return (float)Math.Round(mph * 100f) / 100f;
        }





    }
}
