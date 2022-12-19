namespace Weather_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mi24Hours = new System.Windows.Forms.ToolStripMenuItem();
            this.mi5Day = new System.Windows.Forms.ToolStripMenuItem();
            this.mi2Weeks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCF = new System.Windows.Forms.ToolStripMenuItem();
            this._24HourPanel1 = new Weather_Project._24HourPanel();
            this._14DayPanel1 = new Weather_Project._14DayPanel();
            this._5DayPanel1 = new Weather_Project._5DayPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mi24Hours
            // 
            this.mi24Hours.Name = "mi24Hours";
            this.mi24Hours.Size = new System.Drawing.Size(61, 20);
            this.mi24Hours.Text = "24 Hour";
            this.mi24Hours.Click += new System.EventHandler(this.mi24Hours_Click);
            // 
            // mi5Day
            // 
            this.mi5Day.Name = "mi5Day";
            this.mi5Day.Size = new System.Drawing.Size(47, 20);
            this.mi5Day.Text = "5 day";
            this.mi5Day.Click += new System.EventHandler(this.dayToolStripMenuItem1_Click);
            // 
            // mi2Weeks
            // 
            this.mi2Weeks.Name = "mi2Weeks";
            this.mi2Weeks.Size = new System.Drawing.Size(60, 20);
            this.mi2Weeks.Text = "2 weeks";
            this.mi2Weeks.Click += new System.EventHandler(this.mi2Weeks_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi24Hours,
            this.mi5Day,
            this.mi2Weeks,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCF});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // miCF
            // 
            this.miCF.Name = "miCF";
            this.miCF.Size = new System.Drawing.Size(93, 22);
            this.miCF.Text = "C/F";
            this.miCF.Click += new System.EventHandler(this.miCF_Click);
            // 
            // _24HourPanel1
            // 
            this._24HourPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._24HourPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._24HourPanel1.Location = new System.Drawing.Point(0, 24);
            this._24HourPanel1.Name = "_24HourPanel1";
            this._24HourPanel1.Size = new System.Drawing.Size(1184, 837);
            this._24HourPanel1.TabIndex = 23;
            this._24HourPanel1.Load += new System.EventHandler(this._24HourPanel1_Load);
            // 
            // _14DayPanel1
            // 
            this._14DayPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._14DayPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._14DayPanel1.Location = new System.Drawing.Point(0, 24);
            this._14DayPanel1.Name = "_14DayPanel1";
            this._14DayPanel1.Size = new System.Drawing.Size(1184, 837);
            this._14DayPanel1.TabIndex = 24;
            // 
            // _5DayPanel1
            // 
            this._5DayPanel1.AutoSize = true;
            this._5DayPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._5DayPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._5DayPanel1.Location = new System.Drawing.Point(0, 24);
            this._5DayPanel1.Name = "_5DayPanel1";
            this._5DayPanel1.Size = new System.Drawing.Size(1184, 837);
            this._5DayPanel1.TabIndex = 25;
            this._5DayPanel1.Load += new System.EventHandler(this._5DayPanel1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this._5DayPanel1);
            this.Controls.Add(this._14DayPanel1);
            this.Controls.Add(this._24HourPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem mi24Hours;
        private ToolStripMenuItem mi5Day;
        private ToolStripMenuItem mi2Weeks;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem miCF;
        private _24HourPanel _24HourPanel1;
        private _14DayPanel _14DayPanel1;
        private _5DayPanel _5DayPanel1;
    }
}