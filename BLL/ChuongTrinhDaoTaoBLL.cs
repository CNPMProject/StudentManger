using System.Collections.Generic;
using DTO;
using DAL;

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

        public bool ThemCTDT(string khoi, string mon, int heso)
        {
            ChuongTrinhDaoTaoAccess ct = new ChuongTrinhDaoTaoAccess();
            return ct.ThemCTDT(khoi, mon, heso);
        }

        public bool SuaCTDT(string khoi, string mon, int heso)
        {
            ChuongTrinhDaoTaoAccess ct = new ChuongTrinhDaoTaoAccess();
            return ct.SuaCTDT(khoi, mon, heso);
        }

        public bool XoaCTDT(string khoi, string mon)
        {
            ChuongTrinhDaoTaoAccess ct = new ChuongTrinhDaoTaoAccess();
            return ct.XoaCTDT(khoi, mon);
        }
    }
}
