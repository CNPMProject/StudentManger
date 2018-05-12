using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class MonHocBLL : DatabaseBLL
    {
        public MonHocBLL() : base()
        { }

        public List<MonHoc> GetListMonHoc()
        {
            MonHocAccess monHocAccess = new MonHocAccess();
            return monHocAccess.GetAllMonHoc();
        }

        public MonHoc GetMonHoc(string maMonHoc)
        {
            MonHocAccess mh = new MonHocAccess();
            return mh.GetMonHoc(maMonHoc);
        }

        public bool XoaMonHoc(string maMH)
        {
            MonHocAccess mn = new MonHocAccess();
            return mn.XoaMonHoc(maMH);
        }

        public bool ThemMonHoc(string ma, string ten)
        {
            MonHocAccess mh = new MonHocAccess();
            return mh.ThemMonHoc(ma, ten);
        }

        public bool SuaMonHoc(string ma, string ten)
        {
            MonHocAccess mhac = new MonHocAccess();
            return mhac.SuaMonHoc(ma, ten);
        }
    }
}
