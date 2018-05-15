using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class QuaTrinhHocTapBLL : DatabaseBLL
    {
        QuaTrinhHocTapAccess quatrinhoctap = new QuaTrinhHocTapAccess();

        public QuaTrinhHocTapBLL() : base()
        { }

        public List<QuaTrinhHocTap> GetListQuatrinhhoctap()
        { 
            return quatrinhoctap.GetAllQuaTrinhHocTap();
        }

        public List<QuaTrinhHocTap> GetQuaTrinhHocTapCoMaHS(string maHS)
        {
            QuaTrinhHocTapAccess quatrinhoctap = new QuaTrinhHocTapAccess();
            return quatrinhoctap.GetQuaTrinhHocTapCoMaHS(maHS);
        }

        public QuaTrinhHocTap GetQuaTrinhHocTapCo(string maHS, string hocKy, string namHoc)
        {
            return quatrinhoctap.GetQuaTrinhHocTapCo(maHS, hocKy, namHoc);
        }

        public bool XoaQuatrinhoctap(string maQTH)
        {
            return quatrinhoctap.XoaQuaTrinhHocTap(maQTH);

        }

        public bool ThemQuatrinhhoctap(string ma, string malop, string mahky, string manamhoc,string mahsinh, float diemtbhk)
        {
            return quatrinhoctap.ThemQuaTrinhHocTap(ma, malop, mahky,manamhoc, mahsinh, diemtbhk);
        }

        public ErrorType SuaQuatrinhhoctap(string ma, string malop, string mahky, string manamhoc,string mahsinh, float diemtbhk)
        {
            //Kiem tra xem co ton tai khong da, vi minh khong check khoa chinh
            //nen phai check bo 3: ma hs- nam hoc- hoc ky nay, neu ton tai thi khong them nua
            QuaTrinhHocTap check = null;
            check = quatrinhoctap.GetQuaTrinhHocTapCo(mahsinh, mahky, manamhoc);
            if (check != null)
                return ErrorType.DA_TON_TAI;
            else
            return quatrinhoctap.SuaQuaTrinhHocTap(ma, malop, mahky,manamhoc, mahsinh, diemtbhk);
        }
    }
}

