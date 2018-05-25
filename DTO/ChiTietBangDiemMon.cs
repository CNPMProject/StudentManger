using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietBangDiemMon
    {
        public string MaCTBangDiemMon;
        public string MaBangDiemMon;
        public string MaHTKT;
        public float Diem;

        public ChiTietBangDiemMon(string mact, string mabd, string mahtkt, float diem)
        {
            this.MaCTBangDiemMon = mact;
            this.MaBangDiemMon = mabd;
            this.MaHTKT = mahtkt;
            this.Diem = diem;
        }
    }
}
