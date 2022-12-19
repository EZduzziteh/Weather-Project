namespace Weather_Project
{
    partial class DayAtAGlance
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_High = new System.Windows.Forms.Label();
            this.lbl_low = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_humidity = new System.Windows.Forms.Label();
            this.lbl_pop = new System.Windows.Forms.Label();
            this.lbl_accumulation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Weather_Project.Properties.Resources.cloudy;
            this.pictureBox1.Location = new System.Drawing.Point(3, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_High
            // 
            this.lbl_High.AutoSize = true;
            this.lbl_High.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_High.Location = new System.Drawing.Point(76, 41);
            this.lbl_High.Name = "lbl_High";
            this.lbl_High.Size = new System.Drawing.Size(68, 21);
            this.lbl_High.TabIndex = 1;
            this.lbl_High.Text = "High: 10";
            this.lbl_High.Click += new System.EventHandler(this.lbl_High_Click);
            // 
            // lbl_low
            // 
            this.lbl_low.AutoSize = true;
            this.lbl_low.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_low.Location = new System.Drawing.Point(76, 62);
            this.lbl_low.Name = "lbl_low";
            this.lbl_low.Size = new System.Drawing.Size(74, 21);
            this.lbl_low.TabIndex = 2;
            this.lbl_low.Text = "Low: 10C";
            this.lbl_low.Click += new System.EventHandler(this.lbl_low_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 41);
            this.panel1.TabIndex = 3;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(3, 8);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(189, 25);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "saturday, 2022-05-05";
            this.lbl_date.Click += new System.EventHandler(this.lbl_date_Click);
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_humidity.Location = new System.Drawing.Point(76, 83);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(82, 21);
            this.lbl_humidity.TabIndex = 4;
            this.lbl_humidity.Text = "Hum: 20%";
            this.lbl_humidity.Click += new System.EventHandler(this.lbl_humidity_Click);
            // 
            // lbl_pop
            // 
            this.lbl_pop.AutoSize = true;
            this.lbl_pop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pop.Location = new System.Drawing.Point(76, 104);
            this.lbl_pop.Name = "lbl_pop";
            this.lbl_pop.Size = new System.Drawing.Size(75, 21);
            this.lbl_pop.TabIndex = 5;
            this.lbl_pop.Text = "pop: 10%";
            this.lbl_pop.Click += new System.EventHandler(this.lbl_pop_Click);
            // 
            // lbl_accumulation
            // 
            this.lbl_accumulation.AutoSize = true;
            this.lbl_accumulation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_accumulation.Location = new System.Drawing.Point(76, 124);
            this.lbl_accumulation.Name = "lbl_accumulation";
            this.lbl_accumulation.Size = new System.Drawing.Size(87, 21);
            this.lbl_accumulation.TabIndex = 6;
            this.lbl_accumulation.Text = "Acc: 20mm";
            this.lbl_accumulation.Click += new System.EventHandler(this.lbl_accumulation_Click);
            // 
            // DayAtAGlance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_accumulation);
            this.Controls.Add(this.lbl_pop);
            this.Controls.Add(this.lbl_humidity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_low);
            this.Controls.Add(this.lbl_High);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DayAtAGlance";
            this.Size = new System.Drawing.Size(232, 148);
            this.Load += new System.EventHandler(this.DayAtAGlance_Load);
            this.Click += new System.EventHandler(this.DayAtAGlance_Click_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_High;
        private Label lbl_low;
        private Panel panel1;
        private Label lbl_date;
        private Label lbl_humidity;
        private Label lbl_pop;
        private Label lbl_accumulation;
    }
}
