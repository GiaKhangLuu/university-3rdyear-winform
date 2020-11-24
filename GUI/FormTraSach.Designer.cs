using System.Windows.Forms;

namespace GUI
{
    partial class FormTraSach
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
            this.btnTimDocGia = new System.Windows.Forms.Button();
            this.txtIDDocGia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvTraSach = new System.Windows.Forms.DataGridView();
            this.colIDPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoNgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtPickerNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDSach = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbTenSach = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtPickerHomNay = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLapPhieuTra = new System.Windows.Forms.Button();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDanhSachPhieuTra = new System.Windows.Forms.Button();
            this.txtIDPhieuMuon = new System.Windows.Forms.TextBox();
            this.txtTongNoMoi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.paneldangnhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraSach)).BeginInit();
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
            this.groupBox1.Controls.Add(this.txtTenDocGia);
            this.groupBox1.Controls.Add(this.btnTimDocGia);
            this.groupBox1.Controls.Add(this.txtIDDocGia);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(321, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // btnTimDocGia
            // 
            this.btnTimDocGia.Location = new System.Drawing.Point(103, 96);
            this.btnTimDocGia.Name = "btnTimDocGia";
            this.btnTimDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnTimDocGia.TabIndex = 43;
            this.btnTimDocGia.Text = "Tìm độc giả";
            this.btnTimDocGia.UseVisualStyleBackColor = true;
            this.btnTimDocGia.Click += new System.EventHandler(this.btnTimDocGia_Click);
            // 
            // txtIDDocGia
            // 
            this.txtIDDocGia.Location = new System.Drawing.Point(103, 18);
            this.txtIDDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDDocGia.Name = "txtIDDocGia";
            this.txtIDDocGia.ReadOnly = true;
            this.txtIDDocGia.Size = new System.Drawing.Size(188, 20);
            this.txtIDDocGia.TabIndex = 36;
            this.txtIDDocGia.TextChanged += new System.EventHandler(this.txtIDDocGia_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 21);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "ID độc giả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Nợ";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(103, 70);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(188, 20);
            this.txtNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên độc giả";
            // 
            // gvTraSach
            // 
            this.gvTraSach.AllowUserToAddRows = false;
            this.gvTraSach.AllowUserToDeleteRows = false;
            this.gvTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTraSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPhieuMuon,
            this.colIDSach,
            this.colTenSach,
            this.colNgayMuon,
            this.colSoNgayMuon,
            this.colTienPhat});
            this.gvTraSach.Location = new System.Drawing.Point(336, 30);
            this.gvTraSach.Margin = new System.Windows.Forms.Padding(2);
            this.gvTraSach.Name = "gvTraSach";
            this.gvTraSach.RowTemplate.Height = 24;
            this.gvTraSach.Size = new System.Drawing.Size(460, 278);
            this.gvTraSach.TabIndex = 8;
            this.gvTraSach.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvTraSach_RowsAdded);
            this.gvTraSach.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gvTraSach_RowsRemoved);
            // 
            // colIDPhieuMuon
            // 
            this.colIDPhieuMuon.HeaderText = "IDPhieuMuon";
            this.colIDPhieuMuon.Name = "colIDPhieuMuon";
            this.colIDPhieuMuon.Visible = false;
            // 
            // colIDSach
            // 
            this.colIDSach.HeaderText = "ID sách";
            this.colIDSach.Name = "colIDSach";
            this.colIDSach.Width = 70;
            // 
            // colTenSach
            // 
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Width = 120;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.HeaderText = "Ngày mượn";
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.Width = 90;
            // 
            // colSoNgayMuon
            // 
            this.colSoNgayMuon.HeaderText = "Số ngày mượn";
            this.colSoNgayMuon.Name = "colSoNgayMuon";
            this.colSoNgayMuon.Width = 70;
            // 
            // colTienPhat
            // 
            this.colTienPhat.HeaderText = "Tiền phạt";
            this.colTienPhat.Name = "colTienPhat";
            this.colTienPhat.Width = 70;
            // 
            // btnThem
            // 
            this.btnThem.Enabled = false;
            this.btnThem.Location = new System.Drawing.Point(11, 272);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 36);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm chi tiết";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtPickerNgayMuon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtIDSach);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbbTenSach);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(11, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(321, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách chưa trả";
            // 
            // dtPickerNgayMuon
            // 
            this.dtPickerNgayMuon.Enabled = false;
            this.dtPickerNgayMuon.Location = new System.Drawing.Point(103, 69);
            this.dtPickerNgayMuon.Name = "dtPickerNgayMuon";
            this.dtPickerNgayMuon.Size = new System.Drawing.Size(188, 20);
            this.dtPickerNgayMuon.TabIndex = 39;
            this.dtPickerNgayMuon.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Ngày mượn";
            // 
            // txtIDSach
            // 
            this.txtIDSach.Location = new System.Drawing.Point(103, 17);
            this.txtIDSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.ReadOnly = true;
            this.txtIDSach.Size = new System.Drawing.Size(188, 20);
            this.txtIDSach.TabIndex = 38;
            this.txtIDSach.TextChanged += new System.EventHandler(this.txtIDSach_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "ID sách";
            // 
            // cbbTenSach
            // 
            this.cbbTenSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbTenSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenSach.FormattingEnabled = true;
            this.cbbTenSach.Location = new System.Drawing.Point(103, 42);
            this.cbbTenSach.Name = "cbbTenSach";
            this.cbbTenSach.Size = new System.Drawing.Size(188, 21);
            this.cbbTenSach.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 45);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Sách chưa trả";
            // 
            // dtPickerHomNay
            // 
            this.dtPickerHomNay.Enabled = false;
            this.dtPickerHomNay.Location = new System.Drawing.Point(11, 5);
            this.dtPickerHomNay.Name = "dtPickerHomNay";
            this.dtPickerHomNay.Size = new System.Drawing.Size(188, 20);
            this.dtPickerHomNay.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(93, 272);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 36);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Xóa chi tiết";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLapPhieuTra
            // 
            this.btnLapPhieuTra.Enabled = false;
            this.btnLapPhieuTra.Location = new System.Drawing.Point(175, 272);
            this.btnLapPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnLapPhieuTra.Name = "btnLapPhieuTra";
            this.btnLapPhieuTra.Size = new System.Drawing.Size(78, 36);
            this.btnLapPhieuTra.TabIndex = 6;
            this.btnLapPhieuTra.Text = "Lập phiếu trả";
            this.btnLapPhieuTra.UseVisualStyleBackColor = true;
            this.btnLapPhieuTra.Click += new System.EventHandler(this.btnLapPhieuTra_Click);
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(422, 320);
            this.txtTienPhat.Margin = new System.Windows.Forms.Padding(2);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.ReadOnly = true;
            this.txtTienPhat.Size = new System.Drawing.Size(115, 20);
            this.txtTienPhat.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(339, 323);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Tổng tiền phạt:";
            // 
            // btnDanhSachPhieuTra
            // 
            this.btnDanhSachPhieuTra.Location = new System.Drawing.Point(254, 272);
            this.btnDanhSachPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnDanhSachPhieuTra.Name = "btnDanhSachPhieuTra";
            this.btnDanhSachPhieuTra.Size = new System.Drawing.Size(78, 36);
            this.btnDanhSachPhieuTra.TabIndex = 7;
            this.btnDanhSachPhieuTra.Text = "Danh sách phiếu trả";
            this.btnDanhSachPhieuTra.UseVisualStyleBackColor = true;
            this.btnDanhSachPhieuTra.Click += new System.EventHandler(this.btnDanhSachPhieuTra_Click);
            // 
            // txtIDPhieuMuon
            // 
            this.txtIDPhieuMuon.Enabled = false;
            this.txtIDPhieuMuon.HideSelection = false;
            this.txtIDPhieuMuon.Location = new System.Drawing.Point(611, 431);
            this.txtIDPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDPhieuMuon.Name = "txtIDPhieuMuon";
            this.txtIDPhieuMuon.Size = new System.Drawing.Size(0, 20);
            this.txtIDPhieuMuon.TabIndex = 39;
            // 
            // txtTongNoMoi
            // 
            this.txtTongNoMoi.Location = new System.Drawing.Point(595, 320);
            this.txtTongNoMoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongNoMoi.Name = "txtTongNoMoi";
            this.txtTongNoMoi.ReadOnly = true;
            this.txtTongNoMoi.Size = new System.Drawing.Size(115, 20);
            this.txtTongNoMoi.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(541, 323);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Tổng nợ:";
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(103, 43);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(188, 20);
            this.txtTenDocGia.TabIndex = 44;
            // 
            // FormTraSach_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 350);
            this.Controls.Add(this.txtTongNoMoi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtIDPhieuMuon);
            this.Controls.Add(this.btnDanhSachPhieuTra);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnLapPhieuTra);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dtPickerHomNay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paneldangnhap);
            this.Controls.Add(this.gvTraSach);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTraSach_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả sách";
            this.paneldangnhap.ResumeLayout(false);
            this.paneldangnhap.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTraSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView gvTraSach;
        private Label label7;
        private TextBox txtNo;
        private Button btnThem;
        private GroupBox groupBox2;
        private ComboBox cbbTenSach;
        private Label label16;
        private DateTimePicker dtPickerHomNay;
        private Button btnHuy;
        private Button btnLapPhieuTra;
        private TextBox txtTienPhat;
        private Label label20;
        private Button btnDanhSachPhieuTra;
        private TextBox txtIDDocGia;
        private Label label14;
        private TextBox txtIDSach;
        private Label label11;
        private DateTimePicker dtPickerNgayMuon;
        private Label label8;
        private TextBox txtIDPhieuMuon;
        private DataGridViewTextBoxColumn colIDPhieuMuon;
        private DataGridViewTextBoxColumn colIDSach;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colNgayMuon;
        private DataGridViewTextBoxColumn colSoNgayMuon;
        private DataGridViewTextBoxColumn colTienPhat;
        private TextBox txtTongNoMoi;
        private Label label17;
        private Button btnTimDocGia;
        private TextBox txtTenDocGia;
    }
}

