using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
