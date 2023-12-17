using Newtonsoft.Json;
using QLNSMay10.ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLNSMay10.FormAccount
{
    public partial class FormManagerAcount : Form
    {
        QLNVEntities qlnv = new QLNVEntities();
        BindingSource bd = new BindingSource();
        int checkId = 0;
        public FormManagerAcount()
        {
            InitializeComponent();
        }

        private void FormManagerAcount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet14.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.qLNVDataSet14.NguoiDung);
            // TODO: This line of code loads data into the 'qLNVDataSet1.User' table. You can move, or remove it, as needed.
            //this.userTableAdapter.Fill(this.qLNVDataSet1.User);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            //if (e.RowIndex >=0 && grvAcount.Columns[e.ColumnIndex].Name == "edit")
            //{
            //    if (e.RowIndex < grvAcount.Rows.Count && grvAcount.SelectedCells.Count > 0)
            //    {
                    
            //        txtUsername.Text = grvAcount.Rows[e.RowIndex].Cells[1].Value.ToString();
            //        txtPassword.Text = grvAcount.Rows[e.RowIndex].Cells[2].Value.ToString();
            //        checkid = Int32.Parse(grvAcount.Rows[e.RowIndex].Cells[0].Value.ToString());
            //    }      
            //}
            //if (e.RowIndex >= 0 && grvAcount.Columns[e.ColumnIndex].Name == "delete")
            //{
            //    if (e.RowIndex < grvAcount.Rows.Count && grvAcount.SelectedCells.Count > 0)
            //    {
            //        DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này chứ?", "Thông báo",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //        if (result == DialogResult.Yes)
            //        {
            //            checkid = Int32.Parse(grvAcount.Rows[e.RowIndex].Cells[0].Value.ToString());
            //            var user = db.Users.SingleOrDefault(item => item.UserId == checkid);
            //            if(user != null)
            //            {

            //            db.Users.Remove(user);
            //             db.SaveChanges();
            //            userBindingSource.DataSource = db.Users.ToList();
            //            userBindingSource.ResetBindings(false);
            //            }
            //        }   
            //    }

            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string username = txtUsername.Text;
            //string password = txtPassword.Text;
            //if(username == "" || password == "")
            //{
            //    MessageBox.Show("Chưa nhập đủ", "Lỗi",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    User newUser = new User();
            //    newUser.UserName = username;
            //    newUser.PWord = password;
            //    db.Users.Add(newUser);
            //    db.SaveChanges();
            //    MessageBox.Show("Thêm tài khoản mới thành công.", "Thông báo",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    userBindingSource.DataSource = db.Users.ToList();
            //    userBindingSource.ResetBindings(false);
            //}
        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
           // var user = db.Users.SingleOrDefault(item => item.UserId == checkid);
           //if(txtPassword.Text == "" || txtUsername.Text == "" )
           // {
           //     MessageBox.Show("Hãy nhập đầy đủ trường.", "Thông báo",
           //    MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
           // else
           // {
           //     user.UserName = txtUsername.Text;
           //     user.PWord = txtPassword.Text;
           //     db.SaveChanges();
           //     userBindingSource.DataSource = db.Users.ToList();
           //     userBindingSource.ResetBindings(false);
           //     MessageBox.Show("Chỉnh sửa thành công.", "Thông báo",
           //     MessageBoxButtons.OK, MessageBoxIcon.Information);
           // }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHoVaTen.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var taikhoan = qlnv.NguoiDungs.SingleOrDefault(item => item.MaNguoiDung == checkId);
            if (
                txtHoVaTen.Text == "" || txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                taikhoan.HoVaTen = txtHoVaTen.Text;
                taikhoan.Username = txtTenDangNhap.Text;
                taikhoan.Password = txtMatKhau.Text;
                qlnv.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.NguoiDungs.ToList();
                dtgrNguoiDung.DataSource = bd.DataSource;
                dtgrNguoiDung.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hovaten = txtHoVaTen.Text;
            string tendangnhap = txtTenDangNhap.Text ;
            string matkhau = txtMatKhau.Text;
            DateTime ngaytao = DateTime.Now;
            DateTime ngaycapnhat = DateTime.Now;
            if (hovaten == "" || tendangnhap == "" || matkhau== "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var listNguoiDung = qlnv.NguoiDungs.ToList();
                var result = listNguoiDung.Find(item => item.Username.Equals(tendangnhap));
                if (result != null)
                {
                    MessageBox.Show("Đã có tài khoản này rồi mời nhập lại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NguoiDung nguoidung = new NguoiDung();
                    nguoidung.HoVaTen = hovaten;
                    nguoidung.Username = tendangnhap;
                    nguoidung.Password = matkhau;
                    nguoidung.NgayTao = ngaytao;
                    nguoidung.NgayCapNhat = ngaycapnhat;
                    qlnv.NguoiDungs.Add(nguoidung);
                    qlnv.SaveChanges();
                    bd.DataSource = qlnv.NguoiDungs.ToList();
                    dtgrNguoiDung.DataSource = bd.DataSource; 
                    dtgrNguoiDung.Refresh();
                    MessageBox.Show("Thêm mới thành công! ", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.button2_Click(null, EventArgs.Empty);
                }
            }
        }

        private void dtgrNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkId = Int32.Parse(dtgrNguoiDung.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.RowIndex >= 0 && dtgrNguoiDung.Columns[e.ColumnIndex].Name == "chinhsua")
            {
                if (e.RowIndex < dtgrNguoiDung.Rows.Count && dtgrNguoiDung.SelectedCells.Count > 0)
                {
                    txtHoVaTen.Text = dtgrNguoiDung.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtTenDangNhap.Text = dtgrNguoiDung.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtMatKhau.Text = dtgrNguoiDung.Rows[e.RowIndex].Cells[3].Value.ToString();

                }
            }
            if (e.RowIndex >= 0 && dtgrNguoiDung.Columns[e.ColumnIndex].Name == "xoa")
            {
                if (e.RowIndex < dtgrNguoiDung.Rows.Count && dtgrNguoiDung.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng này này chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {


                        var nguoidung = qlnv.NguoiDungs.SingleOrDefault(item => item.MaNguoiDung == checkId);
                        Console.WriteLine("aaaa " + JsonConvert.SerializeObject(nguoidung, Formatting.Indented));
                        if (nguoidung != null)
                        {
                            MessageBox.Show("Xóa thành công! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            qlnv.NguoiDungs.Remove(nguoidung);
                            qlnv.SaveChanges();
                            bd.DataSource = qlnv.NguoiDungs.ToList();
                            dtgrNguoiDung.DataSource = bd.DataSource;
                            dtgrNguoiDung.Refresh();
                            this.button2_Click(null, EventArgs.Empty);
                        }
                    }
                }

            }
        }
    }
}
