using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class CT_PhieuMuonBUS
    {
        public static void AddCT_PhieuMuon(int idPhieuMuon, int idSach)
        {
            CT_PhieuMuonDAO.AddCT_PhieuMuon(idPhieuMuon, idSach);
        }

        public static IList LoadCT_PhieuMuonByIDPhieuMuon(int idPhieuMuon)
        {
            return CT_PhieuMuonDAO.LoadCT_PhieuMuonByIDPhieuMuon(idPhieuMuon);
        }

        public static IList GetSachMuonQuaHans(int idDocGia)
        {
            int thoiHanMuonSach = ThamSoBUS.GetSoNgayMuon();
            return CT_PhieuMuonDAO.GetSachMuonQuaHans(idDocGia, thoiHanMuonSach);
        }

        public static int GetSoLuongSachMuonTrongKhoangTG(int idDocGia)
        {
            int thoiHanMuonSach = ThamSoBUS.GetSoNgayMuon();
            return CT_PhieuMuonDAO.GetSoLuongSachMuonTrongKhoangTG(idDocGia, thoiHanMuonSach);
        }

        public static int GetSoLuongSachMuonToiDa()
        {
            return ThamSoBUS.GetSoLuongSachDuocMuon();
        }

        public static int GetThoiHanMuonSach()
        {
            return ThamSoBUS.GetSoNgayMuon();
        }
    }
}
