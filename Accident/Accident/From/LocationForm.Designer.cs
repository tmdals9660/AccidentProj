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
            this.uscLocation = new Accident.Control.LocationInfoControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uscLocation
            // 
            this.uscLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscLocation.Location = new System.Drawing.Point(0, 0);
            this.uscLocation.Name = "uscLocation";
            this.uscLocation.Size = new System.Drawing.Size(544, 97);
            this.uscLocation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uscLocation);
            this.Name = "LocationForm";
            this.Text = "LocationForm";
            this.Load += new System.EventHandler(this.LocationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.LocationInfoControl uscLocation;
        private System.Windows.Forms.Label label1;
    }
}