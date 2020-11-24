using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLyMuonTra : Form
    {
        public FormQuanLyMuonTra()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int choose = cbbLoai.SelectedIndex;
            if(choose == 0)
            {
                FormMuonSach form = new FormMuonSach();
                form.Show();
            }
            if(choose == 1)
            {
                FormTraSach form = new FormTraSach();
                form.Show();
            }
            if (choose == 2)
            {
                FormThuTienPhat form = new FormThuTienPhat();
                form.Show();
            }
        }
    }
}
