using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocKy
    {
        public string MaHocKy;
        public string MaNamHoc;

        public HocKy(string hk, string nh)
        {
            this.MaHocKy = hk;
            this.MaNamHoc = nh;
        }
    }
}
