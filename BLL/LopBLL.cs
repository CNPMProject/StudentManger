using System.Collections.Generic;
using DTO;
using DAL;

namespace BLL
{
    public class LopBLL : DatabaseBLL
    {
        LopAccess lopaccess = new LopAccess();
        public LopBLL() : base()
        { }

        public List<Lop> GetListLop()
        {           
            return lopaccess.GetAllLop();
        }

        public Lop GetLop(string maLop)
        {
            return lopaccess.GetLop(maLop);
        }

        public int CountSoLuongLopTheoKhoi(string maKhoi)
        {
            return lopaccess.CountSoLuongLopTheoKhoi(maKhoi);
        }

        public bool Xoalop(string maMH)
        {
            return lopaccess.XoaLop(maMH);
        }

        public bool Themlop(string ma, string ten, string makhoi, int siso)
        {
            return lopaccess.ThemLop(ma, ten, makhoi, siso);
        }

        public bool SuaLop(string ma, string ten, string makhoi, int siso)
        {
      
            return lopaccess.SuaLop(ma, ten, makhoi, siso);
        }
    }
}
