using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class HocKyBLL : DatabaseBLL
    {
        public HocKyBLL() : base()
        { }


        public List<HocKy> GetListHocKy()
        {
            HocKyAccess hocky = new HocKyAccess();
            return hocky.GetAllHocKy();
        }

        public bool XoaHocKy(string maHK)
        {
            HocKyAccess hocky = new HocKyAccess();
            return hocky.XoaHocKy(maHK);
        }

        public bool ThemHocKy(string mahocky, string manamhoc)
        {
            HocKyAccess hocky = new HocKyAccess();
            return hocky.ThemHocKy(mahocky, manamhoc);
        }

        public bool SuaHocKy(string mahocky, string manamhoc)
        {
            HocKyAccess hocky = new HocKyAccess();
            return hocky.SuaHocKy(mahocky, manamhoc);
        }
    }
}

