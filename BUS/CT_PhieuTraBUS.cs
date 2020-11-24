using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class CT_PhieuTraBus
    {

        public static IList LoadCT_PhieuTra(int idPhieuTra)
        {
            return CT_PhieuTraDAO.LoadCT_PhieuTraByIDPhieuTra(idPhieuTra);
        }
        public static void AddCT_PhieuTra(int idPhieuMuon, int idSach, int idPhieuTra, int soNgayMuon, double tienPhat)
        {
            CT_PhieuTraDAO.AddCT_PhieuTra(idPhieuTra, idPhieuMuon, soNgayMuon, idSach, tienPhat);
        }
    }
}
