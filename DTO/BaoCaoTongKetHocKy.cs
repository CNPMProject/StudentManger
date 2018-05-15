using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoTongKetHocKy
    {
        string MaHocKy;
        string MaNamHoc;
        string MaLop;
        int SoLuongDat;
        float Tile;

        public BaoCaoTongKetHocKy(string maHK, string MaNamHoc,string maLop, int soLuongDat, float tile)
        {
            this.MaHocKy = maHK;
            this.MaNamHoc = MaNamHoc;
            this.MaLop = maLop;
            this.SoLuongDat = soLuongDat;
            this.Tile = tile;
        }
    }
}
