namespace QLNSMay10
{
    partial class fPhucap
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maphucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenphucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maphucap,
            this.Giatri,
            this.Tenphucap});
            this.dataGridView1.Location = new System.Drawing.Point(47, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Maphucap
            // 
            this.Maphucap.DataPropertyName = "Maphucap";
            this.Maphucap.HeaderText = "Mã phụ cấp";
            this.Maphucap.Name = "Maphucap";
            // 
            // Giatri
            // 
            this.Giatri.DataPropertyName = "Giatri";
            this.Giatri.HeaderText = "Giá trị";
            this.Giatri.Name = "Giatri";
            // 
            // Tenphucap
            // 
            this.Tenphucap.DataPropertyName = "Tenphucap";
            this.Tenphucap.HeaderText = "Tên phụ cấp";
            this.Tenphucap.Name = "Tenphucap";
            // 
            // fPhucap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fPhucap";
            this.Text = "fPhucap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPhucap_FormClosing);
            this.Load += new System.EventHandler(this.fPhucap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphucap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giatri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenphucap;
    }
}