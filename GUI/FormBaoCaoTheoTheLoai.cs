using System;
using System.Collections;
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
    public partial class FormBaoCaoTheoTheLoai : Form
    {
        public FormBaoCaoTheoTheLoai()
        {
            InitializeComponent();
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            string month = cbbThang.Text;
            if(month != "")
            {
                if(BC_SachMuonTheoTheLoaiBUS.BaoCaoSachMuonTheoTheLoai(Int32.Parse(month)).Count != 0)
                {
                    gvBaoCao.DataSource = BC_SachMuonTheoTheLoaiBUS.BaoCaoSachMuonTheoTheLoai(Int32.Parse(month));
                    EditGridView();
                    Uti(Int32.Parse(month));
                    return;
                }
                MessageBox.Show(this, $"Không có phiếu mượn trong tháng { month }", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvBaoCao.DataSource = null;
                txtTongSoLuotMuon.Text = "";
                return;
            }
            MessageBox.Show(this, $"Bạn chưa chọn tháng để lập báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Uti(int month)
        {

            int idBaoCao = BC_SachMuonTheoTheLoaiBUS.AddBaoCao(month);
            int tongSoLuotMuon = 0;
            foreach (DataGridViewRow row in gvBaoCao.Rows)
            {
                int idTheLoai = Int32.Parse(row.Cells[0].Value.ToString());
                int soLuotMuon = Int32.Parse(row.Cells[2].Value.ToString());
                double tiLe = Double.Parse(row.Cells[3].Value.ToString());
                row.Cells[3].Value = tiLe.ToString("#.##");
                tongSoLuotMuon += Int32.Parse(row.Cells[2].Value.ToString());
                CT_BC_SachMuonTheoTheLoaiBUS.AddCT_BaoCao(idTheLoai, idBaoCao, soLuotMuon, tiLe);
            }
            txtTongSoLuotMuon.Text = tongSoLuotMuon.ToString();          
        }

        private void EditGridView()
        {
            gvBaoCao.Columns[0].Visible = false;
            gvBaoCao.Columns[1].HeaderText = "Tên thể loại";
            gvBaoCao.Columns[2].HeaderText = "Số lượt mượn";
            gvBaoCao.Columns[3].HeaderText = "Tỉ lệ";
        }
    }
}
