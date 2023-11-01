using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiMon
{
    public partial class FrmXe : Form
    {
        BDXe qlx = new BDXe();
        
        public FrmXe()
        {
            InitializeComponent();
            LoadData();
        }

        private void FrmXe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlx.LoadX();
            btnsua.Hide();
            btnxoa.Hide();
            cbbsoghe.Items.Add(16);
            cbbsoghe.Items.Add(30);
            cbbsoghe.Items.Add(47);
            cbbsoghe.Text = "Chọn số ghế";
            cbbsoghe.ForeColor = Color.Gray;
            cbbmacx.Text = "Chọn mã chuyến xe";
            cbbmacx.ForeColor = Color.Gray;
            txbghedat.Text = "0";
            txbghedat.Enabled = false;
            txbtt.Text = "Còn ghế";
            txbtt.Enabled = false;
            dtpgiokh.Format = DateTimePickerFormat.Custom;
            dtpgiokh.CustomFormat = "HH:mm:ss";
            dataGridView1.Columns["GioKhoiHanh"].DefaultCellStyle.Format = "HH:mm:ss";
        }

        private void lbtrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbrefresh_Click(object sender, EventArgs e)
        {
            btntaomx.Focus();
            btntaomx.Show();
            txbmax.Clear();
            txbtentx.Clear();
            txbbiensx.Clear();
            cbbsoghe.SelectedIndex = 0;
            cbbmacx.SelectedIndex = 0;
            btnxoa.Hide();
            btnsua.Hide();
            dataGridView1.DataSource = qlx.LoadX() ;
        }
        private string TaoRandomMaX()
        {
            Random random = new Random();
            int randomValue;
            string maXe;

            do
            {
                randomValue = random.Next(0, 1000);
                maXe = "X" + randomValue.ToString("000");
            } while (KiemTraTrungMaX(maXe));

            return maXe;
        }

        private bool KiemTraTrungMaX(string max)
        {
            return false;
        }

        private void btntaomx_Click(object sender, EventArgs e)
        {
            txbmax.Text = TaoRandomMaX();
        }

        private void txbtentx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtentx.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtentx.Focus();
            }
            else if (txbtentx.Text.Length < 5 || txbtentx.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtentx.Focus();
            }
            else if (txbtentx.Text.Contains("  "))
            {
                MessageBox.Show("Vui lòng chỉ nhập một khoảng trắng giữa các ký tự");
                txbtentx.Focus();
            }
        }

        private void txbbiensx_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbbiensx.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbbiensx.Focus();
            }
            else if (KiemTraBienSoXeKhach(txbbiensx.Text))
            {
            }
            else
            {
                MessageBox.Show("Biển số xe không hợp lệ. Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbbiensx.Focus();
            }
        }
        private bool KiemTraBienSoXeKhach(string bienSoXe)
        {
            if (bienSoXe.Length != 9)
            {
                return false;
            }
            return System.Text.RegularExpressions.Regex.IsMatch(bienSoXe, "^[A-Z]{2}[0-9]{1}-[0-9]{5}$");
        }

        private void cbbsoghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbsoghe.Text == "Chọn số ghế" && cbbsoghe.SelectedIndex == 0)
            {
                cbbsoghe.ForeColor = Color.Gray;
            }
        }

        private void cbbsoghe_DropDown(object sender, EventArgs e)
        {
            if (cbbsoghe.Text == "Chọn số ghế")
            {
                cbbsoghe.Text = "";
            }
        }

        private void cbbsoghe_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbsoghe.Text))
            {
                cbbsoghe.Text = "Chọn số ghế";
                cbbsoghe.ForeColor = Color.Gray;
            }
            else
            {
                cbbmacx.ForeColor = Color.Black;
            }
        }

        private void dtpgiokh_Leave(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {
            var cxs = qlx.LoadCX();

            foreach (var cx in cxs)
            {
                cbbmacx.Items.Add(cx.CX);
            }

            cbbmacx.SelectedIndex = 0;
        }

        private void cbbmacx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmacx.Text == "Chọn mã chuyến xe")
            {
                cbbmacx.ForeColor = Color.Gray;
            }
            else
            {
                cbbmacx.ForeColor = Color.Black;
            }
        }

        private void cbbmacx_DropDown(object sender, EventArgs e)
        {
            if (cbbmacx.Text == "Chọn mã chuyến xe")
            {
                cbbmacx.Text = "";
            }
        }

        private void cbbmacx_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbmacx.Text))
            {
                cbbmacx.Text = "Chọn mã chuyến xe";
                cbbmacx.ForeColor = Color.Gray;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var time = dtpgiokh.Value.ToString("HH:mm:ss");
            if (cbbsoghe.SelectedItem != null && cbbmacx.SelectedItem != null && !string.IsNullOrWhiteSpace(txbmax.Text))
            {
                qlx.ThemX(txbmax.Text, txbtentx.Text, txbbiensx.Text, Convert.ToInt16(cbbsoghe.Text), Convert.ToInt16(txbghedat.Text), txbtt.Text, Convert.ToDateTime(dtpgiokh.Text), cbbmacx.Text);
                dataGridView1.DataSource = qlx.LoadX();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            qlx.XoaX(txbmax.Text);
            dataGridView1.DataSource= qlx.LoadX();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string max = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tentx = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string biensx = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string soghe = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string macx = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                btntaomx.Hide();
                txbmax.Text = max;
                txbtentx.Text = tentx;
                txbbiensx.Text = biensx;
                cbbsoghe.Text = soghe;
                cbbmacx.Text = macx;
                btnxoa.Show();
                btnsua.Show();
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cbbsoghe.SelectedItem != null && !string.IsNullOrWhiteSpace(txbmax.Text))
            {
                qlx.SuaX(txbmax.Text, txbtentx.Text, txbbiensx.Text, Convert.ToInt16(cbbsoghe.Text),Convert.ToInt16(txbghedat.Text), txbtt.Text, Convert.ToDateTime(dtpgiokh.Text), cbbmacx.Text);
                dataGridView1.DataSource = qlx.LoadX();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
