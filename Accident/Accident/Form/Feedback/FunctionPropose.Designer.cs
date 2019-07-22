namespace Accident.From.Feedback
{
    partial class FunctionPropose
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMailFunc = new System.Windows.Forms.TextBox();
            this.txbSubj = new System.Windows.Forms.TextBox();
            this.txbContents = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "메일 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "제목 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "내용 :";
            // 
            // txbMailFunc
            // 
            this.txbMailFunc.Location = new System.Drawing.Point(56, 10);
            this.txbMailFunc.Name = "txbMailFunc";
            this.txbMailFunc.Size = new System.Drawing.Size(257, 21);
            this.txbMailFunc.TabIndex = 3;
            // 
            // txbSubj
            // 
            this.txbSubj.Location = new System.Drawing.Point(56, 36);
            this.txbSubj.Name = "txbSubj";
            this.txbSubj.Size = new System.Drawing.Size(257, 21);
            this.txbSubj.TabIndex = 4;
            // 
            // txbContents
            // 
            this.txbContents.Location = new System.Drawing.Point(56, 64);
            this.txbContents.Multiline = true;
            this.txbContents.Name = "txbContents";
            this.txbContents.Size = new System.Drawing.Size(257, 101);
            this.txbContents.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(227, 171);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(86, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "전송하기(&S)";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // FunctionPropose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 199);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbContents);
            this.Controls.Add(this.txbSubj);
            this.Controls.Add(this.txbMailFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FunctionPropose";
            this.Text = "FunctionPropose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMailFunc;
        private System.Windows.Forms.TextBox txbSubj;
        private System.Windows.Forms.TextBox txbContents;
        private System.Windows.Forms.Button btnSend;
    }
}