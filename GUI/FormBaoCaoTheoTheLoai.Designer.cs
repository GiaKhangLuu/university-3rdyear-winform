namespace GUI
{
    partial class FormBaoCaoTheoTheLoai
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
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.gvBaoCao = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongSoLuotMuon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(70, 18);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(68, 21);
            this.cbbThang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng";
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(144, 16);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnLapBaoCao.TabIndex = 1;
            this.btnLapBaoCao.Text = "Lập báo cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = true;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // gvBaoCao
            // 
            this.gvBaoCao.AllowUserToAddRows = false;
            this.gvBaoCao.AllowUserToDeleteRows = false;
            this.gvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBaoCao.Location = new System.Drawing.Point(12, 45);
            this.gvBaoCao.Name = "gvBaoCao";
            this.gvBaoCao.Size = new System.Drawing.Size(390, 150);
            this.gvBaoCao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số lượt mượn: ";
            // 
            // txtTongSoLuotMuon
            // 
            this.txtTongSoLuotMuon.Enabled = false;
            this.txtTongSoLuotMuon.Location = new System.Drawing.Point(110, 205);
            this.txtTongSoLuotMuon.Name = "txtTongSoLuotMuon";
            this.txtTongSoLuotMuon.Size = new System.Drawing.Size(82, 20);
            this.txtTongSoLuotMuon.TabIndex = 3;
            // 
            // FormBaoCaoTheoTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 245);
            this.Controls.Add(this.txtTongSoLuotMuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvBaoCao);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbThang);
            this.Name = "FormBaoCaoTheoTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tình hình mượn sách theo thể loại";
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.DataGridView gvBaoCao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongSoLuotMuon;
    }
}