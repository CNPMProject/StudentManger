using System.Collections.Generic;
using DTO;
using DAL;
using System;

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

        public List<Lop> GetLopTheoNamHoc(string namhoc)
        {
            return lopaccess.GetLopTheoNamHoc( namhoc);
        }

        public int CountSoLuongLopTheoKhoi(string maKhoi)
        {
            return lopaccess.CountSoLuongLopTheoKhoi(maKhoi);
        }

        public string GetMaLopMax()
        {
            return lopaccess.GetMaLopMax();
        }

        public Lop GetLop(string tenlop, string namhoc)
        {
            return lopaccess.GetLop(tenlop, namhoc);
        }

        public bool Xoalop(string maMH)
        {
            return lopaccess.XoaLop(maMH);
        }

        public ErrorType Themlop(string ma, string ten, string makhoi, string siso)
        {
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(makhoi) || string.IsNullOrEmpty(siso))
                return ErrorType.KI_TU_RONG;

            if (lopaccess.ThemLop(ma, ten, makhoi, Int32.Parse(siso)))
                return ErrorType.THANH_CONG;
            return ErrorType.THAT_BAI;
        }

        public ErrorType SuaLop(string ma, string ten, string makhoi, string siso)
        {
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(makhoi) || string.IsNullOrEmpty(siso))
                return ErrorType.KI_TU_RONG;

            if( lopaccess.SuaLop(ma, ten, makhoi,Int32.Parse( siso)))
                return ErrorType.THANH_CONG;
            return ErrorType.THAT_BAI;
        }
    }
}
