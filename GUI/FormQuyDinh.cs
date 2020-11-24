using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;

namespace GUI
{
    public partial class FormQuyDinh : Form
    {
        public FormQuyDinh()
        {
            InitializeComponent();
            LoadThamSo();
        }

        public void LoadThamSo()
        {
            //ThamSoBUS tsBUS = new ThamSoBUS();
            THAMSO thamso = ThamSoBUS.LoadThamSo();
            txtTuoiToiThieu.Text = thamso.TuoiToiThieu.ToString();
            txtTuoiToiDa.Text = thamso.TuoiToiDa.ToString();
            txtThoiHanGiaTriThe.Text = thamso.ThoiHanGiaTriThe.ToString();
            txtKhoangCachNamXuatBan.Text = thamso.KhoangCachNamXuatBanToiDa.ToString();
            txtSoLuongSachMuon.Text = thamso.SoLuongSachMuonToiDa.ToString();
            txtSoNgayMuon.Text = thamso.SoNgayMuonToiDa.ToString();
            txtTienPhat.Text = thamso.TienPhat.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int tuoiToiThieu = Int32.Parse(txtTuoiToiThieu.Text);
            int tuoiToiDa = Int32.Parse(txtTuoiToiDa.Text);
            int thoiHanGTThe = Int32.Parse(txtThoiHanGiaTriThe.Text);
            int khoangCachNXB = Int32.Parse(txtKhoangCachNamXuatBan.Text);
            int soLuongSachMuon = Int32.Parse(txtSoLuongSachMuon.Text);
            int soNgayMuon = Int32.Parse(txtSoNgayMuon.Text);
            int tienPhat = Int32.Parse(txtTienPhat.Text);
            try
            {
                ThamSoBUS.UpdateThamSo(tuoiToiThieu, tuoiToiDa, thoiHanGTThe, khoangCachNXB, soLuongSachMuon, soNgayMuon, tienPhat);
                MessageBox.Show(this, "Cập nhật quy định thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadThamSo();
            }
            catch
            {
                MessageBox.Show(this, "Không thể cập nhật quy định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
