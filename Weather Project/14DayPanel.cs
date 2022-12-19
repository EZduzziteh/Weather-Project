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
    public partial class _14DayPanel : UserControl
    {
        public Form1 mainForm;

        WeatherDataModel weatherInfo;
        public List<WeekAtAGlance> weekAtAGlanceList = new List<WeekAtAGlance>();
        public _14DayPanel()
        {
            InitializeComponent();




            weekAtaGlance1.TwoWeekPanelReference = this;
            weekAtaGlance2.TwoWeekPanelReference = this;
            weekAtaGlance3.TwoWeekPanelReference = this;
            weekAtaGlance4.TwoWeekPanelReference = this;
            weekAtaGlance5.TwoWeekPanelReference = this;
            weekAtaGlance6.TwoWeekPanelReference = this;
            weekAtaGlance7.TwoWeekPanelReference = this;
            weekAtaGlance8.TwoWeekPanelReference = this;
            weekAtaGlance9.TwoWeekPanelReference = this;
            weekAtaGlance10.TwoWeekPanelReference = this;
            weekAtaGlance11.TwoWeekPanelReference = this;
            weekAtaGlance12.TwoWeekPanelReference = this;
            weekAtaGlance13.TwoWeekPanelReference = this;
            weekAtaGlance14.TwoWeekPanelReference = this;

            weekAtAGlanceList.Add(weekAtaGlance1);
            weekAtAGlanceList.Add(weekAtaGlance2);
            weekAtAGlanceList.Add(weekAtaGlance3);
            weekAtAGlanceList.Add(weekAtaGlance4);
            weekAtAGlanceList.Add(weekAtaGlance5);
            weekAtAGlanceList.Add(weekAtaGlance6);
            weekAtAGlanceList.Add(weekAtaGlance7);
            weekAtAGlanceList.Add(weekAtaGlance8);
            weekAtAGlanceList.Add(weekAtaGlance9);
            weekAtAGlanceList.Add(weekAtaGlance10);
            weekAtAGlanceList.Add(weekAtaGlance11);
            weekAtAGlanceList.Add(weekAtaGlance12);
            weekAtAGlanceList.Add(weekAtaGlance13);
            weekAtAGlanceList.Add(weekAtaGlance14);



            ToggleVisible(false);

        }

        public void ToggleVisible(bool isVisible)
        {
            weekAtaGlance1.Visible = isVisible;
            weekAtaGlance2.Visible = isVisible;
            weekAtaGlance3.Visible = isVisible;
            weekAtaGlance4.Visible = isVisible;
            weekAtaGlance5.Visible = isVisible;
            weekAtaGlance6.Visible = isVisible;
            weekAtaGlance7.Visible = isVisible;
            weekAtaGlance8.Visible = isVisible;
            weekAtaGlance9.Visible = isVisible;
            weekAtaGlance10.Visible = isVisible;
            weekAtaGlance11.Visible = isVisible;
            weekAtaGlance12.Visible = isVisible;
            weekAtaGlance13.Visible = isVisible;
            weekAtaGlance14.Visible = isVisible;
            lbl_results_for.Text = "Enter a City to get some results!";
        }

        internal void HandleClicked(WeekAtAGlance weekAtAGlance)
        {
           // throw new NotImplementedException();
        }

       

        private void cmb_favorite_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_favorite_cities.SelectedItem != null)
            {
                GetWeatherInfo(cmb_favorite_cities.SelectedItem.ToString());


            }
        }

        private void btn_get_weather_Click(object sender, EventArgs e)
        {
            GetWeatherInfo(tb_city_name_input.Text);
        }
        public void UpdateLabel(string text)
        {
            lbl_results_for.Visible = true;
            lbl_results_for.Text = text;
        }

        public async void GetWeatherInfo(string cityName)
        {

            System.Diagnostics.Debug.WriteLine("count: "+weekAtAGlanceList.Count);
            if (cityName != "")
            {
                APIHelper.InitializeClient();

                weatherInfo = await WeatherProcessor.LoadWeatherByCityName(cityName);

                


                for(int i = 0; i<weekAtAGlanceList.Count; i++)
                {
                    weekAtAGlanceList[i].dayInfo = weatherInfo.days[i];


                    weekAtAGlanceList[i].PopulateInfo();
                    weekAtAGlanceList[i].Visible = true;
                }

                UpdateLabel("Showing Results For " + weatherInfo.address);

            }


                

                
        }

        public async void RefreshInfo()
        {

            foreach(WeekAtAGlance week in weekAtAGlanceList)
            {
                week.PopulateInfo();
            }
           
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
       

        private void btn_AddToFavorites_Click_1(object sender, EventArgs e)
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
    }
}
