﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoTongKetMon
    {
        public string MaBCTKM;
        public string MaMonHoc;
        public string MaHocKy;
        public string MaNamHoc;

        public BaoCaoTongKetMon(string maBaoCao, string maMH, string MaHK,string manamhoc)
        {
            this.MaBCTKM = maBaoCao;
            this.MaMonHoc = maMH;
            this.MaHocKy = MaHK;
            this.MaNamHoc = manamhoc;
        }
    }
}
