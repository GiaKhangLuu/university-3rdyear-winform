using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CT_PhieuTraDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static IList LoadCT_PhieuTraByIDPhieuTra(int idPhieuTra)
        {
            var rs = from ctpt in db.CT_PHIEUTRA
                     where ctpt.IDPhieuTra == idPhieuTra
                     select new
                     {
                         IDSach = ctpt.SACH.IDSach,
                         TenSach = ctpt.SACH.TenSach,
                         NgayMuon = ctpt.PHIEUMUON.NgayMuon,
                         SoNgayMuon = ctpt.SoNgayMuon,
                         TienPhat = ctpt.TienPhat
                     };
            return rs.ToList();
        }

        public static IList GetSachChuaTra(int idDocGia)
        {
            var sachDaMuons = from ctpm
                              in db.CT_PHIEUMUON
                              where ctpm.PHIEUMUON.IDDocGia == idDocGia
                              select new { IDPhieuMuon = ctpm.IDPhieuMuon, IDSach = ctpm.IDSach };
            var sachDaTras = from ctpm
                             in db.CT_PHIEUMUON
                             where ctpm.PHIEUMUON.IDDocGia == idDocGia
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
                                       TenTheLoai = sach.THELOAI.TenTheLoai,
                                       TenTacGia = sach.TACGIA.TenTacGia,
                                       NhaXuatBan = sach.NhaXuatBan,
                                       TenSach = sach.TenSach,
                                       NgayMuon = phieuMuon.NgayMuon
                                   };
            return infoSachChuaTras.ToList();

        }

        public static void AddCT_PhieuTra(int idPhieuTra, int idPhieuMuon, int soNgayMuon, int idSach, double tienPhat)
        {
            CT_PHIEUTRA ctPhieuTra = new CT_PHIEUTRA();
            ctPhieuTra.IDPhieuTra = idPhieuTra;
            ctPhieuTra.IDPhieuMuon = idPhieuMuon;
            ctPhieuTra.SoNgayMuon = soNgayMuon;
            ctPhieuTra.IDSach = idSach;
            ctPhieuTra.TienPhat = tienPhat;
            db.CT_PHIEUTRA.Add(ctPhieuTra);
            db.SaveChanges();
        }

        public static IList LoadSachTraTre(DateTime ngayBaoCao)
        {
            var rs = from ctpt in db.CT_PHIEUTRA
                     where DbFunctions.DiffDays(ctpt.PHIEUTRA.NgayTra, ngayBaoCao) == 0 && ctpt.SoNgayMuon > 4
                     select new
                     {
                         IDSach = ctpt.IDSach,
                         TenSach = ctpt.SACH.TenSach,
                         NgayMuon = ctpt.PHIEUMUON.NgayMuon,
                         SoNgayTraTre = (ctpt.SoNgayMuon - 4)
                     };
            return rs.ToList();
        }
    }
}
