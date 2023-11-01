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

namespace DoAnCuoiMon
{
    public partial class FrmDangKy : Form
    {
        BDDangKy qldk = new BDDangKy();
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();
            this.Close();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            if (!qldk.KiemTraTrungTenDK(txbtenDK.Text))
            {
                MessageBox.Show("Tên đăng ký đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbtenDK.Focus();
                return;
            }
            if (!qldk.KiemTraTrungMaCV(txbmacv.Text))
            {
                MessageBox.Show("Mã chức vụ đã được đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbmacv.Focus();
                return;
            }
            if (txbmkDK.Text != txbxnmk.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác", "Vui lòng thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbxnmk.Focus();
            }
            else
            {    
            qldk.DangKy(txbtenDK.Text,txbmkDK.Text,txbmacv.Text);
            MessageBox.Show("Tài khoản đã được tạo thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbtenDK.Clear();
            txbmkDK.Clear();
            txbxnmk.Clear();
            txbmacv.Clear();
            dataGridView1.DataSource = qldk.LoadTK();
            } 
            
        }

        private void txbtenDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtenDK.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtenDK.Focus();
            }
            else if (txbtenDK.Text.Length < 5 || txbtenDK.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtenDK.Focus();
            }
            else if (txbtenDK.Text.Contains(" "))
            {
                MessageBox.Show("Vui lòng không nhập khoảng trắng giữa các ký tự");
                txbtenDK.Focus();
            }
        }

        private void txbtenDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            string kyTuandSo = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; 

            if (!kyTuandSo.Contains(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txbmkDK_Leave(object sender, EventArgs e)
        {
            string dinhDangMK = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^a-zA-Z\\d]).+$";
            if (string.IsNullOrEmpty(txbmkDK.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbmkDK.Focus();
            }
            else if (txbmkDK.Text.Length < 5 || txbmkDK.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbmkDK.Focus();
            }
            else if (Regex.IsMatch(txbmkDK.Text, dinhDangMK))
            {
            }
            else
            {
                MessageBox.Show("Mật khẩu không hợp lệ. Vui lòng thử lại");
                txbmkDK.Clear();
                txbmkDK.Focus();
            }

        }

        private void txbxnmk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbxnmk.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtenDK.Focus();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            FrmTimCCCD frmTim = new FrmTimCCCD(this);
            frmTim.ShowDialog();
        }
        public void CapNhatMacvTXB(string manv)
        {
            txbmacv.Text = manv;
        }
    }
}
