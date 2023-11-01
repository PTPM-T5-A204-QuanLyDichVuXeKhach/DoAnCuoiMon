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
    public partial class FrmTimCCCD : Form
    {
        BDNhanVien nv =new BDNhanVien();
        BDDangKy dk = new BDDangKy();
        private FrmDangKy frmdk;
        public FrmTimCCCD(FrmDangKy frmdk)
        {
            InitializeComponent();
            this.frmdk = frmdk;
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            bool exists = nv.KiemTraCCCD(txbnhapcccd.Text);
            if (!exists)
            {
                MessageBox.Show("Số căn cước công dân không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmdk.CapNhatMacvTXB(dk.LayMaNV(txbnhapcccd.Text));
                this.Close();
            }


            
        }

        private void txbnhapcccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbnhapcccd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbnhapcccd.Text))
            {
                txbnhapcccd.Text = "Nhập căn cước công dân";
                txbnhapcccd.ForeColor = Color.Gray;
            }
            else if (txbnhapcccd.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập đúng 12 số");
                txbnhapcccd.Clear();
            }
        }

        private void txbnhapcccd_Enter(object sender, EventArgs e)
        {
            if (txbnhapcccd.Text == "Nhập căn cước công dân")
            {
                txbnhapcccd.Text = "";
                txbnhapcccd.ForeColor = Color.Black;
            }
        }

        private void FrmTimCCCD_Load(object sender, EventArgs e)
        {
            txbnhapcccd.Text = "Nhập căn cước công dân";
            txbnhapcccd.ForeColor = Color.Gray;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
