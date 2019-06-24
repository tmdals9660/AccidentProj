namespace Accident.From
{
    partial class SearchForm
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
            this.uscList = new Accident.Control.SearchListControl();
            this.uscFilter = new Accident.Control.SearchFilterControl();
            this.uscSearch = new Accident.Control.SearchControl();
            this.SuspendLayout();
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 143);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(726, 352);
            this.uscList.TabIndex = 2;
            // 
            // uscFilter
            // 
            this.uscFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscFilter.Location = new System.Drawing.Point(0, 76);
            this.uscFilter.Name = "uscFilter";
            this.uscFilter.Size = new System.Drawing.Size(726, 67);
            this.uscFilter.TabIndex = 1;
            this.uscFilter.Visible = false;
            this.uscFilter.FilterCheck += new System.EventHandler<Accident.Control.SearchFilterControl.FilterCheckEventArgs>(this.UscFilter_FilterCheck);
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(726, 76);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SeachChangeClick += new System.EventHandler<Accident.Control.SearchControl.SeachChangeClickEventArgs>(this.UscSearch_SeachChangeClick);
            this.uscSearch.SeachChangeClickOff += new System.EventHandler<Accident.Control.SearchControl.SeachChangeClickOffEventArgs>(this.UscSearch_SeachChangeClickOff);
            this.uscSearch.SearchClick += new System.EventHandler<Accident.Control.SearchControl.SearchClickEventArgs>(this.UscSearch_SearchClick);
            this.uscSearch.Load += new System.EventHandler(this.UscSearch_Load);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 495);
            this.Controls.Add(this.uscList);
            this.Controls.Add(this.uscFilter);
            this.Controls.Add(this.uscSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Control.SearchControl uscSearch;
        private Control.SearchFilterControl uscFilter;
        private Control.SearchListControl uscList;
    }
}