using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CT_BC_SachTraTreDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static void AddCT_BC(int idSach, int idBaoCao, DateTime ngayMuon, int soNgayTraTre)
        {
            CT_BAO_CAO_SACH_TRA_TRE ctbc = new CT_BAO_CAO_SACH_TRA_TRE();
            ctbc.IDSach = idSach;
            ctbc.IDBaoCaoSachTraTre = idBaoCao;
            ctbc.NgayMuon = ngayMuon;
            ctbc.SoNgayTraTre = soNgayTraTre;
            db.CT_BAO_CAO_SACH_TRA_TRE.Add(ctbc);
            db.SaveChanges();
        }
    }
}
