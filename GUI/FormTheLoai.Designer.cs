﻿using System.Windows.Forms;

namespace GUI
{
    partial class FormTheLoai
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaTheLoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.gvTheLoai = new System.Windows.Forms.DataGridView();
            this.paneldangnhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTheLoai)).BeginInit();
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
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(234, 11);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 28);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Thể loại";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaTheLoai);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenTheLoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(219, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thể loại";
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.Enabled = false;
            this.txtMaTheLoai.Location = new System.Drawing.Point(72, 29);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(126, 20);
            this.txtMaTheLoai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã thể loại";
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Location = new System.Drawing.Point(72, 64);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(126, 20);
            this.txtTenTheLoai.TabIndex = 2;
            this.txtTenTheLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenTheLoai_KeyPress);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(234, 75);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 28);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(234, 107);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 28);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(234, 43);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 28);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gvTheLoai
            // 
            this.gvTheLoai.AllowUserToAddRows = false;
            this.gvTheLoai.AllowUserToDeleteRows = false;
            this.gvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTheLoai.Location = new System.Drawing.Point(11, 139);
            this.gvTheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.gvTheLoai.MultiSelect = false;
            this.gvTheLoai.Name = "gvTheLoai";
            this.gvTheLoai.RowTemplate.Height = 24;
            this.gvTheLoai.Size = new System.Drawing.Size(328, 116);
            this.gvTheLoai.TabIndex = 7;
            // 
            // FormTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 264);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gvTheLoai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.paneldangnhap);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thể loại";
            this.paneldangnhap.ResumeLayout(false);
            this.paneldangnhap.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel paneldangnhap;
        private System.Windows.Forms.TextBox txtdnmatkhau;
        private System.Windows.Forms.Button bttdndangnhap;
        private System.Windows.Forms.TextBox txtdntaikhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThem;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtTenTheLoai;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMaTheLoai;
        private Label label1;
        private Button btnLuu;
        private DataGridView gvTheLoai;
    }
}

