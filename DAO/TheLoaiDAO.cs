using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TheLoaiDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static Array LoadTheLoai()
        {
            var theloais = from theloai
                              in db.THELOAIs
                              select new { IDTheLoai = theloai.IDTheLoai, TenTheLoai = theloai.TenTheLoai };
            return theloais.ToArray();
        }

        public static List<THELOAI> GetTheLoais()
        {
            return db.THELOAIs.Select(tl => tl).ToList();
        }

        public static void AddTheLoai(string tenTheLoai)
        {
            THELOAI tl = new THELOAI();
            tl.TenTheLoai = tenTheLoai;
            db.THELOAIs.Add(tl);
            db.SaveChanges();
        }

        public static void UpdateTheLoai(int idTheLoai, string tenTheLoai)
        {
            THELOAI tl = db.THELOAIs.Find(idTheLoai);
            tl.TenTheLoai = tenTheLoai;
            db.SaveChanges();
        }

        public static void DeleteTheLoai(int idTheLoai)
        {
            THELOAI tl = db.THELOAIs.Find(idTheLoai);
            db.THELOAIs.Remove(tl);
            db.SaveChanges();
        }


    }
}
