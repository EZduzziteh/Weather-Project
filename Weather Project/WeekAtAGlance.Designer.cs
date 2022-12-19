namespace Weather_Project
{
    partial class WeekAtAGlance
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Weather_Project.Properties.Resources.cloudy;
            this.pictureBox1.Location = new System.Drawing.Point(3, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_High
            // 
            this.lbl_High.AutoSize = true;
            this.lbl_High.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_High.Location = new System.Drawing.Point(62, 59);
            this.lbl_High.Name = "lbl_High";
            this.lbl_High.Size = new System.Drawing.Size(64, 20);
            this.lbl_High.TabIndex = 1;
            this.lbl_High.Text = "High: 10";
            // 
            // lbl_low
            // 
            this.lbl_low.AutoSize = true;
            this.lbl_low.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_low.Location = new System.Drawing.Point(62, 79);
            this.lbl_low.Name = "lbl_low";
            this.lbl_low.Size = new System.Drawing.Size(68, 20);
            this.lbl_low.TabIndex = 2;
            this.lbl_low.Text = "Low: 10C";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 41);
            this.panel1.TabIndex = 3;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(3, 8);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(161, 21);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "saturday, 2022-05-05";
            // 
            // WeekAtAGlance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_low);
            this.Controls.Add(this.lbl_High);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WeekAtAGlance";
            this.Size = new System.Drawing.Size(170, 121);
            this.Load += new System.EventHandler(this.WeekAtAGlance_Load);
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
    }
}
