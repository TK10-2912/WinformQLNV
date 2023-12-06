using Newtonsoft.Json;
using QLNSMay10.Classes;
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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }
        Session session=Session.instance();
        QLNVEntities db = new QLNVEntities();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string oldPassword = txtPassword.Text;
            string newPassword = txtNewPassword.Text;
            string rePassword = txtRePassword.Text;
            System.Console.WriteLine("user" + JsonConvert.SerializeObject( session.userLogin));
            var listUser = db.Users.Where(A => A.UserId == session.userLogin.UserId).ToList();
            if(rePassword != newPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (listUser.Count == 1)
            //{
               
            //}
            else
            {
                MessageBox.Show("Some text", "Some title",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
