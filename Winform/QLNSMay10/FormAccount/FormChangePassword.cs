using Newtonsoft.Json;
using QLNSMay10.Classes;
using QLNSMay10.ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNSMay10.FormAccount
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
            this.Opacity = 1;
        }
        Session session=Session.instance();
        QLNVEntities db = new QLNVEntities();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string oldPassword = txtPassword.Text;
            string newPassword = txtNewPassword.Text;
            string rePassword = txtRePassword.Text;
            System.Console.WriteLine("user" + JsonConvert.SerializeObject( session.userLogin));
            var user = db.Users.SingleOrDefault(A => A.UserId == session.userLogin.UserId);
            if(user != null)
            {
                if (rePassword != newPassword)
                {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                user.PWord = newPassword;
                db.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some text", "Some title",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
