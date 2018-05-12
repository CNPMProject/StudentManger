using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoiLop
    {
        public string MaKhoiLop;
        public string TenKhoiLop;
        public string Ban;
        public string MaNamHoc;

        public KhoiLop(string ma, string ten, string ban, string manh)
        {
            this.MaKhoiLop = ma;
            this.TenKhoiLop = ten;
            this.Ban = ban;
            this.MaNamHoc = manh;
        }
    }
}
