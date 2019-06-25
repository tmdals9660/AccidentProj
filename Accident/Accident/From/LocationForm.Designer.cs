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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.uscLocation = new Accident.Control.LocationInfoControl();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(5, 48);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(974, 659);
            this.webBrowser1.TabIndex = 1;
            // 
            // uscLocation
            // 
            this.uscLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscLocation.Location = new System.Drawing.Point(5, 5);
            this.uscLocation.Name = "uscLocation";
            this.uscLocation.Size = new System.Drawing.Size(974, 43);
            this.uscLocation.TabIndex = 0;
            this.uscLocation.LocationFormClose += new System.EventHandler<Accident.Control.LocationInfoControl.LocationFormCloseEventArgs>(this.UscLocation_LocationFormClose);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 712);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.uscLocation);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "LocationForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.Text = "LocationForm";
            this.Load += new System.EventHandler(this.LocationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.LocationInfoControl uscLocation;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}