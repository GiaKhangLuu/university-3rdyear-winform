using System.Windows.Forms;

namespace GUI
{
    partial class FormTimSach
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
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.gvSach = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbNamXuatBan = new System.Windows.Forms.ComboBox();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtNhaXuatBan = new System.Windows.Forms.TextBox();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.paneldangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).BeginInit();
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
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(189, 285);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(104, 29);
            this.btnTraCuu.TabIndex = 8;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // gvSach
            // 
            this.gvSach.AllowUserToAddRows = false;
            this.gvSach.AllowUserToDeleteRows = false;
            this.gvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSach.Location = new System.Drawing.Point(13, 138);
            this.gvSach.Margin = new System.Windows.Forms.Padding(2);
            this.gvSach.Name = "gvSach";
            this.gvSach.RowTemplate.Height = 24;
            this.gvSach.Size = new System.Drawing.Size(567, 143);
            this.gvSach.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(405, 285);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 29);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Đang được mượn",
            "Chưa được mượn"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(392, 86);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(188, 21);
            this.cbbTinhTrang.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 86);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Tình trạng";
            // 
            // txtIDSach
            // 
            this.txtIDSach.Location = new System.Drawing.Point(92, 6);
            this.txtIDSach.Name = "txtIDSach";
            this.txtIDSach.Size = new System.Drawing.Size(188, 20);
            this.txtIDSach.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "ID sách";
            // 
            // cbbNamXuatBan
            // 
            this.cbbNamXuatBan.FormattingEnabled = true;
            this.cbbNamXuatBan.Location = new System.Drawing.Point(92, 112);
            this.cbbNamXuatBan.Name = "cbbNamXuatBan";
            this.cbbNamXuatBan.Size = new System.Drawing.Size(188, 21);
            this.cbbNamXuatBan.TabIndex = 44;
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(92, 85);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(188, 21);
            this.cbbTacGia.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Trị giá";
            // 
            // dtPickerNgayNhap
            // 
            this.dtPickerNgayNhap.Location = new System.Drawing.Point(392, 31);
            this.dtPickerNgayNhap.Name = "dtPickerNgayNhap";
            this.dtPickerNgayNhap.Size = new System.Drawing.Size(188, 20);
            this.dtPickerNgayNhap.TabIndex = 46;
            // 
            // txtNhaXuatBan
            // 
            this.txtNhaXuatBan.Location = new System.Drawing.Point(392, 6);
            this.txtNhaXuatBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhaXuatBan.Name = "txtNhaXuatBan";
            this.txtNhaXuatBan.Size = new System.Drawing.Size(188, 20);
            this.txtNhaXuatBan.TabIndex = 45;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(92, 58);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(188, 21);
            this.cbbTheLoai.TabIndex = 42;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(92, 32);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(188, 20);
            this.txtTenSach.TabIndex = 41;
            // 
            // txtTriGia
            // 
            this.txtTriGia.Location = new System.Drawing.Point(392, 59);
            this.txtTriGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(188, 20);
            this.txtTriGia.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Năm xuất bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nhà xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tên sách";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(297, 285);
            this.btnChon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(104, 29);
            this.btnChon.TabIndex = 59;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(81, 285);
            this.btnXemTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(104, 29);
            this.btnXemTatCa.TabIndex = 60;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // FormTimSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 325);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.cbbTinhTrang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtIDSach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbNamXuatBan);
            this.Controls.Add(this.cbbTacGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPickerNgayNhap);
            this.Controls.Add(this.txtNhaXuatBan);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtTriGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gvSach);
            this.Controls.Add(this.paneldangnhap);
            this.Controls.Add(this.btnTraCuu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTimSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu sách";
            this.paneldangnhap.ResumeLayout(false);
            this.paneldangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).EndInit();
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
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView gvSach;
        private Button btnHuy;
        private ComboBox cbbTinhTrang;
        private Label label11;
        private TextBox txtIDSach;
        private Label label8;
        private ComboBox cbbNamXuatBan;
        private ComboBox cbbTacGia;
        private Label label7;
        private DateTimePicker dtPickerNgayNhap;
        private TextBox txtNhaXuatBan;
        private ComboBox cbbTheLoai;
        private TextBox txtTenSach;
        private TextBox txtTriGia;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnChon;
        private Button btnXemTatCa;
    }
}

