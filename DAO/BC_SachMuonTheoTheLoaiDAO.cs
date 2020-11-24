using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BC_SachMuonTheoTheLoaiDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static IList LoadSachMuonTheoTheLoai(int month)
        {
            return CT_PhieuMuonDAO.LoadSachMuonTheOTheLoai(month);
        }

        public static int AddBC_SachMuonTheoTheLoai(int thangBaoCao)
        {
            BAO_CAO_SACH_MUON_THEO_THE_LOAI baoCao = new BAO_CAO_SACH_MUON_THEO_THE_LOAI();
            baoCao.ThangBaoCao = thangBaoCao;
            db.BAO_CAO_SACH_MUON_THEO_THE_LOAI.Add(baoCao);
            db.SaveChanges();
            return baoCao.IDBaoCaoSachMuonTheoTheLoai;
        }
    }
}
