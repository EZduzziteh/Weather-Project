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
    public partial class Container : UserControl
    {
        List<UserControl> DayForecasts;

        int xAxis = 0;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Container()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        private void Container_Load(object sender, EventArgs e)
        {
            pnlForecast.AutoScroll = true;

            DayForecasts = new List<UserControl>();
        }

        public void AddDay()
        {
            DayForecast day = new DayForecast();            

            day.Location = new Point(0, xAxis - pnlForecast.HorizontalScroll.Value);

            DayForecasts.Add(day);
            pnlForecast.Controls.Add(day);

            xAxis += day.Width;
        }

      

        public void Clear()
        {
            while (pnlForecast.Controls.Count > 0)
                pnlForecast.Controls.RemoveAt(pnlForecast.Controls.Count - 1);

            DayForecasts = new List<UserControl>();

            xAxis = 0;
        }

        private void pnlForecast_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
