using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class HocKy_NamHocBLL : DatabaseBLL
    {
        public HocKy_NamHocBLL() : base()
        { }


        public List<HocKy_NamHoc> GetListHocKy_NamHoc()
        {
            HocKy_NamHocAccess hocky_namhoc = new HocKy_NamHocAccess();
            return hocky_namhoc.GetAllHocKy_NamHoc();
        }

        public bool XoaHocKy_NamHoc(string maHK,string manamhoc)
        {
            HocKy_NamHocAccess hocky_namhoc = new HocKy_NamHocAccess();
            return hocky_namhoc.XoaHocKy_NamHoc(maHK, manamhoc);
        }

        public bool ThemHocKy_NamHoc(string mahocky, string manamhoc)
        {
            HocKy_NamHocAccess hocky_namhoc = new HocKy_NamHocAccess();
            return hocky_namhoc.ThemHocKy_NamHoc(mahocky, manamhoc);
        }

        public bool SuaHocKy_namhoc(string mahocky, string manamhoc)
        {
            HocKy_NamHocAccess hocky_namhoc = new HocKy_NamHocAccess();
            return hocky_namhoc.SuaHocKy_Namhoc(mahocky, manamhoc);
        }
    }
}

