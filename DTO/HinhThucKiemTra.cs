using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HinhThucKiemTra
    {
        public string MaHTKT;
        public string TenHTKT;
        public int HeSo;

        public HinhThucKiemTra(string ma, string ten, int hs)
        {
            this.MaHTKT = ma;
            this.TenHTKT = ten;
            this.HeSo = hs;
        }
    }
}
