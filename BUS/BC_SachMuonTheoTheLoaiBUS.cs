using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Collections;

namespace BUS
{
    public class BC_SachMuonTheoTheLoaiBUS
    {
        public static IList BaoCaoSachMuonTheoTheLoai(int month)
        {
            return BC_SachMuonTheoTheLoaiDAO.LoadSachMuonTheoTheLoai(month);
        }

        public static int AddBaoCao(int month)
        {
            return BC_SachMuonTheoTheLoaiDAO.AddBC_SachMuonTheoTheLoai(month);
        }
    }
}
