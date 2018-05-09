using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class NamHocBLL : DatabaseBLL
    {
        public NamHocBLL() : base()
        { }

        public List<NamHoc> GetListNamHoc()
        {
            NamHocAccess namhoc = new NamHocAccess();
            return namhoc.GetAllNamHoc();
        }

        public bool Xoanamhoc(string maNH)
        {
            NamHocAccess namhoc = new NamHocAccess();
            return namhoc.XoaNamHoc(maNH);
        }

        public bool ThemNamHoc(string ma, int nam1, int nam2)
        {
            NamHocAccess namhoc = new NamHocAccess();
            return namhoc.ThemNamHoc(ma, nam1, nam2);
        }

        public bool SuaNamHoc(string ma, int nam1, int nam2)
        {
            NamHocAccess namhoc = new NamHocAccess();
            return namhoc.SuaNamHoc(ma, nam1, nam2);

        }
    }
}

