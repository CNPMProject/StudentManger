using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BangDiemMonBLL:DatabaseBLL
    {
        BangDiemMonAccess bdac = new BangDiemMonAccess();
        public BangDiemMonBLL() : base() { }

        public BangDiemMon GetBangDiemMon(string maquatrinh,string mamonhoc)
        {
            return bdac.GetBangDiemMon(maquatrinh, mamonhoc);
        }

        public List<BangDiemDayDu> GetListBangDiemMonDayDu(string maLop, string mahocky, string namhoc, string monhoc)
        {
            return bdac.GetListBangDiemMonDayDu(maLop, mahocky, namhoc, monhoc);
        }

        public ErrorType ThemBDM(string maBD,string maQTH,string maMH)
        {
            return bdac.ThemBD(maBD, maQTH, maMH);
        }

        public string GetMaBDMMax()
        {
            return bdac.GetMaBDMMax();
        }
    }
}
