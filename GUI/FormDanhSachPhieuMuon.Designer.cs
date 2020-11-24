namespace GUI
{
    partial class FormDanhSachPhieuMuon
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
            this.gvDanhSachPhieuMuon = new System.Windows.Forms.DataGridView();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbNgayMuon = new System.Windows.Forms.CheckBox();
            this.chbTenDocGia = new System.Windows.Forms.CheckBox();
            this.dtPickerNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cbbTenDocGia = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachPhieuMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDanhSachPhieuMuon
            // 
            this.gvDanhSachPhieuMuon.AllowUserToAddRows = false;
            this.gvDanhSachPhieuMuon.AllowUserToDeleteRows = false;
            this.gvDanhSachPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachPhieuMuon.Location = new System.Drawing.Point(12, 93);
            this.gvDanhSachPhieuMuon.MultiSelect = false;
            this.gvDanhSachPhieuMuon.Name = "gvDanhSachPhieuMuon";
            this.gvDanhSachPhieuMuon.ReadOnly = true;
            this.gvDanhSachPhieuMuon.Size = new System.Drawing.Size(375, 298);
            this.gvDanhSachPhieuMuon.TabIndex = 0;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(311, 65);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(76, 22);
            this.btnXemChiTiet.TabIndex = 1;
            this.btnXemChiTiet.Text = "Xem chi tiết phiếu mượn";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTietPhieuMuon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbNgayMuon);
            this.groupBox1.Controls.Add(this.chbTenDocGia);
            this.groupBox1.Controls.Add(this.dtPickerNgayMuon);
            this.groupBox1.Controls.Add(this.cbbTenDocGia);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc";
            // 
            // chbNgayMuon
            // 
            this.chbNgayMuon.AutoSize = true;
            this.chbNgayMuon.Location = new System.Drawing.Point(13, 51);
            this.chbNgayMuon.Name = "chbNgayMuon";
            this.chbNgayMuon.Size = new System.Drawing.Size(80, 17);
            this.chbNgayMuon.TabIndex = 7;
            this.chbNgayMuon.Text = "Ngày mượn";
            this.chbNgayMuon.UseVisualStyleBackColor = true;
            this.chbNgayMuon.CheckedChanged += new System.EventHandler(this.chbNgayMuon_CheckedChanged);
            // 
            // chbTenDocGia
            // 
            this.chbTenDocGia.AutoSize = true;
            this.chbTenDocGia.Location = new System.Drawing.Point(13, 24);
            this.chbTenDocGia.Name = "chbTenDocGia";
            this.chbTenDocGia.Size = new System.Drawing.Size(84, 17);
            this.chbTenDocGia.TabIndex = 6;
            this.chbTenDocGia.Text = "Tên độc giả";
            this.chbTenDocGia.UseVisualStyleBackColor = true;
            this.chbTenDocGia.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtPickerNgayMuon
            // 
            this.dtPickerNgayMuon.Enabled = false;
            this.dtPickerNgayMuon.Location = new System.Drawing.Point(99, 49);
            this.dtPickerNgayMuon.Name = "dtPickerNgayMuon";
            this.dtPickerNgayMuon.Size = new System.Drawing.Size(181, 20);
            this.dtPickerNgayMuon.TabIndex = 5;
            this.dtPickerNgayMuon.EnabledChanged += new System.EventHandler(this.dtPickerNgayMuon_EnabledChanged);
            // 
            // cbbTenDocGia
            // 
            this.cbbTenDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTenDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenDocGia.Enabled = false;
            this.cbbTenDocGia.FormattingEnabled = true;
            this.cbbTenDocGia.Location = new System.Drawing.Point(99, 22);
            this.cbbTenDocGia.Name = "cbbTenDocGia";
            this.cbbTenDocGia.Size = new System.Drawing.Size(181, 21);
            this.cbbTenDocGia.TabIndex = 4;
            this.cbbTenDocGia.EnabledChanged += new System.EventHandler(this.cbbTenDocGia_EnabledChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Enabled = false;
            this.btnLoc.Location = new System.Drawing.Point(312, 38);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 21);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(312, 12);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(75, 20);
            this.btnXemTatCa.TabIndex = 4;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // FormDanhSachPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 402);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.gvDanhSachPhieuMuon);
            this.Name = "FormDanhSachPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách phiếu mượn";
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachPhieuMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDanhSachPhieuMuon;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtPickerNgayMuon;
        private System.Windows.Forms.ComboBox cbbTenDocGia;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXemTatCa;
        private System.Windows.Forms.CheckBox chbNgayMuon;
        private System.Windows.Forms.CheckBox chbTenDocGia;
    }
}