using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
   public  class HocKy_NamHoc
    {

        public string MaHocKy;
        public string MaNamHoc;
         
        public HocKy_NamHoc(string maHk,string maNH)
        {
            this.MaHocKy = maHk;
            this.MaNamHoc = maNH;
        }
    }
}
