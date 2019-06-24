namespace Accident.Control
{
    partial class SearchControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCites = new System.Windows.Forms.ComboBox();
            this.bdsCities = new System.Windows.Forms.BindingSource(this.components);
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chbCity = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSearchOpt = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCities)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCites);
            this.groupBox1.Controls.Add(this.chbDate);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.chbCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkSearchOpt);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cbbCites
            // 
            this.cbbCites.DataSource = this.bdsCities;
            this.cbbCites.DisplayMember = "CityName";
            this.cbbCites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCites.FormattingEnabled = true;
            this.cbbCites.Location = new System.Drawing.Point(51, 17);
            this.cbbCites.Name = "cbbCites";
            this.cbbCites.Size = new System.Drawing.Size(97, 20);
            this.cbbCites.TabIndex = 12;
            this.cbbCites.ValueMember = "CityId";
            // 
            // bdsCities
            // 
            this.bdsCities.DataSource = typeof(Accident.Data.City);
            // 
            // chbDate
            // 
            this.chbDate.AutoSize = true;
            this.chbDate.Checked = true;
            this.chbDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDate.Location = new System.Drawing.Point(277, 48);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(15, 14);
            this.chbDate.TabIndex = 11;
            this.chbDate.UseVisualStyleBackColor = true;
            this.chbDate.CheckedChanged += new System.EventHandler(this.ChbDate_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(174, 42);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "기간 :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // chbCity
            // 
            this.chbCity.AutoSize = true;
            this.chbCity.Checked = true;
            this.chbCity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCity.Location = new System.Drawing.Point(158, 20);
            this.chbCity.Name = "chbCity";
            this.chbCity.Size = new System.Drawing.Size(15, 14);
            this.chbCity.TabIndex = 6;
            this.chbCity.UseVisualStyleBackColor = true;
            this.chbCity.CheckedChanged += new System.EventHandler(this.ChbCity_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "지역 :";
            // 
            // chkSearchOpt
            // 
            this.chkSearchOpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSearchOpt.AutoSize = true;
            this.chkSearchOpt.Location = new System.Drawing.Point(423, 16);
            this.chkSearchOpt.Name = "chkSearchOpt";
            this.chkSearchOpt.Size = new System.Drawing.Size(76, 16);
            this.chkSearchOpt.TabIndex = 3;
            this.chkSearchOpt.Text = "검색 옵션";
            this.chkSearchOpt.UseVisualStyleBackColor = true;
            this.chkSearchOpt.CheckedChanged += new System.EventHandler(this.ChkFilter_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(515, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(602, 98);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSearchOpt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbCites;
        private System.Windows.Forms.BindingSource bdsCities;
    }
}
