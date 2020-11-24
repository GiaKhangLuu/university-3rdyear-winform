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
using System.Collections;

namespace GUI
{
    public partial class FormMuonSach : Form
    {
        private int idDocGia, idSach;

        public FormMuonSach()
        {
            idDocGia = -1;
            idSach = -1;
            InitializeComponent();
        }

        private void btnDanhSachPhieuMuon_Click(object sender, EventArgs e)
        {
            FormDanhSachPhieuMuon form = new FormDanhSachPhieuMuon();
            form.Show();
        }

        private bool IsDuplicate(int idSach, string tenSach)
        {
            foreach (DataGridViewRow row in gvMuonSach.Rows)
            {
                if (Int32.Parse(row.Cells[0].Value.ToString()) == idSach)
                {
                    MessageBox.Show(this, $"Sách { tenSach } đã có trong phiếu chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private bool IsSachValid(string tinhTrang, string tenSach)
        {
            if (tinhTrang == "Đang có người mượn")
            {
                MessageBox.Show(this, $"Sách { tenSach } hiện đã có người đang mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string idSach = txtIDSach.Text;
            string tenSach = txtTenSach.Text;
            string tinhTrang = txtTinhTrang.Text;
            if(idSach != "" && tenSach != "" && tinhTrang != "")
            {
                if (IsDuplicate(Int32.Parse(idSach), tenSach) || !IsSachValid(tinhTrang, tenSach)) return;
                gvMuonSach.Rows.Add(new object[] { idSach, tenSach, tinhTrang });
            }
            else
            {
                MessageBox.Show(this, "Bạn chưa chọn sách để thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gvMuonSach_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnLapPhieuMuon.Enabled = true;
            btnXoaChiTiet.Enabled = true;
        }

        private void gvMuonSach_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView gv = sender as DataGridView;
            if (gv.Rows.Count == 0)
            {
                btnLapPhieuMuon.Enabled = false;
                btnXoaChiTiet.Enabled = false;
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (gvMuonSach.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Bạn chưa chọn sách để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show(this, $"Bạn có muốn xóa sách { gvMuonSach.SelectedRows[0].Cells[1].Value } khỏi phiếu chi tiết",
                "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvMuonSach.Rows.Remove(gvMuonSach.SelectedRows[0]);
            }
        }

        private bool IsStillExpiryDate()
        {
            int thoiHanGiaTriThe = PhieuMuonBUS.GetThoiHanGiaTriThe();
            if (dtPickerNgayLapThe.Value.AddMonths(thoiHanGiaTriThe).Subtract(DateTime.Now).Days < 0)
            {
                MessageBox.Show(this, $"Thẻ độc giả của { txtTenDocGia.Text } đã hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool IsSendBookBackOnTime()
        {
            if (cbbSachMuonQuaHan.Items.Count > 0)
            {
                MessageBox.Show(this, "Không thể lập phiếu mượn khi độc giả có sách mượn quá hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                return true;
        }

        private bool IsBorrowingOverMaximum()
        {
            int soLuongSachMuonToiDa = CT_PhieuMuonBUS.GetSoLuongSachMuonToiDa();
            int soLuongSachDaMuon = Int32.Parse(txtSoLuongSachMuon.Text);
            int soLuongSachMuonMuon = gvMuonSach.Rows.Count;
            if (soLuongSachDaMuon + soLuongSachMuonMuon <= soLuongSachMuonToiDa)
            {
                return false;
            }
            int thoiHanMuonSach = CT_PhieuMuonBUS.GetThoiHanMuonSach();
            MessageBox.Show(this,
                $"Chỉ được mượn tối đa { soLuongSachMuonToiDa } quyển sách trong { thoiHanMuonSach } ngày", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        private string[] GetIDSachs()
        {
            string[] idSachs = new string[gvMuonSach.Rows.Count];
            int count = 0;
            foreach (DataGridViewRow row in gvMuonSach.Rows)
            {
                idSachs[count] = row.Cells[0].Value.ToString();
                count++;
            }
            return idSachs;
        }

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {        
            if(txtIDDocGia.Text == "")
            {
                MessageBox.Show(this, "Bạn chưa chọn độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate
            if (!IsStillExpiryDate() || !IsSendBookBackOnTime() || IsBorrowingOverMaximum()) return;
            string[] idSachs = GetIDSachs();
            PhieuMuonBUS.MakeLoan(txtIDDocGia.Text, dtPickerHomNay.Value, idSachs);
            MessageBox.Show(this, "Lập phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gvMuonSach.Rows.Clear();
            // Set txtIDDocGia = "" to call event txtIDDocGia_TextChanged
            txtIDDocGia.Text = "";
            txtTenDocGia.Text = "";
            cbbSachMuonQuaHan.DataSource = null;
            txtSoLuongSachMuon.Text = "";
            dtPickerNgayLapThe.Value = DateTime.Now;
            txtIDSach.Text = "";
            txtTenSach.Text = "";
            txtTinhTrang.Text = "";
        }

        private void SetSachMuonQuaHan(int idDocGia)
        {
            cbbSachMuonQuaHan.DataSource = null;
            IList sachChuaTras = CT_PhieuMuonBUS.GetSachMuonQuaHans(idDocGia);
            if(sachChuaTras.Count == 0)
            {
                cbbSachMuonQuaHan.Text = "Không có sách mượn quá hạn";
                return;
            }
            cbbSachMuonQuaHan.DataSource = sachChuaTras;
            cbbSachMuonQuaHan.DisplayMember = "TenSach";
        }

        private void SetSoLuongSachMuon(int idDocGia)
        {
            int soLuongSachMuon = CT_PhieuMuonBUS.GetSoLuongSachMuonTrongKhoangTG(idDocGia);
            txtSoLuongSachMuon.Text = soLuongSachMuon.ToString();
        }

        private void txtIDDocGia_TextChanged_1(object sender, EventArgs e)
        {
            if (txtIDDocGia.Text != "")
            {
                SetSachMuonQuaHan(Int32.Parse(txtIDDocGia.Text));
                SetSoLuongSachMuon(Int32.Parse(txtIDDocGia.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                cbbSachMuonQuaHan.DataSource = null;
                txtSoLuongSachMuon.Text = "";
                dtPickerNgayLapThe.Value = DateTime.Now;
            }        
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            FormTimSach form = new FormTimSach();
            form.Show();
            this.Visible = false;
            form.Disposed += FormTimSach_Disposed;
        }

        private void FormTimSach_Disposed(object sender, EventArgs e)
        {
            FormTimSach form = sender as FormTimSach;
            this.Visible = true;
            idSach = form.IdSachChon;
            if (idSach != -1)
            {
                LoadSach();
            }
            else
            {
                txtIDSach.Text = "";
                txtTenSach.Text = "";
                txtTinhTrang.Text = "";
            }
        }

        private void LoadSach()
        {
            SACH sach = SachBUS.FindSachById(idSach);
            txtIDSach.Text = sach.IDSach.ToString();
            txtTenSach.Text = sach.TenSach;
            txtTinhTrang.Text = sach.TinhTrang ? "Đang có người mượn" : "Chưa được mượn";
        }

        private void LoadDocGia()
        {
            DOCGIA dg = DocGiaBUS.FindDocGiaById(idDocGia);
            txtIDDocGia.Text = dg.IDDocGia.ToString();
            txtTenDocGia.Text = dg.HoTen;
            dtPickerNgayLapThe.Value = dg.NgayLapThe;
        }
    }
}
