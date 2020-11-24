using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Collections;

namespace BUS
{
    public class CT_BC_SachTraTreBUS
    {

        public static void AddCT_BaoCao(int idSach, int idBaoCao, DateTime ngayMuon, int soNgayTraTre)
        {
            CT_BC_SachTraTreDAO.AddCT_BC(idSach, idBaoCao, ngayMuon, soNgayTraTre);
        }
    }
}
