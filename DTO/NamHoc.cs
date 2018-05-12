using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NamHoc
    {
        public string MaNamHoc;
        public int Nam1;
        public int Nam2;

        public NamHoc(string ma, int n1, int n2)
        {
            this.MaNamHoc = ma;
            this.Nam1 = n1;
            this.Nam2 = n2;
        }
    }
}
