namespace QLNSMay10.CongTac
{
    partial class FormCongTac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayNhamChuc = new System.Windows.Forms.DateTimePicker();
            this.grvCongTac = new System.Windows.Forms.DataGridView();
            this.thoiGianCongTacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVDataSet4 = new QLNSMay10.QLNVDataSet4();
            this.thoiGianCongTacTableAdapter = new QLNSMay10.QLNVDataSet4TableAdapters.ThoiGianCongTacTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNV_NhanVien_CongTac = new QLNSMay10.QLNV_NhanVien_CongTac();
            this.label3 = new System.Windows.Forms.Label();
            this.nhanVienTableAdapter = new QLNSMay10.QLNV_NhanVien_CongTacTableAdapters.NhanVienTableAdapter();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.qLNV_chucvu_congtac = new QLNSMay10.QLNV_chucvu_congtac();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucVuTableAdapter = new QLNSMay10.QLNV_chucvu_congtacTableAdapters.ChucVuTableAdapter();
            this.maCongTacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhanChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvCongTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianCongTacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_NhanVien_CongTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_chucvu_congtac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quản lý công tác";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Ngày nhậm chức";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(397, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 68;
            this.label4.Text = "Chức vụ";
            // 
            // dtNgayNhamChuc
            // 
            this.dtNgayNhamChuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhamChuc.Location = new System.Drawing.Point(488, 294);
            this.dtNgayNhamChuc.Name = "dtNgayNhamChuc";
            this.dtNgayNhamChuc.Size = new System.Drawing.Size(337, 30);
            this.dtNgayNhamChuc.TabIndex = 69;
            // 
            // grvCongTac
            // 
            this.grvCongTac.AllowUserToAddRows = false;
            this.grvCongTac.AllowUserToDeleteRows = false;
            this.grvCongTac.AutoGenerateColumns = false;
            this.grvCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCongTac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCongTacDataGridViewTextBoxColumn,
            this.maNhanVien,
            this.maChucVu,
            this.ngayNhanChuc,
            this.edit,
            this.delete});
            this.grvCongTac.DataSource = this.thoiGianCongTacBindingSource;
            this.grvCongTac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvCongTac.Location = new System.Drawing.Point(0, 425);
            this.grvCongTac.Name = "grvCongTac";
            this.grvCongTac.ReadOnly = true;
            this.grvCongTac.RowHeadersWidth = 51;
            this.grvCongTac.RowTemplate.Height = 24;
            this.grvCongTac.Size = new System.Drawing.Size(1022, 150);
            this.grvCongTac.TabIndex = 70;
            this.grvCongTac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrCongTac_CellContentClick);
            // 
            // thoiGianCongTacBindingSource
            // 
            this.thoiGianCongTacBindingSource.DataMember = "ThoiGianCongTac";
            this.thoiGianCongTacBindingSource.DataSource = this.qLNVDataSet4;
            // 
            // qLNVDataSet4
            // 
            this.qLNVDataSet4.DataSetName = "QLNVDataSet4";
            this.qLNVDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thoiGianCongTacTableAdapter
            // 
            this.thoiGianCongTacTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(181, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 43);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(441, 356);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(118, 43);
            this.btnSumbit.TabIndex = 72;
            this.btnSumbit.Text = "Sửa ";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(692, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 43);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLNV_NhanVien_CongTac;
            // 
            // qLNV_NhanVien_CongTac
            // 
            this.qLNV_NhanVien_CongTac.DataSetName = "QLNV_NhanVien_CongTac";
            this.qLNV_NhanVien_CongTac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nhân viên";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // cbChucVu
            // 
            this.cbChucVu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.thoiGianCongTacBindingSource, "MaChucVu", true));
            this.cbChucVu.DataSource = this.chucVuBindingSource;
            this.cbChucVu.DisplayMember = "TenChucVu";
            this.cbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(487, 230);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(337, 33);
            this.cbChucVu.TabIndex = 76;
            this.cbChucVu.ValueMember = "MaChucVu";
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.thoiGianCongTacBindingSource, "MaNhanVien", true));
            this.cbNhanVien.DataSource = this.nhanVienBindingSource;
            this.cbNhanVien.DisplayMember = "Hoten";
            this.cbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(488, 174);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(337, 33);
            this.cbNhanVien.TabIndex = 77;
            this.cbNhanVien.ValueMember = "MaNhanVien";
            // 
            // qLNV_chucvu_congtac
            // 
            this.qLNV_chucvu_congtac.DataSetName = "QLNV_chucvu_congtac";
            this.qLNV_chucvu_congtac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.qLNV_chucvu_congtac;
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // maCongTacDataGridViewTextBoxColumn
            // 
            this.maCongTacDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maCongTacDataGridViewTextBoxColumn.DataPropertyName = "MaCongTac";
            this.maCongTacDataGridViewTextBoxColumn.HeaderText = "Mã công tác";
            this.maCongTacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCongTacDataGridViewTextBoxColumn.Name = "maCongTacDataGridViewTextBoxColumn";
            this.maCongTacDataGridViewTextBoxColumn.ReadOnly = true;
            this.maCongTacDataGridViewTextBoxColumn.Visible = false;
            // 
            // maNhanVien
            // 
            this.maNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNhanVien.DataPropertyName = "MaNhanVien";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.MinimumWidth = 6;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Visible = false;
            // 
            // maChucVu
            // 
            this.maChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maChucVu.DataPropertyName = "MaChucVu";
            this.maChucVu.HeaderText = "Mã chức vụ";
            this.maChucVu.MinimumWidth = 6;
            this.maChucVu.Name = "maChucVu";
            this.maChucVu.ReadOnly = true;
            this.maChucVu.Visible = false;
            // 
            // ngayNhanChuc
            // 
            this.ngayNhanChuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayNhanChuc.DataPropertyName = "NgayNhanChuc";
            this.ngayNhanChuc.HeaderText = "Ngày nhận chức";
            this.ngayNhanChuc.MinimumWidth = 6;
            this.ngayNhanChuc.Name = "ngayNhanChuc";
            this.ngayNhanChuc.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Sửa";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // FormCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 575);
            this.Controls.Add(this.cbNhanVien);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grvCongTac);
            this.Controls.Add(this.dtNgayNhamChuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCongTac";
            this.Text = "FormCongTac";
            this.Load += new System.EventHandler(this.FormCongTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCongTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianCongTacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_NhanVien_CongTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_chucvu_congtac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayNhamChuc;
        private System.Windows.Forms.DataGridView grvCongTac;
        private QLNVDataSet4 qLNVDataSet4;
        private System.Windows.Forms.BindingSource thoiGianCongTacBindingSource;
        private QLNVDataSet4TableAdapters.ThoiGianCongTacTableAdapter thoiGianCongTacTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private QLNV_NhanVien_CongTac qLNV_NhanVien_CongTac;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLNV_NhanVien_CongTacTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private QLNV_chucvu_congtac qLNV_chucvu_congtac;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private QLNV_chucvu_congtacTableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCongTacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhanChuc;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}