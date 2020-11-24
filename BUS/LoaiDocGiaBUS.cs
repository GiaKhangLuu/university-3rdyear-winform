using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class LoaiDocGiaBUS
    { 
        public static List<LOAIDOCGIA> LoadLoaiDocGia()
        {
            var loaiDocGias = LoaiDocGiaDAO.LoadLoaiDocGia();
            return loaiDocGias;
        }

        public static void AddLoaiDG(string tenLoaiDG)
        {
            LoaiDocGiaDAO.AddLoaiDocGia(tenLoaiDG);
        }

        public static void UpdateLoaiDG(string idLoaiDG, string tenLoaiDG)
        {
            LoaiDocGiaDAO.UpdateLoaiDocGia(Int32.Parse(idLoaiDG), tenLoaiDG);
        }

        public static void DeleteLoaiDG(string idLoaiDG)
        {
            LoaiDocGiaDAO.DeleteLoaiDocGia(Int32.Parse(idLoaiDG));
        }
    }
}
