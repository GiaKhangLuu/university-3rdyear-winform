using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SachDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static Array LoadSach()
        {
            var sachs = from sach
                        in db.SACHes
                        select new { 
                            IDSach = sach.IDSach, 
                            TenSach = sach.TenSach, 
                            TenTheLoai = sach.THELOAI.TenTheLoai,
                            TenTacGia = sach.TACGIA.TenTacGia,
                            NhaXuatBan = sach.NhaXuatBan,
                            NamXuatBan = sach.NamXuatBan,
                            NgayNhap = sach.NgayNhap,
                            TriGia = sach.TriGia,
                            TinhTrang = sach.TinhTrang
                        };
            return sachs.ToArray();
        }

        public static List<SACH> GetSachs()
        {
            return db.SACHes.Select(sach => sach).ToList();
        }

        public static void UpdateTinhTrangSach(int idSach, bool tinhTrang)
        {
            SACH sach = db.SACHes.Find(idSach);
            if(sach != null)
            {
                sach.TinhTrang = tinhTrang;
                db.SaveChanges();
            }
        }

        public static SACH FindSachById(int idSach)
        {
            return db.SACHes.Find(idSach);
        }

        private static IList FindSachByName(string tenSach)
        {
            var rs = from sach in db.SACHes
                     where sach.TenSach.Contains(tenSach)
                   select new
                   {
                       IdSach = sach.IDSach,
                       TenSach = sach.TenSach,
                       TenTheLoai = sach.THELOAI.TenTheLoai,
                       TenTacGia = sach.TACGIA.TenTacGia,
                       NhaXuatBan = sach.NhaXuatBan,
                       NamXuatBan = sach.NamXuatBan,
                       NgayNhap = sach.NgayNhap,
                       TriGia = sach.TriGia,
                       TinhTrang = sach.TinhTrang
                   };
            return rs.ToList();
        }

        private static IList FindSachByTheLoai(string tenTheLoai)
        {
            var rs = from sach in db.SACHes
                     where sach.THELOAI.TenTheLoai.Contains(tenTheLoai)
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }

        private static IList FindSachByTacGia(string tenTacGia)
        {
            var rs = from sach in db.SACHes
                     where sach.TACGIA.TenTacGia.Contains(tenTacGia)
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }

        private static IList FindSachByNamXuatBan(int namXuatBan)
        {
            var rs = from sach in db.SACHes
                     where sach.NamXuatBan == namXuatBan
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }

        private static IList FindSachByNhaXuatBan(string nxb)
        {
            var rs = from sach in db.SACHes
                     where sach.NhaXuatBan.Contains(nxb)
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }

        private static IList FindSachByNgayNhap(DateTime ngayNhap)
        {
            var rs = from sach in db.SACHes
                     where DbFunctions.DiffDays(sach.NgayNhap, ngayNhap) == 0
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }

        private static IList FindSachByTrigia(double triGia)
        {
            var rs = from sach in db.SACHes
                     where sach.TriGia == triGia
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }

        private static IList FindSachByTinhTrang(bool tinhTrang)
        {
            var rs = from sach in db.SACHes
                     where sach.TinhTrang == tinhTrang
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }

        private static IList GetSachById(int idSach)
        {
            var rs = from sach in db.SACHes
                     where sach.IDSach == idSach
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }

        public static IList FindSach(int idSach, string tenSach, string tenTacGia, string tenTheLoai, int namXuatBan, string nxb,
            DateTime ngayNhap, double triGia, bool tinhTrang)
        {
            if (idSach != -1)
            {
                IList sachs = GetSachById(idSach);
                if (sachs.Count > 0) return sachs;
            }
            if (tenSach != "")
            {
                IList sachs = FindSachByName(tenSach);
                if (sachs.Count > 0) return sachs;
            }
            if (tenTacGia != "")
            {
                IList sachs = FindSachByTacGia(tenTacGia);
                if (sachs.Count > 0) return sachs;
            }
            if (tenTheLoai != "")
            {
                IList sachs = FindSachByTheLoai(tenTheLoai);
                if (sachs.Count > 0) return sachs;
            }
            if (namXuatBan != -1)
            {
                IList sachs = FindSachByNamXuatBan(namXuatBan);
                if (sachs.Count > 0) return sachs;
            }
            if (nxb != "")
            {
                IList sachs = FindSachByNhaXuatBan(nxb);
                if (sachs.Count > 0) return sachs;
            }
            if (!ngayNhap.Equals(DateTime.MinValue))
            {
                IList sachs = FindSachByNgayNhap(ngayNhap);
                if (sachs.Count > 0) return sachs;
            }
            if (triGia != -1)
            {
                IList sachs = FindSachByTrigia(triGia);
                if (sachs.Count > 0) return sachs;
            }
            IList s = FindSachByTinhTrang(tinhTrang);
            return s;
        }

        public static void AddSach(string tenSach, int idTheLoai, int idTacGia, int namXuatBan, string nxb, DateTime ngayNhap,
            double triGia, bool tinhTrang)
        {
            SACH sach = new SACH();
            sach.TenSach = tenSach;
            sach.IDTheLoai = idTheLoai;
            sach.IDTacGia = idTacGia;
            sach.NamXuatBan = namXuatBan;
            sach.NhaXuatBan = nxb;
            sach.NgayNhap = ngayNhap;
            sach.TriGia = triGia;
            sach.TinhTrang = tinhTrang;
            db.SACHes.Add(sach);
            db.SaveChanges();
        }

        public static void UpdateSach(int idSach, string tenSach, int idTheLoai, int idTacGia, int namXuatBan, string nxb, DateTime ngayNhap,
            double triGia, bool tinhTrang)
        {
            SACH sach = db.SACHes.Find(idSach);
            sach.TenSach = tenSach;
            sach.IDTheLoai = idTheLoai;
            sach.IDTacGia = idTacGia;
            sach.NamXuatBan = namXuatBan;
            sach.NhaXuatBan = nxb;
            sach.NgayNhap = ngayNhap;
            sach.TriGia = triGia;
            sach.TinhTrang = tinhTrang;
            db.SaveChanges();
        }

        public static void DeleteSach(int idSach)
        {
            SACH sach = db.SACHes.Find(idSach);
            db.SACHes.Remove(sach);
            db.SaveChanges();
        }

        public static IList FindAll()
        {
            var rs = from sach in db.SACHes
                     select new
                     {
                         IdSach = sach.IDSach,
                         TenSach = sach.TenSach,
                         TenTheLoai = sach.THELOAI.TenTheLoai,
                         TenTacGia = sach.TACGIA.TenTacGia,
                         NhaXuatBan = sach.NhaXuatBan,
                         NamXuatBan = sach.NamXuatBan,
                         NgayNhap = sach.NgayNhap,
                         TriGia = sach.TriGia,
                         TinhTrang = sach.TinhTrang
                     };
            return rs.ToList();
        }
    }
}
