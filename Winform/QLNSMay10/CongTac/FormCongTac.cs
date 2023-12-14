using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSMay10.CongTac
{
    public partial class FormCongTac : Form
    {
        public FormCongTac()
        {
            InitializeComponent();
        }

        private void FormCongTac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet4.ThoiGianCongTac' table. You can move, or remove it, as needed.
            this.thoiGianCongTacTableAdapter.Fill(this.qLNVDataSet4.ThoiGianCongTac);

        }
    }
}
