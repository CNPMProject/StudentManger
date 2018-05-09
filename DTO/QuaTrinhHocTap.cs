using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuaTrinhHocTap
    {
        string MaQTH;
        string MaLop;
        string MaHocKy;
        string MaHocSinh;
        float DiemTBHk;

        public QuaTrinhHocTap(string qth, string ml, string mhk, string mhs, float tb)
        {
            this.MaQTH = qth;
            this.MaLop = ml;
            this.MaHocKy = mhk;
            this.MaHocSinh = mhs;
            this.DiemTBHk = tb;
        }
    }
}
