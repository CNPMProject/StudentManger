using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangDiemDayDu
    {
        public string maHS;
        public string tenHS;
        public string HinhThucKT;
        public float DiemHTKT;
        public float DiemTB;

        public BangDiemDayDu(string mahocsinh,string tenhocsinh,string tenhtkt,float diemhtkt,float diemtb)
        {
            this.maHS = mahocsinh;
            this.tenHS = tenhocsinh;
            this.HinhThucKT = tenhtkt;
            this.DiemHTKT = diemhtkt;
            this.DiemTB = diemtb;
        }
    }
}
