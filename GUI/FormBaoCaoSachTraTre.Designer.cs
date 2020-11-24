namespace GUI
{
    partial class FormBaoCaoSachTraTre
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.gvBaoCao = new System.Windows.Forms.DataGridView();
            this.dtPickerNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngày";
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.Location = new System.Drawing.Point(267, 11);
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
            this.gvBaoCao.Location = new System.Drawing.Point(12, 38);
            this.gvBaoCao.Name = "gvBaoCao";
            this.gvBaoCao.Size = new System.Drawing.Size(390, 150);
            this.gvBaoCao.TabIndex = 2;
            // 
            // dtPickerNgayLap
            // 
            this.dtPickerNgayLap.Location = new System.Drawing.Point(61, 12);
            this.dtPickerNgayLap.Name = "dtPickerNgayLap";
            this.dtPickerNgayLap.Size = new System.Drawing.Size(200, 20);
            this.dtPickerNgayLap.TabIndex = 0;
            // 
            // FormBaoCaoSachTraTre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 204);
            this.Controls.Add(this.dtPickerNgayLap);
            this.Controls.Add(this.gvBaoCao);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoSachTraTre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thống kê sách trả trễ";
            ((System.ComponentModel.ISupportInitialize)(this.gvBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLapBaoCao;
        private System.Windows.Forms.DataGridView gvBaoCao;
        private System.Windows.Forms.DateTimePicker dtPickerNgayLap;
    }
}