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

namespace QLNSMay10.ForrmNV
{
    public partial class FormQLNV : Form
    {
        public FormQLNV()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FormQLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNVDataSet8.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter1.Fill(this.qLNVDataSet8.NhanVien);
            // TODO: This line of code loads data into the 'qLNVDataSet11.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.qLNVDataSet11.NhanVien);
            // TODO: This line of code loads data into the 'qLNVDataSet1.ChucVu' table. You can move, or remove it, as needed.



        }
        private void PrintDataGridView(object sender, PrintPageEventArgs e)
        {
            DataGridViewPrint(e, dataGridView1);
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
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            try { 
            workbook.SaveAs("C:\\Users\\DELL\\Downloads\\Danhsachnhanvien_"+DateTime.Now.ToString("yyyyMMddHHmmssffff")+".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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
    }
}
