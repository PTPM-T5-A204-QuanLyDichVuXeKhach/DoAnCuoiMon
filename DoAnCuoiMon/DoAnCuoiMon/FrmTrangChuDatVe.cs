using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiMon
{
    public partial class FrmTrangChuDatVe : Form
    {
        public FrmTrangChuDatVe()
        {
            InitializeComponent();
            FrmMain frmMain = new FrmMain(); 
            frmMain.HomePageUpdated += FrmMain_HomePageUpdated;
            frmMain.OnHomePageUpdated(EventArgs.Empty);
        }

        private void FrmMain_HomePageUpdated(object sender, EventArgs e)
        {
            Button dynamicButton = new Button();
            dynamicButton.Text = "Click Me"; 
            dynamicButton.Location = new Point(50, 50); 
            dynamicButton.Size = new Size(100, 30);
            this.Controls.Add(dynamicButton);
        }

        private void lndangnhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.ShowDialog();
            this.Hide();
        }

        private void đặtVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatVe frmDatVe = new FrmDatVe();
            frmDatVe.ShowDialog();
            this.Hide();
        }

        private void FrmTrangChuDatVe_Load(object sender, EventArgs e)
        {

        }

    }
}
