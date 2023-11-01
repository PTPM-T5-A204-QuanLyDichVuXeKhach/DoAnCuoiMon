using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnCuoiMon
{
    public partial class FrmDangNhap : Form
    {
        BDDangNhap qldn = new BDDangNhap();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void lbtaotk_Click(object sender, EventArgs e)
        {
            FrmDangKy dk = new FrmDangKy();
            dk.Show();
            this.Hide();
        }

        private void lbthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            FrmTrangChuDatVe frmTrangChuDatVe = new FrmTrangChuDatVe();
            frmTrangChuDatVe.Show();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            string maCV = qldn.KiemTraDangNhap(txbtenDN.Text, txbMatKhau.Text);

            if (maCV != null)
            {
                FrmMain frmMain = new FrmMain(maCV,txbtenDN.Text);
                frmMain.Show();
                this.Hide();
                FrmChuyenXe frmChuyenXe = new FrmChuyenXe(txbtenDN.Text);
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbtenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            string kyTuandSo = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            if (!kyTuandSo.Contains(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbtenDN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtenDN.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtenDN.Focus();
            }
            else if (txbtenDN.Text.Length < 5 || txbtenDN.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtenDN.Focus();
            }
            else if (txbtenDN.Text.Contains(" "))
            {
                MessageBox.Show("Vui lòng không nhập khoảng trắng giữa các ký tự");
                txbtenDN.Focus();
            }
        }

        private void txbMatKhau_Leave(object sender, EventArgs e)
        {
            string dinhDangMK = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).+$";
            if (string.IsNullOrEmpty(txbMatKhau.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbMatKhau.Focus();
            }
            else if (txbMatKhau.Text.Length < 5 || txbMatKhau.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbMatKhau.Focus();
            }
            else if (Regex.IsMatch(txbMatKhau.Text, dinhDangMK))
            {
            }
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Vui lòng thử lại");
                txbMatKhau.Clear();
                txbMatKhau.Focus();
            }
        }
    }
}
