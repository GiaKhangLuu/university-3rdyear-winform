using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class FormBaoCaoSachTraTre : Form
    {
        public FormBaoCaoSachTraTre()
        {
            InitializeComponent();
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            DateTime ngayBaoCao = dtPickerNgayLap.Value;
            if(DateTime.Now.Subtract(ngayBaoCao).Days >= 0)
            {
                if(BC_SachTraTreBUS.BaoCaoSachTraTre(ngayBaoCao).Count != 0)
                {
                    gvBaoCao.DataSource = BC_SachTraTreBUS.BaoCaoSachTraTre(ngayBaoCao);
                    EditGridView();
                    AddToDB(ngayBaoCao);
                    return;
                }
                MessageBox.Show(this, $"không có sách trả trễ vào ngày { ngayBaoCao.ToShortDateString() }", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvBaoCao.DataSource = null;
            }
            else
            {
                MessageBox.Show(this, "Ngày lập báo cáo vượt qua ngày hôm nay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditGridView()
        {
            gvBaoCao.Columns[0].Visible = false;
            gvBaoCao.Columns[1].HeaderText = "Tên sách";
            gvBaoCao.Columns[2].HeaderText = "Ngày mượn";
            gvBaoCao.Columns[3].HeaderText = "Số ngày trả trễ";
        }

        private void AddToDB(DateTime ngayBaoCao)
        {
            int idBaoCao = BC_SachTraTreBUS.AddBaoCao(ngayBaoCao);
            foreach(DataGridViewRow row in gvBaoCao.Rows)
            {
                int idSach = Int32.Parse(row.Cells[0].Value.ToString());
                DateTime ngayMuon = DateTime.Parse(row.Cells[2].Value.ToString());
                int soNgayTraTre = Int32.Parse(row.Cells[3].Value.ToString());
                CT_BC_SachTraTreBUS.AddCT_BaoCao(idSach, idBaoCao, ngayMuon, soNgayTraTre);
            }
        }
    }
}
