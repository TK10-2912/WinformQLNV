using QLNSMay10.CongTac;
using QLNSMay10.FormAccount;
using QLNSMay10.ForrmNV;
using QLNSMay10.Hotro;
using QLNSMay10.LuongHSL;
using QLNSMay10.Thongke;
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

        private void bảngLươngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLuong chForm = new FormLuong();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLNV chForm = new FormQLNV();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }

        private void quảnLýPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPhongBan chForm = new FormPhongBan();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChucVu chForm = new FormChucVu();
          
            chForm.Show();
        }

        private void hệSốLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHSL chForm = new FormHSL();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }

        private void quảnLýQuáTrìnhCôngTácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCongTac chForm = new FormCongTac();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();

        }

        //private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FormThongke chForm = new FormThongke();
        //    chForm.MdiParent = this;
        //    chForm.FormBorderStyle = FormBorderStyle.None;
        //    chForm.Dock = DockStyle.Fill;
        //    chForm.Show();
        //}

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1Hotro chForm = new Form1Hotro();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }

        private void thốngKêTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongkeThang chForm = new FormThongkeThang();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }

        private void thốngKêTheoQuýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeQuy chForm = new FormThongKeQuy();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }

        private void thốngKêTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeNam chForm = new FormThongKeNam();
            chForm.MdiParent = this;
            chForm.FormBorderStyle = FormBorderStyle.None;
            chForm.Dock = DockStyle.Fill;
            chForm.Show();
        }
    }
}
