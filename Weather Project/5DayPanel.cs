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
    public partial class _5DayPanel : UserControl
    {

        WeatherDataModel weatherInfo;
        public Form1 mainForm;


        public _5DayPanel()
        {
            InitializeComponent();

            ToggleVisible(false);
            
            lbl_results_for.Text = "Enter a City to get some results!";
        }

        public void ToggleVisible(bool isVisible)
        {
            dayAtaGlance1.Visible = isVisible;
            dayAtaGlance2.Visible = isVisible;
            dayAtaGlance3.Visible = isVisible;
            dayAtaGlance4.Visible = isVisible;
            dayAtaGlance5.Visible = isVisible;
        }

        public void UpdateLabel(string text)
        {
            lbl_results_for.Text = text;
            lbl_results_for.Visible = true;
        }

       
        public void HandleClicked(DayAtAGlance dayAtAGlance)
        {

            
            // set dayForecast1 to have data from dayAtAGlance
            dayForecast1.PopulateValues(dayAtAGlance.dayInfo.sunrise,
                                        dayAtAGlance.dayInfo.sunset, 
                                        dayAtAGlance.dayInfo.windspeed,
                                        dayAtAGlance.dayInfo.humidity, 
                                        dayAtAGlance.dayInfo.icon, 
                                        dayAtAGlance.dayInfo.precip,
                                        dayAtAGlance.dayInfo.temp,
                                        dayAtAGlance.dayInfo.feelslike,
                                        dayAtAGlance.dayInfo.tempmax, 
                                        dayAtAGlance.dayInfo.tempmin,
                                        dayAtAGlance.dayInfo.datetime,
                                        dayAtAGlance.dayInfo.conditions,
                                        dayAtAGlance.dayInfo.pressure);

            dayForecast1.Visible = true;
            dayForecast1.BringToFront();



            dayAtaGlance1.BackColor = Color.WhiteSmoke;
            dayAtaGlance2.BackColor = Color.WhiteSmoke;
            dayAtaGlance3.BackColor = Color.WhiteSmoke;
            dayAtaGlance4.BackColor = Color.WhiteSmoke;
            dayAtaGlance5.BackColor = Color.WhiteSmoke;


            dayAtAGlance.BackColor = Color.Gray;
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




                dayAtaGlance1.dayInfo = weatherInfo.days[0];
                dayAtaGlance1.PopulateInfo();
                dayAtaGlance1.Visible = true;

                dayAtaGlance2.dayInfo = weatherInfo.days[1];
                dayAtaGlance2.PopulateInfo();
                dayAtaGlance2.Visible = true;

                dayAtaGlance3.dayInfo = weatherInfo.days[2];
                dayAtaGlance3.PopulateInfo();
                dayAtaGlance3.Visible = true;

                dayAtaGlance4.dayInfo = weatherInfo.days[3];
                dayAtaGlance4.PopulateInfo();
                dayAtaGlance4.Visible = true;

                dayAtaGlance5.dayInfo = weatherInfo.days[4];
                dayAtaGlance5.PopulateInfo();
                dayAtaGlance5.Visible = true;


                UpdateLabel("Showing Results For " + weatherInfo.address);

            }
        }


        public async void RefreshInfo()
        {
            dayAtaGlance1.PopulateInfo();
        }

        public void RefreshFavorites()
        {
            mainForm = (Form1)Application.OpenForms[0];

            cmb_favorite_cities.Items.Clear();

            foreach (string city in mainForm.favoriteCities)
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

                foreach (string city in mainForm.favoriteCities)
                {
                    if (city == tb_city_name_input.Text)
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

        private void cmb_favorite_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetWeatherInfo(cmb_favorite_cities.Text);
        }

        private void _5DayPanel_Load(object sender, EventArgs e)
        {
            dayAtaGlance1.Visible = false;

            dayAtaGlance2.Visible = false;

            dayAtaGlance3.Visible = false;

            dayAtaGlance4.Visible = false;

            dayAtaGlance5.Visible = false;

            dayForecast1.Visible = false;


            dayAtaGlance1.FiveDayPanelReference = this;
            dayAtaGlance2.FiveDayPanelReference = this;
            dayAtaGlance3.FiveDayPanelReference = this;
            dayAtaGlance4.FiveDayPanelReference = this;
            dayAtaGlance5.FiveDayPanelReference = this;
        }
    }
}
