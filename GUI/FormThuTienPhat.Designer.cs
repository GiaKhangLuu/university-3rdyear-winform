using System.Windows.Forms;

namespace GUI
{
    partial class FormThuTienPhat
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
            this.txtIDDocGia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThuTien = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.gvThuTienPhat = new System.Windows.Forms.DataGridView();
            this.btnTimDocGia = new System.Windows.Forms.Button();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.paneldangnhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuTienPhat)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTongNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(310, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            // 
            // txtIDDocGia
            // 
            this.txtIDDocGia.Location = new System.Drawing.Point(94, 20);
            this.txtIDDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDDocGia.Name = "txtIDDocGia";
            this.txtIDDocGia.ReadOnly = true;
            this.txtIDDocGia.Size = new System.Drawing.Size(188, 20);
            this.txtIDDocGia.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "ID độc giả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tổng nợ";
            // 
            // txtTongNo
            // 
            this.txtTongNo.Location = new System.Drawing.Point(94, 72);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.ReadOnly = true;
            this.txtTongNo.Size = new System.Drawing.Size(188, 20);
            this.txtTongNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ và tên";
            // 
            // btnThuTien
            // 
            this.btnThuTien.Location = new System.Drawing.Point(12, 255);
            this.btnThuTien.Margin = new System.Windows.Forms.Padding(2);
            this.btnThuTien.Name = "btnThuTien";
            this.btnThuTien.Size = new System.Drawing.Size(154, 35);
            this.btnThuTien.TabIndex = 5;
            this.btnThuTien.Text = "Thu tiền";
            this.btnThuTien.UseVisualStyleBackColor = true;
            this.btnThuTien.Click += new System.EventHandler(this.btnThuTien_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Số tiền thu";
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(93, 28);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(188, 20);
            this.txtSoTienThu.TabIndex = 3;
            this.txtSoTienThu.TextChanged += new System.EventHandler(this.txtSoTienThu_TextChanged);
            this.txtSoTienThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienThu_KeyPress);
            // 
            // txtConLai
            // 
            this.txtConLai.Location = new System.Drawing.Point(93, 54);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.ReadOnly = true;
            this.txtConLai.Size = new System.Drawing.Size(188, 20);
            this.txtConLai.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Còn lại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConLai);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSoTienThu);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thu tiền";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(169, 255);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(152, 35);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // gvThuTienPhat
            // 
            this.gvThuTienPhat.AllowUserToAddRows = false;
            this.gvThuTienPhat.AllowUserToDeleteRows = false;
            this.gvThuTienPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThuTienPhat.Location = new System.Drawing.Point(325, 11);
            this.gvThuTienPhat.Margin = new System.Windows.Forms.Padding(2);
            this.gvThuTienPhat.Name = "gvThuTienPhat";
            this.gvThuTienPhat.RowTemplate.Height = 24;
            this.gvThuTienPhat.Size = new System.Drawing.Size(399, 279);
            this.gvThuTienPhat.TabIndex = 6;
            // 
            // btnTimDocGia
            // 
            this.btnTimDocGia.Location = new System.Drawing.Point(94, 98);
            this.btnTimDocGia.Name = "btnTimDocGia";
            this.btnTimDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnTimDocGia.TabIndex = 44;
            this.btnTimDocGia.Text = "Tìm độc giả";
            this.btnTimDocGia.UseVisualStyleBackColor = true;
            this.btnTimDocGia.Click += new System.EventHandler(this.btnTimDocGia_Click);
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(94, 45);
            this.txtTenDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.ReadOnly = true;
            this.txtTenDocGia.Size = new System.Drawing.Size(188, 20);
            this.txtTenDocGia.TabIndex = 45;
            // 
            // FormThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 301);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paneldangnhap);
            this.Controls.Add(this.btnThuTien);
            this.Controls.Add(this.gvThuTienPhat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThuTienPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu tiền phạt";
            this.paneldangnhap.ResumeLayout(false);
            this.paneldangnhap.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThuTienPhat)).EndInit();
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
        private System.Windows.Forms.Button btnThuTien;
        private Label label7;
        private TextBox txtTongNo;
        private Label label8;
        private TextBox txtSoTienThu;
        private TextBox txtConLai;
        private Label label11;
        private GroupBox groupBox2;
        private Button btnHuy;
        private TextBox txtIDDocGia;
        private Label label12;
        private DataGridView gvThuTienPhat;
        private Button btnTimDocGia;
        private TextBox txtTenDocGia;
    }
}

