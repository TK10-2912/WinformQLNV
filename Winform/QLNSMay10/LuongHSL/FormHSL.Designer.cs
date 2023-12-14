namespace QLNSMay10.LuongHSL
{
    partial class FormHSL
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grvHSL = new System.Windows.Forms.DataGridView();
            this.maHSLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHSLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.heSoLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVHeSoLuong = new QLNSMay10.QLNVHeSoLuong();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLuong = new System.Windows.Forms.ComboBox();
            this.cbPhuCap = new System.Windows.Forms.ComboBox();
            this.heSoLuongTableAdapter = new QLNSMay10.QLNVHeSoLuongTableAdapters.HeSoLuongTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grvHSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVHeSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(116, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 50;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(480, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 49;
            this.button3.Text = "Sửa";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 48;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(337, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Lương Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 36);
            this.label2.TabIndex = 43;
            this.label2.Text = "Hệ số lương";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grvHSL
            // 
            this.grvHSL.AutoGenerateColumns = false;
            this.grvHSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvHSL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHSLDataGridViewTextBoxColumn,
            this.tenHSLDataGridViewTextBoxColumn,
            this.LuongThang,
            this.LuongPhuCap,
            this.edit,
            this.delete});
            this.grvHSL.DataSource = this.heSoLuongBindingSource;
            this.grvHSL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvHSL.Location = new System.Drawing.Point(0, 425);
            this.grvHSL.Name = "grvHSL";
            this.grvHSL.RowHeadersWidth = 51;
            this.grvHSL.RowTemplate.Height = 24;
            this.grvHSL.Size = new System.Drawing.Size(1022, 150);
            this.grvHSL.TabIndex = 51;
            this.grvHSL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvHSL_CellContentClick);
            this.grvHSL.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grvHSL_CellFormatting);
            // 
            // maHSLDataGridViewTextBoxColumn
            // 
            this.maHSLDataGridViewTextBoxColumn.DataPropertyName = "MaHSL";
            this.maHSLDataGridViewTextBoxColumn.HeaderText = "MaHSL";
            this.maHSLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHSLDataGridViewTextBoxColumn.Name = "maHSLDataGridViewTextBoxColumn";
            this.maHSLDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHSLDataGridViewTextBoxColumn.Visible = false;
            this.maHSLDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenHSLDataGridViewTextBoxColumn
            // 
            this.tenHSLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenHSLDataGridViewTextBoxColumn.DataPropertyName = "TenHSL";
            this.tenHSLDataGridViewTextBoxColumn.HeaderText = "Hệ số lương";
            this.tenHSLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHSLDataGridViewTextBoxColumn.Name = "tenHSLDataGridViewTextBoxColumn";
            // 
            // LuongThang
            // 
            this.LuongThang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LuongThang.DataPropertyName = "LuongThang";
            this.LuongThang.HeaderText = "Lương tháng";
            this.LuongThang.MinimumWidth = 6;
            this.LuongThang.Name = "LuongThang";
            // 
            // LuongPhuCap
            // 
            this.LuongPhuCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LuongPhuCap.DataPropertyName = "LuongPhuCap";
            this.LuongPhuCap.HeaderText = "Lương phụ cấp";
            this.LuongPhuCap.MinimumWidth = 6;
            this.LuongPhuCap.Name = "LuongPhuCap";
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
            // heSoLuongBindingSource
            // 
            this.heSoLuongBindingSource.DataMember = "HeSoLuong";
            this.heSoLuongBindingSource.DataSource = this.qLNVHeSoLuong;
            // 
            // qLNVHeSoLuong
            // 
            this.qLNVHeSoLuong.DataSetName = "QLNVHeSoLuong";
            this.qLNVHeSoLuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSoLuong.Location = new System.Drawing.Point(493, 168);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(191, 30);
            this.txtHeSoLuong.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tên HSL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Lương phụ cấp";
            // 
            // cbLuong
            // 
            this.cbLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLuong.FormattingEnabled = true;
            this.cbLuong.Location = new System.Drawing.Point(493, 225);
            this.cbLuong.Name = "cbLuong";
            this.cbLuong.Size = new System.Drawing.Size(191, 33);
            this.cbLuong.TabIndex = 56;
            // 
            // cbPhuCap
            // 
            this.cbPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhuCap.FormattingEnabled = true;
            this.cbPhuCap.Location = new System.Drawing.Point(493, 283);
            this.cbPhuCap.Name = "cbPhuCap";
            this.cbPhuCap.Size = new System.Drawing.Size(191, 33);
            this.cbPhuCap.TabIndex = 57;
            // 
            // heSoLuongTableAdapter
            // 
            this.heSoLuongTableAdapter.ClearBeforeFill = true;
            // 
            // FormHSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 575);
            this.Controls.Add(this.cbPhuCap);
            this.Controls.Add(this.cbLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeSoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvHSL);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "FormHSL";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHSL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvHSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVHeSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grvHSL;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLuong;
        private System.Windows.Forms.ComboBox cbPhuCap;
        private QLNVHeSoLuong qLNVHeSoLuong;
        private System.Windows.Forms.BindingSource heSoLuongBindingSource;
        private QLNVHeSoLuongTableAdapters.HeSoLuongTableAdapter heSoLuongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHSLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHSLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongPhuCap;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}