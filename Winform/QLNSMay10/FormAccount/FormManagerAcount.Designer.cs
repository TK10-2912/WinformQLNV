namespace QLNSMay10.FormAccount
{
    partial class FormManagerAcount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgrNguoiDung = new System.Windows.Forms.DataGridView();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVDataSet14 = new QLNSMay10.QLNVDataSet14();
            this.nguoiDungTableAdapter = new QLNSMay10.QLNVDataSet14TableAdapters.NguoiDungTableAdapter();
            this.maNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoVaTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapNhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinhsua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet14)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quản lý tài khoản";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(379, 212);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(191, 30);
            this.txtTenDangNhap.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoVaTen.Location = new System.Drawing.Point(379, 157);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(191, 30);
            this.txtHoVaTen.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Họ và tên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(377, 269);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(191, 30);
            this.txtMatKhau.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(280, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Mật khẩu";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(72, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 64;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(360, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 63;
            this.button3.Text = "Sửa";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(673, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 62;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgrNguoiDung
            // 
            this.dtgrNguoiDung.AutoGenerateColumns = false;
            this.dtgrNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNguoiDungDataGridViewTextBoxColumn,
            this.hoVaTenDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn,
            this.ngayCapNhatDataGridViewTextBoxColumn,
            this.chinhsua,
            this.xoa});
            this.dtgrNguoiDung.DataSource = this.nguoiDungBindingSource;
            this.dtgrNguoiDung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrNguoiDung.Location = new System.Drawing.Point(0, 447);
            this.dtgrNguoiDung.Name = "dtgrNguoiDung";
            this.dtgrNguoiDung.RowHeadersWidth = 51;
            this.dtgrNguoiDung.RowTemplate.Height = 24;
            this.dtgrNguoiDung.Size = new System.Drawing.Size(954, 150);
            this.dtgrNguoiDung.TabIndex = 65;
            this.dtgrNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrNguoiDung_CellContentClick);
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.qLNVDataSet14;
            // 
            // qLNVDataSet14
            // 
            this.qLNVDataSet14.DataSetName = "QLNVDataSet14";
            this.qLNVDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // maNguoiDungDataGridViewTextBoxColumn
            // 
            this.maNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNguoiDung";
            this.maNguoiDungDataGridViewTextBoxColumn.HeaderText = "MaNguoiDung";
            this.maNguoiDungDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNguoiDungDataGridViewTextBoxColumn.Name = "maNguoiDungDataGridViewTextBoxColumn";
            this.maNguoiDungDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNguoiDungDataGridViewTextBoxColumn.Visible = false;
            this.maNguoiDungDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoVaTenDataGridViewTextBoxColumn
            // 
            this.hoVaTenDataGridViewTextBoxColumn.DataPropertyName = "HoVaTen";
            this.hoVaTenDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.hoVaTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoVaTenDataGridViewTextBoxColumn.Name = "hoVaTenDataGridViewTextBoxColumn";
            this.hoVaTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Visible = false;
            this.gioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Visible = false;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.ngayTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            this.ngayTaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayCapNhatDataGridViewTextBoxColumn
            // 
            this.ngayCapNhatDataGridViewTextBoxColumn.DataPropertyName = "NgayCapNhat";
            this.ngayCapNhatDataGridViewTextBoxColumn.HeaderText = "Ngày cập nhật";
            this.ngayCapNhatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCapNhatDataGridViewTextBoxColumn.Name = "ngayCapNhatDataGridViewTextBoxColumn";
            this.ngayCapNhatDataGridViewTextBoxColumn.Width = 125;
            // 
            // chinhsua
            // 
            this.chinhsua.HeaderText = "";
            this.chinhsua.MinimumWidth = 6;
            this.chinhsua.Name = "chinhsua";
            this.chinhsua.Text = "Chỉnh sửa";
            this.chinhsua.UseColumnTextForButtonValue = true;
            this.chinhsua.Width = 125;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 125;
            // 
            // FormManagerAcount
            // 
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(954, 597);
            this.Controls.Add(this.dtgrNguoiDung);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FormManagerAcount";
            this.Load += new System.EventHandler(this.FormManagerAcount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgrNguoiDung;
        private QLNVDataSet14 qLNVDataSet14;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private QLNVDataSet14TableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoVaTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapNhatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn chinhsua;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}
