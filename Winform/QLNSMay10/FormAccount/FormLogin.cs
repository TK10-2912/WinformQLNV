using QLNSMay10.Classes;
using QLNSMay10.ConnectSql;
using QLNSMay10.FormAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSMay10
{
    public partial class FormLogin : Form
    {
        Session session = Session.instance();
        QLNVEntities db= new QLNVEntities();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
           var listUser= db.NguoiDung.Where(A=>A.Username==userName && A.Password==password).ToList();
            if(listUser.Count == 1)
            {
                FormMain mainTab = new FormMain();
                session.userLogin = listUser[0];
                mainTab.ShowDialog();
            }
           else {
                MessageBox.Show("Some text", "Some title",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
