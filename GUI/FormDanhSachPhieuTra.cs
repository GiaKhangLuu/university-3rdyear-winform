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
    public partial class FormDanhSachPhieuTra : Form
    {
        public FormDanhSachPhieuTra()
        {
            InitializeComponent();
            LoadPhieuTra();
        }

        private void LoadDocGia()
        {
            cbbTenDocGia.DataSource = PhieuTraBUS.GetDocGias();
            cbbTenDocGia.DisplayMember = "HoTen";
        }

        private void EditGridView()
        {
            gvDanhSachPhieuTra.Columns[0].Visible = false;
            gvDanhSachPhieuTra.Columns[1].HeaderText = "Họ tên độc giả";
            gvDanhSachPhieuTra.Columns[1].Width = 130;
            gvDanhSachPhieuTra.Columns[2].HeaderText = "Ngày trả";
            gvDanhSachPhieuTra.Columns[3].HeaderText = "Tổng tiền phạt";
            gvDanhSachPhieuTra.Columns[3].Width = 70;
        }

        private void LoadPhieuTra()
        {
            gvDanhSachPhieuTra.DataSource = PhieuTraBUS.LoadPhieuTra();
            EditGridView();
        }

        private void btnXemChiTietPhieuMuon_Click(object sender, EventArgs e)
        {
            if (gvDanhSachPhieuTra.SelectedRows.Count != 0)
            {
                DataGridViewRow row = gvDanhSachPhieuTra.SelectedRows[0];
                int idPhieuTra = Int32.Parse(row.Cells[0].Value.ToString());
                string tenDocGia = row.Cells[1].Value.ToString();
                string ngayTra = row.Cells[2].Value.ToString();
                FormChiTietPhieuTra form = new FormChiTietPhieuTra(idPhieuTra, tenDocGia, ngayTra);
                form.Show();
            }
            else
            {
                MessageBox.Show(this, "Vui lòng chọn phiếu trả để có thể xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            chbTenDocGia.Checked = false;
            chbNgayTra.Checked = false;
            gvDanhSachPhieuTra.DataSource = null;
            LoadPhieuTra();
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
                if (!chbNgayTra.Checked && !chbTenDocGia.Checked)
                {
                    btnLoc.Enabled = false;
                }
            }
        }

        private void chbNgayMuon_CheckedChanged(object sender, EventArgs e)
        {
            if(chbNgayTra.Checked)
            {
                dtPickerNgayTra.Enabled = true;
                btnLoc.Enabled = true;
            }
            else
            {
                dtPickerNgayTra.Enabled = false;
                if(!chbNgayTra.Checked && ! chbTenDocGia.Checked)
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
            dtPickerNgayTra.Value = DateTime.Now;
        }

        private bool IsValidate(DateTime ngayTra)
        {
            if (DateTime.Now > ngayTra) return true;
            MessageBox.Show(this, "Vui lòng chọn ngày trước hoặc ngay ngày hôm nay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        { 
            DateTime ngayTra = dtPickerNgayTra.Value.Date;
            if(IsValidate(ngayTra))
            {
                gvDanhSachPhieuTra.DataSource = null;
                if (chbTenDocGia.Checked && chbNgayTra.Checked)
                {
                    int idDocGia = ((DOCGIA)cbbTenDocGia.SelectedItem).IDDocGia;
                    gvDanhSachPhieuTra.DataSource = PhieuTraBUS.LocPhieuTra(idDocGia, ngayTra);
                    EditGridView();
                }
                else if (chbTenDocGia.Checked)
                {
                    int idDocGia = ((DOCGIA)cbbTenDocGia.SelectedItem).IDDocGia;
                    gvDanhSachPhieuTra.DataSource = PhieuTraBUS.LocPhieuTraByIDDocGia(idDocGia);
                    EditGridView();
                }
                else
                {
                    gvDanhSachPhieuTra.DataSource = PhieuTraBUS.LocPhieuTraByNgay(ngayTra);
                    EditGridView();
                }
            }
            
             
        }
    }
}
