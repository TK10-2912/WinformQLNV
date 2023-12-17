using Newtonsoft.Json;
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

namespace QLNSMay10.ForrmNV
{
    public partial class FormPhongBan : Form
    {
        QLNVEntities qlnv = new QLNVEntities();
        BindingSource bd = new BindingSource();
        int checkId = 0;
        public FormPhongBan()
        {
            InitializeComponent();
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet13.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.qLNVDataSet13.PhongBan);

        }

        private void add_Click(object sender, EventArgs e)
        {
            string tenphongban = txtTenPhongBan.Text;
            string sodienthoai = txtSoDienThoai.Text;
            string diachi = txtDiaChi.Text;
            if (tenphongban.Trim() == "" || sodienthoai.Trim() == "" || diachi.Trim() =="")
            {

                MessageBox.Show("Mời bạn hãy nhập đủ trường", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PhongBan pb = new PhongBan();
                pb.TenPhongBan = tenphongban;
                pb.SoDienThoai = sodienthoai;
                pb.DiaChi = diachi;
                qlnv.PhongBans.Add(pb);
                qlnv.SaveChanges();
                MessageBox.Show("Thêm mới thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.PhongBans.ToList();
                dtgrPhongBan.DataSource = bd.DataSource;
                dtgrPhongBan.Refresh();
                this.delete_Click(null, EventArgs.Empty);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string tenphongban = txtTenPhongBan.Text;
            string sodienthoai = txtSoDienThoai.Text;
            string diachi = txtDiaChi.Text;
            var phongban = qlnv.PhongBans.SingleOrDefault(item => item.MaPhongBan == checkId);
            if (tenphongban.Trim() == "" || sodienthoai.Trim() == "" || diachi.Trim() == "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                phongban.TenPhongBan = tenphongban;
                phongban.SoDienThoai = sodienthoai;
                phongban.DiaChi = diachi;
                qlnv.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.PhongBans.ToList();
                dtgrPhongBan.DataSource = bd.DataSource;
                dtgrPhongBan.Refresh();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            txtTenPhongBan.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        private void dtgrPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            checkId = Int32.Parse(dtgrPhongBan.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.RowIndex >= 0 && dtgrPhongBan.Columns[e.ColumnIndex].Name == "chinhsua")
            {
                if (e.RowIndex < dtgrPhongBan.Rows.Count && dtgrPhongBan.SelectedCells.Count > 0)
                {

                    txtTenPhongBan.Text = dtgrPhongBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSoDienThoai.Text = dtgrPhongBan.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtDiaChi.Text = dtgrPhongBan.Rows[e.RowIndex].Cells[3].Value.ToString();

                }
            }
            if (e.RowIndex >= 0 && dtgrPhongBan.Columns[e.ColumnIndex].Name == "xoa")
            {
                if (e.RowIndex < dtgrPhongBan.Rows.Count && dtgrPhongBan.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng này này chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {


                        var phongban = qlnv.PhongBans.SingleOrDefault(item => item.MaPhongBan == checkId);
                        Console.WriteLine("aaaa " + JsonConvert.SerializeObject(phongban, Formatting.Indented));
                        if (phongban != null)
                        {
                            MessageBox.Show("Xóa thành công! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            qlnv.PhongBans.Remove(phongban);
                            qlnv.SaveChanges();
                            bd.DataSource = qlnv.PhongBans.ToList();
                            dtgrPhongBan.DataSource = bd.DataSource;
                            dtgrPhongBan.Refresh();
                        }
                    }
                }

            }
        }
    }
}
