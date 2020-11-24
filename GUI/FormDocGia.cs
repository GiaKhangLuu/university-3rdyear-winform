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
    public partial class FormDocGia : Form
    {
        public FormDocGia()
        {
            InitializeComponent();
            InitLoaiDocGia();
            LoadDocGia();
            EditCompo();
        }

        private void InitLoaiDocGia()
        {
            var loaiDocGias = LoaiDocGiaBUS.LoadLoaiDocGia();
            cbbLoaiDocGia.DataSource = loaiDocGias;
            cbbLoaiDocGia.DisplayMember = "TenLoaiDocGia";
        }

        private void EditCompo()
        {
            // Set name
            gvDocGia.Columns[0].HeaderText = "ID độc giả";
            gvDocGia.Columns[1].HeaderText = "Tên độc giả";
            gvDocGia.Columns[2].HeaderText = "Loại độc giả";
            gvDocGia.Columns[3].HeaderText = "Ngày sinh";
            gvDocGia.Columns[4].HeaderText = "Địa chỉ";
            gvDocGia.Columns[5].HeaderText = "Email";
            gvDocGia.Columns[6].HeaderText = "Ngày lập thẻ";
            gvDocGia.Columns[7].HeaderText = "Tổng nợ";
            // Set width
            gvDocGia.Columns[0].Width = 80;
            gvDocGia.Columns[1].Width = 150;
            gvDocGia.Columns[2].Width = 80;
            gvDocGia.Columns[3].Width = 100;
            gvDocGia.Columns[4].Width = 130;
            gvDocGia.Columns[5].Width = 130;
            gvDocGia.Columns[6].Width = 100;
            gvDocGia.Columns[7].Width = 80;
        }

        private void LoadDocGia()
        {
            gvDocGia.DataSource = null;
            gvDocGia.DataSource = DocGiaBUS.LoadDocGia();
            AddDataBinding();
        }

        private void AddDataBinding()
        {
            // Clear
            txtIDDocGia.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            cbbLoaiDocGia.DataBindings.Clear();
            dtPickerNgayLapThe.DataBindings.Clear();
            dtPickerNgaySinh.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtTongNo.DataBindings.Clear();

            txtIDDocGia.DataBindings.Add(new Binding("Text", gvDocGia.DataSource, "IDDocGia", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", gvDocGia.DataSource, "TenDocGia", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", gvDocGia.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            cbbLoaiDocGia.DataBindings.Add(new Binding("Text", gvDocGia.DataSource, "LoaiDocGia", true, DataSourceUpdateMode.Never));
            dtPickerNgaySinh.DataBindings.Add(new Binding("Value", gvDocGia.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            dtPickerNgayLapThe.DataBindings.Add(new Binding("Value", gvDocGia.DataSource, "NgayLapThe", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", gvDocGia.DataSource, "Email", true, DataSourceUpdateMode.Never));
            txtTongNo.DataBindings.Add(new Binding("Text", gvDocGia.DataSource, "TongNo", true, DataSourceUpdateMode.Never));
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {

        }

        private void btnXemLoaiDocGia_Click(object sender, EventArgs e)
        {
            FormLoaiDocGia form = new FormLoaiDocGia();
            form.Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            FormTraCuuDocGia form = new FormTraCuuDocGia();
            form.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtIDDocGia.Text = "";
            txtHoTen.Text = "";
            cbbLoaiDocGia.SelectedIndex = 0;
            txtDiaChi.Text = "";
            dtPickerNgaySinh.Value = DateTime.Now;
            dtPickerNgayLapThe.Value = DateTime.Now;
            txtEmail.Text = "";
            txtTongNo.Text = "";
            btnLuu.Enabled = true;
        }

        private bool IsEmpty(string tenDG, string diaChi, string email)
        {
            if (tenDG == "" || diaChi == "" || email == "")
            {
                MessageBox.Show(this, "Bạn chưa điền đầy đủ thông tin độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool IsDocGiaValid(DateTime ngaySinh)
        {
            int tuoiToiThieu = ThamSoBUS.GetTuoiToiThieu();
            int tuoiToiDa = ThamSoBUS.GetTuoiToiDa();
            int tuoiDG = DateTime.Now.Year - ngaySinh.Year;
            if(tuoiToiThieu <= tuoiDG && tuoiDG <= tuoiToiDa)
            {
                return true;
            }
            MessageBox.Show(this, "Tuổi độc giả không phù hợp với quy định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenDG = txtHoTen.Text;
            int idLoaiDG = ((LOAIDOCGIA)cbbLoaiDocGia.SelectedItem).IDLoaiDocGia;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            DateTime ngayLapThe = dtPickerNgayLapThe.Value;
            DateTime ngaySinh = dtPickerNgaySinh.Value;
            if (!IsEmpty(tenDG, diaChi, email))
            {
                if(IsDocGiaValid(ngaySinh))
                {
                    try
                    {
                        DocGiaBUS.AddDocGia(tenDG, idLoaiDG, ngaySinh, diaChi, email, ngayLapThe);
                        MessageBox.Show(this, "Thêm độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDocGia();
                        btnLuu.Enabled = false;
                        
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không thể thêm độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    return;
                }         
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idDG = txtIDDocGia.Text;
            string tenDG = txtHoTen.Text;
            int idLoaiDG = ((LOAIDOCGIA)cbbLoaiDocGia.SelectedItem).IDLoaiDocGia;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            DateTime ngayLapThe = dtPickerNgayLapThe.Value;
            DateTime ngaySinh = dtPickerNgaySinh.Value;
            if (idDG != "")
            {
                if (!IsEmpty(tenDG, diaChi, email))
                {
                    DocGiaBUS.UpdateDocGia(Int32.Parse(idDG), tenDG, idLoaiDG, ngaySinh, diaChi, email, ngayLapThe);
                    MessageBox.Show(this, "Cập nhật độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDocGia();
                    return;
                }
            }
            else
            {
                MessageBox.Show(this, "Bạn chưa chọn độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idDG = txtIDDocGia.Text;
            string tenDG = txtHoTen.Text;
            if (idDG != "")
            {
                if (MessageBox.Show(this, $"Bạn có muốn xóa độc giả { tenDG } không ?", "Xác nhận", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DocGiaBUS.DeleteDocGia(Int32.Parse(idDG));
                        MessageBox.Show(this, "Xóa độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDocGia();
                    }
                    catch 
                    {
                        MessageBox.Show(this, $"Không thể xóa độc giả { tenDG }", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                return;
            }
            else
            {
                MessageBox.Show(this, "Bạn chưa chọn độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
