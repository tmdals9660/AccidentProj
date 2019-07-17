namespace Accident.From
{
	partial class AddAdminInfo
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
            this.btnSaveAddimInfo = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbPassward = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveAddimInfo
            // 
            this.btnSaveAddimInfo.Location = new System.Drawing.Point(122, 105);
            this.btnSaveAddimInfo.Name = "btnSaveAddimInfo";
            this.btnSaveAddimInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAddimInfo.TabIndex = 0;
            this.btnSaveAddimInfo.Text = "저장(&S)";
            this.btnSaveAddimInfo.UseVisualStyleBackColor = true;
            this.btnSaveAddimInfo.Click += new System.EventHandler(this.BtnSaveAddimInfo_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(97, 5);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 21);
            this.txbId.TabIndex = 1;
            // 
            // txbPassward
            // 
            this.txbPassward.Location = new System.Drawing.Point(97, 32);
            this.txbPassward.Name = "txbPassward";
            this.txbPassward.Size = new System.Drawing.Size(100, 21);
            this.txbPassward.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password : ";
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(97, 59);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(100, 21);
            this.txbCode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "이름 : ";
            // 
            // AddAdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPassward);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnSaveAddimInfo);
            this.Name = "AddAdminInfo";
            this.Text = "AddInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSaveAddimInfo;
		private System.Windows.Forms.TextBox txbId;
		private System.Windows.Forms.TextBox txbPassward;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbCode;
		private System.Windows.Forms.Label label3;
    }
}