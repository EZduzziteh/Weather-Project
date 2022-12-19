using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Project
{
    public partial class DayForecast : UserControl
    {

        Form1 mainForm;

        public DayForecast()
        {
            InitializeComponent();
        }


        public void PopulateValues(DateTime sunrise, DateTime sunset, float windspeed,  double humidity, string icon, double precipitationChance, double temp, double tempFeelsLike, double tempMax, double tempMin, DateTime date, string conditions, double pressure)
        {

            mainForm = (Form1)Application.OpenForms[0];

            

           
            lblHumidity.Text = "Humidity: "+((float)humidity * 100f)/100f+"%";
            
            if (IconHelper.GetIconPath(icon) == null)
            {

                pb_weather_icon.Image = null;
            }
            else
            {
                pb_weather_icon.Image = IconHelper.GetIconPath(icon);
            }

            lblPoP.Text = "PoP: "+ precipitationChance + "%";
            
            lbl_date.Text = "Date: "+ date.Date.DayOfWeek+", "+date.Year+"-"+date.Month + "-"+date.Day;
            rtb_conditions.Text = conditions;
            lbl_pressure.Text = "Pressure: " + ((float)pressure*100f)/100f+ " hPa";
            lbl_sunrise.Text = "Sunrise: "+sunrise.TimeOfDay;
            lbl_sunset.Text = "Sunset: "+sunset.TimeOfDay;
            if (mainForm.isMetric)
            {
                lbl_temp_high.Text = "High: " + UnitConverter.FahrenheitToCelsius(tempMax) + "°C";
                lbl_temp_low.Text = "Low: " + UnitConverter.FahrenheitToCelsius(tempMin) + "°C";
                lbl_feels_like.Text = "Feels Like: " + UnitConverter.FahrenheitToCelsius(tempFeelsLike) + "°C";
                lbl_Temp.Text = "Temp: " + UnitConverter.FahrenheitToCelsius(temp)+ "°C";
                lblWind.Text = "Wind speeds: " + windspeed + "kph";
            }
            else
            {
                lbl_temp_high.Text = "High: " + ((float)tempMax * 100f) / 100f + "°F";
                lbl_temp_low.Text = "Low: " + ((float)tempMin * 100f) / 100f + "°F";
                lbl_feels_like.Text = "Feels Like: " + ((float)tempFeelsLike * 100f) / 100f + "°F";
                lbl_Temp.Text = "Temp: " + ((float)temp * 100f) / 100f + "°F";

                lblWind.Text = "Wind speeds: " + windspeed + "mph";
            }

        }

       
    }
}
