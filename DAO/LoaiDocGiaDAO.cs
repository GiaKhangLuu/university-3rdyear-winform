using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiDocGiaDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static List<LOAIDOCGIA> LoadLoaiDocGia()
        {
            var loaiDocGias = from loaiDocGia
                              in db.LOAIDOCGIAs
                              select loaiDocGia;
            //select new { IDLoaiDocGia = loaiDocGia.IDLoaiDocGia, TenLoaiDocGia = loaiDocGia.TenLoaiDocGia };
            return loaiDocGias.ToList();
        }

        public static void AddLoaiDocGia(string tenLoaiDG)
        {
            LOAIDOCGIA loaiDG = new LOAIDOCGIA();
            loaiDG.TenLoaiDocGia = tenLoaiDG;
            db.LOAIDOCGIAs.Add(loaiDG);
            db.SaveChanges();
        }

        public static void UpdateLoaiDocGia(int idLoaiDG, string tenLoaiDG)
        {
            LOAIDOCGIA loaiDG = db.LOAIDOCGIAs.Find(idLoaiDG);
            loaiDG.TenLoaiDocGia = tenLoaiDG;
            db.SaveChanges();
        }

        public static void DeleteLoaiDocGia(int idLoaiDG)
        {
            LOAIDOCGIA loaiDG = db.LOAIDOCGIAs.Find(idLoaiDG);
            db.LOAIDOCGIAs.Remove(loaiDG);
            db.SaveChanges();
        }
    }
}
