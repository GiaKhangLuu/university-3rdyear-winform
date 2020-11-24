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

namespace GUI
{
    public partial class FormChiTietPhieuMuon : Form
    {
        public FormChiTietPhieuMuon(int idPhieuMuon, string tenDocGia, string ngayMuon)
        {
            InitializeComponent();
            Init(idPhieuMuon, tenDocGia, ngayMuon);
        }

        private void LoadCT_PhieuMuonByIDPhieuMuon(int idPhieuMuon)
        {
            gvChiTietPhieuMuon.DataSource = CT_PhieuMuonBUS.LoadCT_PhieuMuonByIDPhieuMuon(idPhieuMuon);
        }

        private void Init(int idPhieuMuon, string tenDocGia, string ngayMuon)
        {
            txtTenDocGia.Text = tenDocGia;
            txtNgayMuon.Text = ngayMuon;
            LoadCT_PhieuMuonByIDPhieuMuon(idPhieuMuon);
            EditGridView();
        }

        private void EditGridView()
        {
            gvChiTietPhieuMuon.Columns[0].HeaderText = "ID sách";
            gvChiTietPhieuMuon.Columns[1].HeaderText = "Tên sách";
            gvChiTietPhieuMuon.Columns[1].Width = 130;
            gvChiTietPhieuMuon.Columns[2].HeaderText = "Thể loại";
            gvChiTietPhieuMuon.Columns[3].HeaderText = "Tác giả";
            gvChiTietPhieuMuon.Columns[3].Width = 130;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
