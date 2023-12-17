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

namespace QLNSMay10.LuongHSL
{
    public partial class FormHSL : Form
    {

        QLNVEntities qlnv = new QLNVEntities();
        BindingSource bd = new BindingSource();
        int checkId = 0;
        public FormHSL()
        {
            InitializeComponent();
        }

        
        private void FormHSL_Load(object sender, EventArgs e)
        {
            this.heSoLuongTableAdapter.Fill(this.qLNVHeSoLuong.HeSoLuong);
            List<float> listLuong = new List<float> { 5000000, 10000000, 12000000, 15000000, 18000000, 20000000, 25000000, 30000000 };
            foreach (float so in listLuong)
            {
                cbLuong.Items.Add(so.ToString("N0"));
            }
            List<float> listPhuCap = new List<float> { 100000, 200000, 300000, 400000, 500000 };
            foreach (float so in listPhuCap)
            {
                cbPhuCap.Items.Add(so.ToString("N0"));
            }
            grvHSL.CellFormatting += new DataGridViewCellFormattingEventHandler(grvHSL_CellFormatting);

            // Tải dữ liệu vào DataGridView (nếu có)
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            // Thực hiện tải dữ liệu thực tế vào DataGridView ở đây
            bd.DataSource = qlnv.HeSoLuongs.ToList();
            grvHSL.DataSource = bd.DataSource;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtHeSoLuong.Text = "";
            cbLuong.Text = "";
            cbPhuCap.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var hsl = qlnv.HeSoLuongs.SingleOrDefault(item => item.MaHSL == checkId);
            if (txtHeSoLuong.Text == "" || cbLuong.Text == "" || cbPhuCap.Text == "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hsl.TenHSL = txtHeSoLuong.Text;
                hsl.LuongThang = float.Parse(cbLuong.Text);
                hsl.LuongPhuCap = float.Parse(cbPhuCap.Text);
                qlnv.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.HeSoLuongs.ToList();
                grvHSL.DataSource = bd.DataSource;
                grvHSL.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenHsl = txtHeSoLuong.Text;
            float luong = float.Parse(cbLuong.Text);
            float phucap = float.Parse(cbPhuCap.Text);
            var list = qlnv.HeSoLuongs.ToList();
            if (txtHeSoLuong.Text == "" || cbPhuCap.Text == "" || cbPhuCap.Text == "")
            {

                MessageBox.Show("Mời bạn hãy nhập đủ trường", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HeSoLuong hsl = new HeSoLuong();
                hsl.TenHSL = tenHsl;
                hsl.LuongThang = luong;
                hsl.LuongPhuCap = phucap;
                qlnv.HeSoLuongs.Add(hsl);
                qlnv.SaveChanges();
                MessageBox.Show("Thêm mới thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.HeSoLuongs.ToList();
                grvHSL.DataSource = bd.DataSource;
                grvHSL.Refresh();
                this.button2_Click(null, EventArgs.Empty);
            }
        }

        private void grvHSL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grvHSL.Columns[e.ColumnIndex].Name == "edit")
            {
                if (e.RowIndex < grvHSL.Rows.Count && grvHSL.SelectedCells.Count > 0)
                {

                    txtHeSoLuong.Text = grvHSL.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cbLuong.Text = grvHSL.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbPhuCap.Text = grvHSL.Rows[e.RowIndex].Cells[3].Value.ToString();
                    checkId = Int32.Parse(grvHSL.Rows[e.RowIndex].Cells[0].Value.ToString());

                }
            }
            if (e.RowIndex >= 0 && grvHSL.Columns[e.ColumnIndex].Name == "delete")
            {
                if (e.RowIndex < grvHSL.Rows.Count && grvHSL.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng này này chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        checkId = Int32.Parse(grvHSL.Rows[e.RowIndex].Cells[0].Value.ToString());

                        var hesl = qlnv.HeSoLuongs.SingleOrDefault(item => item.MaHSL == checkId);
                        Console.WriteLine("aaaa " + JsonConvert.SerializeObject(hesl, Formatting.Indented));
                        if (hesl != null)
                        {
                            MessageBox.Show("Xóa thành công! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            qlnv.HeSoLuongs.Remove(hesl);
                            qlnv.SaveChanges();
                            bd.DataSource = qlnv.HeSoLuongs.ToList();
                            grvHSL.DataSource = bd.DataSource;
                            grvHSL.Refresh();
                        }
                    }
                }

            }
        }

        private void grvHSL_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grvHSL.Columns[e.ColumnIndex].Name == "LuongThang")
            {
                // Lấy giá trị thực tế từ dữ liệu
                object cellValue = grvHSL.Rows[e.RowIndex].Cells["LuongThang"].Value; // Thay "ColumnName" bằng tên thực của cột lương

                // Kiểm tra giá trị có tồn tại và không phải là DBNull
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    // Đặt giá trị hiển thị cho cột lương dựa trên giá trị thực tế
                    e.Value = string.Format("{0:N0} vnđ", Convert.ToDecimal(cellValue));
                    e.FormattingApplied = true;
                }
            }
            else if (grvHSL.Columns[e.ColumnIndex].Name == "LuongPhuCap")
            {
                // Lấy giá trị thực tế từ dữ liệu
                object cellValue = grvHSL.Rows[e.RowIndex].Cells["LuongPhuCap"].Value; // Thay "ColumnName" bằng tên thực của cột lương

                // Kiểm tra giá trị có tồn tại và không phải là DBNull
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    // Đặt giá trị hiển thị cho cột lương dựa trên giá trị thực tế
                    e.Value = string.Format("{0:N0} vnđ", Convert.ToDecimal(cellValue));
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
