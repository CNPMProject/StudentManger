using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class CTBangDiemMonBLL
    {
        CTBangDiemMonAccess ctbdac = new CTBangDiemMonAccess();

        public CTBangDiemMonBLL() : base() { }

        public ChiTietBangDiemMon GetCTBangDiemMon(string maBD, string maHTKT)
        {
            return ctbdac.GetCTBangDiemMon(maBD, maHTKT);
        }

        public ErrorType ThemCTBDM(string maCTBD, string maBD, string maHTKT, string diem)
        {
            if (string.IsNullOrEmpty(diem))
                return ErrorType.KI_TU_RONG;

            return ctbdac.ThemCTBD(maCTBD,maBD,maHTKT,float.Parse( diem));
        }

        public ErrorType SuaCTBDM(string maCTBD, string maBD, string maHTKT, string diem)
        {
            if (string.IsNullOrEmpty(diem))
                return ErrorType.KI_TU_RONG;

            return ctbdac.SuaCTBD(maCTBD, maBD, maHTKT, float.Parse(diem));
        }

        public string GetMaCTBDMMax()
        {
            return ctbdac.GetCTMaBDMMax();
        }
    }
}
