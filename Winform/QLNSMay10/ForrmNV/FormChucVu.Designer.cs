namespace QLNSMay10.ForrmNV
{
    partial class FormChucVu
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
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteChucVu = new System.Windows.Forms.Button();
            this.editChucVu = new System.Windows.Forms.Button();
            this.addChucVu = new System.Windows.Forms.Button();
            this.grvChucVu = new System.Windows.Forms.DataGridView();
            this.qLNVChucVu = new QLNSMay10.QLNVChucVu();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chucVuTableAdapter = new QLNSMay10.QLNVChucVuTableAdapters.ChucVuTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chức vụ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChucVu.Location = new System.Drawing.Point(259, 195);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(151, 30);
            this.txtTenChucVu.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 37;
            this.label8.Text = "Chức vụ";
            // 
            // deleteChucVu
            // 
            this.deleteChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteChucVu.Location = new System.Drawing.Point(444, 281);
            this.deleteChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteChucVu.Name = "deleteChucVu";
            this.deleteChucVu.Size = new System.Drawing.Size(149, 50);
            this.deleteChucVu.TabIndex = 42;
            this.deleteChucVu.Text = "Xoá";
            this.deleteChucVu.UseVisualStyleBackColor = true;
            this.deleteChucVu.Click += new System.EventHandler(this.deleteChucVu_Click);
            // 
            // editChucVu
            // 
            this.editChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editChucVu.Location = new System.Drawing.Point(227, 281);
            this.editChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editChucVu.Name = "editChucVu";
            this.editChucVu.Size = new System.Drawing.Size(149, 50);
            this.editChucVu.TabIndex = 41;
            this.editChucVu.Text = "Sửa";
            this.editChucVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editChucVu.UseVisualStyleBackColor = true;
            this.editChucVu.Click += new System.EventHandler(this.editChucVu_Click);
            // 
            // addChucVu
            // 
            this.addChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addChucVu.Location = new System.Drawing.Point(12, 281);
            this.addChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addChucVu.Name = "addChucVu";
            this.addChucVu.Size = new System.Drawing.Size(149, 50);
            this.addChucVu.TabIndex = 40;
            this.addChucVu.Text = "Thêm";
            this.addChucVu.UseVisualStyleBackColor = true;
            this.addChucVu.Click += new System.EventHandler(this.addChucVu_Click);
            // 
            // grvChucVu
            // 
            this.grvChucVu.AllowUserToAddRows = false;
            this.grvChucVu.AllowUserToDeleteRows = false;
            this.grvChucVu.AutoGenerateColumns = false;
            this.grvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.edit,
            this.delete});
            this.grvChucVu.DataSource = this.chucVuBindingSource;
            this.grvChucVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grvChucVu.Location = new System.Drawing.Point(0, 359);
            this.grvChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grvChucVu.Name = "grvChucVu";
            this.grvChucVu.ReadOnly = true;
            this.grvChucVu.RowHeadersWidth = 51;
            this.grvChucVu.Size = new System.Drawing.Size(636, 185);
            this.grvChucVu.TabIndex = 43;
            this.grvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvChucVu_CellContentClick);
            // 
            // qLNVChucVu
            // 
            this.qLNVChucVu.DataSetName = "QLNVChucVu";
            this.qLNVChucVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.qLNVChucVu;
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaChucVu";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaChucVu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenChucVu";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên chức vụ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // FormChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 544);
            this.Controls.Add(this.grvChucVu);
            this.Controls.Add(this.deleteChucVu);
            this.Controls.Add(this.editChucVu);
            this.Controls.Add(this.addChucVu);
            this.Controls.Add(this.txtTenChucVu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormChucVu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteChucVu;
        private System.Windows.Forms.Button editChucVu;
        private System.Windows.Forms.Button addChucVu;
        private System.Windows.Forms.DataGridView grvChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChucVuDataGridViewTextBoxColumn;
        private QLNVChucVu qLNVChucVu;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private QLNVChucVuTableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}