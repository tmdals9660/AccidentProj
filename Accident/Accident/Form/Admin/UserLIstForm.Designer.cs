namespace Accident.From
{
    partial class UserListForm
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
            this.dgvAdminList = new System.Windows.Forms.DataGridView();
            this.dbsAdmin = new System.Windows.Forms.BindingSource(this.components);
            this.adminIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminIdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdminList
            // 
            this.dgvAdminList.AllowUserToAddRows = false;
            this.dgvAdminList.AllowUserToDeleteRows = false;
            this.dgvAdminList.AllowUserToResizeColumns = false;
            this.dgvAdminList.AllowUserToResizeRows = false;
            this.dgvAdminList.AutoGenerateColumns = false;
            this.dgvAdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIdDataGridViewTextBoxColumn,
            this.adminIdNameDataGridViewTextBoxColumn,
            this.adminPasswordDataGridViewTextBoxColumn,
            this.adminNameDataGridViewTextBoxColumn});
            this.dgvAdminList.DataSource = this.dbsAdmin;
            this.dgvAdminList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminList.Location = new System.Drawing.Point(0, 0);
            this.dgvAdminList.Name = "dgvAdminList";
            this.dgvAdminList.ReadOnly = true;
            this.dgvAdminList.RowTemplate.Height = 23;
            this.dgvAdminList.Size = new System.Drawing.Size(499, 268);
            this.dgvAdminList.TabIndex = 0;
            this.dgvAdminList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgcAdminList_CellContentClick);
            this.dgvAdminList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DgvAdminList_KeyUp);
            // 
            // dbsAdmin
            // 
            this.dbsAdmin.DataSource = typeof(Accident.Data.Admin);
            // 
            // adminIdDataGridViewTextBoxColumn
            // 
            this.adminIdDataGridViewTextBoxColumn.DataPropertyName = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.HeaderText = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.Name = "adminIdDataGridViewTextBoxColumn";
            this.adminIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminIdNameDataGridViewTextBoxColumn
            // 
            this.adminIdNameDataGridViewTextBoxColumn.DataPropertyName = "AdminIdName";
            this.adminIdNameDataGridViewTextBoxColumn.HeaderText = "AdminIdName";
            this.adminIdNameDataGridViewTextBoxColumn.Name = "adminIdNameDataGridViewTextBoxColumn";
            this.adminIdNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminPasswordDataGridViewTextBoxColumn
            // 
            this.adminPasswordDataGridViewTextBoxColumn.DataPropertyName = "AdminPassword";
            this.adminPasswordDataGridViewTextBoxColumn.HeaderText = "AdminPassword";
            this.adminPasswordDataGridViewTextBoxColumn.Name = "adminPasswordDataGridViewTextBoxColumn";
            this.adminPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminNameDataGridViewTextBoxColumn
            // 
            this.adminNameDataGridViewTextBoxColumn.DataPropertyName = "AdminName";
            this.adminNameDataGridViewTextBoxColumn.HeaderText = "AdminName";
            this.adminNameDataGridViewTextBoxColumn.Name = "adminNameDataGridViewTextBoxColumn";
            this.adminNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 268);
            this.Controls.Add(this.dgvAdminList);
            this.Name = "UserListForm";
            this.Text = "UserLoginForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserListForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAdminList;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dbsAdmin;
    }
}