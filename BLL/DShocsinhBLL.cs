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
        DShocsinhAccess danhsachhocsinh = new DShocsinhAccess();
        public DShocsinhBLL() : base() { }
        public List<HocSinh> GetAllHocSinh()
        {
            
            return danhsachhocsinh.GetAllDShocsinh();
        }

        public HocSinh GetHocSinh(string maHocSinh)
        {
            return danhsachhocsinh.GetHocSinh(maHocSinh);
        }

        public List<HocSinh> GetDSHocSinhTheoLop(string malop)
        {
            return danhsachhocsinh.GetDSHocSinhTheoLop(malop);
        }
        public bool ThemHS(string ma, string ten, string gioitinh, string diachi, string email,string namsinh)
        {
            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.ThemHs(ma, ten, gioitinh, diachi, email,namsinh);
        }

        public bool SuaHS(string ma, string ten, string gioitinh, string diachi, string email,string namsinh)
        {
            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.SuaHs(ma, ten, gioitinh, diachi, email,namsinh);
        }

        public bool XoaHs(string ma)
        {
            DShocsinhAccess ac = new DShocsinhAccess();
            return ac.XoaHS(ma);
        }
    }
}
