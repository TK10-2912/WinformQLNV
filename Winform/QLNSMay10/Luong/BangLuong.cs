using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLNSMay10.Luong
{
    public partial class BangLuong : Form
    {
        public BangLuong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet2.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNVDataSet2.NhanVien);
            // TODO: This line of code loads data into the 'qLNVDataSet1.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.qLNVDataSet1.Luong);
            // TODO: This line of code loads data into the 'qLNVDataSet.viewLuongNV' table. You can move, or remove it, as needed.
            this.viewLuongNVTableAdapter.Fill(this.qLNVDataSet.viewLuongNV);
            // TODO: This line of code loads data into the 'qLNVDataSet2.viewLuongNV' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLNVDataSet1.ChucVu' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLNVDataSet.Luong' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView row = new DataGridView();
            int n = e.RowIndex;
            Thang.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
        }
    }
}
