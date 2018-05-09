using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHoc
    {
        public string MaMonHoc;
        public string TenMonHoc;

        public MonHoc(string ma, string ten)
        {
            this.MaMonHoc = ma;
            this.TenMonHoc = ten;
        }
    }
}
