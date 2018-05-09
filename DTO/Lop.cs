using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        string MaLop;
        string TenLop;
        string MaKhoiLop;
        int SiSo;

        public Lop(string maLop, string ten, string maKhoi, int siSo)
        {
            this.MaLop = maLop;
            this.TenLop = ten;
            this.MaKhoiLop = maKhoi;
            this.SiSo = siSo;
        }
    }
}
