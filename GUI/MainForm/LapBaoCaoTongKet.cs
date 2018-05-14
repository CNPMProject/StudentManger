using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MainForm
{
    public partial class LapBaoCaoTongKet : Form
    {
        public LapBaoCaoTongKet()
        {
            InitializeComponent();
        }

        private void LapBaoCaoTongKet_Load(object sender, EventArgs e)
        {

            this.rpBaoCaoMon.RefreshReport();
            this.rpBaoCaoHocKy.RefreshReport();
        }
    }
}
