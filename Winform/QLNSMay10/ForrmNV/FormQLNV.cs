using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office;
using Newtonsoft.Json;
using QLNSMay10.ConnectSql;

namespace QLNSMay10.ForrmNV
{
    public partial class FormQLNV : Form
    {
        QLNVEntities qlnv = new QLNVEntities();
        BindingSource bd = new BindingSource();
        int checkId = 0;
        public FormQLNV()
        {
            InitializeComponent();
        }

    
        private void FormQLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet111.HeSoLuong' table. You can move, or remove it, as needed.
            this.heSoLuongTableAdapter.Fill(this.qLNVDataSet111.HeSoLuong);
            // TODO: This line of code loads data into the 'qLNVDataSet10.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.qLNVDataSet10.ChucVu);
            // TODO: This line of code loads data into the 'qLNVDataSet9.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.qLNVDataSet9.PhongBan);
            // TODO: This line of code loads data into the 'qLNVDataSet8.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter1.Fill(this.qLNVDataSet8.NhanVien);
            // TODO: This line of code loads data into the 'qLNVDataSet11.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.qLNVDataSet11.NhanVien);
            // TODO: This line of code loads data into the 'qLNVDataSet1.ChucVu' table. You can move, or remove it, as needed.



        }
        private void PrintDataGridView(object sender, PrintPageEventArgs e)
        {
            DataGridViewPrint(e, dtgrNhanvien);
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
            e.Graphics.DrawString("Tiêu đề cột 1", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(100, 100));

            // Vẽ dữ liệu từ DataGridView
            for (int i = 0; i < totalPrintedRows; i++)
            {
                DataGridViewRow row = dgv.Rows[rowIndex];
                rowIndex++;

                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    e.Graphics.DrawString(row.Cells[j].Value.ToString(), new Font("Arial", 8), Brushes.Black, new Point(100 + j * 100, 120 + i * cellHeight));
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
            for (int i = 1; i < dtgrNhanvien.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgrNhanvien.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgrNhanvien.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgrNhanvien.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtgrNhanvien.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            try { 
            workbook.SaveAs(".\\Danhsachnhanvien_"+DateTime.Now.ToString("yyyyMMddHHmmssffff")+".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            } catch {
                MessageBox.Show("File đã tồn tại trong thư mục");
            }
            // Exit from the application  
            app.Quit();
        }

        private void print_Click(object sender, EventArgs e)
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

        private void btnthem_Click(object sender, EventArgs e)
        {

           
            if (txthoten.Text.Trim() == "" || cbgt.Text.Trim() == ""|| dtngaysinh.Value.ToString().Trim() == ""|| txtque.Text.Trim() == ""||
                txtsdt.Text.Trim() == ""|| cbphongban.Text.Trim() == ""|| cbchucvu.Text.Trim() == ""|| cbhsl.Text.Trim() == "")
            {

                MessageBox.Show("Mời bạn hãy nhập đủ trường", "Thông báo",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hoten = txthoten.Text;
                string gioitinh = cbgt.Text;
                string birthday = dtngaysinh.Value.ToString("yyyy-MM-dd"); // Chuyển đổi ngày tháng thành chuỗi định dạng yyyy-MM-dd         
                DateTime birthdaynv = DateTime.Parse(birthday);
                string quequan = txtque.Text;
                string sdt = txtsdt.Text;
                int maphongban = (int)cbphongban.SelectedValue;
                int machucvu = (int)cbchucvu.SelectedValue;
                int mahsl = (int)cbhsl.SelectedValue;
                NhanVien nv = new NhanVien();
                nv.Hoten = hoten;
                nv.GioiTinh = gioitinh;
                nv.NgaySinh = birthdaynv;
                nv.SoDienThoai = sdt;
                nv.MaPhongBan = maphongban;
                nv.MaChucVu = machucvu;
                nv.MaHSL = mahsl;
                nv.QueQuan = quequan;
                qlnv.NhanViens.Add(nv);
                qlnv.SaveChanges();
                MessageBox.Show("Thêm mới thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.NhanViens.ToList();
                dtgrNhanvien.DataSource = bd.DataSource;
                dtgrNhanvien.Refresh();
                this.btnxoa_Click(null, EventArgs.Empty);
            }
        }

        private void dtgrNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgrNhanvien.Columns[e.ColumnIndex].Name == "edit")
            {
                if (e.RowIndex < dtgrNhanvien.Rows.Count && dtgrNhanvien.SelectedCells.Count > 0)
                {
                    checkId = Int32.Parse(dtgrNhanvien.Rows[e.RowIndex].Cells[0].Value.ToString());
                    checkId = Int32.Parse(dtgrNhanvien.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txthoten.Text = dtgrNhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cbgt.Text = dtgrNhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dtngaysinh.Text = dtgrNhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtque.Text = dtgrNhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtsdt.Text = dtgrNhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                    cbphongban.SelectedValue = dtgrNhanvien.Rows[e.RowIndex].Cells[6].Value;
                    cbchucvu.SelectedValue = dtgrNhanvien.Rows[e.RowIndex].Cells[7].Value;
                    cbhsl.SelectedValue = dtgrNhanvien.Rows[e.RowIndex].Cells[8].Value;

                }
            }
            if (e.RowIndex >= 0 && dtgrNhanvien.Columns[e.ColumnIndex].Name == "delete")
            {
                if (e.RowIndex < dtgrNhanvien.Rows.Count && dtgrNhanvien.SelectedCells.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa hàng này này chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        checkId = Int32.Parse(dtgrNhanvien.Rows[e.RowIndex].Cells[0].Value.ToString());
                        var deleteNV = qlnv.NhanViens.SingleOrDefault(item => item.MaNhanVien == checkId);
                        if (deleteNV != null)
                        {
                            MessageBox.Show("Xóa thành công! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            qlnv.NhanViens.Remove(deleteNV);
                            qlnv.SaveChanges();
                            bd.DataSource = qlnv.NhanViens.ToList();
                            dtgrNhanvien.DataSource = bd.DataSource;
                            dtgrNhanvien.Refresh();
                        }
                    }
                }

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            string gioitinh = cbgt.Text;
            string birthday = dtngaysinh.Value.ToString("yyyy-MM-dd"); // Chuyển đổi ngày tháng thành chuỗi định dạng yyyy-MM-dd         
            DateTime birthdaynv = DateTime.Parse(birthday);
            string quequan = txtque.Text;
            string sdt = txtsdt.Text;
            int maphongban = Int32.Parse(cbphongban.SelectedValue.ToString());
            int machucvu = Int32.Parse(cbchucvu.SelectedValue.ToString()); ;
            int mahsl = Int32.Parse(cbhsl.SelectedValue.ToString());
            var hsl = qlnv.NhanViens.SingleOrDefault(item => item.MaNhanVien == checkId);
            if (txthoten.Text == "")
            {
                MessageBox.Show("Không để trống trường nào!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hsl.Hoten = hoten;
                hsl.GioiTinh = gioitinh;
                hsl.NgaySinh = birthdaynv;
                hsl.SoDienThoai = sdt;
                hsl.MaPhongBan = maphongban;
                hsl.MaChucVu = machucvu;
                hsl.MaHSL = mahsl;
                hsl.QueQuan = quequan;
                qlnv.SaveChanges();
                MessageBox.Show("Chỉnh sửa thành công! ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                bd.DataSource = qlnv.NhanViens.ToList();
                dtgrNhanvien.DataSource = bd.DataSource;
                dtgrNhanvien.Refresh();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txthoten.Text = "";
            cbgt.Text = "";
            txtsdt.Text = "";
            txtque.Text = "";
            dtngaysinh.Text = "";
            cbphongban.Text = "";
            cbchucvu.Text = "";
            cbhsl.Text = "";
        }
    }
}
