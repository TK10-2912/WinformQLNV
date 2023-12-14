using QLNSMay10.ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSMay10.LuongHSL
{
    public partial class FormLuong : Form
    {
        QLNVEntities qlnv = new QLNVEntities();
        BindingSource bd = new BindingSource();
        int checkId = 0;
        public FormLuong()
        {
            InitializeComponent();
        }

        private void FormLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet7.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter2.Fill(this.qLNVDataSet7.NhanVien);
            // TODO: This line of code loads data into the 'qLNVDataSet6.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter1.Fill(this.qLNVDataSet6.NhanVien);
            // TODO: This line of code loads data into the 'qLNVDataSet5.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNVDataSet5.NhanVien);
            List<int> thang = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12 };
            List<int> songaycong = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30 };
            List<int> nam = new List<int>();
            for(int i = 2015; i< DateTime.Now.Year; i++)
            {
                nam.Add(i);
            }    
            foreach(int i in thang)
            {
                cbThang.Items.Add(i);
            }
            foreach (int i in songaycong)
            {
                cbSoNgayCong.Items.Add(i);
            }
            foreach(int i in nam)
            {
                cbNam.Items.Add(i);
            }
            // TODO: This line of code loads data into the 'qLNVLuong.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.qLNVLuong.Luong);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbMaTinhLuong.Text = "";
            cbMaHSL.Text = "";
            cbThang.Text = "";
            cbSoNgayCong.Text = "";
            cbNam.Text = "";
            txtSoNgayLamThem.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var luong = qlnv.Luong.SingleOrDefault(item => item.MaLuong == checkId);
            if (
                cbMaHSL.Text == ""|| cbThang.Text == "" || cbSoNgayCong.Text == "" || cbNam.Text == "" ||txtSoNgayLamThem.Text == "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                luong.MaHSL = Int32.Parse(cbMaHSL.Text);
                luong.Thang = Int32.Parse(cbThang.Text);
                luong.Nam = Int32.Parse(cbNam.Text);
                luong.SoNgayCong = Int32.Parse(cbSoNgayCong.Text);
                luong.SoNgayLamThem = Int32.Parse(txtSoNgayLamThem.Text);
                qlnv.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.HeSoLuong.ToList();
                grvLuong.DataSource = bd.DataSource;
                grvLuong.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string tenHsl = cbMaHSL.Text;
            //float luong = float.Parse(cbMaTinhLuong.Text);
            //float phucap = float.Parse(cbPhuCap.Text);
            //var list = qlnv.HeSoLuong.ToList();
            //if (tenHsl == "" || cbPhuCap.Text == "" || cbPhuCap.Text == "")
            //{

            //    MessageBox.Show("Mời bạn hãy nhập đủ trường", "Thông báo",
            //     MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    HeSoLuong hsl = new HeSoLuong();
            //    hsl.TenHSL = tenHsl;
            //    hsl.LuongThang = luong;
            //    hsl.LuongPhuCap = phucap;
            //    qlnv.HeSoLuong.Add(hsl);
            //    qlnv.SaveChanges();
            //    MessageBox.Show("Thêm mới thành công! ", "Thông báo",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    bd.DataSource = qlnv.HeSoLuong.ToList();
            //    grvHSL.DataSource = bd.DataSource;
            //    grvHSL.Refresh();
            //}
        }

        private void cbMaTinhLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
