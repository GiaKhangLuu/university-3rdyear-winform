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
    public partial class FormLoaiDocGia : Form
    {
        public FormLoaiDocGia()
        {
            InitializeComponent();
            LoadLoaiDocGia();
        }

        private void LoadLoaiDocGia()
        {
            gvLoaiDocGia.DataSource = null;
            var loaiDocGias = LoaiDocGiaBUS.LoadLoaiDocGia();
            gvLoaiDocGia.DataSource = loaiDocGias;
            gvLoaiDocGia.Columns[0].HeaderText = "ID loại độc giả";
            gvLoaiDocGia.Columns[1].HeaderText = "Tên loại độc giả";
            gvLoaiDocGia.Columns[2].Visible = false;
            AddDataBinding();
        }

        private void AddDataBinding()
        {
            txtMaLoaiDocGia.DataBindings.Clear();
            txtLoaiDocGia.DataBindings.Clear();
            txtMaLoaiDocGia.DataBindings.Add(new Binding("Text", gvLoaiDocGia.DataSource , "IDLoaiDocGia", true, DataSourceUpdateMode.Never));
            txtLoaiDocGia.DataBindings.Add(new Binding("Text", gvLoaiDocGia.DataSource, "TenLoaiDocGia", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLoaiDocGia.Text = "";
            txtLoaiDocGia.Text = "";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenLoaiDG = txtLoaiDocGia.Text;
            if (tenLoaiDG != "")
            {
                try
                {
                    LoaiDocGiaBUS.AddLoaiDG(tenLoaiDG);
                    MessageBox.Show(this, "Thêm loại độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiDocGia();
                    btnLuu.Enabled = false;
                }
                catch
                {
                    MessageBox.Show(this, "Không thể thêm loại độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;

            }
            MessageBox.Show(this, "Bạn chưa nhập tên loại độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idLoaiDG = txtMaLoaiDocGia.Text;
            string tenLoaiDG = txtLoaiDocGia.Text;
            if (idLoaiDG != "" && tenLoaiDG != "")

            {
               
                    LoaiDocGiaBUS.UpdateLoaiDG(idLoaiDG, tenLoaiDG);
                    MessageBox.Show(this, "Cập nhật loại độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoaiDocGia();
                return;
            }
            MessageBox.Show(this, "ID loại độc giả và tên loại độc giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idLoaiDG = txtMaLoaiDocGia.Text;
            string tenLoaiDG = txtLoaiDocGia.Text;
            if (idLoaiDG != "" && tenLoaiDG != "")
            {
                if (MessageBox.Show(this, $"Bạn có muốn xóa loại độc giả { tenLoaiDG } không ?", "Xác nhận", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        LoaiDocGiaBUS.DeleteLoaiDG(idLoaiDG);
                        MessageBox.Show(this, "Xóa loại độc giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLoaiDocGia();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không thể xóa loại độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                return;
            }
            MessageBox.Show(this, "ID loại độc giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
