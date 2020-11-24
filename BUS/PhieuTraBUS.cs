using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using BUS;
using System.Collections;

namespace BUS
{
    public class PhieuTraBUS
    {
        public static List<DOCGIA> GetDocGias()
        {
            return DocGiaBUS.GetDocGias();
        }

        public static IList LoadPhieuTra()
        {
            return PhieuTraDAO.LoadPhieuTra();
        }

        public static IList GetSachChuaTra(int idDocGia)
        {
            return CT_PhieuTraDAO.GetSachChuaTra(idDocGia);
        }

        public static object[] AddDetail(string idPhieuMuon, string idSach, string tenSach, DateTime ngayMuon, DateTime ngayTra)
        {
            int soNgayMuon = ngayTra.Subtract(ngayMuon).Days;
            double tienPhat = IsLate(soNgayMuon) ? GetFine(soNgayMuon) : 0;
            return new object[] { idPhieuMuon, idSach, tenSach, ngayMuon.ToShortDateString(), soNgayMuon, tienPhat };
        }

        private static bool IsLate(int soNgayMuon)
        {
            int soNgayMuonToiDa = ThamSoBUS.GetSoNgayMuon();
            if (soNgayMuon > soNgayMuonToiDa) return true;
            return false;
        }

        private static double GetFine(int soNgayMuon)
        {
            int soNgayTraTre = soNgayMuon - ThamSoBUS.GetSoNgayMuon();
            double tienPhat = ThamSoBUS.GetTienPhat();
            return tienPhat * soNgayTraTre;
        }

        public static IList LocPhieuTra(int idDocGia, DateTime ngayTra)
        {
            return PhieuTraDAO.LocPhieuTra(idDocGia, ngayTra);
        }

        public static IList LocPhieuTraByIDDocGia(int idDocGia)
        {
            return PhieuTraDAO.LocPhieuTraByIDDocGia(idDocGia);
        }

        public static IList LocPhieuTraByNgay(DateTime ngayTra)
        {
            return PhieuTraDAO.LocPhieuTraByNgay(ngayTra);
        }

        public static void MakePhieuTra(string idDocGia, DateTime ngayTra, int[] idSachs, int[] idPhieuMuons, int[] soNgayMuon, int[] tienPhat, string tongNoMoi)
        {
            int idPhieuTra = PhieuTraDAO.AddPhieuTra(Int32.Parse(idDocGia), ngayTra);
            for(int i = 0; i < idSachs.Length; i++)
            {
                CT_PhieuTraBus.AddCT_PhieuTra(idPhieuMuons[i], idSachs[i], idPhieuTra, soNgayMuon[i], tienPhat[i]);
                SachBUS.UpdateTinhTrangSach(idSachs[i], false);
            }
            DocGiaBUS.UpdateNo(Int32.Parse(idDocGia), Double.Parse(tongNoMoi));
        }
    }
}
