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
    public partial class FormTraSach : Form
    {
        private int idDocGia;
        public FormTraSach()
        {
            idDocGia = -1;
            InitializeComponent();
        }

        private void btnDanhSachPhieuTra_Click(object sender, EventArgs e)
        {
            FormDanhSachPhieuTra form = new FormDanhSachPhieuTra();
            form.Show();
        }

        private void AddSachDataBinding()
        {
            // Clear old data binding
            txtIDSach.DataBindings.Clear();
            dtPickerNgayMuon.DataBindings.Clear();
            txtIDPhieuMuon.DataBindings.Clear();
            // Add new data binding
            txtIDSach.DataBindings.Add(new Binding("Text", cbbTenSach.DataSource, "IDSach"));
            dtPickerNgayMuon.DataBindings.Add(new Binding("Value", cbbTenSach.DataSource, "NgayMuon"));
            txtIDPhieuMuon.DataBindings.Add(new Binding("Text", cbbTenSach.DataSource, "IDPhieuMuon"));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (gvTraSach.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Bạn chưa chọn sách để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show(this, $"Bạn có muốn xóa sách { gvTraSach.SelectedRows[0].Cells[2].Value } khỏi phiếu chi tiết",
                "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvTraSach.Rows.Remove(gvTraSach.SelectedRows[0]);
            }
        }

        private bool IsDuplicate(string idSach, string tenSach)
        {
            foreach (DataGridViewRow row in gvTraSach.Rows)
            {
                if (row.Cells[1].Value.ToString() == idSach)
                {
                    MessageBox.Show(this, $"Sách { tenSach } đã có trong phiếu chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string idPhieuMuon = txtIDPhieuMuon.Text;
            string idSach = txtIDSach.Text;
            string tenSach = cbbTenSach.Text;
            DateTime ngayMuon = dtPickerNgayMuon.Value;
            DateTime ngayTra = dtPickerHomNay.Value;
            if (IsDuplicate(idSach, tenSach)) return;
            gvTraSach.Rows.Add(PhieuTraBUS.AddDetail(idPhieuMuon, idSach, tenSach, ngayMuon, ngayTra));
        }

        private void txtIDSach_TextChanged(object sender, EventArgs e)
        {
            if (txtIDSach.Text != "") btnThem.Enabled = true;
            else
            {
                btnThem.Enabled = false;
                txtTienPhat.Text = "";
                txtTongNoMoi.Text = "";
            }
                
        }

        private void UpdateNo()
        {
            int tongNo = 0;
            foreach (DataGridViewRow row in gvTraSach.Rows)
            {
                tongNo += Int32.Parse(row.Cells["colTienPhat"].Value.ToString());
            }
            int tongNoMoi = Int32.Parse(txtNo.Text) + tongNo;
            txtTienPhat.Text = tongNo.ToString();
            txtTongNoMoi.Text = tongNoMoi.ToString();
        }

        private void gvTraSach_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateNo();
            btnLapPhieuTra.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void gvTraSach_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView gv = sender as DataGridView;
            if (gv.Rows.Count == 0)
            {
                btnLapPhieuTra.Enabled = false;
                btnHuy.Enabled = false;
                txtTongNoMoi.Text = "";
                txtTienPhat.Text = "";
            }
            else
            {
                UpdateNo();
            }
        }

        private int[] GetIDSachs()
        {
            int[] idSachs = new int[gvTraSach.Rows.Count];
            int count = 0;
            foreach (DataGridViewRow row in gvTraSach.Rows)
            {
                idSachs[count] = Int32.Parse(row.Cells["colIDSach"].Value.ToString());
                count++;
            }
            return idSachs;
        }

        private int[] GetSoNgayMuons()
        {
            int[] soNgayMuons = new int[gvTraSach.Rows.Count];
            int count = 0;
            foreach (DataGridViewRow row in gvTraSach.Rows)
            {
                soNgayMuons[count] = Int32.Parse(row.Cells["colSoNgayMuon"].Value.ToString());
                count++;
            }
            return soNgayMuons;
        }

        private int[] GetTienPhat()
        {
            int[] tienPhats = new int[gvTraSach.Rows.Count];
            int count = 0;
            foreach (DataGridViewRow row in gvTraSach.Rows)
            {
                tienPhats[count] = Int32.Parse(row.Cells["colTienPhat"].Value.ToString());
                count++;
            }
            return tienPhats;
        }

        private int[] GetIDPhieuMuons()
        {
            int[] idPhieuMuons = new int[gvTraSach.Rows.Count];
            int count = 0;
            foreach (DataGridViewRow row in gvTraSach.Rows)
            {
                idPhieuMuons[count] = Int32.Parse(row.Cells["colIDPhieuMuon"].Value.ToString());
                count++;
            }
            return idPhieuMuons;
        }

        private void btnLapPhieuTra_Click(object sender, EventArgs e)
        {
            int[] idPhieuMuons = GetIDPhieuMuons();
            int[] idSachs = GetIDSachs();
            int[] soNgayMuons = GetSoNgayMuons();
            int[] tienPhats = GetTienPhat();
            PhieuTraBUS.MakePhieuTra(txtIDDocGia.Text, dtPickerHomNay.Value, idSachs, idPhieuMuons, soNgayMuons, tienPhats, txtTongNoMoi.Text);
            MessageBox.Show(this, "Lập phiếu trả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gvTraSach.Rows.Clear();
            gvTraSach.Rows.Clear();
            cbbTenSach.DataSource = null;
            cbbTenSach.Text = "Không có sách chưa trả";
            txtIDSach.Text = "";
            dtPickerNgayMuon.Value = DateTime.Now;
            txtIDPhieuMuon.Text = "";
            txtIDDocGia.Text = "";
            txtTenDocGia.Text = "";
            txtNo.Text = "";
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
                txtNo.Text = "";
            }
        }

        private void LoadDocGia()
        {
            DOCGIA dg = DocGiaBUS.FindDocGiaById(idDocGia);
            txtIDDocGia.Text = dg.IDDocGia.ToString();
            txtTenDocGia.Text = dg.HoTen;
            txtNo.Text = dg.TongNo.ToString();
        }

        private void txtIDDocGia_TextChanged(object sender, EventArgs e)
        {
            gvTraSach.Rows.Clear();
            cbbTenSach.DataSource = null;
            cbbTenSach.Text = "Không có sách chưa trả";
            txtIDSach.Text = "";
            dtPickerNgayMuon.Value = DateTime.Now;
            txtIDPhieuMuon.Text = "";
            if (txtIDDocGia.Text != "")
            {           
                int idDocGia = Int32.Parse(txtIDDocGia.Text);
                var sachChuaTras = PhieuTraBUS.GetSachChuaTra(idDocGia);
                if (sachChuaTras.Count > 0)
                {
                    cbbTenSach.DataSource = sachChuaTras;
                    cbbTenSach.DisplayMember = "TenSach";
                    AddSachDataBinding();
                }           
            }
        }
    }
}
