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
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
            LoadTheLoai();
            LoadTacGia();
            LoadNamXuatBan();
            LoadSach();
            EditCompo();
        }

        private void LoadTheLoai()
        {
            List<THELOAI> theloais = SachBUS.GetTheLoais();
            cbbTheLoai.DataSource = theloais;
            cbbTheLoai.DisplayMember = "TenTheLoai";
        }

        private void LoadTacGia()
        {
            List<TACGIA> tacgias = SachBUS.GetTacGias();
            cbbTacGia.DataSource = tacgias;
            cbbTacGia.DisplayMember = "TenTacGia";
        }

        private void LoadNamXuatBan()
        {
            var namXuatBans = SachBUS.GetNamXuatBan();
            foreach(var namXuatBan in namXuatBans) { cbbNamXuatBan.Items.Add(namXuatBan); };
        }

        private void EditCompo()
        {
            // Set title
            gvSach.Columns[0].HeaderText = "ID sách";
            gvSach.Columns[1].HeaderText = "Tên sách";
            gvSach.Columns[2].HeaderText = "Tên thể loại";
            gvSach.Columns[3].HeaderText = "Tên tác giả";
            gvSach.Columns[4].HeaderText = "Nhà xuất bản";
            gvSach.Columns[5].HeaderText = "Năm xuất bản";
            gvSach.Columns[6].HeaderText = "Ngày nhập";
            gvSach.Columns[7].HeaderText = "Trị giá";
            gvSach.Columns[8].HeaderText = "Tình trạng";
            // Set width
            gvSach.Columns[0].Width = 70;
            gvSach.Columns[1].Width = 150;
            gvSach.Columns[2].Width = 70;
            gvSach.Columns[3].Width = 150;
            gvSach.Columns[5].Width = 70;
            gvSach.Columns[6].Width = 70;
            gvSach.Columns[7].Width = 70;
            gvSach.Columns[8].Width = 60;
        }

        private void LoadSach()
        {
            gvSach.DataSource = null;
            gvSach.DataSource = SachBUS.LoadSach();
            AddDataBinding();
        }

        private void AddDataBinding()
        {
            // Clear 
            txtIDSach.DataBindings.Clear();
            txtTenSach.DataBindings.Clear();
            txtTriGia.DataBindings.Clear();
            cbbNamXuatBan.DataBindings.Clear();
            txtNhaXuatBan.DataBindings.Clear();
            cbbTacGia.DataBindings.Clear();
            cbbTheLoai.DataBindings.Clear();
            dtPickerNgayNhap.DataBindings.Clear();

            txtIDSach.DataBindings.Add(new Binding("Text", gvSach.DataSource, "IDSach", true, DataSourceUpdateMode.Never));
            txtTenSach.DataBindings.Add(new Binding("Text", gvSach.DataSource, "TenSach", true, DataSourceUpdateMode.Never));
            txtTriGia.DataBindings.Add(new Binding("Text", gvSach.DataSource, "TriGia", true, DataSourceUpdateMode.Never));
            cbbNamXuatBan.DataBindings.Add(new Binding("Text", gvSach.DataSource, "NamXuatBan", true, DataSourceUpdateMode.Never));
            txtNhaXuatBan.DataBindings.Add(new Binding("Text", gvSach.DataSource, "NhaXuatBan", true, DataSourceUpdateMode.Never));
            cbbTacGia.DataBindings.Add(new Binding("Text", gvSach.DataSource, "TenTacGia", true, DataSourceUpdateMode.Never));
            cbbTheLoai.DataBindings.Add(new Binding("Text", gvSach.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
            dtPickerNgayNhap.DataBindings.Add(new Binding("Value", gvSach.DataSource, "NgayNhap", true, DataSourceUpdateMode.Never));
        }

        private void txtIDSach_TextChanged(object sender, EventArgs e)
        {
            if (gvSach.SelectedRows.Count > 0)
            {
                if (Boolean.Parse(gvSach.SelectedRows[0].Cells[8].Value.ToString()) == true)
                {
                    cbbTinhTrang.SelectedIndex = 0;
                }
                else
                {
                    cbbTinhTrang.SelectedIndex = 1;
                }
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            FormTraCuuSach form = new FormTraCuuSach();
            form.Show();
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            FormTheLoai form = new FormTheLoai();
            form.Show();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            FormTacGia form = new FormTacGia();
            form.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtIDSach.Text = "";
            txtTenSach.Text = "";
            cbbTheLoai.SelectedIndex = 0;
            cbbTacGia.SelectedIndex = 0;
            cbbNamXuatBan.SelectedIndex = 0;
            txtNhaXuatBan.Text = "";
            dtPickerNgayNhap.Value = DateTime.Now;
            txtTriGia.Text = "";
            cbbTinhTrang.SelectedIndex = 1;
            btnLuu.Enabled = true;
        }

        private bool IsEmpty(string tenSach, string nxb, string triGia)
        {
            if(tenSach == "" || nxb == "" || triGia == "")
            {
                MessageBox.Show(this, "Bạn chưa điền đầy đủ thông tin sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenSach = txtTenSach.Text;
            int idTheLoai = ((THELOAI)cbbTheLoai.SelectedItem).IDTheLoai;
            int idTacGia = ((TACGIA)cbbTacGia.SelectedItem).IDTacGia;
            int namXuatBan = Int32.Parse(cbbNamXuatBan.SelectedItem.ToString());
            string nxb = txtNhaXuatBan.Text;
            DateTime ngayNhap = dtPickerNgayNhap.Value;
            string triGia = txtTriGia.Text;
            bool tinhTrang = cbbTinhTrang.SelectedIndex == 0 ? true : false;
            if (!IsEmpty(tenSach, nxb, triGia))
            {
                try
                {
                    SachBUS.AddSach(tenSach, idTheLoai, idTacGia, namXuatBan, nxb, ngayNhap, Double.Parse(triGia), tinhTrang);
                    MessageBox.Show(this, "Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSach();
                    btnLuu.Enabled = false;
                    
                }
                catch
                {
                    MessageBox.Show(this, "Không thể thêm sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idSach = txtIDSach.Text;
            string tenSach = txtTenSach.Text;
            int idTheLoai = ((THELOAI)cbbTheLoai.SelectedItem).IDTheLoai;
            int idTacGia = ((TACGIA)cbbTacGia.SelectedItem).IDTacGia;
            int namXuatBan = Int32.Parse(cbbNamXuatBan.SelectedItem.ToString());
            string nxb = txtNhaXuatBan.Text;
            DateTime ngayNhap = dtPickerNgayNhap.Value;
            string triGia = txtTriGia.Text;
            bool tinhTrang = cbbTinhTrang.SelectedIndex == 0 ? true : false;
            if(idSach != "")
            {
                if(!IsEmpty(tenSach, nxb, triGia))
                {
                    SachBUS.UpdateSach(Int32.Parse(idSach), tenSach, idTheLoai, idTacGia, namXuatBan, nxb, ngayNhap, Double.Parse(triGia), tinhTrang);
                    MessageBox.Show(this, "Cập nhật sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSach();
                    return;
                }
            }
            else
            {
                MessageBox.Show(this, "Bạn chưa chọn sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idSach = txtIDSach.Text;
            string tenSach = txtTenSach.Text;
            if(idSach != "")
            {
                if (MessageBox.Show(this, $"Bạn có muốn xóa sách { tenSach } không ?", "Xác nhận", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        SachBUS.DelteSach(Int32.Parse(idSach));
                        MessageBox.Show(this, "Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSach();
                    }
                    catch
                    {
                        MessageBox.Show(this, $"Không thể xóa sách { tenSach }", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                return;
            }
            else
            {
                MessageBox.Show(this, "Bạn chưa chọn sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTriGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
