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
    public partial class FormTrangChinh : Form
    {
        private Form[] forms;
        private Button[] buttons;
        private int indexFormOpening;

        public FormTrangChinh()
        {
            InitializeComponent();
            forms = new Form[5];
            buttons = new Button[5];
            indexFormOpening = -1;
        }
        private void OpenForm(int index)
        {
            DisposeFormOpening();
            indexFormOpening = index;
            switch (indexFormOpening)
            {
                case 0:
                    forms[Constant.INDEX_FORM_DOCGIA] = new FormDocGia();
                    buttons[Constant.INDEX_FORM_DOCGIA] = btnDocGia;
                    break;
                case 1:
                    forms[Constant.INDEX_FORM_SACH] = new FormSach();
                    buttons[Constant.INDEX_FORM_SACH] = btnSach;
                    break;
                case 2:
                    forms[Constant.INDEX_FORM_QUANLYMUONTRA] = new FormQuanLyMuonTra();
                    buttons[Constant.INDEX_FORM_QUANLYMUONTRA] = btnMuonTra;
                    break;
                case 3:
                    forms[Constant.INDEX_FORM_BAOCAO] = new FormBaoCao();
                    buttons[Constant.INDEX_FORM_BAOCAO] = btnBaoCao;
                    break;
                case 4:
                    forms[Constant.INDEX_FORM_QUYDINH] = new FormQuyDinh();
                    buttons[Constant.INDEX_FORM_QUYDINH] = btnQuyDinh;
                    break;
            }
            forms[indexFormOpening].Show();
            forms[indexFormOpening].FormClosed += Form_Closed;
            buttons[indexFormOpening].Enabled = false;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            buttons[indexFormOpening].Enabled = true;
        }

        private void DisposeFormOpening()
        {
            if(indexFormOpening != -1)
            {
                forms[indexFormOpening].Dispose();
                buttons[indexFormOpening].Enabled = true;
            }
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            
            OpenForm(Constant.INDEX_FORM_DOCGIA);
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            
            OpenForm(Constant.INDEX_FORM_SACH);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
            OpenForm(Constant.INDEX_FORM_BAOCAO);
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {

            OpenForm(Constant.INDEX_FORM_QUYDINH);
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            OpenForm(Constant.INDEX_FORM_QUANLYMUONTRA);
        }
    }
}
