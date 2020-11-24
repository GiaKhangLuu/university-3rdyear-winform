using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TacGiaDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static Array LoadTacGia()
        {
            var tacGias = from tacgia
                              in db.TACGIAs
                          select new { IDTacGia = tacgia.IDTacGia, TenTacGia = tacgia.TenTacGia };
            return tacGias.ToArray();
        }

        public static List<TACGIA> GetTacGias()
        {
            return db.TACGIAs.Select(tg => tg).ToList();
        }

        public static void AddTacGia(string tenTacGia)
        {
            TACGIA tg = new TACGIA();
            tg.TenTacGia = tenTacGia;
            db.TACGIAs.Add(tg);
            db.SaveChanges();
        }

        public static void UpdateTacGia(int idTacGia, string tenTacGia)
        {
            TACGIA tg = db.TACGIAs.Find(idTacGia);
            tg.TenTacGia = tenTacGia;
            db.SaveChanges();
        }

        public static void DeleteTacGia(int idTacGia)
        {
            TACGIA tg = db.TACGIAs.Find(idTacGia);
            db.TACGIAs.Remove(tg);
            db.SaveChanges();
        }
    }
}
