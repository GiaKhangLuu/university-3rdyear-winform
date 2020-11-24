using System.Windows.Forms;

namespace GUI
{
    partial class FormTraCuuDocGia
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
            this.gvDocGia = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtPickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbbLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDDocGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.paneldangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocGia)).BeginInit();
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
            this.btnTraCuu.Location = new System.Drawing.Point(219, 258);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(131, 29);
            this.btnTraCuu.TabIndex = 8;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // gvDocGia
            // 
            this.gvDocGia.AllowUserToAddRows = false;
            this.gvDocGia.AllowUserToDeleteRows = false;
            this.gvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDocGia.Location = new System.Drawing.Point(12, 111);
            this.gvDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.gvDocGia.Name = "gvDocGia";
            this.gvDocGia.RowTemplate.Height = 24;
            this.gvDocGia.Size = new System.Drawing.Size(537, 143);
            this.gvDocGia.TabIndex = 10;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(354, 258);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(131, 29);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Email";
            // 
            // dtPickerNgaySinh
            // 
            this.dtPickerNgaySinh.Location = new System.Drawing.Point(361, 9);
            this.dtPickerNgaySinh.Name = "dtPickerNgaySinh";
            this.dtPickerNgaySinh.Size = new System.Drawing.Size(188, 20);
            this.dtPickerNgaySinh.TabIndex = 46;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(84, 87);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(188, 20);
            this.txtDiaChi.TabIndex = 45;
            // 
            // cbbLoaiDocGia
            // 
            this.cbbLoaiDocGia.FormattingEnabled = true;
            this.cbbLoaiDocGia.Location = new System.Drawing.Point(84, 61);
            this.cbbLoaiDocGia.Name = "cbbLoaiDocGia";
            this.cbbLoaiDocGia.Size = new System.Drawing.Size(188, 21);
            this.cbbLoaiDocGia.TabIndex = 42;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(84, 35);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(188, 20);
            this.txtTenDocGia.TabIndex = 41;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(361, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Loại độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tên độc giả";
            // 
            // dtPickerNgayLapThe
            // 
            this.dtPickerNgayLapThe.Location = new System.Drawing.Point(361, 61);
            this.dtPickerNgayLapThe.Name = "dtPickerNgayLapThe";
            this.dtPickerNgayLapThe.Size = new System.Drawing.Size(188, 20);
            this.dtPickerNgayLapThe.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ngày lập thẻ";
            // 
            // txtIDDocGia
            // 
            this.txtIDDocGia.Location = new System.Drawing.Point(84, 9);
            this.txtIDDocGia.Name = "txtIDDocGia";
            this.txtIDDocGia.Size = new System.Drawing.Size(188, 20);
            this.txtIDDocGia.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "ID độc giả";
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(84, 258);
            this.btnXemTatCa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(131, 29);
            this.btnXemTatCa.TabIndex = 62;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // FormTraCuuDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 298);
            this.Controls.Add(this.btnXemTatCa);
            this.Controls.Add(this.txtIDDocGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtPickerNgayLapThe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPickerNgaySinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.cbbLoaiDocGia);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gvDocGia);
            this.Controls.Add(this.paneldangnhap);
            this.Controls.Add(this.btnTraCuu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTraCuuDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu độc giả";
            this.Load += new System.EventHandler(this.FormTraCuuSach_Load);
            this.paneldangnhap.ResumeLayout(false);
            this.paneldangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDocGia)).EndInit();
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
        private System.Windows.Forms.DataGridView gvDocGia;
        private Button btnHuy;
        private Label label7;
        private DateTimePicker dtPickerNgaySinh;
        private TextBox txtDiaChi;
        private ComboBox cbbLoaiDocGia;
        private TextBox txtTenDocGia;
        private TextBox txtEmail;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtPickerNgayLapThe;
        private Label label4;
        private TextBox txtIDDocGia;
        private Label label5;
        private Button btnXemTatCa;
    }
}

