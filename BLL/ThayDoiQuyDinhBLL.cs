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

        public bool SuaThamSo(string mathamso, decimal giatri)
        {
            ThayDoiQuyDinhAccess thaydoi = new ThayDoiQuyDinhAccess();
            return thaydoi.SuaThamSo(mathamso, giatri);

        }
    }
}

