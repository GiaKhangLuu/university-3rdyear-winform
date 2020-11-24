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
    public partial class FormDanhSachPhieuMuon : Form
    {
        public FormDanhSachPhieuMuon()
        {
            InitializeComponent();
            LoadPhieuMuon();
        }

        private void LoadDocGia()
        {
            cbbTenDocGia.DataSource = PhieuMuonBUS.GetDocGias();
            cbbTenDocGia.DisplayMember = "HoTen";
        }

        private void EditGridView()
        {
            gvDanhSachPhieuMuon.Columns[0].Visible = false;
            gvDanhSachPhieuMuon.Columns[1].HeaderText = "Họ tên độc giả";
            gvDanhSachPhieuMuon.Columns[1].Width = 130;
            gvDanhSachPhieuMuon.Columns[2].HeaderText = "Ngày mượn";
            gvDanhSachPhieuMuon.Columns[3].HeaderText = "Số lượng sách mượn";
            gvDanhSachPhieuMuon.Columns[3].Width = 70;
        }

        private void LoadPhieuMuon()
        {
            gvDanhSachPhieuMuon.DataSource = PhieuMuonBUS.LoadPhieuMuon();
            EditGridView();
        }

        private void btnXemChiTietPhieuMuon_Click(object sender, EventArgs e)
        {
            if(gvDanhSachPhieuMuon.SelectedRows.Count != 0)
            {
                DataGridViewRow row = gvDanhSachPhieuMuon.SelectedRows[0];
                int idPhieuMuon = Int32.Parse(row.Cells[0].Value.ToString());
                string tenDocGia = row.Cells[1].Value.ToString();
                string ngayMuon = row.Cells[2].Value.ToString();
                FormChiTietPhieuMuon form = new FormChiTietPhieuMuon(idPhieuMuon, tenDocGia, ngayMuon);
                form.Show();
            }
            else 
            {
                MessageBox.Show(this, "Vui lòng chọn phiếu mượn để có thể xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            chbTenDocGia.Checked = false;
            chbNgayMuon.Checked = false;
            gvDanhSachPhieuMuon.DataSource = null;
            LoadPhieuMuon();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chbTenDocGia.Checked)
            {
                cbbTenDocGia.Enabled = true;
                btnLoc.Enabled = true;
            }
            else
            {
                cbbTenDocGia.Enabled = false;
                if (!chbNgayMuon.Checked && !chbTenDocGia.Checked)
                {
                    btnLoc.Enabled = false;
                }
            }
        }

        private void chbNgayMuon_CheckedChanged(object sender, EventArgs e)
        {
            if(chbNgayMuon.Checked)
            {
                dtPickerNgayMuon.Enabled = true;
                btnLoc.Enabled = true;
            }
            else
            {
                dtPickerNgayMuon.Enabled = false;
                if(!chbNgayMuon.Checked && ! chbTenDocGia.Checked)
                {
                    btnLoc.Enabled = false;
                }
            }
        }

        private void cbbTenDocGia_EnabledChanged(object sender, EventArgs e)
        {
            if(cbbTenDocGia.Enabled)
            {
                LoadDocGia();
            }
            else
            {
                cbbTenDocGia.DataSource = null;
                cbbTenDocGia.Text = "";
            }
        }

        private void dtPickerNgayMuon_EnabledChanged(object sender, EventArgs e)
        {
            dtPickerNgayMuon.Value = DateTime.Now;
        }

        private bool IsValidate(DateTime ngayMuon)
        {
            if (DateTime.Now > ngayMuon) return true;
            MessageBox.Show(this, "Vui lòng chọn ngày trước hoặc ngay ngày hôm nay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        { 
            DateTime ngayMuon = dtPickerNgayMuon.Value.Date;
            if(IsValidate(ngayMuon))
            {
                gvDanhSachPhieuMuon.DataSource = null;
                if (chbTenDocGia.Checked && chbNgayMuon.Checked)
                {
                    int idDocGia = ((DOCGIA)cbbTenDocGia.SelectedItem).IDDocGia;
                    gvDanhSachPhieuMuon.DataSource = PhieuMuonBUS.LocPhieuMuon(idDocGia, ngayMuon);
                    EditGridView();
                }
                else if (chbTenDocGia.Checked)
                {
                    int idDocGia = ((DOCGIA)cbbTenDocGia.SelectedItem).IDDocGia;
                    gvDanhSachPhieuMuon.DataSource = PhieuMuonBUS.LocPhieuMuonByIDDocGia(idDocGia);
                    EditGridView();
                }
                else
                {
                    gvDanhSachPhieuMuon.DataSource = PhieuMuonBUS.LocPhieuMuonByNgay(ngayMuon);
                    EditGridView();
                }
            }
            
             
        }
    }
}
