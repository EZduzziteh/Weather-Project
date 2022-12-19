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
    public partial class WeekAtAGlance : UserControl
    {
        public WeekAtAGlance()
        {
            InitializeComponent();
        }

        public Form1 mainForm;
        public _14DayPanel TwoWeekPanelReference;
        public DayModel dayInfo;

       

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

                if (mainForm.isMetric)
                {
                    lbl_High.Text = "High: " + UnitConverter.FahrenheitToCelsius(tempHigh) + "°C";
                    lbl_low.Text = "Low: " + UnitConverter.FahrenheitToCelsius(tempLow) + "°C";
                }
                else
                {
                    lbl_High.Text = "High: " + ((float)tempHigh * 100f) / 100f + "°F";
                    lbl_low.Text = "Low: " + ((float)tempLow * 100f) / 100f + "°F";
                }
            }


        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void WeekAtAGlance_Load(object sender, EventArgs e)
        {

        }
    }
}
