using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuMuonDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static IList LoadPhieuMuon()
        {
            var rs = from phieuMuon
                     in db.PHIEUMUONs
                     select new
                     {
                         IDPhieuMuon = phieuMuon.IDPhieuMuon,
                         HoTen = phieuMuon.DOCGIA.HoTen,
                         NgayMuon = phieuMuon.NgayMuon,
                         SoLuongSachMuon = phieuMuon.CT_PHIEUMUON.Count()
                     };
            return rs.ToList();
        }

        public static int AddPhieuMuon(int idDocGia, DateTime ngayMuon)
        {
            PHIEUMUON phieuMuon = new PHIEUMUON();
            phieuMuon.IDDocGia = idDocGia;
            phieuMuon.NgayMuon = ngayMuon;
            db.PHIEUMUONs.Add(phieuMuon);
            db.SaveChanges();
            return phieuMuon.IDPhieuMuon;
        }

        public static IList LocPhieuMuonByIDDocGia(int idDocGia)
        {
            var rs = from phieuMuon
                     in db.PHIEUMUONs
                     where phieuMuon.IDDocGia == idDocGia
                     select new
                     {
                         IDPhieuMuon = phieuMuon.IDPhieuMuon,
                         HoTen = phieuMuon.DOCGIA.HoTen,
                         NgayMuon = phieuMuon.NgayMuon,
                         SoLuongSachMuon = phieuMuon.CT_PHIEUMUON.Count()
                     };
            return rs.ToList();
        }

        public static IList LocPhieuMuonByNgay(DateTime ngayMuon)
        {
            var rs = from phieuMuon
                     in db.PHIEUMUONs
                     where phieuMuon.NgayMuon.Equals(ngayMuon)
                     select new
                     {
                         IDPhieuMuon = phieuMuon.IDPhieuMuon,
                         HoTen = phieuMuon.DOCGIA.HoTen,
                         NgayMuon = phieuMuon.NgayMuon,
                         SoLuongSachMuon = phieuMuon.CT_PHIEUMUON.Count()
                     };
            return rs.ToList();
        }

        public static IList LocPhieuMuon(int idDocGia, DateTime ngayMuon)
        {
            var rs = from phieuMuon
                     in db.PHIEUMUONs
                     where phieuMuon.IDDocGia == idDocGia && phieuMuon.NgayMuon.Equals(ngayMuon)
                     select new
                     {
                         IDPhieuMuon = phieuMuon.IDPhieuMuon,
                         HoTen = phieuMuon.DOCGIA.HoTen,
                         NgayMuon = phieuMuon.NgayMuon,
                         SoLuongSachMuon = phieuMuon.CT_PHIEUMUON.Count()
                     };
            return rs.ToList();
        }

        
    }
}
