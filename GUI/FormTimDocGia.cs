﻿using System;
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
    public partial class FormTimDocGia : Form
    {
        private int idDocGiaChon;
        private int idDG;
        private string tenDG, tenLoaiDG, email, diaChi;
        private DateTime ngaySinh, ngayLapThe;

        public int IdDocGiaChon { get => idDocGiaChon; set => idDocGiaChon = value; }

        public FormTimDocGia()
        {
            IdDocGiaChon = -1;
            InitializeComponent();
            LoadLoaiDocGia();
        }

        private void FormTraCuuSach_Load(object sender, EventArgs e)
        {

        }

        public void LoadLoaiDocGia()
        {
            cbbLoaiDocGia.DataSource = LoaiDocGiaBUS.LoadLoaiDocGia();
            cbbLoaiDocGia.DisplayMember = "TenLoaiDocGia";
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            gvDocGia.DataSource = null;
            gvDocGia.DataSource = DocGiaBUS.FindAll();
        }

        private void PreProcess()
        {
            string idDG = txtIDDocGia.Text;
            string tenDocGia = txtTenDocGia.Text;
            string loaiDocGia = cbbLoaiDocGia.Text;
            DateTime ngaySinh = dtPickerNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            DateTime ngayLapThe = dtPickerNgayLapThe.Value;

            this.idDG = idDG == "" ? -1 : Int32.Parse(idDG);
            this.tenDG = tenDocGia;
            this.tenLoaiDG = loaiDocGia;
            this.ngaySinh = ngaySinh;
            this.ngayLapThe = ngayLapThe;
            this.diaChi = diaChi;
            this.email = email;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            gvDocGia.DataSource = null;
            PreProcess();
            if(DocGiaBUS.FindDocGia(idDG, tenDG, tenLoaiDG, ngaySinh, diaChi, email, ngayLapThe).Count != 0)
            {
                gvDocGia.DataSource = DocGiaBUS.FindDocGia(idDG, tenDG, tenLoaiDG, ngaySinh, diaChi, email, ngayLapThe);
            }
            else
            {
                MessageBox.Show(this, "Không tìm thấy độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(gvDocGia.SelectedRows.Count > 0)
            {
                IdDocGiaChon = Int32.Parse(gvDocGia.SelectedRows[0].Cells[0].Value.ToString());
                this.Dispose();
            } 
            else
            {
                MessageBox.Show(this, "Vui lòng chọn độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
