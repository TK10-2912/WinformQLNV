namespace QLNSMay10.LuongHSL
{
    partial class FormLuong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaTinhLuong = new System.Windows.Forms.ComboBox();
            this.luongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNV_Luong = new QLNSMay10.QLNV_Luong();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVDataSet5 = new QLNSMay10.QLNVDataSet5();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.heSoLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVDataSet12 = new QLNSMay10.QLNVDataSet12();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grvLuong = new System.Windows.Forms.DataGridView();
            this.maLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songaycong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayLamThem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongThucLinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbSoNgayCong = new System.Windows.Forms.ComboBox();
            this.heSoLuongTableAdapter = new QLNSMay10.QLNVDataSet12TableAdapters.HeSoLuongTableAdapter();
            this.txtPhat = new System.Windows.Forms.TextBox();
            this.phat = new System.Windows.Forms.Label();
            this.cbNgayLamThem = new System.Windows.Forms.ComboBox();
            this.luongTableAdapter = new QLNSMay10.QLNV_LuongTableAdapters.LuongTableAdapter();
            this.nhanVienTableAdapter = new QLNSMay10.QLNVDataSet5TableAdapters.NhanVienTableAdapter();
            this.qLNVDataSet6 = new QLNSMay10.QLNVDataSet6();
            this.heSoLuongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.heSoLuongTableAdapter1 = new QLNSMay10.QLNVDataSet6TableAdapters.HeSoLuongTableAdapter();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_Luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 44;
            this.label2.Text = "Bảng lương";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã nhân viên";
            // 
            // cbMaTinhLuong
            // 
            this.cbMaTinhLuong.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.luongBindingSource, "MaNhanVien", true));
            this.cbMaTinhLuong.DataSource = this.nhanVienBindingSource;
            this.cbMaTinhLuong.DisplayMember = "MaTinhLuong";
            this.cbMaTinhLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTinhLuong.FormattingEnabled = true;
            this.cbMaTinhLuong.Location = new System.Drawing.Point(216, 176);
            this.cbMaTinhLuong.Name = "cbMaTinhLuong";
            this.cbMaTinhLuong.Size = new System.Drawing.Size(240, 33);
            this.cbMaTinhLuong.TabIndex = 55;
            this.cbMaTinhLuong.ValueMember = "MaNhanVien";
            // 
            // luongBindingSource
            // 
            this.luongBindingSource.DataMember = "Luong";
            this.luongBindingSource.DataSource = this.qLNV_Luong;
            // 
            // qLNV_Luong
            // 
            this.qLNV_Luong.DataSetName = "QLNV_Luong";
            this.qLNV_Luong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLNVDataSet5;
            // 
            // qLNVDataSet5
            // 
            this.qLNVDataSet5.DataSetName = "QLNVDataSet5";
            this.qLNVDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbNam
            // 
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(622, 171);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(139, 33);
            this.cbNam.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(865, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tháng";
            // 
            // heSoLuongBindingSource
            // 
            this.heSoLuongBindingSource.DataMember = "HeSoLuong";
            this.heSoLuongBindingSource.DataSource = this.qLNVDataSet12;
            // 
            // qLNVDataSet12
            // 
            this.qLNVDataSet12.DataSetName = "QLNVDataSet12";
            this.qLNVDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Số ngày công";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ngày làm thêm";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(216, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 68;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(599, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 67;
            this.button3.Text = "Sửa";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(970, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 66;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grvLuong
            // 
            this.grvLuong.AllowUserToAddRows = false;
            this.grvLuong.AllowUserToDeleteRows = false;
            this.grvLuong.AutoGenerateColumns = false;
            this.grvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLuongDataGridViewTextBoxColumn,
            this.MaNhanVien,
            this.Thang,
            this.Nam,
            this.songaycong,
            this.soNgayLamThem,
            this.TienPhat,
            this.LuongThucLinh,
            this.edit,
            this.delete});
            this.grvLuong.DataSource = this.luongBindingSource;
            this.grvLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvLuong.Location = new System.Drawing.Point(0, 424);
            this.grvLuong.Name = "grvLuong";
            this.grvLuong.ReadOnly = true;
            this.grvLuong.RowHeadersWidth = 51;
            this.grvLuong.RowTemplate.Height = 24;
            this.grvLuong.Size = new System.Drawing.Size(1162, 190);
            this.grvLuong.TabIndex = 69;
            this.grvLuong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvLuong_CellContentClick);
            this.grvLuong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grvLuong_CellFormatting);
            // 
            // maLuongDataGridViewTextBoxColumn
            // 
            this.maLuongDataGridViewTextBoxColumn.DataPropertyName = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.HeaderText = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLuongDataGridViewTextBoxColumn.Name = "maLuongDataGridViewTextBoxColumn";
            this.maLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLuongDataGridViewTextBoxColumn.Visible = false;
            this.maLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Visible = false;
            this.MaNhanVien.Width = 125;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            this.Thang.Width = 125;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            this.Nam.Width = 125;
            // 
            // songaycong
            // 
            this.songaycong.DataPropertyName = "SoNgayCong";
            this.songaycong.HeaderText = "Số ngày công ";
            this.songaycong.MinimumWidth = 6;
            this.songaycong.Name = "songaycong";
            this.songaycong.ReadOnly = true;
            this.songaycong.Width = 125;
            // 
            // soNgayLamThem
            // 
            this.soNgayLamThem.DataPropertyName = "SoNgayLamThem";
            this.soNgayLamThem.HeaderText = "Số ngày làm thêm";
            this.soNgayLamThem.MinimumWidth = 6;
            this.soNgayLamThem.Name = "soNgayLamThem";
            this.soNgayLamThem.ReadOnly = true;
            this.soNgayLamThem.Width = 125;
            // 
            // TienPhat
            // 
            this.TienPhat.DataPropertyName = "Phat";
            this.TienPhat.HeaderText = "Phạt";
            this.TienPhat.MinimumWidth = 6;
            this.TienPhat.Name = "TienPhat";
            this.TienPhat.ReadOnly = true;
            this.TienPhat.Width = 125;
            // 
            // LuongThucLinh
            // 
            this.LuongThucLinh.DataPropertyName = "LuongThucLinh";
            this.LuongThucLinh.HeaderText = "Lương thực lĩnh";
            this.LuongThucLinh.MinimumWidth = 6;
            this.LuongThucLinh.Name = "LuongThucLinh";
            this.LuongThucLinh.ReadOnly = true;
            this.LuongThucLinh.Width = 125;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Chỉnh sửa";
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
            // cbSoNgayCong
            // 
            this.cbSoNgayCong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoNgayCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoNgayCong.FormattingEnabled = true;
            this.cbSoNgayCong.Location = new System.Drawing.Point(216, 243);
            this.cbSoNgayCong.Name = "cbSoNgayCong";
            this.cbSoNgayCong.Size = new System.Drawing.Size(240, 33);
            this.cbSoNgayCong.TabIndex = 70;
            // 
            // heSoLuongTableAdapter
            // 
            this.heSoLuongTableAdapter.ClearBeforeFill = true;
            // 
            // txtPhat
            // 
            this.txtPhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhat.Location = new System.Drawing.Point(940, 239);
            this.txtPhat.Name = "txtPhat";
            this.txtPhat.Size = new System.Drawing.Size(139, 30);
            this.txtPhat.TabIndex = 72;
            // 
            // phat
            // 
            this.phat.AutoSize = true;
            this.phat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phat.Location = new System.Drawing.Point(876, 237);
            this.phat.Name = "phat";
            this.phat.Size = new System.Drawing.Size(52, 25);
            this.phat.TabIndex = 71;
            this.phat.Text = "Phạt";
            // 
            // cbNgayLamThem
            // 
            this.cbNgayLamThem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgayLamThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgayLamThem.FormattingEnabled = true;
            this.cbNgayLamThem.Location = new System.Drawing.Point(622, 243);
            this.cbNgayLamThem.Name = "cbNgayLamThem";
            this.cbNgayLamThem.Size = new System.Drawing.Size(139, 33);
            this.cbNgayLamThem.TabIndex = 73;
            // 
            // luongTableAdapter
            // 
            this.luongTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // qLNVDataSet6
            // 
            this.qLNVDataSet6.DataSetName = "QLNVDataSet6";
            this.qLNVDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // heSoLuongBindingSource1
            // 
            this.heSoLuongBindingSource1.DataMember = "HeSoLuong";
            this.heSoLuongBindingSource1.DataSource = this.qLNVDataSet6;
            // 
            // heSoLuongTableAdapter1
            // 
            this.heSoLuongTableAdapter1.ClearBeforeFill = true;
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(940, 168);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(139, 33);
            this.cbThang.TabIndex = 74;
            // 
            // btnExportData
            // 
            this.btnExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.Location = new System.Drawing.Point(988, 59);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(150, 50);
            this.btnExportData.TabIndex = 75;
            this.btnExportData.Text = "Xuất dữ liệu ";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangLuong.Location = new System.Drawing.Point(54, 59);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(150, 50);
            this.btnBangLuong.TabIndex = 76;
            this.btnBangLuong.Text = "In bảng lương";
            this.btnBangLuong.UseVisualStyleBackColor = true;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // 
            // FormLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1162, 614);
            this.Controls.Add(this.btnBangLuong);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.cbNgayLamThem);
            this.Controls.Add(this.txtPhat);
            this.Controls.Add(this.phat);
            this.Controls.Add(this.cbSoNgayCong);
            this.Controls.Add(this.grvLuong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMaTinhLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormLuong";
            this.Text = "FormLuong";
            this.Load += new System.EventHandler(this.FormLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_Luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaTinhLuong;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grvLuong;
        private System.Windows.Forms.ComboBox cbSoNgayCong;
        private QLNVDataSet12 qLNVDataSet12;
        private System.Windows.Forms.BindingSource heSoLuongBindingSource;
        private QLNVDataSet12TableAdapters.HeSoLuongTableAdapter heSoLuongTableAdapter;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.Label phat;
        private System.Windows.Forms.ComboBox cbNgayLamThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCong;
        private QLNV_Luong qLNV_Luong;
        private System.Windows.Forms.BindingSource luongBindingSource;
        private QLNV_LuongTableAdapters.LuongTableAdapter luongTableAdapter;
        private QLNVDataSet5 qLNVDataSet5;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLNVDataSet5TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLNVDataSet6 qLNVDataSet6;
        private System.Windows.Forms.BindingSource heSoLuongBindingSource1;
        private QLNVDataSet6TableAdapters.HeSoLuongTableAdapter heSoLuongTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn songaycong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayLamThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongThucLinh;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.Button btnBangLuong;
    }
}