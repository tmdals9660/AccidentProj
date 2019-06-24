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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInccident = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.bdsIncident = new System.Windows.Forms.BindingSource(this.components);
            this.dateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriouslyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slightlyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.injuryCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialAccidentFiledNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialAccidentTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialViolationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartialRoadFormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialAttackerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialVictimNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInccident)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInccident.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInccident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInccident.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateAndTimeDataGridViewTextBoxColumn,
            this.dayNightDataGridViewTextBoxColumn,
            this.dayOfWeekDataGridViewTextBoxColumn,
            this.deadCountDataGridViewTextBoxColumn,
            this.seriouslyCountDataGridViewTextBoxColumn,
            this.slightlyCountDataGridViewTextBoxColumn,
            this.injuryCountDataGridViewTextBoxColumn,
            this.partialAccidentFiledNameDataGridViewTextBoxColumn,
            this.partialAccidentTypeNameDataGridViewTextBoxColumn,
            this.partialViolationNameDataGridViewTextBoxColumn,
            this.PartialRoadFormName,
            this.partialAttackerNameDataGridViewTextBoxColumn,
            this.partialVictimNameDataGridViewTextBoxColumn});
            this.dgvInccident.DataSource = this.bdsIncident;
            this.dgvInccident.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInccident.Location = new System.Drawing.Point(0, 0);
            this.dgvInccident.MultiSelect = false;
            this.dgvInccident.Name = "dgvInccident";
            this.dgvInccident.RowHeadersVisible = false;
            this.dgvInccident.RowTemplate.Height = 23;
            this.dgvInccident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInccident.Size = new System.Drawing.Size(628, 338);
            this.dgvInccident.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sslCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "검색 건수 :";
            // 
            // sslCount
            // 
            this.sslCount.Name = "sslCount";
            this.sslCount.Size = new System.Drawing.Size(14, 17);
            this.sslCount.Text = "0";
            // 
            // bdsIncident
            // 
            this.bdsIncident.DataSource = typeof(Accident.Data.Incident);
            // 
            // dateAndTimeDataGridViewTextBoxColumn
            // 
            this.dateAndTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "DateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.HeaderText = "날짜";
            this.dateAndTimeDataGridViewTextBoxColumn.Name = "dateAndTimeDataGridViewTextBoxColumn";
            this.dateAndTimeDataGridViewTextBoxColumn.Width = 54;
            // 
            // dayNightDataGridViewTextBoxColumn
            // 
            this.dayNightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dayNightDataGridViewTextBoxColumn.DataPropertyName = "DayNight";
            this.dayNightDataGridViewTextBoxColumn.HeaderText = "주/야";
            this.dayNightDataGridViewTextBoxColumn.Name = "dayNightDataGridViewTextBoxColumn";
            this.dayNightDataGridViewTextBoxColumn.Visible = false;
            this.dayNightDataGridViewTextBoxColumn.Width = 60;
            // 
            // dayOfWeekDataGridViewTextBoxColumn
            // 
            this.dayOfWeekDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dayOfWeekDataGridViewTextBoxColumn.DataPropertyName = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.HeaderText = "요일";
            this.dayOfWeekDataGridViewTextBoxColumn.Name = "dayOfWeekDataGridViewTextBoxColumn";
            this.dayOfWeekDataGridViewTextBoxColumn.Visible = false;
            this.dayOfWeekDataGridViewTextBoxColumn.Width = 54;
            // 
            // deadCountDataGridViewTextBoxColumn
            // 
            this.deadCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.deadCountDataGridViewTextBoxColumn.DataPropertyName = "DeadCount";
            this.deadCountDataGridViewTextBoxColumn.HeaderText = "사망자수";
            this.deadCountDataGridViewTextBoxColumn.Name = "deadCountDataGridViewTextBoxColumn";
            this.deadCountDataGridViewTextBoxColumn.Visible = false;
            this.deadCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // seriouslyCountDataGridViewTextBoxColumn
            // 
            this.seriouslyCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.seriouslyCountDataGridViewTextBoxColumn.DataPropertyName = "SeriouslyCount";
            this.seriouslyCountDataGridViewTextBoxColumn.HeaderText = "중상자수";
            this.seriouslyCountDataGridViewTextBoxColumn.Name = "seriouslyCountDataGridViewTextBoxColumn";
            this.seriouslyCountDataGridViewTextBoxColumn.Visible = false;
            this.seriouslyCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // slightlyCountDataGridViewTextBoxColumn
            // 
            this.slightlyCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.slightlyCountDataGridViewTextBoxColumn.DataPropertyName = "SlightlyCount";
            this.slightlyCountDataGridViewTextBoxColumn.HeaderText = "경상자수";
            this.slightlyCountDataGridViewTextBoxColumn.Name = "slightlyCountDataGridViewTextBoxColumn";
            this.slightlyCountDataGridViewTextBoxColumn.Visible = false;
            this.slightlyCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // injuryCountDataGridViewTextBoxColumn
            // 
            this.injuryCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.injuryCountDataGridViewTextBoxColumn.DataPropertyName = "InjuryCount";
            this.injuryCountDataGridViewTextBoxColumn.HeaderText = "부상자수";
            this.injuryCountDataGridViewTextBoxColumn.Name = "injuryCountDataGridViewTextBoxColumn";
            this.injuryCountDataGridViewTextBoxColumn.Visible = false;
            this.injuryCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // partialAccidentFiledNameDataGridViewTextBoxColumn
            // 
            this.partialAccidentFiledNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.partialAccidentFiledNameDataGridViewTextBoxColumn.DataPropertyName = "PartialAccidentFiledName";
            this.partialAccidentFiledNameDataGridViewTextBoxColumn.HeaderText = "사고유형";
            this.partialAccidentFiledNameDataGridViewTextBoxColumn.Name = "partialAccidentFiledNameDataGridViewTextBoxColumn";
            this.partialAccidentFiledNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // partialAccidentTypeNameDataGridViewTextBoxColumn
            // 
            this.partialAccidentTypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.partialAccidentTypeNameDataGridViewTextBoxColumn.DataPropertyName = "PartialAccidentTypeName";
            this.partialAccidentTypeNameDataGridViewTextBoxColumn.HeaderText = "사고형태";
            this.partialAccidentTypeNameDataGridViewTextBoxColumn.Name = "partialAccidentTypeNameDataGridViewTextBoxColumn";
            this.partialAccidentTypeNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // partialViolationNameDataGridViewTextBoxColumn
            // 
            this.partialViolationNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.partialViolationNameDataGridViewTextBoxColumn.DataPropertyName = "PartialViolationName";
            this.partialViolationNameDataGridViewTextBoxColumn.HeaderText = "법규위반유형";
            this.partialViolationNameDataGridViewTextBoxColumn.Name = "partialViolationNameDataGridViewTextBoxColumn";
            this.partialViolationNameDataGridViewTextBoxColumn.Visible = false;
            this.partialViolationNameDataGridViewTextBoxColumn.Width = 102;
            // 
            // PartialRoadFormName
            // 
            this.PartialRoadFormName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PartialRoadFormName.DataPropertyName = "PartialRoadFormName";
            this.PartialRoadFormName.HeaderText = "도로형태";
            this.PartialRoadFormName.Name = "PartialRoadFormName";
            this.PartialRoadFormName.Visible = false;
            this.PartialRoadFormName.Width = 78;
            // 
            // partialAttackerNameDataGridViewTextBoxColumn
            // 
            this.partialAttackerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.partialAttackerNameDataGridViewTextBoxColumn.DataPropertyName = "PartialAttackerName";
            this.partialAttackerNameDataGridViewTextBoxColumn.HeaderText = "가해자유형";
            this.partialAttackerNameDataGridViewTextBoxColumn.Name = "partialAttackerNameDataGridViewTextBoxColumn";
            this.partialAttackerNameDataGridViewTextBoxColumn.Visible = false;
            this.partialAttackerNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // partialVictimNameDataGridViewTextBoxColumn
            // 
            this.partialVictimNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.partialVictimNameDataGridViewTextBoxColumn.DataPropertyName = "PartialVictimName";
            this.partialVictimNameDataGridViewTextBoxColumn.HeaderText = "피해자유형";
            this.partialVictimNameDataGridViewTextBoxColumn.Name = "partialVictimNameDataGridViewTextBoxColumn";
            this.partialVictimNameDataGridViewTextBoxColumn.Visible = false;
            this.partialVictimNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // SearchListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInccident);
            this.Controls.Add(this.statusStrip1);
            this.Name = "SearchListControl";
            this.Size = new System.Drawing.Size(628, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInccident)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIncident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInccident;
        private System.Windows.Forms.BindingSource bdsIncident;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sslCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriouslyCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slightlyCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn injuryCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialAccidentFiledNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialAccidentTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialViolationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartialRoadFormName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialAttackerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialVictimNameDataGridViewTextBoxColumn;
    }
}
