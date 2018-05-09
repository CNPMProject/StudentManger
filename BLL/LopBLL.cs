using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class LopBLL : DatabaseBLL
    {
        public LopBLL() : base()
        { }

        public List<Lop> GetListLop()
        {
            LopAccess lopaccess = new LopAccess();
            return lopaccess.GetAllLop();
        }

        public bool Xoalop(string maMH)
        {
            LopAccess lop = new LopAccess();
            return lop.XoaLop(maMH);
        }

        public bool Themlop(string ma, string ten, string makhoi, int siso)
        {
            LopAccess lop = new LopAccess();
            return lop.ThemLop(ma, ten, makhoi, siso);
        }

        public bool SuaLop(string ma, string ten, string makhoi, int siso)
        {
            LopAccess lop = new LopAccess();
            return lop.SuaLop(ma, ten, makhoi, siso);
        }
    }
}
