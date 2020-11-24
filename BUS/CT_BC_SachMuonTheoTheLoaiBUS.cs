using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Collections;

namespace BUS
{
    public class CT_BC_SachMuonTheoTheLoaiBUS
    {

        public static void AddCT_BaoCao(int idTheLoai, int idBaoCao, int soLuotMuon, double tiLe)
        {
            CT_BC_SachMuonTheoTheLoaiDAO.AddCT_BC(idTheLoai, idBaoCao, soLuotMuon, tiLe);
        }
    }
}
