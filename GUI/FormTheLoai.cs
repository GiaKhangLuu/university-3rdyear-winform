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
    public partial class FormTheLoai : Form
    {
        public FormTheLoai()
        {
            InitializeComponent();
            LoadTheLoai();
        }

        private void LoadTheLoai()
        {
            gvTheLoai.DataSource = null;
            var theloais = TheLoaiBUS.LoadTheLoai();
            gvTheLoai.DataSource = theloais;
            gvTheLoai.Columns[0].HeaderText = "ID thể loại";
            gvTheLoai.Columns[1].HeaderText = "Tên thể loại";
            AddDataBinding();
        }

        private void AddDataBinding()
        {
            txtMaTheLoai.DataBindings.Clear();
            txtTenTheLoai.DataBindings.Clear();
            txtMaTheLoai.DataBindings.Add(new Binding("Text", gvTheLoai.DataSource, "IDTheLoai", true, DataSourceUpdateMode.Never));
            txtTenTheLoai.DataBindings.Add(new Binding("Text", gvTheLoai.DataSource, "TenTheLoai", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text;
            if (tenTheLoai != "")
            {
                try
                {
                    TheLoaiBUS.AddTheLoai(tenTheLoai);
                    MessageBox.Show(this, "Thêm thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTheLoai();
                    btnLuu.Enabled = false;
                }
                catch
                {
                    MessageBox.Show(this, "Không thể thêm thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }
            MessageBox.Show(this, "Bạn chưa nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idTheLoai = txtMaTheLoai.Text;
            string tenTheLoai = txtTenTheLoai.Text;
            if (idTheLoai != "" && tenTheLoai != "")
            {
                
                    TheLoaiBUS.UpdateTheLoai(idTheLoai, tenTheLoai);
                    MessageBox.Show(this, "Cập nhật thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTheLoai();
                return;
            }
            MessageBox.Show(this, "ID thể loại và tên thể loại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idTheLoai = txtMaTheLoai.Text;
            string tenTheLoai = txtTenTheLoai.Text;
            if (idTheLoai != "" && tenTheLoai != "")
            {
                if (MessageBox.Show(this, $"Bạn có muốn xóa thể loại { tenTheLoai } không ?", "Xác nhận", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        TheLoaiBUS.DeleteTheLoai(idTheLoai);
                        MessageBox.Show(this, "Xóa thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTheLoai();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không thể xóa thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                return;
            }
            MessageBox.Show(this, "ID thể loại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtTenTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
