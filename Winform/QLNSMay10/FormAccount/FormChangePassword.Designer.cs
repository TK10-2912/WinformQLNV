namespace QLNSMay10.FormAccount
{
    partial class FormChangePassword
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu mới";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(428, 188);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(325, 38);
            this.txtPassword.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(428, 244);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(325, 37);
            this.txtNewPassword.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(465, 354);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 59);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(229, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 59);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(428, 296);
            this.txtRePassword.Multiline = true;
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(325, 41);
            this.txtRePassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 51);
            this.label4.TabIndex = 20;
            this.label4.Text = "Thay đổi mật khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormChangePassword
            // 
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(788, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
