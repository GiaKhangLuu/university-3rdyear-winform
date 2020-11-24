using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuThuDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static void AddReceipt(int idDocGia, double soTienThu, double tongNo, double conLai)
        {
            PHIEUTHUTIENPHAT phieuThu = new PHIEUTHUTIENPHAT();
            phieuThu.IDDocGia = idDocGia;
            phieuThu.SoTienThu = soTienThu;
            phieuThu.TongNo = tongNo;
            phieuThu.ConLai = conLai;
            db.PHIEUTHUTIENPHATs.Add(phieuThu);
            db.SaveChanges();
        }

        public static Array LoadPhieuThu()
        {
            var phieuThus = from phieuThu
                            in db.PHIEUTHUTIENPHATs
                            select new
                            {
                                TenDocGia = phieuThu.DOCGIA.HoTen,
                                TongNo = phieuThu.TongNo,
                                SoTienThu = phieuThu.SoTienThu,
                                ConLai = phieuThu.ConLai
                            };
            return phieuThus.ToArray();
        }
    }
}
