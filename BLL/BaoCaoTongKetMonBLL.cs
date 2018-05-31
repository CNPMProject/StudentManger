using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BaoCaoTongKetMonBLL : DatabaseBLL
    {
        public BaoCaoTongKetMonBLL() : base()
        { }

        public List<BaoCaoTongKetMon> GetListBaoCaoTongKetMon()
        {
            BaoCaoTongKetMonAccess baoCaoTongKetMonAccess = new BaoCaoTongKetMonAccess();
            return baoCaoTongKetMonAccess.GetAllBaoCaoTongKetMon();
        }

        public ErrorType TaoBaoCaoTongKetMon(string hocky, string namhoc, string monhoc)
        {
            BaoCaoTongKetMonAccess baoCaoTongKetMonAccess = new BaoCaoTongKetMonAccess();
            return baoCaoTongKetMonAccess.TaoBaoCaoTongKetMon(hocky, namhoc, monhoc);
        }

        public bool XoaBaoCaoTongKetMon(string MaBCTKM)
        {
            BaoCaoTongKetMonAccess BCTKMon = new BaoCaoTongKetMonAccess();
            return BCTKMon.XoaBaoCaoTongKetMon(MaBCTKM);
        }

        public bool ThemBaoCaoTongKetMon(string MaBCTKM, string MaMonHoc, string MaHocKy,string MaNamHoc)
        {
            BaoCaoTongKetMonAccess BaoCaoTKM = new BaoCaoTongKetMonAccess();
            return BaoCaoTKM.ThemBaoCaoTongKetMon(MaBCTKM, MaMonHoc, MaHocKy,MaNamHoc);
        }

        public bool SuaBaoCaoTongKetMon(string MaBCTKM, string MaMonHoc, string MaHocKy,string MaNamHoc)
        {
            BaoCaoTongKetMonAccess BCTKM = new BaoCaoTongKetMonAccess();
            return BCTKM.SuaBaoCaoTongKetMon(MaBCTKM, MaMonHoc, MaHocKy,MaNamHoc);
        }
    }
}
