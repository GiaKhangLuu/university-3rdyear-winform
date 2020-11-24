using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BC_SachTraTreDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static IList LoadSachTraTre(DateTime ngayBaoCao)
        {
            return CT_PhieuTraDAO.LoadSachTraTre(ngayBaoCao);
        }

        public static int AddBC_SachTraTre(DateTime ngayBaoCao)
        {
            BAO_CAO_SACH_TRA_TRE baoCao = new BAO_CAO_SACH_TRA_TRE();
            baoCao.NgayBaoCao = ngayBaoCao;
            db.BAO_CAO_SACH_TRA_TRE.Add(baoCao);
            db.SaveChanges();
            return baoCao.IDBaoCaoSachTraTre;
        }
    }
}
