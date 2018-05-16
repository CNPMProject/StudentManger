using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class HinhThucKiemTraBLL : DatabaseBLL
    {
        public HinhThucKiemTraBLL() : base() { }

        public List<HinhThucKiemTra> GetAllHinhThucKiemTra()
        {
            HinhThucKiemTraAccess hinhThucKiemTra = new HinhThucKiemTraAccess();
            return hinhThucKiemTra.GetAllHinhThucKiemTra();
        }

        public ErrorType ThemHinhThucKiemTra(string ma, string ten, string heso)
        {
            HinhThucKiemTraAccess ac = new HinhThucKiemTraAccess();
            HinhThucKiemTra ht = ac.GetHinhThucKiemTra(ma);

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(heso))
                return ErrorType.KI_TU_RONG;
            if (ht != null)
                return ErrorType.DA_TON_TAI;
            else
            return ac.ThemHTKT(ma, ten,Int32.Parse( heso));
        }

        public ErrorType SuaHinhThucKiemTra(string ma, string ten, string heso)
        {
            HinhThucKiemTraAccess ac = new HinhThucKiemTraAccess();
            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(heso))
                return ErrorType.KI_TU_RONG;
            return ac.SuaHTKT(ma, ten,Int32.Parse( heso));
        }

        public bool XoaHinhThucKiemTra(string ma)
        {
            HinhThucKiemTraAccess ac = new HinhThucKiemTraAccess();
            return ac.XoaHTKT(ma);
        }
    }
}
