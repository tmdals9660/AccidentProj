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
            this.bdsIncident = new System.Windows.Forms.BindingSource(this.components);
            this.partialAccidentFiledNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialAccidentTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialAttackerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialLoadFormNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialVictimNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partialViolationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incidentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriouslyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slightlyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.injuryCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accidentFiledIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accidentTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadFormIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victimIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accidentFiledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accidentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roadFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.victimTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.victimId,
            this.partialAccidentFiledNameDataGridViewTextBoxColumn,
            this.partialAccidentTypeNameDataGridViewTextBoxColumn,
            this.partialAttackerNameDataGridViewTextBoxColumn,
            this.partialLoadFormNameDataGridViewTextBoxColumn,
            this.partialVictimNameDataGridViewTextBoxColumn,
            this.partialViolationNameDataGridViewTextBoxColumn,
            this.incidentIdDataGridViewTextBoxColumn,
            this.dateAndTimeDataGridViewTextBoxColumn,
            this.dayNightDataGridViewTextBoxColumn,
            this.dayOfWeekDataGridViewTextBoxColumn,
            this.deadCountDataGridViewTextBoxColumn,
            this.seriouslyCountDataGridViewTextBoxColumn,
            this.slightlyCountDataGridViewTextBoxColumn,
            this.injuryCountDataGridViewTextBoxColumn,
            this.accidentFiledIdDataGridViewTextBoxColumn,
            this.accidentTypeIdDataGridViewTextBoxColumn,
            this.violationIdDataGridViewTextBoxColumn,
            this.roadFormIdDataGridViewTextBoxColumn,
            this.attackerIdDataGridViewTextBoxColumn,
            this.victimIdDataGridViewTextBoxColumn,
            this.accidentFiledDataGridViewTextBoxColumn,
            this.accidentTypeDataGridViewTextBoxColumn,
            this.attackerTypeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.roadFormDataGridViewTextBoxColumn,
            this.victimTypeDataGridViewTextBoxColumn,
            this.violationDataGridViewTextBoxColumn});
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
            // bdsIncident
            // 
            this.bdsIncident.DataSource = typeof(Accident.Data.Incident);
            // 
            // partialAccidentFiledNameDataGridViewTextBoxColumn
            // 
            this.partialAccidentFiledNameDataGridViewTextBoxColumn.DataPropertyName = "PartialAccidentFiledName";
            this.partialAccidentFiledNameDataGridViewTextBoxColumn.HeaderText = "PartialAccidentFiledName";
            this.partialAccidentFiledNameDataGridViewTextBoxColumn.Name = "partialAccidentFiledNameDataGridViewTextBoxColumn";
            // 
            // partialAccidentTypeNameDataGridViewTextBoxColumn
            // 
            this.partialAccidentTypeNameDataGridViewTextBoxColumn.DataPropertyName = "PartialAccidentTypeName";
            this.partialAccidentTypeNameDataGridViewTextBoxColumn.HeaderText = "PartialAccidentTypeName";
            this.partialAccidentTypeNameDataGridViewTextBoxColumn.Name = "partialAccidentTypeNameDataGridViewTextBoxColumn";
            // 
            // partialAttackerNameDataGridViewTextBoxColumn
            // 
            this.partialAttackerNameDataGridViewTextBoxColumn.DataPropertyName = "PartialAttackerName";
            this.partialAttackerNameDataGridViewTextBoxColumn.HeaderText = "PartialAttackerName";
            this.partialAttackerNameDataGridViewTextBoxColumn.Name = "partialAttackerNameDataGridViewTextBoxColumn";
            // 
            // partialLoadFormNameDataGridViewTextBoxColumn
            // 
            this.partialLoadFormNameDataGridViewTextBoxColumn.DataPropertyName = "PartialLoadFormName";
            this.partialLoadFormNameDataGridViewTextBoxColumn.HeaderText = "PartialLoadFormName";
            this.partialLoadFormNameDataGridViewTextBoxColumn.Name = "partialLoadFormNameDataGridViewTextBoxColumn";
            // 
            // partialVictimNameDataGridViewTextBoxColumn
            // 
            this.partialVictimNameDataGridViewTextBoxColumn.DataPropertyName = "PartialVictimName";
            this.partialVictimNameDataGridViewTextBoxColumn.HeaderText = "PartialVictimName";
            this.partialVictimNameDataGridViewTextBoxColumn.Name = "partialVictimNameDataGridViewTextBoxColumn";
            // 
            // partialViolationNameDataGridViewTextBoxColumn
            // 
            this.partialViolationNameDataGridViewTextBoxColumn.DataPropertyName = "PartialViolationName";
            this.partialViolationNameDataGridViewTextBoxColumn.HeaderText = "PartialViolationName";
            this.partialViolationNameDataGridViewTextBoxColumn.Name = "partialViolationNameDataGridViewTextBoxColumn";
            // 
            // incidentIdDataGridViewTextBoxColumn
            // 
            this.incidentIdDataGridViewTextBoxColumn.DataPropertyName = "IncidentId";
            this.incidentIdDataGridViewTextBoxColumn.HeaderText = "IncidentId";
            this.incidentIdDataGridViewTextBoxColumn.Name = "incidentIdDataGridViewTextBoxColumn";
            // 
            // dateAndTimeDataGridViewTextBoxColumn
            // 
            this.dateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "DateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.HeaderText = "DateAndTime";
            this.dateAndTimeDataGridViewTextBoxColumn.Name = "dateAndTimeDataGridViewTextBoxColumn";
            // 
            // dayNightDataGridViewTextBoxColumn
            // 
            this.dayNightDataGridViewTextBoxColumn.DataPropertyName = "DayNight";
            this.dayNightDataGridViewTextBoxColumn.HeaderText = "DayNight";
            this.dayNightDataGridViewTextBoxColumn.Name = "dayNightDataGridViewTextBoxColumn";
            // 
            // dayOfWeekDataGridViewTextBoxColumn
            // 
            this.dayOfWeekDataGridViewTextBoxColumn.DataPropertyName = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.HeaderText = "DayOfWeek";
            this.dayOfWeekDataGridViewTextBoxColumn.Name = "dayOfWeekDataGridViewTextBoxColumn";
            // 
            // deadCountDataGridViewTextBoxColumn
            // 
            this.deadCountDataGridViewTextBoxColumn.DataPropertyName = "DeadCount";
            this.deadCountDataGridViewTextBoxColumn.HeaderText = "DeadCount";
            this.deadCountDataGridViewTextBoxColumn.Name = "deadCountDataGridViewTextBoxColumn";
            // 
            // seriouslyCountDataGridViewTextBoxColumn
            // 
            this.seriouslyCountDataGridViewTextBoxColumn.DataPropertyName = "SeriouslyCount";
            this.seriouslyCountDataGridViewTextBoxColumn.HeaderText = "SeriouslyCount";
            this.seriouslyCountDataGridViewTextBoxColumn.Name = "seriouslyCountDataGridViewTextBoxColumn";
            // 
            // slightlyCountDataGridViewTextBoxColumn
            // 
            this.slightlyCountDataGridViewTextBoxColumn.DataPropertyName = "SlightlyCount";
            this.slightlyCountDataGridViewTextBoxColumn.HeaderText = "SlightlyCount";
            this.slightlyCountDataGridViewTextBoxColumn.Name = "slightlyCountDataGridViewTextBoxColumn";
            // 
            // injuryCountDataGridViewTextBoxColumn
            // 
            this.injuryCountDataGridViewTextBoxColumn.DataPropertyName = "InjuryCount";
            this.injuryCountDataGridViewTextBoxColumn.HeaderText = "InjuryCount";
            this.injuryCountDataGridViewTextBoxColumn.Name = "injuryCountDataGridViewTextBoxColumn";
            // 
            // accidentFiledIdDataGridViewTextBoxColumn
            // 
            this.accidentFiledIdDataGridViewTextBoxColumn.DataPropertyName = "AccidentFiledId";
            this.accidentFiledIdDataGridViewTextBoxColumn.HeaderText = "AccidentFiledId";
            this.accidentFiledIdDataGridViewTextBoxColumn.Name = "accidentFiledIdDataGridViewTextBoxColumn";
            // 
            // accidentTypeIdDataGridViewTextBoxColumn
            // 
            this.accidentTypeIdDataGridViewTextBoxColumn.DataPropertyName = "AccidentTypeId";
            this.accidentTypeIdDataGridViewTextBoxColumn.HeaderText = "AccidentTypeId";
            this.accidentTypeIdDataGridViewTextBoxColumn.Name = "accidentTypeIdDataGridViewTextBoxColumn";
            // 
            // violationIdDataGridViewTextBoxColumn
            // 
            this.violationIdDataGridViewTextBoxColumn.DataPropertyName = "ViolationId";
            this.violationIdDataGridViewTextBoxColumn.HeaderText = "ViolationId";
            this.violationIdDataGridViewTextBoxColumn.Name = "violationIdDataGridViewTextBoxColumn";
            // 
            // roadFormIdDataGridViewTextBoxColumn
            // 
            this.roadFormIdDataGridViewTextBoxColumn.DataPropertyName = "RoadFormId";
            this.roadFormIdDataGridViewTextBoxColumn.HeaderText = "RoadFormId";
            this.roadFormIdDataGridViewTextBoxColumn.Name = "roadFormIdDataGridViewTextBoxColumn";
            // 
            // attackerIdDataGridViewTextBoxColumn
            // 
            this.attackerIdDataGridViewTextBoxColumn.DataPropertyName = "AttackerId";
            this.attackerIdDataGridViewTextBoxColumn.HeaderText = "AttackerId";
            this.attackerIdDataGridViewTextBoxColumn.Name = "attackerIdDataGridViewTextBoxColumn";
            // 
            // victimIdDataGridViewTextBoxColumn
            // 
            this.victimIdDataGridViewTextBoxColumn.DataPropertyName = "VictimId";
            this.victimIdDataGridViewTextBoxColumn.HeaderText = "VictimId";
            this.victimIdDataGridViewTextBoxColumn.Name = "victimIdDataGridViewTextBoxColumn";
            // 
            // accidentFiledDataGridViewTextBoxColumn
            // 
            this.accidentFiledDataGridViewTextBoxColumn.DataPropertyName = "AccidentFiled";
            this.accidentFiledDataGridViewTextBoxColumn.HeaderText = "AccidentFiled";
            this.accidentFiledDataGridViewTextBoxColumn.Name = "accidentFiledDataGridViewTextBoxColumn";
            // 
            // accidentTypeDataGridViewTextBoxColumn
            // 
            this.accidentTypeDataGridViewTextBoxColumn.DataPropertyName = "AccidentType";
            this.accidentTypeDataGridViewTextBoxColumn.HeaderText = "AccidentType";
            this.accidentTypeDataGridViewTextBoxColumn.Name = "accidentTypeDataGridViewTextBoxColumn";
            // 
            // attackerTypeDataGridViewTextBoxColumn
            // 
            this.attackerTypeDataGridViewTextBoxColumn.DataPropertyName = "AttackerType";
            this.attackerTypeDataGridViewTextBoxColumn.HeaderText = "AttackerType";
            this.attackerTypeDataGridViewTextBoxColumn.Name = "attackerTypeDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // roadFormDataGridViewTextBoxColumn
            // 
            this.roadFormDataGridViewTextBoxColumn.DataPropertyName = "RoadForm";
            this.roadFormDataGridViewTextBoxColumn.HeaderText = "RoadForm";
            this.roadFormDataGridViewTextBoxColumn.Name = "roadFormDataGridViewTextBoxColumn";
            // 
            // victimTypeDataGridViewTextBoxColumn
            // 
            this.victimTypeDataGridViewTextBoxColumn.DataPropertyName = "VictimType";
            this.victimTypeDataGridViewTextBoxColumn.HeaderText = "VictimType";
            this.victimTypeDataGridViewTextBoxColumn.Name = "victimTypeDataGridViewTextBoxColumn";
            // 
            // violationDataGridViewTextBoxColumn
            // 
            this.violationDataGridViewTextBoxColumn.DataPropertyName = "Violation";
            this.violationDataGridViewTextBoxColumn.HeaderText = "Violation";
            this.violationDataGridViewTextBoxColumn.Name = "violationDataGridViewTextBoxColumn";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn partialAccidentFiledNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialAccidentTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialAttackerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialLoadFormNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialVictimNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partialViolationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incidentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriouslyCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slightlyCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn injuryCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accidentFiledIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accidentTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadFormIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn victimIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accidentFiledDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accidentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roadFormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn victimTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn violationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsIncident;
    }
}
