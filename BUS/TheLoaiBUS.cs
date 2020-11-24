using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class TheLoaiBUS
    { 
        public static Array LoadTheLoai()
        {
            var theloais = TheLoaiDAO.LoadTheLoai();
            return theloais;
        }

        public static List<THELOAI> GetTHELOAIs()
        {
            return TheLoaiDAO.GetTheLoais();
        }

        public static void AddTheLoai(string tenTheLoai)
        {
            TheLoaiDAO.AddTheLoai(tenTheLoai);
        }

        public static void UpdateTheLoai(string idTheLoai, string tenTheLoai)
        {
            TheLoaiDAO.UpdateTheLoai(Int32.Parse(idTheLoai), tenTheLoai);
        }

        public static void DeleteTheLoai(string idTheLoai)
        {
            TheLoaiDAO.DeleteTheLoai(Int32.Parse(idTheLoai));
        }

    }
}
