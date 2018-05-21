using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangDiemMon
    {
        public string MaBangDiemMon;
        public string MaQTH;
        public string MaMonHoc;
        public float DiemTBMon;

        public BangDiemMon(string mbd, string mqt, string mmh, float tb)
        {
            this.MaBangDiemMon = mbd;
            this.MaQTH = mqt;
            this.MaMonHoc = mmh;
            this.DiemTBMon = tb;
        }
    }
}
