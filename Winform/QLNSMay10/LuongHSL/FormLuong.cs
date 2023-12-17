using Microsoft.Office.Interop.Excel;
using QLNSMay10.ConnectSql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;

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

        private async void FormLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet6.HeSoLuong' table. You can move, or remove it, as needed.
            this.heSoLuongTableAdapter1.Fill(this.qLNVDataSet6.HeSoLuong);
            // TODO: This line of code loads data into the 'qLNVDataSet5.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLNVDataSet5.NhanVien);
            // TODO: This line of code loads data into the 'qLNV_Luong.Luong' table. You can move, or remove it, as needed.
            this.luongTableAdapter.Fill(this.qLNV_Luong.Luong);
            // TODO: This line of code loads data into the 'qLNVDataSet18.Luong' table. You can move, or remove it, as needed.
 


            this.heSoLuongTableAdapter.Fill(this.qLNVDataSet12.HeSoLuong);
       
            List<int> thang = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12 };
            List<int> ngaylamthem = new List<int> {1,2,3,4};
            List<int> songaycong = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27};
            List<int> nam = new List<int>();
            for(int i = 2015; i<= DateTime.Now.Year; i++)
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
            }  foreach(int i in ngaylamthem)
            {
                cbNgayLamThem.Items.Add(i);
            }
            var nhanVienData = await qlnv.NhanViens.ToDictionaryAsync(nv => nv.MaNhanVien);
            if (!grvLuong.Columns.Contains("tennv"))
            {
                DataGridViewTextBoxColumn tenNhanVienColumn = new DataGridViewTextBoxColumn();
                tenNhanVienColumn.Name = "tennv";
                tenNhanVienColumn.HeaderText = "Tên Nhân Viên";
                grvLuong.Columns.Insert(2, tenNhanVienColumn);
            }
            // 2. Thêm cột mới vào DataGridView'
                 
            foreach (DataGridViewRow row in grvLuong.Rows)
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

           
        }
        private void PrintDataGridView(object sender, PrintPageEventArgs e)
        {
            DataGridViewPrint(e, grvLuong);
        }
        private void DataGridViewPrint(PrintPageEventArgs e, DataGridView dgv)
        {
            // Thiết lập các tham số in ấn
            int rowPerPage = 20;
            int rowIndex = 0;
            int totalRows = dgv.Rows.Count;
            int cellHeight = dgv.Rows[0].Height;
            int headerHeight = dgv.ColumnHeadersHeight;


            // Xác định vùng in ấn
            Rectangle printArea = new Rectangle(e.PageBounds.Left, e.PageBounds.Top, e.PageBounds.Width, e.PageBounds.Height);

            // Xác định số dòng cần in ấn
            int totalPrintedRows = (totalRows - rowIndex) >= rowPerPage ? rowPerPage : (totalRows - rowIndex);

            // Vẽ tiêu đề cột
            e.Graphics.DrawString("Tiêu đề cột 1", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(100, 100));

            // Vẽ dữ liệu từ DataGridView
            for (int i = 0; i < totalPrintedRows; i++)
            {
                DataGridViewRow row = dgv.Rows[rowIndex];
                rowIndex++;

                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    e.Graphics.DrawString(row.Cells[j].Value.ToString(), new System.Drawing.Font("Arial", 8), Brushes.Black, new System.Drawing.Point(100 + j * 100, 120 + i * cellHeight));
                }
            }

            // Kiểm tra xem còn dòng nào không
            if (rowIndex < totalRows)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
                rowIndex = 0;
            }
        }

        private void exportData_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < grvLuong.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grvLuong.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < grvLuong.Rows.Count - 1; i++)
            {
                for (int j = 0; j < grvLuong.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = grvLuong.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            try
            {
                workbook.SaveAs(".\\Danhsachnhanvien_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch
            {
                MessageBox.Show("File đã tồn tại trong thư mục");
            }
            // Exit from the application  
            app.Quit();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            cbMaTinhLuong.Text = "";
            cbThang.SelectedIndex = -1;
            cbSoNgayCong.SelectedIndex = -1;
            cbNam.SelectedIndex = -1;
            cbNgayLamThem.SelectedIndex = -1;
            txtPhat.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var luong = qlnv.Luongs.SingleOrDefault(item => item.MaLuong == checkId);
            if (
                   txtPhat.Text == "" || cbThang.Text == "" || cbSoNgayCong.Text == "" || cbNam.Text == "" ||cbNgayLamThem.Text == "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                luong.Thang = Int32.Parse(cbThang.Text);
                luong.Nam = Int32.Parse(cbNam.Text);
                luong.SoNgayCong = Int32.Parse(cbSoNgayCong.Text);
                luong.SoNgayLamThem = Int32.Parse(cbNgayLamThem.Text);
                luong.Phat = float.Parse(txtPhat.Text);
                qlnv.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FormLuong_Load(null, EventArgs.Empty);
                this.button2_Click(null, EventArgs.Empty);

            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int manhanvien = -1;
            int nam = -1;
            int thang = -1;
            int ngaylamthem = -1;
            int ngaycong = -1;
            float phat = 0;



            if (cbMaTinhLuong.Text == "" || cbThang.Text == "" || cbNam.Text == "" || cbNgayLamThem.Text == "" || cbSoNgayCong.Text == "" || txtPhat.Text == "")
            {

                MessageBox.Show("Mời bạn hãy nhập đủ trường", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                manhanvien = (int)cbMaTinhLuong.SelectedValue;
                nam = int.Parse(cbNam.Text);
                thang = int.Parse(cbThang.Text);
                ngaylamthem = int.Parse(cbNgayLamThem.Text);
                ngaycong = int.Parse(cbSoNgayCong.Text);
                phat = float.Parse(txtPhat.Text);

                var list = qlnv.Luongs.ToList();
                var luongDatontai = list.Find(item => item.MaNhanVien == manhanvien && item.Nam == nam && item.Thang == thang);
                if (luongDatontai != null)
                {
                    MessageBox.Show("Nhân viên đã có nhận lương vào tháng " + thang + " và năm " + nam, "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Luong luong = new Luong();
                    luong.MaNhanVien = manhanvien;
                    luong.Thang = thang;
                    luong.Nam = nam;
                    luong.SoNgayCong = ngaycong;
                    luong.SoNgayLamThem = ngaylamthem;
                    luong.Phat = phat;
                    qlnv.Luongs.Add(luong);
                    await qlnv.SaveChangesAsync();
                    MessageBox.Show("Thêm mới thành công! ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.FormLuong_Load(null, EventArgs.Empty);
                    this.button2_Click(null, EventArgs.Empty);
                }
            }
        }
            


        private void grvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkId = Int32.Parse(grvLuong.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (e.RowIndex >= 0 && grvLuong.Columns[e.ColumnIndex].Name == "edit")
            {
                if (e.RowIndex < grvLuong.Rows.Count && grvLuong.SelectedCells.Count > 0)
                {

                    cbNam.Text = grvLuong.Rows[e.RowIndex].Cells["Nam"].Value.ToString();
                    cbThang.Text = grvLuong.Rows[e.RowIndex].Cells["Thang"].Value.ToString();
                    cbSoNgayCong.Text = grvLuong.Rows[e.RowIndex].Cells["soNgayCong"].Value.ToString();
                    cbNgayLamThem.Text = grvLuong.Rows[e.RowIndex].Cells["soNgayLamThem"].Value.ToString();
                    txtPhat.Text = grvLuong.Rows[e.RowIndex].Cells["TienPhat"].Value.ToString();
                    

                }
            }
            if (e.RowIndex >= 0 && grvLuong.Columns[e.ColumnIndex].Name == "delete")
            {
                if (e.RowIndex < grvLuong.Rows.Count && grvLuong.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng này chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {


                        var luong = qlnv.Luongs.SingleOrDefault(item => item.MaLuong == checkId);
                        if (luong != null)
                        {
                            MessageBox.Show("Xóa thành công! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            qlnv.Luongs.Remove(luong);
                            qlnv.SaveChanges();
                            this.FormLuong_Load(null, EventArgs.Empty);
                        }
                    }
                }

            }
        }

    

        private void grvLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grvLuong.Columns[e.ColumnIndex].Name == "LuongThucLinh")
            {
                // Lấy giá trị thực tế từ dữ liệu
                object cellValue = grvLuong.Rows[e.RowIndex].Cells["LuongThucLinh"].Value; // Thay "ColumnName" bằng tên thực của cột lương

                // Kiểm tra giá trị có tồn tại và không phải là DBNull
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    // Đặt giá trị hiển thị cho cột lương dựa trên giá trị thực tế
                    e.Value = string.Format("{0:N0} vnđ", Convert.ToDecimal(cellValue));
                    e.FormattingApplied = true;
                }
            }
             else if (grvLuong.Columns[e.ColumnIndex].Name == "TienPhat")
            {
                // Lấy giá trị thực tế từ dữ liệu
                object cellValue = grvLuong.Rows[e.RowIndex].Cells["TienPhat"].Value; // Thay "ColumnName" bằng tên thực của cột lương

                // Kiểm tra giá trị có tồn tại và không phải là DBNull
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    // Đặt giá trị hiển thị cho cột lương dựa trên giá trị thực tế
                    e.Value = string.Format("{0:N0} vnđ", Convert.ToDecimal(cellValue));
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 3; i < grvLuong.Columns.Count -1; i++)
            {
                worksheet.Cells[1, i] = grvLuong.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < grvLuong.Rows.Count ; i++)
            {
                for (int j = 2; j < grvLuong.Columns.Count -2; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = grvLuong.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            try
            {
                workbook.SaveAs(".\\BangLuong_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch
            {
                MessageBox.Show("File đã tồn tại trong thư mục");
            }
            // Exit from the application  
            app.Quit();
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintDataGridView);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
    }
}
