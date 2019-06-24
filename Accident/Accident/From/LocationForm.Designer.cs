namespace Accident.From
{
    partial class LocationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.locationInfoControl1 = new Accident.Control.LocationInfoControl();
            this.SuspendLayout();
            // 
            // locationInfoControl1
            // 
            this.locationInfoControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationInfoControl1.Location = new System.Drawing.Point(0, 0);
            this.locationInfoControl1.Name = "locationInfoControl1";
            this.locationInfoControl1.Size = new System.Drawing.Size(544, 97);
            this.locationInfoControl1.TabIndex = 0;
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 527);
            this.Controls.Add(this.locationInfoControl1);
            this.Name = "LocationForm";
            this.Text = "LocationForm";
            this.Load += new System.EventHandler(this.LocationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.LocationInfoControl locationInfoControl1;
    }
}