namespace Accident.Control
{
    partial class SearchListControl
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
            this.dgvInccident = new System.Windows.Forms.DataGridView();
            this.bdsIncident = new System.Windows.Forms.BindingSource(this.components);
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.am_pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfTheWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfDeaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfSeriously = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfSlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfinjury = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accidentFiledId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acidentTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadFormId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInccident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIncident)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInccident
            // 
            this.dgvInccident.AllowUserToAddRows = false;
            this.dgvInccident.AllowUserToDeleteRows = false;
            this.dgvInccident.AllowUserToResizeColumns = false;
            this.dgvInccident.AllowUserToResizeRows = false;
            this.dgvInccident.AutoGenerateColumns = false;
            this.dgvInccident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInccident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.am_pm,
            this.dayOfTheWeek,
            this.NumberOfDeaths,
            this.NumberOfSeriously,
            this.NumberOfSlight,
            this.NumberOfinjury,
            this.accidentFiledId,
            this.acidentTypeId,
            this.violationId,
            this.loadFormId,
            this.attackerId,
            this.victimId});
            this.dgvInccident.DataSource = this.bdsIncident;
            this.dgvInccident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInccident.Location = new System.Drawing.Point(0, 0);
            this.dgvInccident.MultiSelect = false;
            this.dgvInccident.Name = "dgvInccident";
            this.dgvInccident.RowHeadersVisible = false;
            this.dgvInccident.RowTemplate.Height = 23;
            this.dgvInccident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInccident.Size = new System.Drawing.Size(628, 360);
            this.dgvInccident.TabIndex = 3;
            // 
            // bdsIncident
            // 
            this.bdsIncident.DataSource = typeof(Accident.Data.Incident);
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "날짜/시간";
            this.date.Name = "date";
            // 
            // am_pm
            // 
            this.am_pm.DataPropertyName = "am_pm";
            this.am_pm.HeaderText = "주/야";
            this.am_pm.Name = "am_pm";
            this.am_pm.Visible = false;
            // 
            // dayOfTheWeek
            // 
            this.dayOfTheWeek.DataPropertyName = "dayOfTheWeek";
            this.dayOfTheWeek.HeaderText = "요일";
            this.dayOfTheWeek.Name = "dayOfTheWeek";
            this.dayOfTheWeek.Visible = false;
            // 
            // NumberOfDeaths
            // 
            this.NumberOfDeaths.DataPropertyName = "NumberOfDeaths";
            this.NumberOfDeaths.HeaderText = "사망자수";
            this.NumberOfDeaths.Name = "NumberOfDeaths";
            this.NumberOfDeaths.Visible = false;
            // 
            // NumberOfSeriously
            // 
            this.NumberOfSeriously.DataPropertyName = "NumberOfSeriously";
            this.NumberOfSeriously.HeaderText = "중상자수";
            this.NumberOfSeriously.Name = "NumberOfSeriously";
            this.NumberOfSeriously.Visible = false;
            // 
            // NumberOfSlight
            // 
            this.NumberOfSlight.DataPropertyName = "NumberOfSlight";
            this.NumberOfSlight.HeaderText = "경상자수";
            this.NumberOfSlight.Name = "NumberOfSlight";
            this.NumberOfSlight.Visible = false;
            // 
            // NumberOfinjury
            // 
            this.NumberOfinjury.DataPropertyName = "NumberOfinjury";
            this.NumberOfinjury.HeaderText = "부상자수";
            this.NumberOfinjury.Name = "NumberOfinjury";
            this.NumberOfinjury.Visible = false;
            // 
            // accidentFiledId
            // 
            this.accidentFiledId.DataPropertyName = "accidentFiledId";
            this.accidentFiledId.HeaderText = "사고유형(ID)";
            this.accidentFiledId.Name = "accidentFiledId";
            // 
            // acidentTypeId
            // 
            this.acidentTypeId.DataPropertyName = "acidentTypeId";
            this.acidentTypeId.HeaderText = "사고형태(ID)";
            this.acidentTypeId.Name = "acidentTypeId";
            // 
            // violationId
            // 
            this.violationId.DataPropertyName = "violationId";
            this.violationId.HeaderText = "법규위반(ID)";
            this.violationId.Name = "violationId";
            this.violationId.Visible = false;
            // 
            // loadFormId
            // 
            this.loadFormId.DataPropertyName = "loadFormId";
            this.loadFormId.HeaderText = "도로형태(ID)";
            this.loadFormId.Name = "loadFormId";
            this.loadFormId.Visible = false;
            // 
            // attackerId
            // 
            this.attackerId.DataPropertyName = "attackerId";
            this.attackerId.HeaderText = "가해자유형(ID)";
            this.attackerId.Name = "attackerId";
            this.attackerId.Visible = false;
            // 
            // victimId
            // 
            this.victimId.DataPropertyName = "victimId";
            this.victimId.HeaderText = "피해자유형(ID)";
            this.victimId.Name = "victimId";
            this.victimId.Visible = false;
            // 
            // SearchListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInccident);
            this.Name = "SearchListControl";
            this.Size = new System.Drawing.Size(628, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInccident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIncident)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInccident;
        private System.Windows.Forms.BindingSource bdsIncident;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn am_pm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfTheWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfDeaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfSeriously;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfSlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfinjury;
        private System.Windows.Forms.DataGridViewTextBoxColumn accidentFiledId;
        private System.Windows.Forms.DataGridViewTextBoxColumn acidentTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn loadFormId;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn victimId;
    }
}
