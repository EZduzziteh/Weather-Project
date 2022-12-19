namespace Weather_Project
{
    partial class _24HourPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_city_name_input = new System.Windows.Forms.TextBox();
            this.lbl_Enter_City_Name = new System.Windows.Forms.Label();
            this.cmb_favorite_cities = new System.Windows.Forms.ComboBox();
            this.lbl_favorite_city = new System.Windows.Forms.Label();
            this.dayForecast1 = new Weather_Project.DayForecast();
            this.btn_get_weather = new System.Windows.Forms.Button();
            this.btn_AddToFavorites = new System.Windows.Forms.Button();
            this.lbl_results_for = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_city_name_input
            // 
            this.tb_city_name_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_city_name_input.Location = new System.Drawing.Point(439, 74);
            this.tb_city_name_input.Name = "tb_city_name_input";
            this.tb_city_name_input.Size = new System.Drawing.Size(100, 23);
            this.tb_city_name_input.TabIndex = 2;
            // 
            // lbl_Enter_City_Name
            // 
            this.lbl_Enter_City_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Enter_City_Name.AutoSize = true;
            this.lbl_Enter_City_Name.Location = new System.Drawing.Point(439, 47);
            this.lbl_Enter_City_Name.Name = "lbl_Enter_City_Name";
            this.lbl_Enter_City_Name.Size = new System.Drawing.Size(93, 15);
            this.lbl_Enter_City_Name.TabIndex = 3;
            this.lbl_Enter_City_Name.Text = "Enter City Name";
            // 
            // cmb_favorite_cities
            // 
            this.cmb_favorite_cities.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_favorite_cities.FormattingEnabled = true;
            this.cmb_favorite_cities.Location = new System.Drawing.Point(663, 74);
            this.cmb_favorite_cities.Name = "cmb_favorite_cities";
            this.cmb_favorite_cities.Size = new System.Drawing.Size(121, 23);
            this.cmb_favorite_cities.TabIndex = 4;
            this.cmb_favorite_cities.SelectedValueChanged += new System.EventHandler(this.cmb_favorite_cities_SelectedValueChanged);
            // 
            // lbl_favorite_city
            // 
            this.lbl_favorite_city.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_favorite_city.AutoSize = true;
            this.lbl_favorite_city.Location = new System.Drawing.Point(669, 47);
            this.lbl_favorite_city.Name = "lbl_favorite_city";
            this.lbl_favorite_city.Size = new System.Drawing.Size(115, 15);
            this.lbl_favorite_city.TabIndex = 6;
            this.lbl_favorite_city.Text = "Select from favorites";
            // 
            // dayForecast1
            // 
            this.dayForecast1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayForecast1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dayForecast1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayForecast1.Location = new System.Drawing.Point(332, 132);
            this.dayForecast1.Name = "dayForecast1";
            this.dayForecast1.Size = new System.Drawing.Size(506, 440);
            this.dayForecast1.TabIndex = 7;
            // 
            // btn_get_weather
            // 
            this.btn_get_weather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_get_weather.Location = new System.Drawing.Point(378, 103);
            this.btn_get_weather.Name = "btn_get_weather";
            this.btn_get_weather.Size = new System.Drawing.Size(100, 23);
            this.btn_get_weather.TabIndex = 8;
            this.btn_get_weather.Text = "Get Weather";
            this.btn_get_weather.UseVisualStyleBackColor = true;
            this.btn_get_weather.Click += new System.EventHandler(this.btn_get_weather_Click);
            // 
            // btn_AddToFavorites
            // 
            this.btn_AddToFavorites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_AddToFavorites.Location = new System.Drawing.Point(484, 103);
            this.btn_AddToFavorites.Name = "btn_AddToFavorites";
            this.btn_AddToFavorites.Size = new System.Drawing.Size(104, 23);
            this.btn_AddToFavorites.TabIndex = 9;
            this.btn_AddToFavorites.Text = "Add To Favorites";
            this.btn_AddToFavorites.UseVisualStyleBackColor = true;
            this.btn_AddToFavorites.Click += new System.EventHandler(this.btn_AddToFavorites_Click);
            // 
            // lbl_results_for
            // 
            this.lbl_results_for.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_results_for.BackColor = System.Drawing.Color.Gray;
            this.lbl_results_for.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_results_for.Location = new System.Drawing.Point(300, 0);
            this.lbl_results_for.Name = "lbl_results_for";
            this.lbl_results_for.Size = new System.Drawing.Size(600, 45);
            this.lbl_results_for.TabIndex = 31;
            this.lbl_results_for.Text = "Showing Results For Bankok";
            this.lbl_results_for.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _24HourPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lbl_results_for);
            this.Controls.Add(this.btn_AddToFavorites);
            this.Controls.Add(this.btn_get_weather);
            this.Controls.Add(this.dayForecast1);
            this.Controls.Add(this.lbl_favorite_city);
            this.Controls.Add(this.cmb_favorite_cities);
            this.Controls.Add(this.lbl_Enter_City_Name);
            this.Controls.Add(this.tb_city_name_input);
            this.Name = "_24HourPanel";
            this.Size = new System.Drawing.Size(1200, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_city_name_input;
        private Label lbl_Enter_City_Name;
        private ComboBox cmb_favorite_cities;
        private Label lbl_favorite_city;
        private DayForecast dayForecast1;
        private Button btn_get_weather;
        private Button btn_AddToFavorites;
        private Label lbl_results_for;
    }
}
