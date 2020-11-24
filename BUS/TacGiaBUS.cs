using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class TacGiaBUS
    { 
        public static Array LoadTacGia()
        {
            var tacGias = TacGiaDAO.LoadTacGia();
            return tacGias;
        }

        public static List<TACGIA> GetTacGias()
        {
            return TacGiaDAO.GetTacGias();
        }

        public static void AddTacGia(string tenTacGia)
        {
            TacGiaDAO.AddTacGia(tenTacGia);
        }

        public static void UpdateTacGia(string idTacGia, string tenTacGia)
        {
            TacGiaDAO.UpdateTacGia(Int32.Parse(idTacGia), tenTacGia);
        }

        public static void DeletaTacGia(string idTacGia)
        {
            TacGiaDAO.DeleteTacGia(Int32.Parse(idTacGia));
        }
    }
}
