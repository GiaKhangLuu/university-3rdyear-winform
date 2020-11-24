using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;

namespace GUI
{
    public partial class FormThuTienPhat : Form
    {
        private int idDocGia;
        public FormThuTienPhat()
        {
            idDocGia = -1;
            InitializeComponent();
            LoadPhieuThu();
        }

        private void LoadPhieuThu()
        {
            gvThuTienPhat.DataSource = null;
            var phieuThus = PhieuThuBUS.LoadPhieuThu();
            gvThuTienPhat.DataSource = phieuThus;
        }

        private void txtSoTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!PhieuThuBUS.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtSoTienThu_TextChanged(object sender, EventArgs e)
        {
            TextBox txtThuTien = sender as TextBox;
            if(txtThuTien.Text == "")
            {
                txtConLai.Text = "";
            }
            else
            {
                int tongNo = Int32.Parse(txtTongNo.Text);
                int soTienThu = Int32.Parse(txtThuTien.Text);
                txtConLai.Text = (tongNo - soTienThu).ToString();
            }
        }

        private bool IsValid()
        {
            if (txtSoTienThu.Text == "")
            {
                MessageBox.Show(this, "Bạn chưa nhập số tiền thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Int32.Parse(txtConLai.Text) < 0)
            {
                MessageBox.Show(this, "Số tiền thu không được vượt quá số tiền độc giả đang nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                PhieuThuBUS.AddReceipt(txtIDDocGia.Text, txtSoTienThu.Text, txtTongNo.Text, txtConLai.Text);
                MessageBox.Show(this, "Thu tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTienThu.Text = "";
                txtSoTienThu.Text = "";
                txtIDDocGia.Text = "";
                txtTenDocGia.Text = "";
                txtTongNo.Text = "";
                txtConLai.Text = "";
                LoadPhieuThu();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSoTienThu.Text = "";
            txtIDDocGia.Text = "";
            txtTenDocGia.Text = "";
            txtTongNo.Text = "";
            txtConLai.Text = "";
        }

        private void btnTimDocGia_Click(object sender, EventArgs e)
        {
            FormTimDocGia form = new FormTimDocGia();
            form.Show();
            this.Visible = false;
            form.Disposed += FormTimDG_Disposed;
        }

        private void FormTimDG_Disposed(object sender, EventArgs e)
        {
            FormTimDocGia form = sender as FormTimDocGia;
            this.Visible = true;
            idDocGia = form.IdDocGiaChon;
            if (idDocGia != -1)
            {
                LoadDocGia();
            }
            else
            {
                txtIDDocGia.Text = "";
                txtTenDocGia.Text = "";
                txtTongNo.Text = "";
            }
        }

        private void LoadDocGia()
        {
            DOCGIA dg = DocGiaBUS.FindDocGiaById(idDocGia);
            txtIDDocGia.Text = dg.IDDocGia.ToString();
            txtTenDocGia.Text = dg.HoTen;
            txtTongNo.Text = dg.TongNo.ToString();
        }
    }
}
