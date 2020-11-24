using System.Windows.Forms;

namespace GUI
{
    partial class FormMuonSach
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
            this.label9 = new System.Windows.Forms.Label();
            this.paneldangnhap = new System.Windows.Forms.Panel();
            this.txtdnmatkhau = new System.Windows.Forms.TextBox();
            this.bttdndangnhap = new System.Windows.Forms.Button();
            this.txtdntaikhoan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPickerNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.btnTimDocGia = new System.Windows.Forms.Button();
            this.txtSoLuongSachMuon = new System.Windows.Forms.TextBox();
            this.cbbSachMuonQuaHan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIDDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvMuonSach = new System.Windows.Forms.DataGridView();
            this.colIDSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.btnTimSach = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIDSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtPickerHomNay = new System.Windows.Forms.DateTimePicker();
            this.btnXoaChiTiet = new System.Windows.Forms.Button();
            this.btnLapPhieuMuon = new System.Windows.Forms.Button();
            this.btnDanhSachPhieuMuon = new System.Windows.Forms.Button();
            this.paneldangnhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMuonSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tài Khoản";
            // 
            // paneldangnhap
            // 
            this.paneldangnhap.Controls.Add(this.label9);
            this.paneldangnhap.Controls.Add(this.txtdnmatkhau);
            this.paneldangnhap.Controls.Add(this.bttdndangnhap);
            this.paneldangnhap.Controls.Add(this.txtdntaikhoan);
            this.paneldangnhap.Controls.Add(this.label10);
            this.paneldangnhap.Location = new System.Drawing.Point(536, -104);
            this.paneldangnhap.Name = "paneldangnhap";
            this.paneldangnhap.Size = new System.Drawing.Size(414, 103);
            this.paneldangnhap.TabIndex = 12;
            // 
            // txtdnmatkhau
            // 
            this.txtdnmatkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdnmatkhau.Location = new System.Drawing.Point(104, 59);
            this.txtdnmatkhau.Name = "txtdnmatkhau";
            this.txtdnmatkhau.PasswordChar = '*';
            this.txtdnmatkhau.Size = new System.Drawing.Size(154, 26);
            this.txtdnmatkhau.TabIndex = 1;
            this.txtdnmatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bttdndangnhap
            // 
            this.bttdndangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttdndangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttdndangnhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bttdndangnhap.Location = new System.Drawing.Point(300, 7);
            this.bttdndangnhap.Name = "bttdndangnhap";
            this.bttdndangnhap.Size = new System.Drawing.Size(109, 90);
            this.bttdndangnhap.TabIndex = 4;
            this.bttdndangnhap.Text = "Đăng Nhập";
            this.bttdndangnhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttdndangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bttdndangnhap.UseVisualStyleBackColor = true;
            // 
            // txtdntaikhoan
            // 
            this.txtdntaikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdntaikhoan.Location = new System.Drawing.Point(104, 21);
            this.txtdntaikhoan.Name = "txtdntaikhoan";
            this.txtdntaikhoan.Size = new System.Drawing.Size(154, 26);
            this.txtdntaikhoan.TabIndex = 0;
            this.txtdntaikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mật Khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPickerNgayLapThe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenDocGia);
            this.groupBox1.Controls.Add(this.btnTimDocGia);
            this.groupBox1.Controls.Add(this.txtSoLuongSachMuon);
            this.groupBox1.Controls.Add(this.cbbSachMuonQuaHan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtIDDocGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(389, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // dtPickerNgayLapThe
            // 
            this.dtPickerNgayLapThe.Enabled = false;
            this.dtPickerNgayLapThe.Location = new System.Drawing.Point(182, 70);
            this.dtPickerNgayLapThe.Name = "dtPickerNgayLapThe";
            this.dtPickerNgayLapThe.Size = new System.Drawing.Size(187, 20);
            this.dtPickerNgayLapThe.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Ngày lập thẻ";
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(182, 43);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(188, 20);
            this.txtTenDocGia.TabIndex = 43;
            // 
            // btnTimDocGia
            // 
            this.btnTimDocGia.Location = new System.Drawing.Point(141, 147);
            this.btnTimDocGia.Name = "btnTimDocGia";
            this.btnTimDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnTimDocGia.TabIndex = 42;
            this.btnTimDocGia.Text = "Tìm độc giả";
            this.btnTimDocGia.UseVisualStyleBackColor = true;
            this.btnTimDocGia.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoLuongSachMuon
            // 
            this.txtSoLuongSachMuon.Location = new System.Drawing.Point(181, 122);
            this.txtSoLuongSachMuon.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuongSachMuon.Name = "txtSoLuongSachMuon";
            this.txtSoLuongSachMuon.ReadOnly = true;
            this.txtSoLuongSachMuon.Size = new System.Drawing.Size(188, 20);
            this.txtSoLuongSachMuon.TabIndex = 39;
            // 
            // cbbSachMuonQuaHan
            // 
            this.cbbSachMuonQuaHan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbSachMuonQuaHan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSachMuonQuaHan.FormattingEnabled = true;
            this.cbbSachMuonQuaHan.Location = new System.Drawing.Point(181, 96);
            this.cbbSachMuonQuaHan.Name = "cbbSachMuonQuaHan";
            this.cbbSachMuonQuaHan.Size = new System.Drawing.Size(188, 21);
            this.cbbSachMuonQuaHan.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Số lượng sách mượn trong 4 ngày";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 99);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Sách mượn quá hạn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "ID độc giả";
            // 
            // txtIDDocGia
            // 
            this.txtIDDocGia.Location = new System.Drawing.Point(182, 17);
            this.txtIDDocGia.Name = "txtIDDocGia";
            this.txtIDDocGia.ReadOnly = true;
            this.txtIDDocGia.Size = new System.Drawing.Size(188, 20);
            this.txtIDDocGia.TabIndex = 36;
            this.txtIDDocGia.TextChanged += new System.EventHandler(this.txtIDDocGia_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên độc giả";
            // 
            // gvMuonSach
            // 
            this.gvMuonSach.AllowUserToAddRows = false;
            this.gvMuonSach.AllowUserToDeleteRows = false;
            this.gvMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDSach,
            this.colTenSach});
            this.gvMuonSach.Location = new System.Drawing.Point(404, 39);
            this.gvMuonSach.Margin = new System.Windows.Forms.Padding(2);
            this.gvMuonSach.MultiSelect = false;
            this.gvMuonSach.Name = "gvMuonSach";
            this.gvMuonSach.RowTemplate.Height = 24;
            this.gvMuonSach.Size = new System.Drawing.Size(274, 359);
            this.gvMuonSach.TabIndex = 9;
            this.gvMuonSach.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvMuonSach_RowsAdded);
            this.gvMuonSach.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gvMuonSach_RowsRemoved);
            // 
            // colIDSach
            // 
            this.colIDSach.HeaderText = "ID Sách";
            this.colIDSach.Name = "colIDSach";
            // 
            // colTenSach
            // 
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.Name = "colTenSach";
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Location = new System.Drawing.Point(36, 359);
            this.btnThemChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(79, 39);
            this.btnThemChiTiet.TabIndex = 5;
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenSach);
            this.groupBox2.Controls.Add(this.btnTimSach);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtIDSach);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTinhTrang);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(11, 226);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(389, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(182, 42);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(188, 20);
            this.txtTenSach.TabIndex = 44;
            // 
            // btnTimSach
            // 
            this.btnTimSach.Location = new System.Drawing.Point(141, 94);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(75, 23);
            this.btnTimSach.TabIndex = 43;
            this.btnTimSach.Text = "Tìm sách";
            this.btnTimSach.UseVisualStyleBackColor = true;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "ID sách";
            // 
            // txtIDSach
            // 
            this.txtIDSach.Location = new System.Drawing.Point(182, 16);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.ReadOnly = true;
            this.txtIDSach.Size = new System.Drawing.Size(188, 20);
            this.txtIDSach.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tình trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(182, 68);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(188, 20);
            this.txtTinhTrang.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 45);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Tên sách";
            // 
            // dtPickerHomNay
            // 
            this.dtPickerHomNay.Location = new System.Drawing.Point(9, 11);
            this.dtPickerHomNay.Name = "dtPickerHomNay";
            this.dtPickerHomNay.Size = new System.Drawing.Size(188, 20);
            this.dtPickerHomNay.TabIndex = 0;
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.Enabled = false;
            this.btnXoaChiTiet.Location = new System.Drawing.Point(119, 359);
            this.btnXoaChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(78, 39);
            this.btnXoaChiTiet.TabIndex = 6;
            this.btnXoaChiTiet.Text = "Xóa chi tiết";
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // btnLapPhieuMuon
            // 
            this.btnLapPhieuMuon.Enabled = false;
            this.btnLapPhieuMuon.Location = new System.Drawing.Point(201, 359);
            this.btnLapPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnLapPhieuMuon.Name = "btnLapPhieuMuon";
            this.btnLapPhieuMuon.Size = new System.Drawing.Size(78, 39);
            this.btnLapPhieuMuon.TabIndex = 7;
            this.btnLapPhieuMuon.Text = "Lập phiếu mượn";
            this.btnLapPhieuMuon.UseVisualStyleBackColor = true;
            this.btnLapPhieuMuon.Click += new System.EventHandler(this.btnLapPhieuMuon_Click);
            // 
            // btnDanhSachPhieuMuon
            // 
            this.btnDanhSachPhieuMuon.Location = new System.Drawing.Point(283, 359);
            this.btnDanhSachPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.btnDanhSachPhieuMuon.Name = "btnDanhSachPhieuMuon";
            this.btnDanhSachPhieuMuon.Size = new System.Drawing.Size(78, 39);
            this.btnDanhSachPhieuMuon.TabIndex = 8;
            this.btnDanhSachPhieuMuon.Text = "Danh sách phiếu mượn";
            this.btnDanhSachPhieuMuon.UseVisualStyleBackColor = true;
            this.btnDanhSachPhieuMuon.Click += new System.EventHandler(this.btnDanhSachPhieuMuon_Click);
            // 
            // FormMuonSach_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 409);
            this.Controls.Add(this.btnDanhSachPhieuMuon);
            this.Controls.Add(this.btnLapPhieuMuon);
            this.Controls.Add(this.btnXoaChiTiet);
            this.Controls.Add(this.dtPickerHomNay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemChiTiet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paneldangnhap);
            this.Controls.Add(this.gvMuonSach);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMuonSach_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mượn sách";
            this.paneldangnhap.ResumeLayout(false);
            this.paneldangnhap.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMuonSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel paneldangnhap;
        private System.Windows.Forms.TextBox txtdnmatkhau;
        private System.Windows.Forms.Button bttdndangnhap;
        private System.Windows.Forms.TextBox txtdntaikhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvMuonSach;
        private Button btnThemChiTiet;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox txtTinhTrang;
        private Label label16;
        private DateTimePicker dtPickerHomNay;
        private Button btnXoaChiTiet;
        private Button btnLapPhieuMuon;
        private Button btnDanhSachPhieuMuon;
        private Label label17;
        private TextBox txtIDDocGia;
        private Label label14;
        private TextBox txtIDSach;
        private TextBox txtSoLuongSachMuon;
        private ComboBox cbbSachMuonQuaHan;
        private Label label7;
        private Label label11;
        private Button btnTimDocGia;
        private Button btnTimSach;
        private TextBox txtTenDocGia;
        private TextBox txtTenSach;
        private DateTimePicker dtPickerNgayLapThe;
        private Label label2;
        private DataGridViewTextBoxColumn colIDSach;
        private DataGridViewTextBoxColumn colTenSach;
    }
}

