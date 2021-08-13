
namespace Ordersystem
{
    partial class Member
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "註冊新會員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "手機";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "密碼";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(266, 41);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(107, 177);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(266, 41);
            this.textBoxPhone.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(107, 238);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(266, 41);
            this.textBoxPassword.TabIndex = 6;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.AutoSize = true;
            this.SubmitBtn.Location = new System.Drawing.Point(156, 311);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(125, 42);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "填寫完成";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 387);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Member";
            this.Text = "會員註冊";
            this.Load += new System.EventHandler(this.Member_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button SubmitBtn;
    }
}