using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;


namespace BUS
{
    public class ThamSoBUS
    {
        public static THAMSO LoadThamSo()
        {
            //ThamSoDAO thamSoDAO = new ThamSoDAO();
            THAMSO thamso = ThamSoDAO.LoadThamSo();
            return thamso;
        }

        public static int GetSoNgayMuon()
        {
            int soNgayMuon = LoadThamSo().SoNgayMuonToiDa;
            return soNgayMuon;
        }

        public static int GetTuoiToiThieu()
        {
            int soNgayMuon = LoadThamSo().TuoiToiThieu;
            return soNgayMuon;
        }

        public static int GetTuoiToiDa()
        {
            int soNgayMuon = LoadThamSo().TuoiToiDa;
            return soNgayMuon;
        }

        public static double GetTienPhat()
        {
            double tienPhat = LoadThamSo().TienPhat;
            return tienPhat;
        }

        public static int GetThoiHanGiaTriThe()
        {
            return LoadThamSo().ThoiHanGiaTriThe;
        }

        public static int GetKhoangCachNamXuatBan()
        {
            return LoadThamSo().KhoangCachNamXuatBanToiDa;
        }

        public static int GetSoLuongSachDuocMuon()
        {
            return ThamSoDAO.LoadThamSo().SoLuongSachMuonToiDa;
        }

        public static void UpdateThamSo(int tuoiToiThieu, int tuoiToiDa, int thoiHanGiaTriThe, int khoangCachNXBToiDa,
            int soLuongSachMuonToiDa, int soNgayMuonToiDa, double tienPhat)
        {
            ThamSoDAO.UpdateThamSo(tuoiToiThieu, tuoiToiDa, thoiHanGiaTriThe, khoangCachNXBToiDa, soLuongSachMuonToiDa, soNgayMuonToiDa,
                tienPhat);
        }
    }
}