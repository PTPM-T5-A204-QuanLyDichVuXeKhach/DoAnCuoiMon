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
    public partial class FrmMain : Form
    {
        private string manv;
        private string tendn;
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string manv, string tendn)
        {
            InitializeComponent();
            this.manv = manv;
            this.tendn = tendn;
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (manv.StartsWith("QL"))
            {
            }
            else if (manv.StartsWith("NV"))
            {
                quảnLýNhânViênToolStripMenuItem.Visible = false;
                quảnLýChuyếnXeToolStripMenuItem.Visible = false;
                quảnLýXeToolStripMenuItem.Visible = false;
            }
            else
            {
                quảnLýNhânViênToolStripMenuItem.Visible=false;
                quảnLýChuyếnXeToolStripMenuItem.Visible=false;
                quảnLýXeToolStripMenuItem.Visible=false;
                quảnLýVéToolStripMenuItem.Visible=false;
            }  
            lbdangxuat.Hide();
            lbwelcome.Text = "Welcome " + tendn;
        }

        private void lbdangxuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Close();
        }

        private void lbwelcome_Click(object sender, EventArgs e)
        {
            lbdangxuat.Show();
        }

        private void quảnLýChuyếnXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChuyenXe frmChuyenXe = new FrmChuyenXe(manv);
            frmChuyenXe.Show();
        }

        private void quảnLýXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXe frmXe = new FrmXe();
            frmXe.Show();
        }

        private void quảnLýVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVe frmVe = new FrmVe();
            frmVe.Show();
        }
        public event EventHandler HomePageUpdated;

        public virtual void OnHomePageUpdated(EventArgs empty)
        {
            HomePageUpdated?.Invoke(this, empty);
        }

    }
}
