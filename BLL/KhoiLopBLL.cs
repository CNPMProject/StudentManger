using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class KhoiLopBLL : DatabaseBLL
    {
        public KhoiLopBLL() : base()
        { }

        public List<KhoiLop> GetListKhoiLop()
        {
            KhoiLopAccess khoilopAccess = new KhoiLopAccess();
            return khoilopAccess.GetAllKhoilop();
        }

        public List<KhoiLop> GetListKhoiLop(string namhoc)
        {
            KhoiLopAccess khoilopAccess = new KhoiLopAccess();
            return khoilopAccess.GetAllKhoilop(namhoc);
        }

        public KhoiLop GetKhoiLop(string maKhoiLop)
        {
            KhoiLopAccess lopaccess = new KhoiLopAccess();
            return lopaccess.GetKhoiLop(maKhoiLop);
        }

        public KhoiLop GetKhoiLopTheoNH(string namhoc)
        {
            KhoiLopAccess lopaccess = new KhoiLopAccess();
            return lopaccess.GetKhoiLopTheoNH(namhoc);
        }

        public string GetMaKhoiLopMax()
        {
            KhoiLopAccess ac = new KhoiLopAccess();
            return ac.GetMaKhoiLopMax();
        }

        public bool XoaKhoilop(string maKL)
        {
            KhoiLopAccess kl = new KhoiLopAccess();
            return kl.XoaKhoiLop(maKL);
        }

        public ErrorType Themkhoilop(string ma, string ten, string ban, string manamhoc)
        {
            KhoiLopAccess kl = new KhoiLopAccess();
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ban) || string.IsNullOrEmpty(manamhoc))
                return ErrorType.KI_TU_RONG;

            if (kl.ThemKhoiLop(ma, ten, ban, manamhoc))
                return ErrorType.THANH_CONG;
            return ErrorType.THAT_BAI;
  
        }

        public ErrorType Suakhoilop(string ma, string ten, string ban, string manamhoc)
        {
            KhoiLopAccess kl = new KhoiLopAccess();
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ban) || string.IsNullOrEmpty(manamhoc))
                return ErrorType.KI_TU_RONG;

            if (kl.SuaKhoiLop(ma, ten, ban, manamhoc))
                return ErrorType.THANH_CONG;
            return ErrorType.THAT_BAI;
        }
    }
}

