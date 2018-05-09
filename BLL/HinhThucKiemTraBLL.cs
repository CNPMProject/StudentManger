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

        public bool ThemHinhThucKiemTra(string ma, string ten, int heso)
        {
            HinhThucKiemTraAccess ac = new HinhThucKiemTraAccess();
            return ac.ThemHTKT(ma, ten, heso);
        }

        public bool SuaHinhThucKiemTra(string ma, string ten, int heso)
        {
            HinhThucKiemTraAccess ac = new HinhThucKiemTraAccess();
            return ac.SuaHTKT(ma, ten, heso);
        }

        public bool XoaHinhThucKiemTra(string ma)
        {
            HinhThucKiemTraAccess ac = new HinhThucKiemTraAccess();
            return ac.XoaHTKT(ma);
        }
    }
}
