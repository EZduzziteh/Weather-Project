namespace Weather_Project
{
    partial class DayForecast
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
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPoP = new System.Windows.Forms.Label();
            this.pb_weather_icon = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.lbl_pressure = new System.Windows.Forms.Label();
            this.lbl_sunrise = new System.Windows.Forms.Label();
            this.lbl_sunset = new System.Windows.Forms.Label();
            this.lbl_feels_like = new System.Windows.Forms.Label();
            this.lbl_temp_high = new System.Windows.Forms.Label();
            this.lbl_temp_low = new System.Windows.Forms.Label();
            this.lbl_conditions = new System.Windows.Forms.Label();
            this.rtb_conditions = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_weather_icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWind.Location = new System.Drawing.Point(31, 268);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(113, 21);
            this.lblWind.TabIndex = 73;
            this.lblWind.Text = "Wind: 45 km/h";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHumidity.Location = new System.Drawing.Point(31, 247);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(112, 21);
            this.lblHumidity.TabIndex = 68;
            this.lblHumidity.Text = "Humidity: 30%";
            // 
            // lblPoP
            // 
            this.lblPoP.AutoSize = true;
            this.lblPoP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoP.Location = new System.Drawing.Point(31, 226);
            this.lblPoP.Name = "lblPoP";
            this.lblPoP.Size = new System.Drawing.Size(74, 21);
            this.lblPoP.TabIndex = 63;
            this.lblPoP.Text = "PoP: 30%";
            // 
            // pb_weather_icon
            // 
            this.pb_weather_icon.Image = global::Weather_Project.Properties.Resources.clear_day;
            this.pb_weather_icon.Location = new System.Drawing.Point(28, 49);
            this.pb_weather_icon.Name = "pb_weather_icon";
            this.pb_weather_icon.Size = new System.Drawing.Size(112, 112);
            this.pb_weather_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_weather_icon.TabIndex = 57;
            this.pb_weather_icon.TabStop = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(9, 5);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(86, 25);
            this.lbl_date.TabIndex = 44;
            this.lbl_date.Text = "Saturday";
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Temp.Location = new System.Drawing.Point(175, 49);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(180, 28);
            this.lbl_Temp.TabIndex = 43;
            this.lbl_Temp.Text = "Current Temp: 15°C";
            // 
            // lbl_pressure
            // 
            this.lbl_pressure.AutoSize = true;
            this.lbl_pressure.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pressure.Location = new System.Drawing.Point(271, 268);
            this.lbl_pressure.Name = "lbl_pressure";
            this.lbl_pressure.Size = new System.Drawing.Size(73, 21);
            this.lbl_pressure.TabIndex = 79;
            this.lbl_pressure.Text = "pressure:";
            // 
            // lbl_sunrise
            // 
            this.lbl_sunrise.AutoSize = true;
            this.lbl_sunrise.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sunrise.Location = new System.Drawing.Point(271, 226);
            this.lbl_sunrise.Name = "lbl_sunrise";
            this.lbl_sunrise.Size = new System.Drawing.Size(60, 21);
            this.lbl_sunrise.TabIndex = 80;
            this.lbl_sunrise.Text = "sunrise";
            // 
            // lbl_sunset
            // 
            this.lbl_sunset.AutoSize = true;
            this.lbl_sunset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_sunset.Location = new System.Drawing.Point(271, 247);
            this.lbl_sunset.Name = "lbl_sunset";
            this.lbl_sunset.Size = new System.Drawing.Size(58, 21);
            this.lbl_sunset.TabIndex = 81;
            this.lbl_sunset.Text = "sunset:";
            // 
            // lbl_feels_like
            // 
            this.lbl_feels_like.AutoSize = true;
            this.lbl_feels_like.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_feels_like.Location = new System.Drawing.Point(175, 133);
            this.lbl_feels_like.Name = "lbl_feels_like";
            this.lbl_feels_like.Size = new System.Drawing.Size(145, 28);
            this.lbl_feels_like.TabIndex = 82;
            this.lbl_feels_like.Text = "Feels Like: 15°C";
            // 
            // lbl_temp_high
            // 
            this.lbl_temp_high.AutoSize = true;
            this.lbl_temp_high.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_temp_high.Location = new System.Drawing.Point(175, 77);
            this.lbl_temp_high.Name = "lbl_temp_high";
            this.lbl_temp_high.Size = new System.Drawing.Size(105, 28);
            this.lbl_temp_high.TabIndex = 83;
            this.lbl_temp_high.Text = "High: 15°C";
            // 
            // lbl_temp_low
            // 
            this.lbl_temp_low.AutoSize = true;
            this.lbl_temp_low.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_temp_low.Location = new System.Drawing.Point(175, 105);
            this.lbl_temp_low.Name = "lbl_temp_low";
            this.lbl_temp_low.Size = new System.Drawing.Size(43, 28);
            this.lbl_temp_low.TabIndex = 84;
            this.lbl_temp_low.Text = "low";
            // 
            // lbl_conditions
            // 
            this.lbl_conditions.AutoSize = true;
            this.lbl_conditions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_conditions.Location = new System.Drawing.Point(206, 324);
            this.lbl_conditions.Name = "lbl_conditions";
            this.lbl_conditions.Size = new System.Drawing.Size(104, 25);
            this.lbl_conditions.TabIndex = 85;
            this.lbl_conditions.Text = "conditions:";
            // 
            // rtb_conditions
            // 
            this.rtb_conditions.BackColor = System.Drawing.Color.LightGray;
            this.rtb_conditions.Location = new System.Drawing.Point(9, 352);
            this.rtb_conditions.Name = "rtb_conditions";
            this.rtb_conditions.ReadOnly = true;
            this.rtb_conditions.Size = new System.Drawing.Size(485, 72);
            this.rtb_conditions.TabIndex = 86;
            this.rtb_conditions.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 40);
            this.panel1.TabIndex = 87;
            // 
            // DayForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtb_conditions);
            this.Controls.Add(this.lbl_conditions);
            this.Controls.Add(this.lbl_temp_low);
            this.Controls.Add(this.lbl_temp_high);
            this.Controls.Add(this.lbl_feels_like);
            this.Controls.Add(this.lbl_sunset);
            this.Controls.Add(this.lbl_sunrise);
            this.Controls.Add(this.lbl_pressure);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblPoP);
            this.Controls.Add(this.pb_weather_icon);
            this.Controls.Add(this.lbl_Temp);
            this.Name = "DayForecast";
            this.Size = new System.Drawing.Size(504, 438);
            ((System.ComponentModel.ISupportInitialize)(this.pb_weather_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblWind;
        private Label lblHumidity;
        private Label lblPoP;
        private PictureBox pb_weather_icon;
        private Label lbl_date;
        private Label lbl_Temp;
        private Label lbl_pressure;
        private Label lbl_sunrise;
        private Label lbl_sunset;
        private Label lbl_feels_like;
        private Label lbl_temp_high;
        private Label lbl_temp_low;
        private Label lbl_conditions;
        private RichTextBox rtb_conditions;
        private Panel panel1;
    }
}
