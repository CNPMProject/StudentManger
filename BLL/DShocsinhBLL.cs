using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class DShocsinhBLL : DatabaseBLL
    {
        public DShocsinhBLL() : base() { }
        public List<HocSinh> GetAllHinhThucKiemTra()
        {
            DShocsinhAccess danhsachhocsinh = new DShocsinhAccess();
            return danhsachhocsinh.GetAllDShocsinh();
        }
        public bool ThemHS(string ma, string ten, string gioitinh, string diachi, string email)
        {
            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.ThemHs(ma, ten, gioitinh, diachi, email);
        }

        public bool SuaHS(string ma, string ten, string gioitinh, string diachi, string email)
        {
            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.SuaHs(ma, ten, gioitinh, diachi, email);
        }

        public bool XoaHs(string ma)
        {
            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.XoaHS(ma);
        }
    }
}
