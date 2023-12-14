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
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaHSL = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoNgayLamThem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grvLuong = new System.Windows.Forms.DataGridView();
            this.maLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHSLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayCongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soNgayLamThemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongThucLinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.luongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVLuong = new QLNSMay10.QLNVLuong();
            this.luongTableAdapter = new QLNSMay10.QLNVLuongTableAdapters.LuongTableAdapter();
            this.cbSoNgayCong = new System.Windows.Forms.ComboBox();
            this.qLNVDataSet5 = new QLNSMay10.QLNVDataSet5();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLNSMay10.QLNVDataSet5TableAdapters.NhanVienTableAdapter();
            this.qLNVDataSet6 = new QLNSMay10.QLNVDataSet6();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter1 = new QLNSMay10.QLNVDataSet6TableAdapters.NhanVienTableAdapter();
            this.qLNVDataSet7 = new QLNSMay10.QLNVDataSet7();
            this.nhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter2 = new QLNSMay10.QLNVDataSet7TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grvLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 99);
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
            this.label1.Location = new System.Drawing.Point(39, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã nhân viên";
            // 
            // cbMaTinhLuong
            // 
            this.cbMaTinhLuong.DataSource = this.nhanVienBindingSource2;
            this.cbMaTinhLuong.DisplayMember = "MaTinhLuong";
            this.cbMaTinhLuong.FormattingEnabled = true;
            this.cbMaTinhLuong.Location = new System.Drawing.Point(175, 204);
            this.cbMaTinhLuong.Name = "cbMaTinhLuong";
            this.cbMaTinhLuong.Size = new System.Drawing.Size(139, 24);
            this.cbMaTinhLuong.TabIndex = 55;
            this.cbMaTinhLuong.ValueMember = "MaNhanVien";
            this.cbMaTinhLuong.SelectedIndexChanged += new System.EventHandler(this.cbMaTinhLuong_SelectedIndexChanged);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(831, 199);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(139, 24);
            this.cbNam.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Năm";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(501, 200);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(139, 24);
            this.cbThang.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tháng";
            // 
            // cbMaHSL
            // 
            this.cbMaHSL.FormattingEnabled = true;
            this.cbMaHSL.Location = new System.Drawing.Point(175, 271);
            this.cbMaHSL.Name = "cbMaHSL";
            this.cbMaHSL.Size = new System.Drawing.Size(139, 24);
            this.cbMaHSL.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tên hệ số lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Số ngày công";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(694, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ngày làm thêm";
            // 
            // txtSoNgayLamThem
            // 
            this.txtSoNgayLamThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayLamThem.Location = new System.Drawing.Point(831, 269);
            this.txtSoNgayLamThem.Name = "txtSoNgayLamThem";
            this.txtSoNgayLamThem.Size = new System.Drawing.Size(139, 24);
            this.txtSoNgayLamThem.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(145, 335);
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
            this.button3.Location = new System.Drawing.Point(523, 335);
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
            this.button1.Location = new System.Drawing.Point(863, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 66;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grvLuong
            // 
            this.grvLuong.AutoGenerateColumns = false;
            this.grvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLuongDataGridViewTextBoxColumn,
            this.nameNV,
            this.maNhanVienDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.maHSLDataGridViewTextBoxColumn,
            this.soNgayCongDataGridViewTextBoxColumn,
            this.soNgayLamThemDataGridViewTextBoxColumn,
            this.phatDataGridViewTextBoxColumn,
            this.luongThucLinhDataGridViewTextBoxColumn,
            this.edit,
            this.delete});
            this.grvLuong.DataSource = this.luongBindingSource;
            this.grvLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvLuong.Location = new System.Drawing.Point(0, 425);
            this.grvLuong.Name = "grvLuong";
            this.grvLuong.RowHeadersWidth = 51;
            this.grvLuong.RowTemplate.Height = 24;
            this.grvLuong.Size = new System.Drawing.Size(1022, 150);
            this.grvLuong.TabIndex = 69;
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
            // nameNV
            // 
            this.nameNV.HeaderText = "Tên nhân viên";
            this.nameNV.MinimumWidth = 6;
            this.nameNV.Name = "nameNV";
            this.nameNV.Width = 125;
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "Mã nhân viên";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.Visible = false;
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "Thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Tháng";
            this.thangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            // 
            // maHSLDataGridViewTextBoxColumn
            // 
            this.maHSLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maHSLDataGridViewTextBoxColumn.DataPropertyName = "MaHSL";
            this.maHSLDataGridViewTextBoxColumn.HeaderText = "Mã HSL";
            this.maHSLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHSLDataGridViewTextBoxColumn.Name = "maHSLDataGridViewTextBoxColumn";
            // 
            // soNgayCongDataGridViewTextBoxColumn
            // 
            this.soNgayCongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soNgayCongDataGridViewTextBoxColumn.DataPropertyName = "SoNgayCong";
            this.soNgayCongDataGridViewTextBoxColumn.HeaderText = "Số ngày công";
            this.soNgayCongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soNgayCongDataGridViewTextBoxColumn.Name = "soNgayCongDataGridViewTextBoxColumn";
            // 
            // soNgayLamThemDataGridViewTextBoxColumn
            // 
            this.soNgayLamThemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soNgayLamThemDataGridViewTextBoxColumn.DataPropertyName = "SoNgayLamThem";
            this.soNgayLamThemDataGridViewTextBoxColumn.HeaderText = "Ngày làm thêm";
            this.soNgayLamThemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soNgayLamThemDataGridViewTextBoxColumn.Name = "soNgayLamThemDataGridViewTextBoxColumn";
            // 
            // phatDataGridViewTextBoxColumn
            // 
            this.phatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phatDataGridViewTextBoxColumn.DataPropertyName = "Phat";
            this.phatDataGridViewTextBoxColumn.HeaderText = "Phạt";
            this.phatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phatDataGridViewTextBoxColumn.Name = "phatDataGridViewTextBoxColumn";
            // 
            // luongThucLinhDataGridViewTextBoxColumn
            // 
            this.luongThucLinhDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.luongThucLinhDataGridViewTextBoxColumn.DataPropertyName = "LuongThucLinh";
            this.luongThucLinhDataGridViewTextBoxColumn.HeaderText = "Lương thực lĩnh";
            this.luongThucLinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.luongThucLinhDataGridViewTextBoxColumn.Name = "luongThucLinhDataGridViewTextBoxColumn";
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Text = "Chỉnh sửa";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Text = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 125;
            // 
            // luongBindingSource
            // 
            this.luongBindingSource.DataMember = "Luong";
            this.luongBindingSource.DataSource = this.qLNVLuong;
            // 
            // qLNVLuong
            // 
            this.qLNVLuong.DataSetName = "QLNVLuong";
            this.qLNVLuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luongTableAdapter
            // 
            this.luongTableAdapter.ClearBeforeFill = true;
            // 
            // cbSoNgayCong
            // 
            this.cbSoNgayCong.FormattingEnabled = true;
            this.cbSoNgayCong.Location = new System.Drawing.Point(501, 275);
            this.cbSoNgayCong.Name = "cbSoNgayCong";
            this.cbSoNgayCong.Size = new System.Drawing.Size(139, 24);
            this.cbSoNgayCong.TabIndex = 70;
            // 
            // qLNVDataSet5
            // 
            this.qLNVDataSet5.DataSetName = "QLNVDataSet5";
            this.qLNVDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLNVDataSet5;
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
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.qLNVDataSet6;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // qLNVDataSet7
            // 
            this.qLNVDataSet7.DataSetName = "QLNVDataSet7";
            this.qLNVDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource2
            // 
            this.nhanVienBindingSource2.DataMember = "NhanVien";
            this.nhanVienBindingSource2.DataSource = this.qLNVDataSet7;
            // 
            // nhanVienTableAdapter2
            // 
            this.nhanVienTableAdapter2.ClearBeforeFill = true;
            // 
            // FormLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 575);
            this.Controls.Add(this.cbSoNgayCong);
            this.Controls.Add(this.grvLuong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSoNgayLamThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMaHSL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMaTinhLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormLuong";
            this.Text = "FormLuong";
            this.Load += new System.EventHandler(this.FormLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaTinhLuong;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaHSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoNgayLamThem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grvLuong;
        private QLNVLuong qLNVLuong;
        private System.Windows.Forms.BindingSource luongBindingSource;
        private QLNVLuongTableAdapters.LuongTableAdapter luongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayCongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayLamThemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongThucLinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.ComboBox cbSoNgayCong;
        private QLNVDataSet5 qLNVDataSet5;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLNVDataSet5TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLNVDataSet6 qLNVDataSet6;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private QLNVDataSet6TableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private QLNVDataSet7 qLNVDataSet7;
        private System.Windows.Forms.BindingSource nhanVienBindingSource2;
        private QLNVDataSet7TableAdapters.NhanVienTableAdapter nhanVienTableAdapter2;
    }
}