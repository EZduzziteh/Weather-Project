namespace Weather_Project
{
    public partial class Form1 : Form
    {

        public bool isMetric = true;

        public List<string> favoriteCities = new List<string>();
        public List<string> citiesOfTheDay = new List<string>();
        public string CityOfTheDay;
        public Form1()
        {
            InitializeComponent();

            citiesOfTheDay.Add("Phoenix");
            citiesOfTheDay.Add("Vancouver");
            citiesOfTheDay.Add("Moscow");
            citiesOfTheDay.Add("Calgary");
            citiesOfTheDay.Add("Toronto");
            citiesOfTheDay.Add("Singapore");
            citiesOfTheDay.Add("Cape Town");
            citiesOfTheDay.Add("Cancun");
            citiesOfTheDay.Add("Bangkok");



            Random rand = new Random();
            CityOfTheDay = citiesOfTheDay[rand.Next(citiesOfTheDay.Count-1)];
            
         



            favoriteCities.Add("Calgary");
            favoriteCities.Add("Vancouver");

            _14DayPanel1.Visible = false;
            _5DayPanel1.Visible = false;

            _24HourPanel1.GetWeatherInfo(CityOfTheDay);
            _24HourPanel1.UpdateLabel("Showing City of the Day: " + CityOfTheDay);


        }

        public void RefreshFavorites()
        {
            _24HourPanel1.RefreshFavorites();
            _5DayPanel1.RefreshFavorites();
            _14DayPanel1.RefreshFavorites();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            RefreshFavorites();
        }

        private void dayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _24HourPanel1.Visible = false;
            _14DayPanel1.Visible = false;
            _5DayPanel1.Visible = true;
            RefreshFavorites();
            _24HourPanel1.ToggleVisible(false);
            _5DayPanel1.ToggleVisible(false);
            _24HourPanel1.ToggleVisible(false);
        }

     

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Enter_CityNAme_Click(object sender, EventArgs e)
        {

        }

        private void mi24Hours_Click(object sender, EventArgs e)
        {
            _24HourPanel1.Visible = true;
            _14DayPanel1.Visible = false;
            _5DayPanel1.Visible = false;
            RefreshFavorites();
            _24HourPanel1.ToggleVisible(false);
            _5DayPanel1.ToggleVisible(false);
            _24HourPanel1.ToggleVisible(false);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miCF_Click(object sender, EventArgs e)
        {
            if (isMetric)
            {
                isMetric = false;
            }
            else
            {
                isMetric = true;
            }

            _24HourPanel1.RefreshInfo();
            _14DayPanel1.RefreshInfo();
            _5DayPanel1.RefreshInfo();
        }

        private void _24HourPanel1_Load(object sender, EventArgs e)
        {

        }

        private void mi2Weeks_Click(object sender, EventArgs e)
        {
            _24HourPanel1.Visible = false;
            _14DayPanel1.Visible = true;
            _5DayPanel1.Visible = false;
            RefreshFavorites();
            _24HourPanel1.ToggleVisible(false);
            _5DayPanel1.ToggleVisible(false);
            _24HourPanel1.ToggleVisible(false);
        }

        private void _5DayPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}