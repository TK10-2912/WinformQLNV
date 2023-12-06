using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace QLNSMay10
{
    public partial class FormPhucap : Form
    {
        public FormPhucap()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối
        string strConnectionString = @"Data Source=@DESKTOP - RNFS31E\SQLEXPRESS;Initial Catalog = QLNSCTMay10; Integrated Security = True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTABLENAME
        SqlDataAdapter daPhucap = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtPhucap = null;

        private void fPhucap_Load(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection(strConnectionString);
                daPhucap = new SqlDataAdapter("SELECT * FROMPhucap", conn);
                dtPhucap = new DataTable();
                dtPhucap.Clear();
                daPhucap.Fill(dtPhucap);
                // Đưa dữ liệu lên DataGridView
                dataGridView1.DataSource = dtPhucap;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Phucap.Lỗi rồi!!!");
              }

        }

        private void fPhucap_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtPhucap.Dispose();
            dtPhucap = null;
            // Hủy kết nối
            conn = null;
        }

       

    }
}
