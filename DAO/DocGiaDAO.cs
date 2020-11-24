using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DocGiaDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static Array LoadDocGia()
        {
            var docGias = from docgia in db.DOCGIAs
                          select new
                          {
                              IDDocGia = docgia.IDDocGia,
                              TenDocGia = docgia.HoTen,
                              LoaiDocGia = docgia.LOAIDOCGIA.TenLoaiDocGia,
                              NgaySinh = docgia.NgaySinh,
                              DiaChi = docgia.DiaChi,
                              Email = docgia.Email,
                              NgayLapThe = docgia.NgayLapThe,
                              TongNo = docgia.TongNo
                          };
            return docGias.ToArray();
        }

        public static List<DOCGIA> GetDocGias()
        {
            var docGias = db.DOCGIAs.Select(dg => dg);
            return docGias.ToList();
        }

        public static void UpdateNo(int idDocGia, double tongNo)
        {
            DOCGIA docGia = db.DOCGIAs.Find(idDocGia);
            if(docGia != null)
            {
                docGia.TongNo = tongNo;
                db.SaveChanges();
            }
        }

        public static IList FindDocGia(int idDG, string hoTen, string tenLoaiDocGia, DateTime ngaySinh, string diaChi, string email, DateTime ngayLapThe)
        {
            if(idDG != -1)
            {
                IList dgs = GetDGByID(idDG);
                if (dgs.Count > 0) return dgs;
            }
            if(hoTen != "")
            {
                IList dgs = FindDocGiaByTen(hoTen);
                if (dgs.Count > 0) return dgs;
            }
            if(tenLoaiDocGia != "")
            {
                IList dgs = FindDocGiaByLoaiDocGia(tenLoaiDocGia);
                if (dgs.Count > 0) return dgs;
            }
            if(!ngaySinh.Equals(DateTime.MinValue))
            {
                IList dgs = FindDocGiaByNgaySinh(ngaySinh);
                if (dgs.Count > 0) return dgs;
            }
            if(diaChi != "")
            {
                IList dgs = FindDocGiaByDiaChi(diaChi);
                if (dgs.Count > 0) return dgs;
            }
            if (email != "")
            {
                IList dgs = FindDocGiaByEmail(email);
                if (dgs.Count > 0) return dgs;
            }         
            IList dg = FindDocGiaByNgayLapThe(ngayLapThe);
            return dg;    
        }

        private static IList FindDocGiaByTen(string hoTen)
        {
            var dgs = from dg in db.DOCGIAs
                      where dg.HoTen.Contains(hoTen)
                      select new
                      {
                          IDDocGia = dg.IDDocGia,
                          TenDocGia = dg.HoTen,
                          LoaiDocGia = dg.LOAIDOCGIA.TenLoaiDocGia,
                          NgaySinh = dg.NgaySinh,
                          DiaChi = dg.DiaChi,
                          Email = dg.Email,
                          NgayLapThe = dg.NgayLapThe,
                          TongNo = dg.TongNo
                      };
            return dgs.ToList();
        }

        private static IList FindDocGiaByLoaiDocGia(string tenLoaiDocGia)
        {
            var dgs = from dg in db.DOCGIAs
                      where dg.LOAIDOCGIA.TenLoaiDocGia.Equals(tenLoaiDocGia)
                      select new
                      {
                          IDDocGia = dg.IDDocGia,
                          TenDocGia = dg.HoTen,
                          LoaiDocGia = dg.LOAIDOCGIA.TenLoaiDocGia,
                          NgaySinh = dg.NgaySinh,
                          DiaChi = dg.DiaChi,
                          Email = dg.Email,
                          NgayLapThe = dg.NgayLapThe,
                          TongNo = dg.TongNo
                      };
            return dgs.ToList();
        }

        private static IList FindDocGiaByNgaySinh(DateTime ngaySinh)
        {
            var dgs = from dg in db.DOCGIAs
                      where DbFunctions.DiffDays(dg.NgaySinh, ngaySinh) == 0
                      select new
                      {
                          IDDocGia = dg.IDDocGia,
                          TenDocGia = dg.HoTen,
                          LoaiDocGia = dg.LOAIDOCGIA.TenLoaiDocGia,
                          NgaySinh = dg.NgaySinh,
                          DiaChi = dg.DiaChi,
                          Email = dg.Email,
                          NgayLapThe = dg.NgayLapThe,
                          TongNo = dg.TongNo
                      };
            return dgs.ToList();
        }

        private static IList FindDocGiaByDiaChi(string diaChi)
        {
            var dgs = from dg in db.DOCGIAs
                      where dg.DiaChi.Equals(diaChi)
                      select new
                      {
                          IDDocGia = dg.IDDocGia,
                          TenDocGia = dg.HoTen,
                          LoaiDocGia = dg.LOAIDOCGIA.TenLoaiDocGia,
                          NgaySinh = dg.NgaySinh,
                          DiaChi = dg.DiaChi,
                          Email = dg.Email,
                          NgayLapThe = dg.NgayLapThe,
                          TongNo = dg.TongNo
                      };
            return dgs.ToList();
        }

        private static IList FindDocGiaByEmail(string email)
        {
            var dgs = from dg in db.DOCGIAs
                      where dg.HoTen.Equals(email)
                      select new
                      {
                          IDDocGia = dg.IDDocGia,
                          TenDocGia = dg.HoTen,
                          LoaiDocGia = dg.LOAIDOCGIA.TenLoaiDocGia,
                          NgaySinh = dg.NgaySinh,
                          DiaChi = dg.DiaChi,
                          Email = dg.Email,
                          NgayLapThe = dg.NgayLapThe,
                          TongNo = dg.TongNo
                      };
            return dgs.ToList();
        }

        private static IList FindDocGiaByNgayLapThe(DateTime ngayLapThe)
        {
            var dgs = from dg in db.DOCGIAs
                      where DbFunctions.DiffDays(dg.NgayLapThe, ngayLapThe) == 0
                      select new
                      {
                          IDDocGia = dg.IDDocGia,
                          TenDocGia = dg.HoTen,
                          LoaiDocGia = dg.LOAIDOCGIA.TenLoaiDocGia,
                          NgaySinh = dg.NgaySinh,
                          DiaChi = dg.DiaChi,
                          Email = dg.Email,
                          NgayLapThe = dg.NgayLapThe,
                          TongNo = dg.TongNo
                      };
            return dgs.ToList();
        }

        private static IList GetDGByID(int idDG)
        {
            return (from dg in db.DOCGIAs
                    where dg.IDDocGia == idDG
                    select new
                    {
                        IDDocGia = dg.IDDocGia,
                        TenDocGia = dg.HoTen,
                        LoaiDocGia = dg.LOAIDOCGIA.TenLoaiDocGia,
                        NgaySinh = dg.NgaySinh,
                        DiaChi = dg.DiaChi,
                        Email = dg.Email,
                        NgayLapThe = dg.NgayLapThe,
                        TongNo = dg.TongNo
                    }).ToList();
        }

        public static DOCGIA FindDocGiaById(int idDocGia)
        {
            return db.DOCGIAs.Find(idDocGia);
        }

        public static void AddDocGia(string tenDocGia, int idLoaiDG, DateTime ngaySinh, string diaChi, string email,
            DateTime ngayLapThe, double tongNo)
        {
            DOCGIA dg = new DOCGIA();
            dg.HoTen = tenDocGia;
            dg.IDLoaiDocGia = idLoaiDG;
            dg.NgaySinh = ngaySinh;
            dg.DiaChi = diaChi;
            dg.Email = email;
            dg.NgayLapThe = ngayLapThe;
            dg.TongNo = tongNo;
            db.DOCGIAs.Add(dg);
            db.SaveChanges();
        }

        public static void UpdateDocGia(int idDocGia, string tenDocGia, int idLoaiDG, DateTime ngaySinh, string diaChi, string email,
            DateTime ngayLapThe, double tongNo)
        {
            DOCGIA dg = db.DOCGIAs.Find(idDocGia);
            dg.HoTen = tenDocGia;
            dg.IDLoaiDocGia = idLoaiDG;
            dg.NgaySinh = ngaySinh;
            dg.DiaChi = diaChi;
            dg.Email = email;
            dg.NgayLapThe = ngayLapThe;
            dg.TongNo = tongNo;
            db.SaveChanges();
        }

        public static void DeleteDocGia(int idDocGia)
        {
            DOCGIA dg = db.DOCGIAs.Find(idDocGia);
            db.DOCGIAs.Remove(dg);
            db.SaveChanges();
        }

        public static IList FindAll()
        {
            return (from dg in db.DOCGIAs
                    select new
                    {
                        IDDocGia = dg.IDDocGia,
                        TenDocGia = dg.HoTen,
                        LoaiDocGia = dg.LOAIDOCGIA.TenLoaiDocGia,
                        NgaySinh = dg.NgaySinh,
                        DiaChi = dg.DiaChi,
                        Email = dg.Email,
                        NgayLapThe = dg.NgayLapThe,
                        TongNo = dg.TongNo
                    }).ToList();
        }

    }
}
