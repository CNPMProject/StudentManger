using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh
    {
        string MaHocSinh;
        string HoVaTen;
        string GioiTinh;
        string DiaChi;
        string Email;

        public HocSinh(string ma, string ten, string gioiTinh, string dc, string email)
        {
            this.MaHocSinh = ma;
            this.HoVaTen = ten;
            this.GioiTinh = gioiTinh;
            this.DiaChi = dc;
            this.Email = email;
        }
    }
}
