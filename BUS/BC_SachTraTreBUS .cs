using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Collections;

namespace BUS
{
    public class BC_SachTraTreBUS
    {
        public static IList BaoCaoSachTraTre(DateTime ngayBaoCao)
        {
            return BC_SachTraTreDAO.LoadSachTraTre(ngayBaoCao);
        }

        public static int AddBaoCao(DateTime ngayBaoCao)
        {
            return BC_SachTraTreDAO.AddBC_SachTraTre(ngayBaoCao);
        }
    }
}
