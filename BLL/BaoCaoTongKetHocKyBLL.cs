using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BaoCaoTongKetHocKyBLL : DatabaseBLL
    {
        public BaoCaoTongKetHocKyBLL() : base()
        { }

        public List<BaoCaoTongKetHocKy> GetListBaoCaoTongKetHocKy()
        {
            BaoCaoTongKetHocKyAccess baoCaoTongKetHocKyAccess = new BaoCaoTongKetHocKyAccess();
            return baoCaoTongKetHocKyAccess.GetAllBaoCaoTongKetHocKy();
        }

        public bool XoaBaoCaoTongKetHocKy(string MaHocKy, string MaNamHoc,string MaLop)
        {
            BaoCaoTongKetHocKyAccess BCTKHK = new BaoCaoTongKetHocKyAccess();
            return BCTKHK.XoaBaoCaoTongKetHocKy(MaHocKy, MaNamHoc,MaLop);
        }

        public bool ThemBaoCaoTongKetHocKy(string MaHocKy,string MaNamHoc, string MaLop, int SoLuongDat,  float Tile)
        {
            BaoCaoTongKetHocKyAccess BaoCaoTKHK = new BaoCaoTongKetHocKyAccess();
            return BaoCaoTKHK.ThemBaoCaoTongKetHocKy(MaHocKy,MaNamHoc, MaLop, SoLuongDat,Tile);
        }

        public bool SuaBaoCaoTongKetHocKy(string MaHocKy, string MaNamHoc,string MaLop, int SoLuongDat, float Tile)
        {
            BaoCaoTongKetHocKyAccess BCTKHocKy = new BaoCaoTongKetHocKyAccess();
            return BCTKHocKy.SuaBaoCaoTongKetHocKy(MaHocKy,MaNamHoc, MaLop, SoLuongDat, Tile);
        }
    }
}
