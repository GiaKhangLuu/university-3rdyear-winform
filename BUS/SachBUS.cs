using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class SachBUS
    { 
        public static Array LoadSach()
        {
            var sachs = SachDAO.LoadSach();
            return sachs;
        }

        public static List<TACGIA> GetTacGias()
        {
            return TacGiaDAO.GetTacGias();
        }

        public static List<SACH> GetSachs()
        {
            return SachDAO.GetSachs();
        }

        public static List<THELOAI> GetTheLoais() { return TheLoaiDAO.GetTheLoais(); }

        public static int[] GetNamXuatBan()
        {
            int khoang_cach_nam_xuat_ban = ThamSoBUS.GetKhoangCachNamXuatBan();
            int currYear = DateTime.Now.Year;
            int[] namXuatBans = new int[khoang_cach_nam_xuat_ban + 1];
            namXuatBans[0] = currYear;
            for(int i = 1; i <= khoang_cach_nam_xuat_ban; i++)
            {
                namXuatBans[i] = currYear - i;
            }
            return namXuatBans;
        }

        public static void UpdateTinhTrangSach(int idSach, bool tinhTrang)
        {
            SachDAO.UpdateTinhTrangSach(idSach, tinhTrang);
        }

        public static IList FindSach(int idSach, string tenSach, string tenTacGia, string tenTheLoai, int namXuatBan, string nxb,
            DateTime ngayNhap, double triGia, bool tinhTrang)
        {
            return SachDAO.FindSach(idSach, tenSach, tenTacGia, tenTheLoai, namXuatBan, nxb, ngayNhap, triGia, tinhTrang);
        }

        public static SACH FindSachById(int idSach)
        {
            return SachDAO.FindSachById(idSach);
        }

        public static void AddSach(string tenSach, int idTheLoai, int idTacGia, int namXuatBan, string nxb, DateTime ngayNhap,
            double triGia, bool tinhTrang)
        {
            SachDAO.AddSach(tenSach, idTheLoai, idTacGia, namXuatBan, nxb, ngayNhap, triGia, tinhTrang);
        }

        public static void UpdateSach(int idSach, string tenSach, int idTheLoai, int idTacGia, int namXuatBan, string nxb, DateTime ngayNhap,
            double triGia, bool tinhTrang)
        {
            SachDAO.UpdateSach(idSach, tenSach, idTheLoai, idTacGia, namXuatBan, nxb, ngayNhap, triGia, tinhTrang);
        }

        public static void DelteSach(int idSach)
        {
            SachDAO.DeleteSach(idSach);
        }

        public static IList FindAll()
        {
            return SachDAO.FindAll();
        }
    }
}
