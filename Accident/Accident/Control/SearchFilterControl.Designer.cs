namespace Accident.Control
{
    partial class SearchFilterControl
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
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.btnCommit = new System.Windows.Forms.Button();
            this.ccbVictim = new System.Windows.Forms.CheckBox();
            this.ccbAttacker = new System.Windows.Forms.CheckBox();
            this.ccbLoadForm = new System.Windows.Forms.CheckBox();
            this.ccbAccidentType = new System.Windows.Forms.CheckBox();
            this.ccbViolation = new System.Windows.Forms.CheckBox();
            this.ccbAccientFiled = new System.Windows.Forms.CheckBox();
            this.ccbInjury = new System.Windows.Forms.CheckBox();
            this.ccbSlight = new System.Windows.Forms.CheckBox();
            this.ccbSeriously = new System.Windows.Forms.CheckBox();
            this.ccbDeath = new System.Windows.Forms.CheckBox();
            this.ccbDNN = new System.Windows.Forms.CheckBox();
            this.ccbDOW = new System.Windows.Forms.CheckBox();
            this.ccbDate = new System.Windows.Forms.CheckBox();
            this.ccbCity = new System.Windows.Forms.CheckBox();
            this.ccbState = new System.Windows.Forms.CheckBox();
            this.gbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.ccbCity);
            this.gbOption.Controls.Add(this.ccbState);
            this.gbOption.Controls.Add(this.btnCommit);
            this.gbOption.Controls.Add(this.ccbVictim);
            this.gbOption.Controls.Add(this.ccbAttacker);
            this.gbOption.Controls.Add(this.ccbLoadForm);
            this.gbOption.Controls.Add(this.ccbAccidentType);
            this.gbOption.Controls.Add(this.ccbViolation);
            this.gbOption.Controls.Add(this.ccbAccientFiled);
            this.gbOption.Controls.Add(this.ccbInjury);
            this.gbOption.Controls.Add(this.ccbSlight);
            this.gbOption.Controls.Add(this.ccbSeriously);
            this.gbOption.Controls.Add(this.ccbDeath);
            this.gbOption.Controls.Add(this.ccbDNN);
            this.gbOption.Controls.Add(this.ccbDOW);
            this.gbOption.Controls.Add(this.ccbDate);
            this.gbOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOption.Location = new System.Drawing.Point(0, 0);
            this.gbOption.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(704, 79);
            this.gbOption.TabIndex = 7;
            this.gbOption.TabStop = false;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(623, 33);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 33;
            this.btnCommit.Text = "적용";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.BtnCommit_Click);
            // 
            // ccbVictim
            // 
            this.ccbVictim.AutoSize = true;
            this.ccbVictim.Location = new System.Drawing.Point(407, 56);
            this.ccbVictim.Name = "ccbVictim";
            this.ccbVictim.Size = new System.Drawing.Size(72, 16);
            this.ccbVictim.TabIndex = 32;
            this.ccbVictim.Text = "피해유형";
            this.ccbVictim.UseVisualStyleBackColor = true;
            // 
            // ccbAttacker
            // 
            this.ccbAttacker.AutoSize = true;
            this.ccbAttacker.Location = new System.Drawing.Point(315, 56);
            this.ccbAttacker.Name = "ccbAttacker";
            this.ccbAttacker.Size = new System.Drawing.Size(72, 16);
            this.ccbAttacker.TabIndex = 31;
            this.ccbAttacker.Text = "가해유형";
            this.ccbAttacker.UseVisualStyleBackColor = true;
            // 
            // ccbLoadForm
            // 
            this.ccbLoadForm.AutoSize = true;
            this.ccbLoadForm.Location = new System.Drawing.Point(217, 56);
            this.ccbLoadForm.Name = "ccbLoadForm";
            this.ccbLoadForm.Size = new System.Drawing.Size(72, 16);
            this.ccbLoadForm.TabIndex = 30;
            this.ccbLoadForm.Text = "도로형태";
            this.ccbLoadForm.UseVisualStyleBackColor = true;
            // 
            // ccbAccidentType
            // 
            this.ccbAccidentType.AutoSize = true;
            this.ccbAccidentType.Checked = true;
            this.ccbAccidentType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ccbAccidentType.Location = new System.Drawing.Point(33, 56);
            this.ccbAccidentType.Name = "ccbAccidentType";
            this.ccbAccidentType.Size = new System.Drawing.Size(72, 16);
            this.ccbAccidentType.TabIndex = 29;
            this.ccbAccidentType.Text = "사고형태";
            this.ccbAccidentType.UseVisualStyleBackColor = true;
            // 
            // ccbViolation
            // 
            this.ccbViolation.AutoSize = true;
            this.ccbViolation.Location = new System.Drawing.Point(125, 56);
            this.ccbViolation.Name = "ccbViolation";
            this.ccbViolation.Size = new System.Drawing.Size(72, 16);
            this.ccbViolation.TabIndex = 28;
            this.ccbViolation.Text = "법규위반";
            this.ccbViolation.UseVisualStyleBackColor = true;
            // 
            // ccbAccientFiled
            // 
            this.ccbAccientFiled.AutoSize = true;
            this.ccbAccientFiled.Checked = true;
            this.ccbAccientFiled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ccbAccientFiled.Location = new System.Drawing.Point(407, 37);
            this.ccbAccientFiled.Name = "ccbAccientFiled";
            this.ccbAccientFiled.Size = new System.Drawing.Size(72, 16);
            this.ccbAccientFiled.TabIndex = 27;
            this.ccbAccientFiled.Text = "사고유형";
            this.ccbAccientFiled.UseVisualStyleBackColor = true;
            // 
            // ccbInjury
            // 
            this.ccbInjury.AutoSize = true;
            this.ccbInjury.Location = new System.Drawing.Point(315, 37);
            this.ccbInjury.Name = "ccbInjury";
            this.ccbInjury.Size = new System.Drawing.Size(72, 16);
            this.ccbInjury.TabIndex = 26;
            this.ccbInjury.Text = "부상자수";
            this.ccbInjury.UseVisualStyleBackColor = true;
            // 
            // ccbSlight
            // 
            this.ccbSlight.AutoSize = true;
            this.ccbSlight.Location = new System.Drawing.Point(217, 37);
            this.ccbSlight.Name = "ccbSlight";
            this.ccbSlight.Size = new System.Drawing.Size(72, 16);
            this.ccbSlight.TabIndex = 25;
            this.ccbSlight.Text = "경상자수";
            this.ccbSlight.UseVisualStyleBackColor = true;
            // 
            // ccbSeriously
            // 
            this.ccbSeriously.AutoSize = true;
            this.ccbSeriously.Location = new System.Drawing.Point(125, 37);
            this.ccbSeriously.Name = "ccbSeriously";
            this.ccbSeriously.Size = new System.Drawing.Size(72, 16);
            this.ccbSeriously.TabIndex = 24;
            this.ccbSeriously.Text = "중상자수";
            this.ccbSeriously.UseVisualStyleBackColor = true;
            // 
            // ccbDeath
            // 
            this.ccbDeath.AutoSize = true;
            this.ccbDeath.Location = new System.Drawing.Point(33, 37);
            this.ccbDeath.Name = "ccbDeath";
            this.ccbDeath.Size = new System.Drawing.Size(72, 16);
            this.ccbDeath.TabIndex = 23;
            this.ccbDeath.Text = "사망자수";
            this.ccbDeath.UseVisualStyleBackColor = true;
            // 
            // ccbDNN
            // 
            this.ccbDNN.AutoSize = true;
            this.ccbDNN.Location = new System.Drawing.Point(315, 18);
            this.ccbDNN.Name = "ccbDNN";
            this.ccbDNN.Size = new System.Drawing.Size(54, 16);
            this.ccbDNN.TabIndex = 22;
            this.ccbDNN.Text = "주/야";
            this.ccbDNN.UseVisualStyleBackColor = true;
            // 
            // ccbDOW
            // 
            this.ccbDOW.AutoSize = true;
            this.ccbDOW.Location = new System.Drawing.Point(407, 18);
            this.ccbDOW.Name = "ccbDOW";
            this.ccbDOW.Size = new System.Drawing.Size(48, 16);
            this.ccbDOW.TabIndex = 21;
            this.ccbDOW.Text = "요일";
            this.ccbDOW.UseVisualStyleBackColor = true;
            // 
            // ccbDate
            // 
            this.ccbDate.AutoSize = true;
            this.ccbDate.Checked = true;
            this.ccbDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ccbDate.Location = new System.Drawing.Point(33, 18);
            this.ccbDate.Name = "ccbDate";
            this.ccbDate.Size = new System.Drawing.Size(78, 16);
            this.ccbDate.TabIndex = 20;
            this.ccbDate.Text = "날짜/시간";
            this.ccbDate.UseVisualStyleBackColor = true;
            // 
            // ccbCity
            // 
            this.ccbCity.AutoSize = true;
            this.ccbCity.Checked = true;
            this.ccbCity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ccbCity.Location = new System.Drawing.Point(125, 18);
            this.ccbCity.Name = "ccbCity";
            this.ccbCity.Size = new System.Drawing.Size(54, 16);
            this.ccbCity.TabIndex = 35;
            this.ccbCity.Text = "시/도";
            this.ccbCity.UseVisualStyleBackColor = true;
            // 
            // ccbState
            // 
            this.ccbState.AutoSize = true;
            this.ccbState.Checked = true;
            this.ccbState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ccbState.Location = new System.Drawing.Point(217, 18);
            this.ccbState.Name = "ccbState";
            this.ccbState.Size = new System.Drawing.Size(72, 16);
            this.ccbState.TabIndex = 34;
            this.ccbState.Text = "시/군/구";
            this.ccbState.UseVisualStyleBackColor = true;
            // 
            // SearchFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOption);
            this.Name = "SearchFilterControl";
            this.Size = new System.Drawing.Size(704, 79);
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.CheckBox ccbVictim;
        private System.Windows.Forms.CheckBox ccbAttacker;
        private System.Windows.Forms.CheckBox ccbLoadForm;
        private System.Windows.Forms.CheckBox ccbAccidentType;
        private System.Windows.Forms.CheckBox ccbViolation;
        private System.Windows.Forms.CheckBox ccbAccientFiled;
        private System.Windows.Forms.CheckBox ccbInjury;
        private System.Windows.Forms.CheckBox ccbSlight;
        private System.Windows.Forms.CheckBox ccbSeriously;
        private System.Windows.Forms.CheckBox ccbDeath;
        private System.Windows.Forms.CheckBox ccbDNN;
        private System.Windows.Forms.CheckBox ccbDOW;
        private System.Windows.Forms.CheckBox ccbDate;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.CheckBox ccbCity;
        private System.Windows.Forms.CheckBox ccbState;
    }
}
