using QLNSMay10.ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNSMay10.FormAccount
{
    public partial class FormSignup : Form
    {
        QLNVEntities db = new QLNVEntities();
        public FormSignup()
        {
            InitializeComponent();

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string userName = txtuserName.Text;
            string password = txtPassword.Text;
            string rePassword = txtRePassword.Text;

            // Kiểm tra mật khẩu và xác nhận mật khẩu
            if (password != rePassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem tài khoản có tồn tại không
            var existingUser = db.Users.FirstOrDefault(A => A.UserName == userName);

            if (existingUser == null)
            {
                // Tạo người dùng mới và thêm vào cơ sở dữ liệu
                User newUser = new User();
                newUser.UserName = userName;
                newUser.PWord = password;
                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
