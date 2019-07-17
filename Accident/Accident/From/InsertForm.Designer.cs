namespace Accident.From
{
    partial class InsertForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCity = new System.Windows.Forms.ComboBox();
            this.bdsCity = new System.Windows.Forms.BindingSource(this.components);
            this.cbbState = new System.Windows.Forms.ComboBox();
            this.bdsState = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbField = new System.Windows.Forms.ComboBox();
            this.bdsAccidentFiled = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.bdsAccidentType = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cbbViolation = new System.Windows.Forms.ComboBox();
            this.bdsViolation = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cbbRoadform = new System.Windows.Forms.ComboBox();
            this.bdsRoadForm = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.cbbAttacker = new System.Windows.Forms.ComboBox();
            this.bdsAttacker = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.cbbVictim = new System.Windows.Forms.ComboBox();
            this.bdsVictim = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.dtpInsert = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txbDeathCount = new System.Windows.Forms.TextBox();
            this.txbSeriouslyCount = new System.Windows.Forms.TextBox();
            this.txbSlightlyCount = new System.Windows.Forms.TextBox();
            this.txbInjuerlyCount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbLongitude = new System.Windows.Forms.TextBox();
            this.txbRatitude = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbDayAndNight = new System.Windows.Forms.TextBox();
            this.txbDayOfWeeks = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAccidentFiled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAccidentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsViolation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRoadForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAttacker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVictim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "시/도 :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cbbCity
            // 
            this.cbbCity.DataSource = this.bdsCity;
            this.cbbCity.DisplayMember = "CityName";
            this.cbbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCity.FormattingEnabled = true;
            this.cbbCity.Location = new System.Drawing.Point(67, 163);
            this.cbbCity.Name = "cbbCity";
            this.cbbCity.Size = new System.Drawing.Size(121, 20);
            this.cbbCity.TabIndex = 2;
            this.cbbCity.ValueMember = "CityId";
            this.cbbCity.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // bdsCity
            // 
            this.bdsCity.DataSource = typeof(Accident.Data.City);
            // 
            // cbbState
            // 
            this.cbbState.DataSource = this.bdsState;
            this.cbbState.DisplayMember = "StateName";
            this.cbbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbState.FormattingEnabled = true;
            this.cbbState.Location = new System.Drawing.Point(67, 189);
            this.cbbState.Name = "cbbState";
            this.cbbState.Size = new System.Drawing.Size(121, 20);
            this.cbbState.TabIndex = 4;
            this.cbbState.ValueMember = "StateId";
            // 
            // bdsState
            // 
            this.bdsState.DataSource = typeof(Accident.Data.State);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "시/군/구 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "요일 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "주야 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "사망자수 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "중상자수 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "경상자수 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "부상자수 :";
            // 
            // cbbField
            // 
            this.cbbField.DataSource = this.bdsAccidentFiled;
            this.cbbField.DisplayMember = "AccidentFieldName";
            this.cbbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbField.FormattingEnabled = true;
            this.cbbField.Location = new System.Drawing.Point(315, 25);
            this.cbbField.Name = "cbbField";
            this.cbbField.Size = new System.Drawing.Size(147, 20);
            this.cbbField.TabIndex = 18;
            this.cbbField.ValueMember = "AccidentFieldId";
            // 
            // bdsAccidentFiled
            // 
            this.bdsAccidentFiled.DataSource = typeof(Accident.Data.AccidentFiled);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "사고형태 :";
            // 
            // cbbType
            // 
            this.cbbType.DataSource = this.bdsAccidentType;
            this.cbbType.DisplayMember = "AccidentTypeName";
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(315, 51);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(147, 20);
            this.cbbType.TabIndex = 20;
            this.cbbType.ValueMember = "AccidentTypeId";
            // 
            // bdsAccidentType
            // 
            this.bdsAccidentType.DataSource = typeof(Accident.Data.AccidentType);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "사고유형 :";
            // 
            // cbbViolation
            // 
            this.cbbViolation.DataSource = this.bdsViolation;
            this.cbbViolation.DisplayMember = "ViiolationName";
            this.cbbViolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbViolation.FormattingEnabled = true;
            this.cbbViolation.Location = new System.Drawing.Point(315, 77);
            this.cbbViolation.Name = "cbbViolation";
            this.cbbViolation.Size = new System.Drawing.Size(147, 20);
            this.cbbViolation.TabIndex = 22;
            this.cbbViolation.ValueMember = "ViolationId";
            // 
            // bdsViolation
            // 
            this.bdsViolation.DataSource = typeof(Accident.Data.Violation);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "법규위반 :";
            // 
            // cbbRoadform
            // 
            this.cbbRoadform.DataSource = this.bdsRoadForm;
            this.cbbRoadform.DisplayMember = "RoadFormName";
            this.cbbRoadform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoadform.FormattingEnabled = true;
            this.cbbRoadform.Location = new System.Drawing.Point(315, 103);
            this.cbbRoadform.Name = "cbbRoadform";
            this.cbbRoadform.Size = new System.Drawing.Size(147, 20);
            this.cbbRoadform.TabIndex = 24;
            this.cbbRoadform.ValueMember = "RoadFormId";
            // 
            // bdsRoadForm
            // 
            this.bdsRoadForm.DataSource = typeof(Accident.Data.RoadForm);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "도로형태 :";
            // 
            // cbbAttacker
            // 
            this.cbbAttacker.DataSource = this.bdsAttacker;
            this.cbbAttacker.DisplayMember = "AttackerTypeName";
            this.cbbAttacker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAttacker.FormattingEnabled = true;
            this.cbbAttacker.Location = new System.Drawing.Point(550, 163);
            this.cbbAttacker.Name = "cbbAttacker";
            this.cbbAttacker.Size = new System.Drawing.Size(142, 20);
            this.cbbAttacker.TabIndex = 26;
            this.cbbAttacker.ValueMember = "AttackerId";
            // 
            // bdsAttacker
            // 
            this.bdsAttacker.DataSource = typeof(Accident.Data.AttackerType);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(471, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "가해자유형 :";
            // 
            // cbbVictim
            // 
            this.cbbVictim.DataSource = this.bdsVictim;
            this.cbbVictim.DisplayMember = "VictimTypeName";
            this.cbbVictim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVictim.FormattingEnabled = true;
            this.cbbVictim.Location = new System.Drawing.Point(550, 189);
            this.cbbVictim.Name = "cbbVictim";
            this.cbbVictim.Size = new System.Drawing.Size(142, 20);
            this.cbbVictim.TabIndex = 28;
            this.cbbVictim.ValueMember = "VictimId";
            this.cbbVictim.SelectedIndexChanged += new System.EventHandler(this.ComboBox14_SelectedIndexChanged);
            // 
            // bdsVictim
            // 
            this.bdsVictim.DataSource = typeof(Accident.Data.VictimType);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(471, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "피해자유형 :";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // dtpInsert
            // 
            this.dtpInsert.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpInsert.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInsert.Location = new System.Drawing.Point(67, 22);
            this.dtpInsert.Name = "dtpInsert";
            this.dtpInsert.Size = new System.Drawing.Size(158, 21);
            this.dtpInsert.TabIndex = 29;
            this.dtpInsert.ValueChanged += new System.EventHandler(this.DtpInsert_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "날짜 :";
            // 
            // txbDeathCount
            // 
            this.txbDeathCount.Location = new System.Drawing.Point(550, 25);
            this.txbDeathCount.Name = "txbDeathCount";
            this.txbDeathCount.Size = new System.Drawing.Size(100, 21);
            this.txbDeathCount.TabIndex = 31;
            // 
            // txbSeriouslyCount
            // 
            this.txbSeriouslyCount.Location = new System.Drawing.Point(550, 52);
            this.txbSeriouslyCount.Name = "txbSeriouslyCount";
            this.txbSeriouslyCount.Size = new System.Drawing.Size(100, 21);
            this.txbSeriouslyCount.TabIndex = 32;
            // 
            // txbSlightlyCount
            // 
            this.txbSlightlyCount.Location = new System.Drawing.Point(550, 79);
            this.txbSlightlyCount.Name = "txbSlightlyCount";
            this.txbSlightlyCount.Size = new System.Drawing.Size(100, 21);
            this.txbSlightlyCount.TabIndex = 33;
            // 
            // txbInjuerlyCount
            // 
            this.txbInjuerlyCount.Location = new System.Drawing.Point(550, 106);
            this.txbInjuerlyCount.Name = "txbInjuerlyCount";
            this.txbInjuerlyCount.Size = new System.Drawing.Size(100, 21);
            this.txbInjuerlyCount.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbDayAndNight);
            this.groupBox1.Controls.Add(this.txbDayOfWeeks);
            this.groupBox1.Controls.Add(this.txbLongitude);
            this.groupBox1.Controls.Add(this.txbRatitude);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txbInjuerlyCount);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txbSlightlyCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbSeriouslyCount);
            this.groupBox1.Controls.Add(this.cbbCity);
            this.groupBox1.Controls.Add(this.txbDeathCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbState);
            this.groupBox1.Controls.Add(this.dtpInsert);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbVictim);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbAttacker);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbRoadform);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbViolation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbType);
            this.groupBox1.Controls.Add(this.cbbField);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 218);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기본정보";
            // 
            // txbLongitude
            // 
            this.txbLongitude.Location = new System.Drawing.Point(315, 189);
            this.txbLongitude.Name = "txbLongitude";
            this.txbLongitude.Size = new System.Drawing.Size(100, 21);
            this.txbLongitude.TabIndex = 38;
            // 
            // txbRatitude
            // 
            this.txbRatitude.Location = new System.Drawing.Point(315, 163);
            this.txbRatitude.Name = "txbRatitude";
            this.txbRatitude.Size = new System.Drawing.Size(100, 21);
            this.txbRatitude.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(250, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 12);
            this.label16.TabIndex = 35;
            this.label16.Text = "위도 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(250, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 12);
            this.label17.TabIndex = 36;
            this.label17.Text = "경도 :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(630, 236);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "취소(&C)";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "저장(&S)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txbDayAndNight
            // 
            this.txbDayAndNight.Enabled = false;
            this.txbDayAndNight.Location = new System.Drawing.Point(66, 81);
            this.txbDayAndNight.Name = "txbDayAndNight";
            this.txbDayAndNight.Size = new System.Drawing.Size(100, 21);
            this.txbDayAndNight.TabIndex = 40;
            // 
            // txbDayOfWeeks
            // 
            this.txbDayOfWeeks.Enabled = false;
            this.txbDayOfWeeks.Location = new System.Drawing.Point(66, 51);
            this.txbDayOfWeeks.Name = "txbDayOfWeeks";
            this.txbDayOfWeeks.Size = new System.Drawing.Size(100, 21);
            this.txbDayOfWeeks.TabIndex = 39;
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAccidentFiled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAccidentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsViolation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRoadForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAttacker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVictim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCity;
        private System.Windows.Forms.ComboBox cbbState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbViolation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbRoadform;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbAttacker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbVictim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbDeathCount;
        private System.Windows.Forms.TextBox txbSeriouslyCount;
        private System.Windows.Forms.TextBox txbSlightlyCount;
        private System.Windows.Forms.TextBox txbInjuerlyCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bdsCity;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bdsState;
        private System.Windows.Forms.BindingSource bdsAccidentFiled;
        private System.Windows.Forms.BindingSource bdsAccidentType;
        private System.Windows.Forms.BindingSource bdsViolation;
        private System.Windows.Forms.BindingSource bdsRoadForm;
        private System.Windows.Forms.BindingSource bdsAttacker;
        private System.Windows.Forms.BindingSource bdsVictim;
        private System.Windows.Forms.TextBox txbLongitude;
        private System.Windows.Forms.TextBox txbRatitude;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpInsert;
        private System.Windows.Forms.TextBox txbDayAndNight;
        private System.Windows.Forms.TextBox txbDayOfWeeks;
    }
}