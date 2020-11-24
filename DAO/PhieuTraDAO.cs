using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuTraDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static IList LoadPhieuTra()
        {
            var rs = from phieuTra in db.PHIEUTRAs
                     select new
                     {
                         IDPhieuTra = phieuTra.IDPhieuTra,
                         HoTen = phieuTra.DOCGIA.HoTen,
                         NgayTra = phieuTra.NgayTra,
                         TongTienPhat = phieuTra.CT_PHIEUTRA.Sum(ctpt => ctpt.TienPhat)
                     };
            return rs.ToList();

        }

        public static int AddPhieuTra(int idDocGia, DateTime ngayTra)
        {
            PHIEUTRA phieuTra = new PHIEUTRA();
            phieuTra.IDDocGia = idDocGia;
            phieuTra.NgayTra = ngayTra;
            db.PHIEUTRAs.Add(phieuTra);
            db.SaveChanges();
            return phieuTra.IDPhieuTra;
        }

        public static IList LocPhieuTraByIDDocGia(int idDocGia)
        {
            var rs = from phieuTra
                     in db.PHIEUTRAs
                     where phieuTra.IDDocGia == idDocGia
                     select new
                     {
                         IDPhieuTra = phieuTra.IDPhieuTra,
                         HoTen = phieuTra.DOCGIA.HoTen,
                         NgayTra = phieuTra.NgayTra,
                         TongTienPhat = phieuTra.CT_PHIEUTRA.Sum(ctpt => ctpt.TienPhat)
                     };
            return rs.ToList();
        }

        public static IList LocPhieuTraByNgay(DateTime ngayTra)
        {
            var rs = from phieuTra
                     in db.PHIEUTRAs
                     where phieuTra.NgayTra.Equals(ngayTra)
                     select new
                     {
                         IDPhieuTra = phieuTra.IDPhieuTra,
                         HoTen = phieuTra.DOCGIA.HoTen,
                         NgayTra = phieuTra.NgayTra,
                         TongTienPhat = phieuTra.CT_PHIEUTRA.Sum(ctpt => ctpt.TienPhat)
                     };
            return rs.ToList();
        }

        public static IList LocPhieuTra(int idDocGia, DateTime ngayTra)
        {
            var rs = from phieuTra
                     in db.PHIEUTRAs
                     where phieuTra.IDDocGia == idDocGia && phieuTra.NgayTra.Equals(ngayTra)
                     select new
                     {
                         IDPhieuTra = phieuTra.IDPhieuTra,
                         HoTen = phieuTra.DOCGIA.HoTen,
                         NgayTra = phieuTra.NgayTra,
                         TongTienPhat = phieuTra.CT_PHIEUTRA.Sum(ctpt => ctpt.TienPhat)
                     };
            return rs.ToList();
        }
    }
}
