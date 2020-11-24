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
    public partial class FormTimSach : Form
    {
        int idSach, namXuatBan, idSachChon;
        string tenSach, tenTacGia, tenTheLoai, nhaXuatBan;
        DateTime ngayNhap;
        bool tinhTrang;
        double triGia;

        public int IdSachChon { get => idSachChon; set => idSachChon = value; }

        public FormTimSach()
        {
            IdSachChon = -1;
            InitializeComponent();
            LoadTheLoai();
            LoadTacGia();
            LoadNamXuatBan();
        }

        private void LoadTheLoai()
        {
            List<THELOAI> theloais = SachBUS.GetTheLoais();
            theloais.ForEach(theloai => cbbTheLoai.Items.Add(((THELOAI)theloai).TenTheLoai));
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (gvSach.SelectedRows.Count > 0)
            {
                IdSachChon = Int32.Parse(gvSach.SelectedRows[0].Cells[0].Value.ToString());
                this.Dispose();
            }
            else
            {
                MessageBox.Show(this, "Vui lòng chọn sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            gvSach.DataSource = null;
            gvSach.DataSource = SachBUS.FindAll();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoadTacGia()
        {
            List<TACGIA> tacgias = SachBUS.GetTacGias();
            tacgias.ForEach(tacgia => cbbTacGia.Items.Add(((TACGIA)tacgia).TenTacGia));
        }

        private void LoadNamXuatBan()
        {
            var namXuatBans = SachBUS.GetNamXuatBan();
            foreach (var namXuatBan in namXuatBans) { cbbNamXuatBan.Items.Add(namXuatBan); };
        }

        private void PreProcess()
        {
            string idSach = txtIDSach.Text;
            string tenSach = txtTenSach.Text;
            string tenTheLoai = cbbTheLoai.Text;
            string tenTacGia = cbbTacGia.Text;
            string nxb = txtNhaXuatBan.Text;
            string namXuatBan = cbbNamXuatBan.Text;
            DateTime ngayNhap = dtPickerNgayNhap.Value;
            string triGia = txtTriGia.Text;
            int tinhTrang = cbbTinhTrang.SelectedIndex;

            this.idSach = idSach == "" ? -1 : Int32.Parse(idSach);
            this.tenSach = tenSach;
            this.tenTacGia = tenTacGia;
            this.tenTheLoai = tenTheLoai;
            this.namXuatBan = namXuatBan == "" ? -1 : Int32.Parse(namXuatBan);
            this.nhaXuatBan = nxb;
            this.ngayNhap = ngayNhap;
            this.triGia = triGia == "" ? -1 : Double.Parse(triGia);
            this.tinhTrang = tinhTrang == 0 ? true : false;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            gvSach.DataSource = null;
            PreProcess();
            
                if(SachBUS.FindSach(idSach, tenSach, tenTacGia, tenTheLoai, namXuatBan, 
                    nhaXuatBan, ngayNhap, triGia, tinhTrang).Count != 0)
                {
                    gvSach.DataSource = SachBUS.FindSach(idSach, tenSach, tenTacGia, tenTheLoai, namXuatBan, nhaXuatBan, ngayNhap, triGia, tinhTrang);
                    return;
                }
                MessageBox.Show(this, "Không tìm thấy sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            
        }
    }
}
