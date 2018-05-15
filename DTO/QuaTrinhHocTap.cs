using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuaTrinhHocTap
    {
        public string MaQTH;
        public string MaLop;
        public string MaHocKy;
        public string MaNamHoc;
        public string MaHocSinh;
        public float DiemTBHk;

        public QuaTrinhHocTap(string qth, string ml, string mhk, string manamhoc,string mhs, float tb)
        {
            this.MaQTH = qth;
            this.MaLop = ml;
            this.MaHocKy = mhk;
            this.MaNamHoc = manamhoc;
            this.MaHocSinh = mhs;
            this.DiemTBHk = tb;
        }
    }
}
