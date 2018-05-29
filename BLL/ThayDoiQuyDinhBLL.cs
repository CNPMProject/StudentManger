using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ThayDoiQuyDinhBLL : DatabaseBLL
    {
        public ThayDoiQuyDinhBLL() : base()
        { }


        public List<ThamSo> GetListThamSo()
        {
            ThayDoiQuyDinhAccess thaydoi = new ThayDoiQuyDinhAccess();
            return thaydoi.GetAllThamSo();


        }

        public bool XoaThamSo(string mathamso)
        {
            ThayDoiQuyDinhAccess thamso = new ThayDoiQuyDinhAccess();
            return thamso.XoaThamSo(mathamso);

        }

        public bool ThemThamSo(string mathamso, string tenthamso, float giatri)
        {
            ThayDoiQuyDinhAccess thaydoi = new ThayDoiQuyDinhAccess();
            return thaydoi.ThemThamSo(mathamso, tenthamso, giatri);

        }

        public ErrorType SuaThamSo(string mathamso, decimal giatri)
        {

            #region Kiem tra rang buoc tu nhien

            if (giatri < 0)
                return ErrorType.VI_PHAM_RANG_BUOC_TU_NHIEN;

                List<ThamSo> listThamSo = GetListThamSo();
                foreach(ThamSo thamso in listThamSo)
                {
                //dang cap nhat diem toi thieu
                    if(mathamso== "TuoiToiThieu"&& thamso.MaThamSo == "TuoiToiDa")
                     {
                            decimal tuoiToiDa =(decimal)thamso.GiaTri;
                            if (giatri > tuoiToiDa)
                            return ErrorType.VI_PHAM_RANG_BUOC_TU_NHIEN;
                     }

                //dang cap nhat diem toi thieu
                if (mathamso == "TuoiToiDa" && thamso.MaThamSo == "TuoiToiThieu")
                {
                    decimal tuoiToiThieu = (decimal)thamso.GiaTri;
                    if (giatri < tuoiToiThieu)
                        return ErrorType.VI_PHAM_RANG_BUOC_TU_NHIEN;
                }

                //dang cap nhat diem toi thieu
                if (mathamso == "DiemToiDa" && thamso.MaThamSo == "DiemToiThieu")
                {
                    decimal DiemToiThieu = (decimal)thamso.GiaTri;
                    if (giatri < DiemToiThieu)
                        return ErrorType.VI_PHAM_RANG_BUOC_TU_NHIEN;
                }

                //dang cap nhat diem toi thieu
                if (mathamso == "DiemToiThieu" && thamso.MaThamSo == "DiemToiDa")
                {
                    decimal DiemToiDa = (decimal)thamso.GiaTri;
                    if (giatri > DiemToiDa)
                        return ErrorType.VI_PHAM_RANG_BUOC_TU_NHIEN;
                }
            }

            #endregion

            ThayDoiQuyDinhAccess thaydoi = new ThayDoiQuyDinhAccess();
            return thaydoi.SuaThamSo(mathamso, giatri);

        }
    }
}

