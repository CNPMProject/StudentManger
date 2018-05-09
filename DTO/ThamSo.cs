using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo
    {
        string TenThamSo;
        float GiaTri;

        public ThamSo(string tenThamSo, float giaTri)
        {
            this.TenThamSo = tenThamSo;
            this.GiaTri = giaTri;
        }
    }
}
