using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThamSoDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static THAMSO LoadThamSo()
        {
            THAMSO thamso = db.THAMSOes.SingleOrDefault();
            return thamso;
        }

        public static void UpdateThamSo(int tuoiToiThieu, int tuoiToiDa, int thoiHanGiaTriThe, int khoangCachNXBToiDa, 
            int soLuongSachMuonToiDa, int soNgayMuonToiDa, double tienPhat)
        {
            THAMSO ts = db.THAMSOes.SingleOrDefault();
            ts.TuoiToiThieu = tuoiToiThieu;
            ts.TuoiToiDa = tuoiToiDa;
            ts.ThoiHanGiaTriThe = thoiHanGiaTriThe;
            ts.KhoangCachNamXuatBanToiDa = khoangCachNXBToiDa;
            ts.SoLuongSachMuonToiDa = soLuongSachMuonToiDa;
            ts.SoNgayMuonToiDa = soNgayMuonToiDa;
            ts.TienPhat = tienPhat;
            db.SaveChanges();
        }
    }
}
