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
    public partial class _24HourPanel : UserControl
    {

        public Form1 mainForm;
        WeatherDataModel weatherInfo;
        public _24HourPanel()
        {
            InitializeComponent();

            dayForecast1.Visible = false;
        }

        private async void cmb_favorite_cities_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_favorite_cities.SelectedItem != null)
            {
                GetWeatherInfo(cmb_favorite_cities.SelectedItem.ToString());

                dayForecast1.Visible = true;

            }
        }
        public void ToggleVisible(bool isVisible)
        {
            dayForecast1.Visible = Visible;
            lbl_results_for.Text = "Enter a City to get some results!";
        }
        private async void btn_get_weather_Click(object sender, EventArgs e)
        {

            GetWeatherInfo(tb_city_name_input.Text);


        }


        public async void GetWeatherInfo(string cityName)
        {
            if (cityName != "")
            {
                APIHelper.InitializeClient();

                weatherInfo = await WeatherProcessor.LoadWeatherByCityName(cityName);

                System.Diagnostics.Debug.WriteLine(weatherInfo.currentConditions.precip);
                dayForecast1.PopulateValues(weatherInfo.days[0].sunrise,
                                            weatherInfo.days[0].sunset,
                                            weatherInfo.currentConditions.windspeed,
                                            weatherInfo.currentConditions.humidity,
                                            weatherInfo.currentConditions.icon,
                                            weatherInfo.currentConditions.precip,
                                            weatherInfo.currentConditions.temp,
                                            weatherInfo.currentConditions.feelslike,
                                            weatherInfo.days[0].tempmax,
                                            weatherInfo.days[0].tempmin,
                                            weatherInfo.days[0].datetime,
                                            weatherInfo.currentConditions.conditions,
                                            weatherInfo.currentConditions.pressure);


                dayForecast1.Visible = true;
            }

            UpdateLabel("Showing Results For " + weatherInfo.address);
        }

        public void UpdateLabel(string text)
        {
            lbl_results_for.Text = text;
            lbl_results_for.Visible = true;
        }
        public async void RefreshInfo()
        {
            if (weatherInfo != null)
            {
                dayForecast1.PopulateValues(weatherInfo.days[0].sunrise,
                                            weatherInfo.days[0].sunset,
                                            weatherInfo.currentConditions.windspeed,
                                            weatherInfo.currentConditions.humidity,
                                            weatherInfo.currentConditions.icon,
                                            weatherInfo.currentConditions.precip,
                                            weatherInfo.currentConditions.temp,
                                            weatherInfo.currentConditions.feelslike,
                                            weatherInfo.days[0].tempmax,
                                            weatherInfo.days[0].tempmin,
                                            weatherInfo.days[0].datetime,
                                            weatherInfo.currentConditions.conditions,
                                            weatherInfo.currentConditions.pressure);
            }
        }
        public void RefreshFavorites()
        {
            mainForm = (Form1)Application.OpenForms[0];

            cmb_favorite_cities.Items.Clear();

            foreach(string city in mainForm.favoriteCities)
            {

                cmb_favorite_cities.Items.Add(city);
            }
        }
        private void btn_AddToFavorites_Click(object sender, EventArgs e)
        {
            if (lbl_Enter_City_Name.Text != "")
            {
                mainForm = (Form1)Application.OpenForms[0];

                bool allowAddingCity = true;

                foreach(string city in mainForm.favoriteCities)
                {
                    if(city == tb_city_name_input.Text)
                    {
                        allowAddingCity = false;
                    }
                }

                if (allowAddingCity)
                {
                    mainForm.favoriteCities.Add(tb_city_name_input.Text);
                }
            }

            RefreshFavorites();
        }

       
    }
}
