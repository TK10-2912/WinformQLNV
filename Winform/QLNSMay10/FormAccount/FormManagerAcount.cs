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
        QLNVEntities db = new QLNVEntities();
        int checkid = 0;
        public FormManagerAcount()
        {
            InitializeComponent();
        }

        private void FormManagerAcount_Load(object sender, EventArgs e)
        {
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
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
    }
}
