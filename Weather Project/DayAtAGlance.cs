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
    public partial class DayAtAGlance : UserControl
    {
        public DayAtAGlance()
        {
            InitializeComponent();
        }

        public Form1 mainForm;
        public _5DayPanel FiveDayPanelReference;
        public DayModel dayInfo;

        public void HandleClicked()
        {
            if (this.Visible)
            {
                if (FiveDayPanelReference != null)
                {
                    FiveDayPanelReference.HandleClicked(this);
                }
            }
        }

        public void PopulateInfo()
        {
            if (dayInfo != null)
            {
                DateTime date = dayInfo.datetime;
                float tempHigh = dayInfo.tempmax;
                float tempLow = dayInfo.tempmin;


                mainForm = (Form1)Application.OpenForms[0];
                lbl_date.Text = date.Date.DayOfWeek + ", " + date.Year + "-" + date.Month + "-" + date.Day;
                pictureBox1.Image = IconHelper.GetIconPath(dayInfo.icon);


                lbl_humidity.Text = "Hum: " + dayInfo.humidity + "%";
                lbl_pop.Text = "PoP: " + dayInfo.precipprob + "%";

                if (mainForm.isMetric)
                {
                    lbl_High.Text = "High: " + UnitConverter.FahrenheitToCelsius(tempHigh) + "°C";
                    lbl_low.Text = "Low: " + UnitConverter.FahrenheitToCelsius(tempLow) + "°C";
                    lbl_accumulation.Text = "Acc: " + UnitConverter.inchesToCentimetres(dayInfo.precip) + "cm";
                }
                else
                {
                    lbl_High.Text = "High: " + ((float)tempHigh * 100f) / 100f + "°F";
                    lbl_low.Text = "Low: " + ((float)tempLow * 100f) / 100f + "°F";

                    lbl_accumulation.Text = "Acc: " + dayInfo.precip + "in";
                }
            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HandleClicked();
        }

        private void lbl_low_Click(object sender, EventArgs e)
        {
            HandleClicked();
        }

        private void lbl_High_Click(object sender, EventArgs e)
        {
            HandleClicked();
        }

        private void lbl_date_Click(object sender, EventArgs e)
        {
            HandleClicked();
        }

      

        private void DayAtAGlance_Click(object sender, EventArgs e)
        {
            HandleClicked();
        }

        private void lbl_accumulation_Click(object sender, EventArgs e)
        {
            HandleClicked();
        }

        private void lbl_pop_Click(object sender, EventArgs e)
        {
            HandleClicked();
        }

        private void lbl_humidity_Click(object sender, EventArgs e)
        {
            HandleClicked();
        }

       

        private void DayAtAGlance_Click_1(object sender, EventArgs e)
        {
            HandleClicked();
        }

        private void DayAtAGlance_Load(object sender, EventArgs e)
        {

        }
    }
}
