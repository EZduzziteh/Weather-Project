namespace Weather_Project
{
    partial class _14DayPanel
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
            this.lbl_results_for = new System.Windows.Forms.Label();
            this.btn_AddToFavorites = new System.Windows.Forms.Button();
            this.btn_get_weather = new System.Windows.Forms.Button();
            this.lbl_favorite_city = new System.Windows.Forms.Label();
            this.cmb_favorite_cities = new System.Windows.Forms.ComboBox();
            this.tb_city_name_input = new System.Windows.Forms.TextBox();
            this.lbl_Enter_City_Name = new System.Windows.Forms.Label();
            this.weekAtaGlance1 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance2 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance3 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance4 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance5 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance6 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance7 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance8 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance9 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance10 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance11 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance12 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance13 = new Weather_Project.WeekAtAGlance();
            this.weekAtaGlance14 = new Weather_Project.WeekAtAGlance();
            this.SuspendLayout();
            // 
            // lbl_results_for
            // 
            this.lbl_results_for.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_results_for.BackColor = System.Drawing.Color.Gray;
            this.lbl_results_for.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_results_for.Location = new System.Drawing.Point(299, 0);
            this.lbl_results_for.Name = "lbl_results_for";
            this.lbl_results_for.Size = new System.Drawing.Size(600, 45);
            this.lbl_results_for.TabIndex = 43;
            this.lbl_results_for.Text = "Showing Results For Bankok";
            this.lbl_results_for.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddToFavorites
            // 
            this.btn_AddToFavorites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_AddToFavorites.Location = new System.Drawing.Point(483, 102);
            this.btn_AddToFavorites.Name = "btn_AddToFavorites";
            this.btn_AddToFavorites.Size = new System.Drawing.Size(104, 23);
            this.btn_AddToFavorites.TabIndex = 42;
            this.btn_AddToFavorites.Text = "Add To Favorites";
            this.btn_AddToFavorites.UseVisualStyleBackColor = true;
            this.btn_AddToFavorites.Click += new System.EventHandler(this.btn_AddToFavorites_Click_1);
            // 
            // btn_get_weather
            // 
            this.btn_get_weather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_get_weather.Location = new System.Drawing.Point(377, 102);
            this.btn_get_weather.Name = "btn_get_weather";
            this.btn_get_weather.Size = new System.Drawing.Size(100, 23);
            this.btn_get_weather.TabIndex = 41;
            this.btn_get_weather.Text = "Get Weather";
            this.btn_get_weather.UseVisualStyleBackColor = true;
            this.btn_get_weather.Click += new System.EventHandler(this.btn_get_weather_Click);
            // 
            // lbl_favorite_city
            // 
            this.lbl_favorite_city.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_favorite_city.AutoSize = true;
            this.lbl_favorite_city.Location = new System.Drawing.Point(668, 46);
            this.lbl_favorite_city.Name = "lbl_favorite_city";
            this.lbl_favorite_city.Size = new System.Drawing.Size(115, 15);
            this.lbl_favorite_city.TabIndex = 40;
            this.lbl_favorite_city.Text = "Select from favorites";
            // 
            // cmb_favorite_cities
            // 
            this.cmb_favorite_cities.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_favorite_cities.FormattingEnabled = true;
            this.cmb_favorite_cities.Location = new System.Drawing.Point(662, 73);
            this.cmb_favorite_cities.Name = "cmb_favorite_cities";
            this.cmb_favorite_cities.Size = new System.Drawing.Size(121, 23);
            this.cmb_favorite_cities.TabIndex = 39;
            this.cmb_favorite_cities.SelectedIndexChanged += new System.EventHandler(this.cmb_favorite_cities_SelectedIndexChanged);
            // 
            // tb_city_name_input
            // 
            this.tb_city_name_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_city_name_input.Location = new System.Drawing.Point(438, 73);
            this.tb_city_name_input.Name = "tb_city_name_input";
            this.tb_city_name_input.Size = new System.Drawing.Size(100, 23);
            this.tb_city_name_input.TabIndex = 38;
            // 
            // lbl_Enter_City_Name
            // 
            this.lbl_Enter_City_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Enter_City_Name.AutoSize = true;
            this.lbl_Enter_City_Name.Location = new System.Drawing.Point(438, 46);
            this.lbl_Enter_City_Name.Name = "lbl_Enter_City_Name";
            this.lbl_Enter_City_Name.Size = new System.Drawing.Size(93, 15);
            this.lbl_Enter_City_Name.TabIndex = 37;
            this.lbl_Enter_City_Name.Text = "Enter City Name";
            // 
            // weekAtaGlance1
            // 
            this.weekAtaGlance1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance1.Location = new System.Drawing.Point(-12, 162);
            this.weekAtaGlance1.Name = "weekAtaGlance1";
            this.weekAtaGlance1.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance1.TabIndex = 44;
            // 
            // weekAtaGlance2
            // 
            this.weekAtaGlance2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance2.Location = new System.Drawing.Point(164, 162);
            this.weekAtaGlance2.Name = "weekAtaGlance2";
            this.weekAtaGlance2.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance2.TabIndex = 45;
            // 
            // weekAtaGlance3
            // 
            this.weekAtaGlance3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance3.Location = new System.Drawing.Point(343, 162);
            this.weekAtaGlance3.Name = "weekAtaGlance3";
            this.weekAtaGlance3.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance3.TabIndex = 46;
            // 
            // weekAtaGlance4
            // 
            this.weekAtaGlance4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance4.Location = new System.Drawing.Point(519, 162);
            this.weekAtaGlance4.Name = "weekAtaGlance4";
            this.weekAtaGlance4.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance4.TabIndex = 47;
            // 
            // weekAtaGlance5
            // 
            this.weekAtaGlance5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance5.Location = new System.Drawing.Point(695, 162);
            this.weekAtaGlance5.Name = "weekAtaGlance5";
            this.weekAtaGlance5.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance5.TabIndex = 48;
            // 
            // weekAtaGlance6
            // 
            this.weekAtaGlance6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance6.Location = new System.Drawing.Point(871, 162);
            this.weekAtaGlance6.Name = "weekAtaGlance6";
            this.weekAtaGlance6.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance6.TabIndex = 49;
            // 
            // weekAtaGlance7
            // 
            this.weekAtaGlance7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance7.Location = new System.Drawing.Point(1047, 162);
            this.weekAtaGlance7.Name = "weekAtaGlance7";
            this.weekAtaGlance7.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance7.TabIndex = 50;
            // 
            // weekAtaGlance8
            // 
            this.weekAtaGlance8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance8.Location = new System.Drawing.Point(-12, 295);
            this.weekAtaGlance8.Name = "weekAtaGlance8";
            this.weekAtaGlance8.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance8.TabIndex = 51;
            // 
            // weekAtaGlance9
            // 
            this.weekAtaGlance9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance9.Location = new System.Drawing.Point(164, 295);
            this.weekAtaGlance9.Name = "weekAtaGlance9";
            this.weekAtaGlance9.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance9.TabIndex = 52;
            // 
            // weekAtaGlance10
            // 
            this.weekAtaGlance10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance10.Location = new System.Drawing.Point(343, 295);
            this.weekAtaGlance10.Name = "weekAtaGlance10";
            this.weekAtaGlance10.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance10.TabIndex = 53;
            // 
            // weekAtaGlance11
            // 
            this.weekAtaGlance11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance11.Location = new System.Drawing.Point(519, 295);
            this.weekAtaGlance11.Name = "weekAtaGlance11";
            this.weekAtaGlance11.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance11.TabIndex = 54;
            // 
            // weekAtaGlance12
            // 
            this.weekAtaGlance12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance12.Location = new System.Drawing.Point(695, 295);
            this.weekAtaGlance12.Name = "weekAtaGlance12";
            this.weekAtaGlance12.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance12.TabIndex = 55;
            // 
            // weekAtaGlance13
            // 
            this.weekAtaGlance13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance13.Location = new System.Drawing.Point(871, 295);
            this.weekAtaGlance13.Name = "weekAtaGlance13";
            this.weekAtaGlance13.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance13.TabIndex = 56;
            // 
            // weekAtaGlance14
            // 
            this.weekAtaGlance14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.weekAtaGlance14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.weekAtaGlance14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weekAtaGlance14.Location = new System.Drawing.Point(1047, 295);
            this.weekAtaGlance14.Name = "weekAtaGlance14";
            this.weekAtaGlance14.Size = new System.Drawing.Size(170, 121);
            this.weekAtaGlance14.TabIndex = 57;
            // 
            // _14DayPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.weekAtaGlance14);
            this.Controls.Add(this.weekAtaGlance13);
            this.Controls.Add(this.weekAtaGlance12);
            this.Controls.Add(this.weekAtaGlance11);
            this.Controls.Add(this.weekAtaGlance10);
            this.Controls.Add(this.weekAtaGlance9);
            this.Controls.Add(this.weekAtaGlance8);
            this.Controls.Add(this.weekAtaGlance7);
            this.Controls.Add(this.weekAtaGlance6);
            this.Controls.Add(this.weekAtaGlance5);
            this.Controls.Add(this.weekAtaGlance4);
            this.Controls.Add(this.weekAtaGlance3);
            this.Controls.Add(this.weekAtaGlance2);
            this.Controls.Add(this.weekAtaGlance1);
            this.Controls.Add(this.lbl_results_for);
            this.Controls.Add(this.btn_AddToFavorites);
            this.Controls.Add(this.btn_get_weather);
            this.Controls.Add(this.lbl_favorite_city);
            this.Controls.Add(this.cmb_favorite_cities);
            this.Controls.Add(this.tb_city_name_input);
            this.Controls.Add(this.lbl_Enter_City_Name);
            this.Name = "_14DayPanel";
            this.Size = new System.Drawing.Size(1200, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_results_for;
        private Button btn_AddToFavorites;
        private Button btn_get_weather;
        private Label lbl_favorite_city;
        private ComboBox cmb_favorite_cities;
        private TextBox tb_city_name_input;
        private Label lbl_Enter_City_Name;
        private WeekAtAGlance weekAtaGlance1;
        private WeekAtAGlance weekAtaGlance2;
        private WeekAtAGlance weekAtaGlance3;
        private WeekAtAGlance weekAtaGlance4;
        private WeekAtAGlance weekAtaGlance5;
        private WeekAtAGlance weekAtaGlance6;
        private WeekAtAGlance weekAtaGlance7;
        private WeekAtAGlance weekAtaGlance8;
        private WeekAtAGlance weekAtaGlance9;
        private WeekAtAGlance weekAtaGlance10;
        private WeekAtAGlance weekAtaGlance11;
        private WeekAtAGlance weekAtaGlance12;
        private WeekAtAGlance weekAtaGlance13;
        private WeekAtAGlance weekAtaGlance14;
    }
}
