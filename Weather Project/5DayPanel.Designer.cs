namespace Weather_Project
{
    partial class _5DayPanel
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
            this.dayForecast1 = new Weather_Project.DayForecast();
            this.dayAtaGlance1 = new Weather_Project.DayAtAGlance();
            this.dayAtaGlance2 = new Weather_Project.DayAtAGlance();
            this.dayAtaGlance3 = new Weather_Project.DayAtAGlance();
            this.lbl_Enter_City_Name = new System.Windows.Forms.Label();
            this.btn_AddToFavorites = new System.Windows.Forms.Button();
            this.btn_get_weather = new System.Windows.Forms.Button();
            this.lbl_favorite_city = new System.Windows.Forms.Label();
            this.cmb_favorite_cities = new System.Windows.Forms.ComboBox();
            this.tb_city_name_input = new System.Windows.Forms.TextBox();
            this.dayAtaGlance5 = new Weather_Project.DayAtAGlance();
            this.dayAtaGlance4 = new Weather_Project.DayAtAGlance();
            this.lbl_results_for = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayForecast1
            // 
            this.dayForecast1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayForecast1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dayForecast1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayForecast1.Location = new System.Drawing.Point(359, 297);
            this.dayForecast1.Name = "dayForecast1";
            this.dayForecast1.Size = new System.Drawing.Size(506, 440);
            this.dayForecast1.TabIndex = 0;
            // 
            // dayAtaGlance1
            // 
            this.dayAtaGlance1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayAtaGlance1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dayAtaGlance1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayAtaGlance1.Location = new System.Drawing.Point(16, 143);
            this.dayAtaGlance1.Name = "dayAtaGlance1";
            this.dayAtaGlance1.Size = new System.Drawing.Size(228, 148);
            this.dayAtaGlance1.TabIndex = 17;
            // 
            // dayAtaGlance2
            // 
            this.dayAtaGlance2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayAtaGlance2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dayAtaGlance2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayAtaGlance2.Location = new System.Drawing.Point(250, 143);
            this.dayAtaGlance2.Name = "dayAtaGlance2";
            this.dayAtaGlance2.Size = new System.Drawing.Size(228, 148);
            this.dayAtaGlance2.TabIndex = 18;
            // 
            // dayAtaGlance3
            // 
            this.dayAtaGlance3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayAtaGlance3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dayAtaGlance3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayAtaGlance3.Location = new System.Drawing.Point(484, 143);
            this.dayAtaGlance3.Name = "dayAtaGlance3";
            this.dayAtaGlance3.Size = new System.Drawing.Size(228, 148);
            this.dayAtaGlance3.TabIndex = 19;
            // 
            // lbl_Enter_City_Name
            // 
            this.lbl_Enter_City_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Enter_City_Name.AutoSize = true;
            this.lbl_Enter_City_Name.Location = new System.Drawing.Point(439, 46);
            this.lbl_Enter_City_Name.Name = "lbl_Enter_City_Name";
            this.lbl_Enter_City_Name.Size = new System.Drawing.Size(93, 15);
            this.lbl_Enter_City_Name.TabIndex = 23;
            this.lbl_Enter_City_Name.Text = "Enter City Name";
            // 
            // btn_AddToFavorites
            // 
            this.btn_AddToFavorites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_AddToFavorites.Location = new System.Drawing.Point(484, 102);
            this.btn_AddToFavorites.Name = "btn_AddToFavorites";
            this.btn_AddToFavorites.Size = new System.Drawing.Size(104, 23);
            this.btn_AddToFavorites.TabIndex = 29;
            this.btn_AddToFavorites.Text = "Add To Favorites";
            this.btn_AddToFavorites.UseVisualStyleBackColor = true;
            this.btn_AddToFavorites.Click += new System.EventHandler(this.btn_AddToFavorites_Click);
            // 
            // btn_get_weather
            // 
            this.btn_get_weather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_get_weather.Location = new System.Drawing.Point(378, 102);
            this.btn_get_weather.Name = "btn_get_weather";
            this.btn_get_weather.Size = new System.Drawing.Size(100, 23);
            this.btn_get_weather.TabIndex = 28;
            this.btn_get_weather.Text = "Get Weather";
            this.btn_get_weather.UseVisualStyleBackColor = true;
            this.btn_get_weather.Click += new System.EventHandler(this.btn_get_weather_Click);
            // 
            // lbl_favorite_city
            // 
            this.lbl_favorite_city.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_favorite_city.AutoSize = true;
            this.lbl_favorite_city.Location = new System.Drawing.Point(669, 46);
            this.lbl_favorite_city.Name = "lbl_favorite_city";
            this.lbl_favorite_city.Size = new System.Drawing.Size(115, 15);
            this.lbl_favorite_city.TabIndex = 27;
            this.lbl_favorite_city.Text = "Select from favorites";
            // 
            // cmb_favorite_cities
            // 
            this.cmb_favorite_cities.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_favorite_cities.FormattingEnabled = true;
            this.cmb_favorite_cities.Location = new System.Drawing.Point(663, 73);
            this.cmb_favorite_cities.Name = "cmb_favorite_cities";
            this.cmb_favorite_cities.Size = new System.Drawing.Size(121, 23);
            this.cmb_favorite_cities.TabIndex = 26;
            this.cmb_favorite_cities.SelectedIndexChanged += new System.EventHandler(this.cmb_favorite_cities_SelectedIndexChanged);
            // 
            // tb_city_name_input
            // 
            this.tb_city_name_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_city_name_input.Location = new System.Drawing.Point(439, 73);
            this.tb_city_name_input.Name = "tb_city_name_input";
            this.tb_city_name_input.Size = new System.Drawing.Size(100, 23);
            this.tb_city_name_input.TabIndex = 24;
            // 
            // dayAtaGlance5
            // 
            this.dayAtaGlance5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayAtaGlance5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dayAtaGlance5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayAtaGlance5.Location = new System.Drawing.Point(954, 143);
            this.dayAtaGlance5.Name = "dayAtaGlance5";
            this.dayAtaGlance5.Size = new System.Drawing.Size(228, 148);
            this.dayAtaGlance5.TabIndex = 21;
            // 
            // dayAtaGlance4
            // 
            this.dayAtaGlance4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayAtaGlance4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dayAtaGlance4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dayAtaGlance4.Location = new System.Drawing.Point(718, 143);
            this.dayAtaGlance4.Name = "dayAtaGlance4";
            this.dayAtaGlance4.Size = new System.Drawing.Size(228, 148);
            this.dayAtaGlance4.TabIndex = 20;
            // 
            // lbl_results_for
            // 
            this.lbl_results_for.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_results_for.BackColor = System.Drawing.Color.Gray;
            this.lbl_results_for.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_results_for.Location = new System.Drawing.Point(300, 0);
            this.lbl_results_for.Name = "lbl_results_for";
            this.lbl_results_for.Size = new System.Drawing.Size(600, 45);
            this.lbl_results_for.TabIndex = 30;
            this.lbl_results_for.Text = "Showing Results For Bankok";
            this.lbl_results_for.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _5DayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lbl_results_for);
            this.Controls.Add(this.btn_AddToFavorites);
            this.Controls.Add(this.btn_get_weather);
            this.Controls.Add(this.lbl_favorite_city);
            this.Controls.Add(this.cmb_favorite_cities);
            this.Controls.Add(this.tb_city_name_input);
            this.Controls.Add(this.lbl_Enter_City_Name);
            this.Controls.Add(this.dayAtaGlance5);
            this.Controls.Add(this.dayAtaGlance4);
            this.Controls.Add(this.dayAtaGlance3);
            this.Controls.Add(this.dayAtaGlance2);
            this.Controls.Add(this.dayAtaGlance1);
            this.Controls.Add(this.dayForecast1);
            this.Name = "_5DayPanel";
            this.Size = new System.Drawing.Size(1200, 900);
            this.Load += new System.EventHandler(this._5DayPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DayForecast dayForecast1;
        private DayAtAGlance dayAtaGlance1;
        private DayAtAGlance dayAtaGlance2;
        private DayAtAGlance dayAtaGlance3;
        private Label lbl_Enter_City_Name;
        private Button btn_AddToFavorites;
        private Button btn_get_weather;
        private Label lbl_favorite_city;
        private ComboBox cmb_favorite_cities;
        private TextBox tb_city_name_input;
        private DayAtAGlance dayAtaGlance5;
        private DayAtAGlance dayAtaGlance4;
        private Label lbl_results_for;
    }
}
