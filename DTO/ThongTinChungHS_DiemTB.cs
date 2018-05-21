using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinChungHS_DiemTB
    {
        public string maHocSinh;
        public string TenHocSinh;
        public string Lop;
        public string maHocKy;
        public string diemTB;

        public ThongTinChungHS_DiemTB(string maHocSinh, string TenHocSinh, string Lop, string maHocKy, string diemTB)
        {
            this.maHocSinh = maHocSinh;
            this.TenHocSinh = TenHocSinh;
            this.Lop=Lop;
            this.maHocKy = maHocKy;
            this.diemTB = diemTB;
        }
    }
}
