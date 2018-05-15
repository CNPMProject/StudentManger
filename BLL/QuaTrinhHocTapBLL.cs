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
        public QuaTrinhHocTapBLL() : base()
        { }

        public List<QuaTrinhHocTap> GetListQuatrinhhoctap()
        {
            QuaTrinhHocTapAccess quatrinhoctap = new QuaTrinhHocTapAccess();
            return quatrinhoctap.GetAllQuaTrinhHocTap();
        }

        public List<QuaTrinhHocTap> GetQuaTrinhHocTapCoMaHS(string maHS)
        {
            QuaTrinhHocTapAccess quatrinhoctap = new QuaTrinhHocTapAccess();
            return quatrinhoctap.GetQuaTrinhHocTapCoMaHS(maHS);
        }

        public bool XoaQuatrinhoctap(string maQTH)
        {
            QuaTrinhHocTapAccess qtrinh = new QuaTrinhHocTapAccess();
            return qtrinh.XoaQuaTrinhHocTap(maQTH);

        }

        public bool ThemQuatrinhhoctap(string ma, string malop, string mahky, string manamhoc,string mahsinh, float diemtbhk)
        {
            QuaTrinhHocTapAccess qtrinh = new QuaTrinhHocTapAccess();
            return qtrinh.ThemQuaTrinhHocTap(ma, malop, mahky,manamhoc, mahsinh, diemtbhk);
        }

        public bool SuaQuatrinhhoctap(string ma, string malop, string mahky, string manamhoc,string mahsinh, float diemtbhk)
        {
            QuaTrinhHocTapAccess qtrinh = new QuaTrinhHocTapAccess();
            return qtrinh.SuaQuaTrinhHocTap(ma, malop, mahky,manamhoc, mahsinh, diemtbhk);
        }
    }
}

