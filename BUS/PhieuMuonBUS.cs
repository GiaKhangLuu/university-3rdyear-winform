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
    public class PhieuMuonBUS
    {
        public static List<DOCGIA> GetDocGias()
        {
            return DocGiaBUS.GetDocGias();
        }

        public static List<SACH> GetSachs()
        {
            return SachBUS.GetSachs();
        }

        public static object[] AddDetail(SACH sach)
        {
            object[] detail = { sach.IDSach, sach.TenSach, sach.THELOAI.TenTheLoai, sach.TACGIA.TenTacGia };
            return detail;
        }

        public static void MakeLoan(string idDocGia, DateTime ngayMuon, string[] idSachs)
        {
            int idPhieuMuon = PhieuMuonDAO.AddPhieuMuon(Int32.Parse(idDocGia), ngayMuon);
            foreach(string idSach in idSachs)
            {
                CT_PhieuMuonBUS.AddCT_PhieuMuon(idPhieuMuon, Int32.Parse(idSach));
                SachBUS.UpdateTinhTrangSach(Int32.Parse(idSach), true);
            }
        }

        public static int GetThoiHanGiaTriThe()
        {
            return ThamSoBUS.GetThoiHanGiaTriThe();
        }

        public static IList LoadPhieuMuon()
        {
            return PhieuMuonDAO.LoadPhieuMuon();
        }

        public static IList LocPhieuMuon(int idDocGia, DateTime ngayMuon)
        {
            return PhieuMuonDAO.LocPhieuMuon(idDocGia, ngayMuon);
        }

        public static IList LocPhieuMuonByIDDocGia(int idDocGia)
        {
            return PhieuMuonDAO.LocPhieuMuonByIDDocGia(idDocGia);
        }

        public static IList LocPhieuMuonByNgay(DateTime ngayMuon)
        {
            return PhieuMuonDAO.LocPhieuMuonByNgay(ngayMuon);
        }
    }
}
