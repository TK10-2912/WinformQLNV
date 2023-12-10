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
    public partial class FormMain : Form
    {
        bool isThoat = true;

        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) 
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            FormLogin f = new FormLogin();
            f.Show();
        }

        private void btnPhucap_Click(object sender, EventArgs e)
        {
            FormPhucap f = new FormPhucap();
            f.Show();
        }

        private void Doimk_Click(object sender, EventArgs e)
        {
            FormChangePassword chForm = new FormChangePassword();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }

        private void qltk_Click(object sender, EventArgs e)
        {
            FormManagerAcount chForm = new FormManagerAcount();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }
    }
}
