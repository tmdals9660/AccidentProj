﻿namespace Accident.Control
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
            this.btnMonth6 = new System.Windows.Forms.Button();
            this.btnMonth3 = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.cbbCites = new System.Windows.Forms.ComboBox();
            this.bdsCities = new System.Windows.Forms.BindingSource(this.components);
            this.chbDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chbCity = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPrintOpt = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCities)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMonth6);
            this.groupBox1.Controls.Add(this.btnMonth3);
            this.groupBox1.Controls.Add(this.btnMonth);
            this.groupBox1.Controls.Add(this.btnWeek);
            this.groupBox1.Controls.Add(this.cbbCites);
            this.groupBox1.Controls.Add(this.chbDate);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.chbCity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkPrintOpt);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnMonth6
            // 
            this.btnMonth6.Location = new System.Drawing.Point(219, 43);
            this.btnMonth6.Name = "btnMonth6";
            this.btnMonth6.Size = new System.Drawing.Size(47, 23);
            this.btnMonth6.TabIndex = 16;
            this.btnMonth6.Text = "6개월";
            this.btnMonth6.UseVisualStyleBackColor = true;
            this.btnMonth6.Click += new System.EventHandler(this.BtnMonth6_Click);
            // 
            // btnMonth3
            // 
            this.btnMonth3.Location = new System.Drawing.Point(166, 43);
            this.btnMonth3.Name = "btnMonth3";
            this.btnMonth3.Size = new System.Drawing.Size(47, 23);
            this.btnMonth3.TabIndex = 15;
            this.btnMonth3.Text = "3개월";
            this.btnMonth3.UseVisualStyleBackColor = true;
            this.btnMonth3.Click += new System.EventHandler(this.BtnMonth3_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(112, 43);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(47, 23);
            this.btnMonth.TabIndex = 14;
            this.btnMonth.Text = "1개월";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.BtnMonth_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(59, 43);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(47, 23);
            this.btnWeek.TabIndex = 13;
            this.btnWeek.Text = "1주일";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.BtnWeek_Click);
            // 
            // cbbCites
            // 
            this.cbbCites.DataSource = this.bdsCities;
            this.cbbCites.DisplayMember = "CityName";
            this.cbbCites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCites.FormattingEnabled = true;
            this.cbbCites.Location = new System.Drawing.Point(389, 19);
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
            this.chbDate.Location = new System.Drawing.Point(278, 22);
            this.chbDate.Name = "chbDate";
            this.chbDate.Size = new System.Drawing.Size(15, 14);
            this.chbDate.TabIndex = 11;
            this.chbDate.UseVisualStyleBackColor = true;
            this.chbDate.CheckedChanged += new System.EventHandler(this.ChbDate_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(175, 16);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.Value = new System.DateTime(2019, 6, 24, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "기간 :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 21);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // chbCity
            // 
            this.chbCity.AutoSize = true;
            this.chbCity.Checked = true;
            this.chbCity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCity.Location = new System.Drawing.Point(496, 22);
            this.chbCity.Name = "chbCity";
            this.chbCity.Size = new System.Drawing.Size(15, 14);
            this.chbCity.TabIndex = 6;
            this.chbCity.UseVisualStyleBackColor = true;
            this.chbCity.CheckedChanged += new System.EventHandler(this.ChbCity_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "지역 :";
            // 
            // chkPrintOpt
            // 
            this.chkPrintOpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrintOpt.AutoSize = true;
            this.chkPrintOpt.Location = new System.Drawing.Point(643, 50);
            this.chkPrintOpt.Name = "chkPrintOpt";
            this.chkPrintOpt.Size = new System.Drawing.Size(76, 16);
            this.chkPrintOpt.TabIndex = 3;
            this.chkPrintOpt.Text = "출력 옵션";
            this.chkPrintOpt.UseVisualStyleBackColor = true;
            this.chkPrintOpt.CheckedChanged += new System.EventHandler(this.ChkFilter_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(643, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(730, 76);
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
        private System.Windows.Forms.CheckBox chkPrintOpt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chbDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbCites;
        private System.Windows.Forms.BindingSource bdsCities;
        private System.Windows.Forms.Button btnMonth6;
        private System.Windows.Forms.Button btnMonth3;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnWeek;
    }
}
