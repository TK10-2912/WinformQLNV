namespace QLNSMay10.ForrmNV
{
    partial class FormPhongBan
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
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dtgrPhongBan = new System.Windows.Forms.DataGridView();
            this.maPhongBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinhsua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVDataSet13 = new QLNSMay10.QLNVDataSet13();
            this.phongBanTableAdapter = new QLNSMay10.QLNVDataSet13TableAdapters.PhongBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng ban";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(288, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tên phòng ban";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(288, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Địa chỉ";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(439, 230);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(151, 30);
            this.txtSoDienThoai.TabIndex = 31;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(439, 280);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(151, 30);
            this.txtDiaChi.TabIndex = 33;
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhongBan.Location = new System.Drawing.Point(439, 178);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(151, 30);
            this.txtTenPhongBan.TabIndex = 35;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(104, 339);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(150, 50);
            this.add.TabIndex = 36;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.Location = new System.Drawing.Point(424, 339);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(150, 50);
            this.edit.TabIndex = 37;
            this.edit.Text = "Sửa";
            this.edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(726, 339);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(150, 50);
            this.delete.TabIndex = 38;
            this.delete.Text = "Xoá";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dtgrPhongBan
            // 
            this.dtgrPhongBan.AllowUserToAddRows = false;
            this.dtgrPhongBan.AllowUserToDeleteRows = false;
            this.dtgrPhongBan.AutoGenerateColumns = false;
            this.dtgrPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhongBanDataGridViewTextBoxColumn,
            this.tenPhongBanDataGridViewTextBoxColumn,
            this.soDienThoaiDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.chinhsua,
            this.xoa});
            this.dtgrPhongBan.DataSource = this.phongBanBindingSource;
            this.dtgrPhongBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrPhongBan.Location = new System.Drawing.Point(0, 425);
            this.dtgrPhongBan.Name = "dtgrPhongBan";
            this.dtgrPhongBan.ReadOnly = true;
            this.dtgrPhongBan.RowHeadersWidth = 51;
            this.dtgrPhongBan.RowTemplate.Height = 24;
            this.dtgrPhongBan.Size = new System.Drawing.Size(1022, 150);
            this.dtgrPhongBan.TabIndex = 39;
            this.dtgrPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrPhongBan_CellContentClick);
            // 
            // maPhongBanDataGridViewTextBoxColumn
            // 
            this.maPhongBanDataGridViewTextBoxColumn.DataPropertyName = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.HeaderText = "MaPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhongBanDataGridViewTextBoxColumn.Name = "maPhongBanDataGridViewTextBoxColumn";
            this.maPhongBanDataGridViewTextBoxColumn.ReadOnly = true;
            this.maPhongBanDataGridViewTextBoxColumn.Visible = false;
            this.maPhongBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenPhongBanDataGridViewTextBoxColumn
            // 
            this.tenPhongBanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenPhongBanDataGridViewTextBoxColumn.DataPropertyName = "TenPhongBan";
            this.tenPhongBanDataGridViewTextBoxColumn.HeaderText = "Tên phòng ban";
            this.tenPhongBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenPhongBanDataGridViewTextBoxColumn.Name = "tenPhongBanDataGridViewTextBoxColumn";
            this.tenPhongBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soDienThoaiDataGridViewTextBoxColumn
            // 
            this.soDienThoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soDienThoaiDataGridViewTextBoxColumn.DataPropertyName = "SoDienThoai";
            this.soDienThoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDienThoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDienThoaiDataGridViewTextBoxColumn.Name = "soDienThoaiDataGridViewTextBoxColumn";
            this.soDienThoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chinhsua
            // 
            this.chinhsua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chinhsua.HeaderText = "";
            this.chinhsua.MinimumWidth = 6;
            this.chinhsua.Name = "chinhsua";
            this.chinhsua.ReadOnly = true;
            this.chinhsua.Text = "Chỉnh sửa";
            this.chinhsua.UseColumnTextForButtonValue = true;
            // 
            // xoa
            // 
            this.xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xoa.HeaderText = "";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.qLNVDataSet13;
            // 
            // qLNVDataSet13
            // 
            this.qLNVDataSet13.DataSetName = "QLNVDataSet13";
            this.qLNVDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 575);
            this.Controls.Add(this.dtgrPhongBan);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtTenPhongBan);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPhongBan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dtgrPhongBan;
        private QLNVDataSet13 qLNVDataSet13;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private QLNVDataSet13TableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn chinhsua;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}