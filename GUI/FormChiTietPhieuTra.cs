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
    public partial class FormChiTietPhieuTra : Form
    {
        public FormChiTietPhieuTra(int idPhieuTra, string tenDocGia, string ngayTra)
        {
            InitializeComponent();
            Init(idPhieuTra, tenDocGia, ngayTra);
        }

        private void LoadCT_PhieuMuonByIDPhieuMuon(int idPhieuTra)
        {
            gvChiTietPhieuTra.DataSource = CT_PhieuTraBus.LoadCT_PhieuTra(idPhieuTra);
        }

        private void Init(int idPhieuTra, string tenDocGia, string ngayTra)
        {
            txtTenDocGia.Text = tenDocGia;
            txtNgayTra.Text = ngayTra;
            LoadCT_PhieuMuonByIDPhieuMuon(idPhieuTra);
            EditGridView();
        }

        private void EditGridView()
        {
            gvChiTietPhieuTra.Columns[0].HeaderText = "ID sách";
            gvChiTietPhieuTra.Columns[1].HeaderText = "Tên sách";
            gvChiTietPhieuTra.Columns[1].Width = 130;
            gvChiTietPhieuTra.Columns[2].HeaderText = "Ngày mượn";
            gvChiTietPhieuTra.Columns[3].HeaderText = "Số ngày mươn";
            gvChiTietPhieuTra.Columns[4].HeaderText = "Tiền phạt";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
