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
    public partial class FormTacGia : Form
    {
        public FormTacGia()
        {
            InitializeComponent();
            LoadTacGia();
        }

        private void LoadTacGia()
        {
            gvTacGia.DataSource = null;
            gvTacGia.DataSource = TacGiaBUS.LoadTacGia();
            gvTacGia.Columns[0].HeaderText = "ID tác giả";
            gvTacGia.Columns[1].HeaderText = "Tên tác giả";
            gvTacGia.Columns[1].Width = 150;
            AddDataBinding();
        }

        private void AddDataBinding()
        {
            txtIDTacGia.DataBindings.Clear();
            txtTenTacGia.DataBindings.Clear();
            txtIDTacGia.DataBindings.Add(new Binding("Text", gvTacGia.DataSource, "IDTacGia", true, DataSourceUpdateMode.Never));
            txtTenTacGia.DataBindings.Add(new Binding("Text", gvTacGia.DataSource, "TenTacGia", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtIDTacGia.Text = "";
            txtTenTacGia.Text = "";
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenTacGia = txtTenTacGia.Text;
            if(tenTacGia != "")
            {
                try
                {
                    TacGiaBUS.AddTacGia(tenTacGia);
                    MessageBox.Show(this, "Thêm tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTacGia();
                    btnLuu.Enabled = false;

                }
                catch
                {
                    MessageBox.Show(this, "Không thể thêm tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            MessageBox.Show(this, "Bạn chưa nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);          
        }

        private void txtTenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idTacGia = txtIDTacGia.Text;
            string tenTacGia = txtTenTacGia.Text;
            if(idTacGia != "" && tenTacGia != "")
            {
                
                    TacGiaBUS.UpdateTacGia(idTacGia, tenTacGia);
                    MessageBox.Show(this, "Cập nhật tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTacGia();
                return;
                
            }
            MessageBox.Show(this, "ID tác giả và tên tác giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string idTacGia = txtIDTacGia.Text;
            string tenTacGia = txtTenTacGia.Text;
            if (idTacGia != "" && tenTacGia != "")
            {
                if (MessageBox.Show(this, $"Bạn có muốn xóa tác giả { tenTacGia } không ?", "Xác nhận", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        TacGiaBUS.DeletaTacGia(idTacGia);
                        MessageBox.Show(this, "Xóa tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTacGia();
                    }
                    catch
                    {
                        MessageBox.Show(this, "Không thể xóa tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return;
            }
            MessageBox.Show(this, "ID tác giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}  
