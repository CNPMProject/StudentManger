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
        public string TenHocKy;

        public HocKy(string hk, string ten)
        {
            this.MaHocKy = hk;
            this.TenHocKy= ten;
        }
    }
}
