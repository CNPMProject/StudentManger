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

        public ErrorType ThemMonHoc(string ma, string ten)
        {
            MonHocAccess mh = new MonHocAccess();
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                return ErrorType.KI_TU_RONG;

            MonHoc monhoc = mh.GetMonHoc(ma);
            if (monhoc != null)
                return ErrorType.DA_TON_TAI;

            return mh.ThemMonHoc(ma, ten);
        }

        public ErrorType SuaMonHoc(string ma, string ten)
        {
            MonHocAccess mhac = new MonHocAccess();
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
                return ErrorType.KI_TU_RONG;

            return mhac.SuaMonHoc(ma, ten);
        }
    }
}
