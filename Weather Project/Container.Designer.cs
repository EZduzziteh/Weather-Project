namespace Weather_Project
{
    partial class Container
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
            this.pnlForecast = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlForecast
            // 
            this.pnlForecast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForecast.Location = new System.Drawing.Point(0, 0);
            this.pnlForecast.Name = "pnlForecast";
            this.pnlForecast.Size = new System.Drawing.Size(766, 383);
            this.pnlForecast.TabIndex = 0;
            this.pnlForecast.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlForecast_Paint);
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlForecast);
            this.Name = "Container";
            this.Size = new System.Drawing.Size(766, 383);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlForecast;
    }
}
