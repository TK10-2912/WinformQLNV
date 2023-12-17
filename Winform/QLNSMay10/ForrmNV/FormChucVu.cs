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
    public partial class FormChucVu : Form
    {
        QLNVEntities qlnv = new QLNVEntities();
        BindingSource bd = new BindingSource();
        int checkId = 0;
        public FormChucVu()
        {
            InitializeComponent();
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVChucVu.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.qLNVChucVu.ChucVu);
        }

        private void addChucVu_Click(object sender, EventArgs e)
        {
            string tenchucvu = txtTenChucVu.Text.Trim();
            if (tenchucvu == "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var listChucvu = qlnv.ChucVus.ToList();
                var result = listChucvu.Find(item => item.TenChucVu.Equals(tenchucvu));
                if (result != null)
                {
                    MessageBox.Show("Đã có chức vụ này rồi mời nhập lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ChucVu chucvu = new ChucVu();
                    chucvu.TenChucVu = tenchucvu;
                    qlnv.ChucVus.Add(chucvu);
                    qlnv.SaveChanges();
                    bd.DataSource = qlnv.ChucVus.ToList();
                    grvChucVu.DataSource = bd.DataSource;
                    grvChucVu.Refresh();
                    MessageBox.Show("Thêm mới thành công! ", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenChucVu.Text = "";
                }


            }
        }

        private void deleteChucVu_Click(object sender, EventArgs e)
        {
            txtTenChucVu.Text = "";
        }

        private void grvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkId = Int32.Parse(grvChucVu.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.RowIndex >= 0 && grvChucVu.Columns[e.ColumnIndex].Name == "edit")
            {
                if (e.RowIndex < grvChucVu.Rows.Count && grvChucVu.SelectedCells.Count > 0)
                {

                    txtTenChucVu.Text = grvChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
              
                }
            }
            if (e.RowIndex >= 0 && grvChucVu.Columns[e.ColumnIndex].Name == "delete")
            {
                if (e.RowIndex < grvChucVu.Rows.Count && grvChucVu.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng này này chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                       

                        var chucvu= qlnv.ChucVus.SingleOrDefault(item => item.MaChucVu == checkId);
                        Console.WriteLine("aaaa " + JsonConvert.SerializeObject(chucvu, Formatting.Indented));
                        if (chucvu != null)
                        {
                            MessageBox.Show("Xóa thành công! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            qlnv.ChucVus.Remove(chucvu);
                            qlnv.SaveChanges();
                            bd.DataSource = qlnv.ChucVus.ToList();
                            grvChucVu.DataSource = bd.DataSource;
                            grvChucVu.Refresh();
                        }
                    }
                }

            }
        }

        private void editChucVu_Click(object sender, EventArgs e)
        {
            var chucvu = qlnv.ChucVus.SingleOrDefault(item => item.MaChucVu == checkId);
            if (txtTenChucVu.Text == "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chucvu.TenChucVu = txtTenChucVu.Text;
                qlnv.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.ChucVus.ToList();
                grvChucVu.DataSource = bd.DataSource;
                grvChucVu.Refresh();
            }
        }
    }
}
