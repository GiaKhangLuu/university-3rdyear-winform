using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CT_PhieuMuonDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static IList LoadCT_PhieuMuonByIDPhieuMuon(int idPhieuMuon)
        {
            var rs = from ctpm in db.CT_PHIEUMUON
                     where ctpm.IDPhieuMuon == idPhieuMuon
                     select new
                     {
                         IDSach = ctpm.IDSach,
                         TenSach = ctpm.SACH.TenSach,
                         TenTheLoai = ctpm.SACH.THELOAI.TenTheLoai,
                         TenTacGia = ctpm.SACH.TACGIA.TenTacGia
                     };
            return rs.ToList();
        }

        public static void AddCT_PhieuMuon(int idPhieuMuon, int idSach)
        {
            CT_PHIEUMUON ctPhieuMuon = new CT_PHIEUMUON();
            ctPhieuMuon.IDPhieuMuon = idPhieuMuon;
            ctPhieuMuon.IDSach = idSach;
            db.CT_PHIEUMUON.Add(ctPhieuMuon);
            db.SaveChanges();
        }

        public static IList GetSachMuonQuaHans(int idDocGia, int thoiHanMuonSach)
        {
            var sachDaMuons = from ctpm
                              in db.CT_PHIEUMUON
                              where ctpm.PHIEUMUON.IDDocGia == idDocGia && DbFunctions.DiffDays(ctpm.PHIEUMUON.NgayMuon, DateTime.Now) > thoiHanMuonSach
                              select new { IDPhieuMuon = ctpm.IDPhieuMuon, IDSach = ctpm.IDSach };
            var sachDaTras = from ctpm
                             in db.CT_PHIEUMUON
                             where ctpm.PHIEUMUON.IDDocGia == idDocGia && DbFunctions.DiffDays(ctpm.PHIEUMUON.NgayMuon, DateTime.Now) > thoiHanMuonSach
                             group ctpm by ctpm.IDPhieuMuon into ct_phieuMuonGroup 
                             from ctpt
                             in db.CT_PHIEUTRA
                             where ctpt.IDPhieuMuon == ct_phieuMuonGroup.Key 
                             select new
                             {
                                 IDPhieuMuon = ctpt.IDPhieuMuon,
                                 IDSach = ctpt.IDSach
                             };
            var sachChuaTras = sachDaMuons.Except(sachDaTras);
            var infoSachChuaTras = from sach
                                   in db.SACHes
                                   from sachChuaTra
                                   in sachChuaTras
                                   from phieuMuon
                                   in db.PHIEUMUONs
                                   where sach.IDSach == sachChuaTra.IDSach && phieuMuon.IDPhieuMuon == sachChuaTra.IDPhieuMuon
                                   select new
                                   {
                                       IDPhieuMuon = sachChuaTra.IDPhieuMuon,
                                       IDSach = sach.IDSach,
                                       TenSach = sach.TenSach,
                                       NgayMuon = phieuMuon.NgayMuon
                                   };
            return infoSachChuaTras.ToList();
        }

        public static int GetSoLuongSachMuonTrongKhoangTG(int idDocGia, int thoiHanMuonSach)
        {
            var sachDaMuons = from ctpm
                              in db.CT_PHIEUMUON
                              where ctpm.PHIEUMUON.IDDocGia == idDocGia && DbFunctions.DiffDays(ctpm.PHIEUMUON.NgayMuon, DateTime.Now) <= thoiHanMuonSach
                              select new { IDPhieuMuon = ctpm.IDPhieuMuon, IDSach = ctpm.IDSach };
            var sachDaTras = from ctpm
                             in db.CT_PHIEUMUON
                             where ctpm.PHIEUMUON.IDDocGia == idDocGia && DbFunctions.DiffDays(ctpm.PHIEUMUON.NgayMuon, DateTime.Now) <= thoiHanMuonSach
                             group ctpm by ctpm.IDPhieuMuon into ct_phieuMuonGroup
                             from ctpt
                             in db.CT_PHIEUTRA
                             where ctpt.IDPhieuMuon == ct_phieuMuonGroup.Key
                             select new
                             {
                                 IDPhieuMuon = ctpt.IDPhieuMuon,
                                 IDSach = ctpt.IDSach
                             };
            var soLuongSachMuon = sachDaMuons.Except(sachDaTras).Count();
            return soLuongSachMuon;
        }

        public static IList LoadSachMuonTheOTheLoai(int month)
        {
            int tongSoLuotMuon = (from ctpm in db.CT_PHIEUMUON
                                 where ctpm.PHIEUMUON.NgayMuon.Month - month == 0
                                 select ctpm).Count();
            var rs = from ctpm in db.CT_PHIEUMUON
                     where ctpm.PHIEUMUON.NgayMuon.Month - month == 0
                     group ctpm by ctpm.SACH.THELOAI.IDTheLoai into ctpmGroup
                     select new
                     {
                         IDTheLoai = ctpmGroup.Key,
                         TenTheLoai = ((THELOAI)db.THELOAIs.FirstOrDefault(tl => tl.IDTheLoai == ctpmGroup.Key)).TenTheLoai,
                         SoLuotMuon = ctpmGroup.Count(),
                         TiLe = Math.Round(((double)ctpmGroup.Count() / tongSoLuotMuon), 2)                     
                     };
            return rs.ToList();
        }
    }
}
