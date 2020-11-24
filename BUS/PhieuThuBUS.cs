using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using BUS;

namespace BUS
{
    public class PhieuThuBUS
    {
        public static List<DOCGIA> GetDocGias()
        {
            return DocGiaBUS.GetDocGias();
        }

        public static bool IsDigit(char letter)
        {
            if (char.IsDigit(letter) || char.IsControl(letter)) return true;
            return false;
        }

        public static void AddReceipt(string idDocGia, string soTienThu, string tongNo, string conLai)
        {
            PhieuThuDAO.AddReceipt(Int32.Parse(idDocGia), Double.Parse(soTienThu), Double.Parse(tongNo), double.Parse(conLai));
            UpdateNo(idDocGia, conLai);
        }

        private static void UpdateNo(string idDocGia, string conLai)
        {
            DocGiaBUS.UpdateNo(Int32.Parse(idDocGia), Double.Parse(conLai));
        }

        public static Array LoadPhieuThu()
        {
            return PhieuThuDAO.LoadPhieuThu();
        }

    }
}
