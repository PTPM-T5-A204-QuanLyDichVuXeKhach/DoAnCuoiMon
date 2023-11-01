using BLL_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace DoAnCuoiMon
{
    public partial class FrmChonChuyen : Form
    {
        private string macx;
        BDDatVe qldv = new BDDatVe();
        public FrmChonChuyen(string macx)
        {
            InitializeComponent();
            this.macx = macx;
        }

        private void FrmChonChuyen_Load(object sender, EventArgs e)
        {
            List<XeS> lstX = qldv.LayXeTheoMaCX(macx);
            dataGridView1.DataSource = lstX;
        }
    }
}
