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
    public partial class fMain : Form
    {
        bool isThoat = true;

        public fMain()
        {
            InitializeComponent();
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
            Form1 f = new Form1();
            f.Show();
        }

        private void btnPhucap_Click(object sender, EventArgs e)
        {
            fPhucap f = new fPhucap();
            f.Show();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }
    }
}
