using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo
    {
       public string MaThamSo;
        public  string TenThamSo;
        public float GiaTri;
      
        public ThamSo(string mathamso,string tenThamSo, float giaTri)
        {
            this.MaThamSo = mathamso;
            this.TenThamSo = tenThamSo;
            this.GiaTri = giaTri;
        }
    }
}
