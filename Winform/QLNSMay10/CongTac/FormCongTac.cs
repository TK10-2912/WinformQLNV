using QLNSMay10.ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSMay10.CongTac
{
    public partial class FormCongTac : Form
    {
        QLNVEntities qlnv = new QLNVEntities();
        BindingSource bd = new BindingSource();
        int checkId = 0;
        public FormCongTac()
        {
            InitializeComponent();
        }

        private async void FormCongTac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNV_chucvu_congtac.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.qLNV_chucvu_congtac.ChucVu);
            // TODO: This line of code loads data into the 'qLNV_NhanVien_CongTac.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNV_NhanVien_CongTac.NhanVien);
            this.thoiGianCongTacTableAdapter.Fill(this.qLNVDataSet4.ThoiGianCongTac);

            var nhanVienData = await qlnv.NhanViens.ToDictionaryAsync(item => item.MaNhanVien);
            if (!grvCongTac.Columns.Contains("tennv"))
            {
                DataGridViewTextBoxColumn tenNhanVienColumn = new DataGridViewTextBoxColumn();
                tenNhanVienColumn.Name = "tennv";
                tenNhanVienColumn.HeaderText = "Tên Nhân Viên";
                tenNhanVienColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grvCongTac.Columns.Insert(2, tenNhanVienColumn);
            }
            // 2. Thêm cột mới vào DataGridView'

            foreach (DataGridViewRow row in grvCongTac.Rows)
            {
                int maNhanVien = Convert.ToInt32(row.Cells["MaNhanVien"].Value);

                // Kiểm tra xem mã nhân viên có trong danh sách NhanVienData không
                if (nhanVienData.ContainsKey(maNhanVien))
                {
                    // Lấy thông tin tên nhân viên từ danh sách NhanVienData và gán vào cột mới
                    row.Cells["tennv"].Value = nhanVienData[maNhanVien].Hoten;
                    //
                }
                else
                {
                    // Xử lý khi không tìm thấy thông tin tên nhân viên
                }
            }

            var chucvuData = await qlnv.ChucVus.ToDictionaryAsync(item => item.MaChucVu);
            if (!grvCongTac.Columns.Contains("chucVu"))
            {
                DataGridViewTextBoxColumn chuVuColumn = new DataGridViewTextBoxColumn();
                chuVuColumn.Name = "chucVu";
                chuVuColumn.HeaderText = "Tên Nhân Viên";
                chuVuColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                grvCongTac.Columns.Insert(2, chuVuColumn);
            }
            // 2. Thêm cột mới vào DataGridView'

            foreach (DataGridViewRow row in grvCongTac.Rows)
            {
                int maChucVu = Convert.ToInt32(row.Cells["maChucVu"].Value);

                // Kiểm tra xem mã nhân viên có trong danh sách NhanVienData không
                if (chucvuData.ContainsKey(maChucVu))
                {
                    // Lấy thông tin tên nhân viên từ danh sách NhanVienData và gán vào cột mới
                    row.Cells["chucVu"].Value = chucvuData[maChucVu].TenChucVu;
                    //
                }
                else
                {
                    // Xử lý khi không tìm thấy thông tin tên nhân viên
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nhanvien = Int32.Parse(cbNhanVien.SelectedValue.ToString()); ;
            string nhamchuc = dtNgayNhamChuc.Value.ToString("yyyy-MM-dd"); // Chuyển đổi ngày tháng thành chuỗi định dạng yyyy-MM-dd         
            DateTime ngaynhamchuc = DateTime.Parse(nhamchuc);
            int machucvu = Int32.Parse(cbChucVu.SelectedValue.ToString());
       
            if (nhamchuc == "" || cbNhanVien.SelectedValue.ToString()== "" || cbChucVu.SelectedValue.ToString() =="") {
                MessageBox.Show("Không được để trống các trường! ", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ThoiGianCongTac ct = new ThoiGianCongTac();
                ct.MaNhanVien = nhanvien;
                ct.MaChucVu = machucvu;
                ct.NgayNhanChuc = ngaynhamchuc;
                qlnv.ThoiGianCongTacs.Add(ct);
                qlnv.SaveChanges();
                MessageBox.Show("Thêm mới thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCongTac_Load(null, EventArgs.Empty);
                this.btnDelete_Click(null, EventArgs.Empty);
            }
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            int manhanvien = Int32.Parse(cbNhanVien.SelectedValue.ToString());
            int machucvu = Int32.Parse(cbChucVu.SelectedValue.ToString()); ;
            string ngaynhamchuc = dtNgayNhamChuc.Value.ToString("yyyy-MM-dd"); // Chuyển đổi ngày tháng thành chuỗi định dạng yyyy-MM-dd
            DateTime nhamchucdate = DateTime.Parse(ngaynhamchuc);
            var congtac = qlnv.ThoiGianCongTacs.SingleOrDefault(item => item.MaCongTac == checkId);
            if (ngaynhamchuc == "" || cbNhanVien.SelectedValue.ToString() == "" || cbChucVu.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Không được để trống các trường! ", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
            else
            {
                congtac.MaChucVu = machucvu;
                congtac.MaNhanVien = manhanvien;
                congtac.NgayNhanChuc = nhamchucdate;
                qlnv.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.ThoiGianCongTacs.ToList();
                grvCongTac.DataSource = bd.DataSource;
                grvCongTac.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cbNhanVien.Text = "";
            cbChucVu.Text = "";
            dtNgayNhamChuc.Text = "";
        }

        private void dtgrCongTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkId = Int32.Parse(grvCongTac.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (e.RowIndex >= 0 && grvCongTac.Columns[e.ColumnIndex].Name == "edit")
            {
                if (e.RowIndex < grvCongTac.Rows.Count && grvCongTac.SelectedCells.Count > 0)
                {
                    cbNhanVien.Text = grvCongTac.Rows[e.RowIndex].Cells["maNhanVien"].Value.ToString();
                    cbChucVu.Text = grvCongTac.Rows[e.RowIndex].Cells["maChucVu"].Value.ToString();
                    dtNgayNhamChuc.Text = grvCongTac.Rows[e.RowIndex].Cells["ngayNhanChuc"].Value.ToString();
                }
            }
            if (e.RowIndex >= 0 && grvCongTac.Columns[e.ColumnIndex].Name == "delete")
            {
                if (e.RowIndex < grvCongTac.Rows.Count && grvCongTac.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng này này chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        checkId = Int32.Parse(grvCongTac.Rows[e.RowIndex].Cells[0].Value.ToString());
                        var xoaCongtac = qlnv.ThoiGianCongTacs.SingleOrDefault(item => item.MaCongTac == checkId);
                        if (xoaCongtac != null)
                        {
                            MessageBox.Show("Xóa thành công! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            qlnv.ThoiGianCongTacs.Remove(xoaCongtac);
                            qlnv.SaveChanges();
                            bd.DataSource = qlnv.ThoiGianCongTacs.ToList();
                            grvCongTac.DataSource = bd.DataSource;
                            grvCongTac.Refresh();
                        }
                    }
                }

            }
        }

    }
}
