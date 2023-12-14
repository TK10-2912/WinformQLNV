using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSMay10.ForrmNV
{
    public partial class FormQLNV : Form
    {
        public FormQLNV()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet11.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNVDataSet11.NhanVien);
            // TODO: This line of code loads data into the 'qLNVDataSet1.ChucVu' table. You can move, or remove it, as needed.



        }
    }
}
