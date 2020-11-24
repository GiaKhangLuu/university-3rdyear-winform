using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CT_BC_SachMuonTheoTheLoaiDAO
    {
        private static THUVIENEntities db = new THUVIENEntities();

        public static void AddCT_BC(int idTheLoai, int idBaoCao, int soLuotMuon, double tiLe)
        {
            CT_BAO_CAO_SACH_MUON_THEO_THE_LOAI ctbc = new CT_BAO_CAO_SACH_MUON_THEO_THE_LOAI();
            ctbc.IDTheLoai = idTheLoai;
            ctbc.IDBaoCaoSachMuonTheoTheLoai = idBaoCao;
            ctbc.SoLuotMuon = soLuotMuon;
            ctbc.TiLe = tiLe;
            db.CT_BAO_CAO_SACH_MUON_THEO_THE_LOAI.Add(ctbc);
            db.SaveChanges();
        }
    }
}
