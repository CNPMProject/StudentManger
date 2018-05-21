using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinh
    {
        public string MaHocSinh;
        public string HoVaTen;
        public string GioiTinh;
        public string DiaChi;
        public string Email;
        public string NamSinh;
        public string TrangThai;

        public HocSinh(string ma, string ten, string gioiTinh, string dc, string email,string namsinh,string TrangThai)
        {
            this.MaHocSinh = ma;
            this.HoVaTen = ten;
            this.GioiTinh = gioiTinh;
            this.DiaChi = dc;
            this.Email = email;
            this.NamSinh = namsinh;
            this.TrangThai = TrangThai;
        }
    }
}
