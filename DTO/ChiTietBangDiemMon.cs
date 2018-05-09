using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietBangDiemMon
    {
        string MaCTBangDiemMon;
        string MaBangDiemMon;
        string MaHTKT;
        float Diem;

        public ChiTietBangDiemMon(string mact, string mabd, string mahtkt, float diem)
        {
            this.MaCTBangDiemMon = mact;
            this.MaBangDiemMon = mabd;
            this.MaHTKT = mahtkt;
            this.Diem = diem;
        }
    }
}
