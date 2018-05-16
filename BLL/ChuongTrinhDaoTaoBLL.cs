using System.Collections.Generic;
using DTO;
using DAL;
using System;

namespace BLL
{
    public class ChuongTrinhDaoTaoBLL : DatabaseBLL
    {
        public ChuongTrinhDaoTaoBLL() : base() { }

        public List<ChuongTrinhDaoTao> GetAllCTDT()
        {
            ChuongTrinhDaoTaoAccess acess = new ChuongTrinhDaoTaoAccess();
            return acess.GetAllCTDT();
        }

        public ChuongTrinhDaoTao GetChuongTrinhDaoTao(string mamon)
        {
            ChuongTrinhDaoTaoAccess ctdt = new ChuongTrinhDaoTaoAccess();
            return ctdt.GetChuongTrinhDaoTao(mamon);
        }

        public ErrorType ThemCTDT(string khoi, string mon, string heso)
        {
            ChuongTrinhDaoTaoAccess ct = new ChuongTrinhDaoTaoAccess();

            if (string.IsNullOrEmpty(khoi) || string.IsNullOrEmpty(mon)|| string.IsNullOrEmpty(heso))
                return ErrorType.KI_TU_RONG;

            ChuongTrinhDaoTao ctdt = ct.GetChuongTrinhDaoTao(mon, khoi);
            if (ctdt != null)
                return ErrorType.DA_TON_TAI;

            return ct.ThemCTDT(khoi, mon, Int32.Parse(heso));
        }

        public ErrorType SuaCTDT(string khoi, string mon, string heso)
        {
            ChuongTrinhDaoTaoAccess ct = new ChuongTrinhDaoTaoAccess();
            if (string.IsNullOrEmpty(khoi) || string.IsNullOrEmpty(mon) || string.IsNullOrEmpty(heso))
                return ErrorType.KI_TU_RONG;

            return ct.SuaCTDT(khoi, mon,Int32.Parse( heso));
        }

        public bool XoaCTDT(string khoi, string mon)
        {
            ChuongTrinhDaoTaoAccess ct = new ChuongTrinhDaoTaoAccess();
            return ct.XoaCTDT(khoi, mon);
        }
    }
}
