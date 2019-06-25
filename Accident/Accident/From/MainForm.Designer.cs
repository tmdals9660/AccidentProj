namespace Accident
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msClose = new System.Windows.Forms.ToolStripMenuItem();
            this.검색CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.msSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msAdminMode = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msVoca = new System.Windows.Forms.ToolStripMenuItem();
            this.msRef = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.피드백보내기FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdminEnter = new System.Windows.Forms.Button();
            this.btnSearchEnter = new System.Windows.Forms.Button();
            this.btnStatEnter = new System.Windows.Forms.Button();
            this.btnMakeId = new System.Windows.Forms.Button();
            this.sstMain = new System.Windows.Forms.StatusStrip();
            this.stlMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.sstMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.검색CToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msClose});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // msClose
            // 
            this.msClose.Name = "msClose";
            this.msClose.Size = new System.Drawing.Size(113, 22);
            this.msClose.Text = "닫기(&X)";
            this.msClose.Click += new System.EventHandler(this.MsClose_Click);
            // 
            // 검색CToolStripMenuItem
            // 
            this.검색CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msStatistics,
            this.msSearch,
            this.toolStripSeparator2,
            this.msAdminMode});
            this.검색CToolStripMenuItem.Name = "검색CToolStripMenuItem";
            this.검색CToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.검색CToolStripMenuItem.Text = "검색(&C)";
            // 
            // msStatistics
            // 
            this.msStatistics.Name = "msStatistics";
            this.msStatistics.Size = new System.Drawing.Size(150, 22);
            this.msStatistics.Text = "통계(&T)";
            this.msStatistics.Click += new System.EventHandler(this.MsStatistics_Click);
            // 
            // msSearch
            // 
            this.msSearch.Name = "msSearch";
            this.msSearch.Size = new System.Drawing.Size(150, 22);
            this.msSearch.Text = "검색(&S)";
            this.msSearch.Click += new System.EventHandler(this.MsSearch_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // msAdminMode
            // 
            this.msAdminMode.Name = "msAdminMode";
            this.msAdminMode.Size = new System.Drawing.Size(150, 22);
            this.msAdminMode.Text = "관리자모드(&A)";
            this.msAdminMode.Click += new System.EventHandler(this.MsAdminMode_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msVoca,
            this.msRef,
            this.toolStripSeparator1,
            this.피드백보내기FToolStripMenuItem});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // msVoca
            // 
            this.msVoca.Name = "msVoca";
            this.msVoca.Size = new System.Drawing.Size(164, 22);
            this.msVoca.Text = "용어보기(&T)";
            this.msVoca.Click += new System.EventHandler(this.MsVoca_Click);
            // 
            // msRef
            // 
            this.msRef.Name = "msRef";
            this.msRef.Size = new System.Drawing.Size(164, 22);
            this.msRef.Text = "참조사이트(&R)";
            this.msRef.Click += new System.EventHandler(this.MsRef_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // 피드백보내기FToolStripMenuItem
            // 
            this.피드백보내기FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFunction});
            this.피드백보내기FToolStripMenuItem.Name = "피드백보내기FToolStripMenuItem";
            this.피드백보내기FToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.피드백보내기FToolStripMenuItem.Text = "피드백 보내기(&F)";
            // 
            // msFunction
            // 
            this.msFunction.Name = "msFunction";
            this.msFunction.Size = new System.Drawing.Size(205, 22);
            this.msFunction.Text = "기능제안 및 문제보고(&P)";
            this.msFunction.Click += new System.EventHandler(this.MsFunction_Click);
            // 
            // btnAdminEnter
            // 
            this.btnAdminEnter.Location = new System.Drawing.Point(429, 246);
            this.btnAdminEnter.Name = "btnAdminEnter";
            this.btnAdminEnter.Size = new System.Drawing.Size(75, 23);
            this.btnAdminEnter.TabIndex = 2;
            this.btnAdminEnter.Text = "관리자모드";
            this.btnAdminEnter.UseVisualStyleBackColor = true;
            this.btnAdminEnter.Click += new System.EventHandler(this.BtnAdminEnter_Click);
            // 
            // btnSearchEnter
            // 
            this.btnSearchEnter.Location = new System.Drawing.Point(242, 127);
            this.btnSearchEnter.Name = "btnSearchEnter";
            this.btnSearchEnter.Size = new System.Drawing.Size(75, 23);
            this.btnSearchEnter.TabIndex = 3;
            this.btnSearchEnter.Text = "검색들으감";
            this.btnSearchEnter.UseVisualStyleBackColor = true;
            this.btnSearchEnter.Click += new System.EventHandler(this.BtnSearchEnter_Click);
            // 
            // btnStatEnter
            // 
            this.btnStatEnter.Location = new System.Drawing.Point(100, 127);
            this.btnStatEnter.Name = "btnStatEnter";
            this.btnStatEnter.Size = new System.Drawing.Size(75, 23);
            this.btnStatEnter.TabIndex = 4;
            this.btnStatEnter.Text = "통계들으감";
            this.btnStatEnter.UseVisualStyleBackColor = true;
            // 
            // btnMakeId
            // 
            this.btnMakeId.Location = new System.Drawing.Point(394, 127);
            this.btnMakeId.Name = "btnMakeId";
            this.btnMakeId.Size = new System.Drawing.Size(75, 23);
            this.btnMakeId.TabIndex = 5;
            this.btnMakeId.Text = "아이디생성";
            this.btnMakeId.UseVisualStyleBackColor = true;
            this.btnMakeId.Visible = false;
            // 
            // sstMain
            // 
            this.sstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlMode});
            this.sstMain.Location = new System.Drawing.Point(0, 283);
            this.sstMain.Name = "sstMain";
            this.sstMain.Size = new System.Drawing.Size(591, 22);
            this.sstMain.TabIndex = 6;
            this.sstMain.Text = "statusStrip1";
            // 
            // stlMode
            // 
            this.stlMode.Name = "stlMode";
            this.stlMode.Size = new System.Drawing.Size(59, 17);
            this.stlMode.Tag = "0";
            this.stlMode.Text = "일반 모드";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 305);
            this.Controls.Add(this.sstMain);
            this.Controls.Add(this.btnMakeId);
            this.Controls.Add(this.btnStatEnter);
            this.Controls.Add(this.btnSearchEnter);
            this.Controls.Add(this.btnAdminEnter);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sstMain.ResumeLayout(false);
            this.sstMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msClose;
        private System.Windows.Forms.ToolStripMenuItem 검색CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msVoca;
        private System.Windows.Forms.ToolStripMenuItem msRef;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 피드백보내기FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msFunction;
        private System.Windows.Forms.ToolStripMenuItem msStatistics;
        private System.Windows.Forms.ToolStripMenuItem msSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem msAdminMode;
        private System.Windows.Forms.Button btnAdminEnter;
        private System.Windows.Forms.Button btnSearchEnter;
        private System.Windows.Forms.Button btnStatEnter;
        private System.Windows.Forms.Button btnMakeId;
        private System.Windows.Forms.StatusStrip sstMain;
        private System.Windows.Forms.ToolStripStatusLabel stlMode;
    }
}