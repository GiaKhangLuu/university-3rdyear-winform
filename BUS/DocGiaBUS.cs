using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class DocGiaBUS
    { 
        public static Array LoadDocGia()
        {
            var docGias = DocGiaDAO.LoadDocGia();
            return docGias;
        }

        public static List<DOCGIA> GetDocGias()
        {
            var docGias = DocGiaDAO.GetDocGias();
            return docGias;
        }

        public static void UpdateNo(int idDocGia, double conLai)
        {
            DocGiaDAO.UpdateNo(idDocGia, conLai);
        }

        public static IList FindDocGia(int idDG, string tenDocGia, string tenLoaiDocGia, DateTime ngaySinh, string diaChi, 
            string email, DateTime ngayLapThe)
        {
            return DocGiaDAO.FindDocGia(idDG, tenDocGia, tenLoaiDocGia, ngaySinh, diaChi, email, ngayLapThe);
        }

        public static DOCGIA FindDocGiaById(int idDocGia)
        {
            return DocGiaDAO.FindDocGiaById(idDocGia);
        }

        public static void AddDocGia(string tenDG, int idLoaiDG, DateTime ngaySinh, string diaChi, string email, 
            DateTime ngayLapThe)
        {
            DocGiaDAO.AddDocGia(tenDG, idLoaiDG, ngaySinh, diaChi, email, ngayLapThe, 0);
        }

        public static void UpdateDocGia(int idDocGia, string tenDG, int idLoaiDG, DateTime ngaySinh, string diaChi, string email,
            DateTime ngayLapThe)
        {
            DocGiaDAO.UpdateDocGia(idDocGia, tenDG, idLoaiDG, ngaySinh, diaChi, email, ngayLapThe, 0);
        }

        public static void DeleteDocGia(int idDG)
        {
            DocGiaDAO.DeleteDocGia(idDG);
        }

        public static IList FindAll()
        {
            return DocGiaDAO.FindAll();
        }
    }
}
