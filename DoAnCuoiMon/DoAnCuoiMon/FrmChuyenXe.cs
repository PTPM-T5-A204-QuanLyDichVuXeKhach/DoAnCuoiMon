using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiMon
{
    public partial class FrmChuyenXe : Form
    {
        BDChuyenXe qlcx = new BDChuyenXe();
        private string Manv;
        public FrmChuyenXe(string manv)
        {
            InitializeComponent();
            LoadData();
            Manv = manv;
        }

        private void FrmChuyenXe_Load(object sender, EventArgs e)
        {
            cbbDiemdi.Text = "Chọn điểm đi";
            cbbDiemdi.ForeColor = Color.Gray;
            cbbDiemden.Text = "Chọn điểm đến";
            cbbDiemden.ForeColor = Color.Gray;
            txbmanv.Text = Manv;
            btnxoa.Hide();
            btnsua.Hide();
            dataGridView1.DataSource = qlcx.LoadCX();
        }

        private void LoadData()
        {
            var tps = qlcx.LoadTP(); 

            foreach (var tp in tps)
            {
                cbbDiemdi.Items.Add(tp.TP);
                cbbDiemden.Items.Add(tp.TP);
            }

            cbbDiemdi.SelectedIndex = 0; 
        }

        private void cbbDiemdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDiemdi.Text == "Chọn điểm đi")
            {
                cbbDiemdi.ForeColor = Color.Gray;
            }
            else
            {
                cbbDiemdi.ForeColor = Color.Black;
            }
        }

        private void cbbDiemden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDiemden.Text == "Chọn điểm đến")
            {
                cbbDiemden.ForeColor = Color.Gray;
            }
            else
            {
                cbbDiemden.ForeColor = Color.Black;
            }
        }

        private void cbbDiemdi_DropDown(object sender, EventArgs e)
        {
            if (cbbDiemdi.Text == "Chọn điểm đi")
            {
                cbbDiemdi.Text = "";
            }
        }

        private void cbbDiemdi_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbDiemdi.Text))
            {
                cbbDiemdi.Text = "Chọn điểm đi";
                cbbDiemdi.ForeColor = Color.Gray;
            }
        }

        private void cbbDiemden_DropDown(object sender, EventArgs e)
        {
            if (cbbDiemden.Text == "Chọn điểm đến")
            {
                cbbDiemden.Text = "";
            }
        }

        private void cbbDiemden_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbDiemden.Text))
            {
                cbbDiemden.Text = "Chọn điểm đến";
                cbbDiemden.ForeColor = Color.Gray;
            }
        }

        private string TaoRandomMaCX()
        {
            Random random = new Random();
            int randomValue;
            string maChuyenXe;

            do
            {
                randomValue = random.Next(0, 1000); 
                maChuyenXe = "CX" + randomValue.ToString("000"); 
            } while (KiemTraTrungMaCX(maChuyenXe));

            return maChuyenXe;
        }

        private bool KiemTraTrungMaCX(string macx)
        {
            return false;
        }

        private void btntaomcx_Click(object sender, EventArgs e)
        {
            txbmacx.Text = TaoRandomMaCX();
        }
        private bool KiemTraGiaTien(string giaTienText)
        {
            string giaTien = @"^\d{1,3}(,\d{3})*$"; 
            return System.Text.RegularExpressions.Regex.IsMatch(giaTienText, giaTien);
        }

        private bool IsInRange(string giaTienText, int minValue, int maxValue)
        {
            if (int.TryParse(giaTienText.Replace(",", ""), out int giaTien))
            {
                return giaTien >= minValue && giaTien <= maxValue;
            }
            return false;
        }
        private string DinhDangGiaTien(string giaTienText)
        {
            if (int.TryParse(giaTienText.Replace(",", ""), out int giaTien))
            {
                return giaTien.ToString("N0");
            }
            return giaTienText;
        }

        private void txbgiave_Leave(object sender, EventArgs e)
        {
            string giaTienText = txbgiave.Text;
            if (KiemTraGiaTien(giaTienText) && IsInRange(giaTienText, 500000, 10000000))
            {
                txbgiave.Text = DinhDangGiaTien(giaTienText); 
            }
            else
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập lại theo đúng định dạng và trong khoảng từ 500.000 đến 10.000.000", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbgiave.Text = "";
                txbgiave.Focus();
            }
        }

        private void lbtrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (cbbDiemdi.SelectedItem != null && cbbDiemden.SelectedItem != null && !string.IsNullOrWhiteSpace(txbmacx.Text))
            {
                if (!cbbDiemdi.SelectedItem.Equals(cbbDiemden.SelectedItem))
                {
                    qlcx.ThemCX(txbmacx.Text, cbbDiemdi.Text, cbbDiemden.Text,Convert.ToDateTime(dtpngaydi.Text),Convert.ToDecimal(txbgiave.Text),txbmanv.Text);
                    dataGridView1.DataSource = qlcx.LoadCX();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Điểm đi và điểm đến phải khác nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpngaydi_Leave(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            DateTime selectedDate = dtpngaydi.Value;

            if (selectedDate <= now)
            {
                MessageBox.Show("Vui lòng chọn một ngày và giờ lớn hơn hiện tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpngaydi.Value = now;
                dtpngaydi.Focus();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                string macx = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string diemdi = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string diemden = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string ngaydi = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string giave = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string manv = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                btntaomcx.Hide();
                txbmacx.Text = macx;
                cbbDiemdi.Text = diemdi;
                cbbDiemden.Text = diemden;
                dtpngaydi.Text = ngaydi;
                txbgiave.Text = giave;
                txbmanv.Text = manv;
                btnxoa.Show();
                btnsua.Show();
            }
        }

        private void lbrefresh_Click(object sender, EventArgs e)
        {
            btntaomcx.Show();
            txbmacx.Clear();
            txbgiave.Clear();
            cbbDiemdi.SelectedIndex = 0;
            cbbDiemden.SelectedIndex = 0;
            btnxoa.Hide();
            btnsua.Hide();
            dataGridView1.DataSource = qlcx.LoadCX();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            qlcx.XoaCX(txbmacx.Text);
            dataGridView1.DataSource = qlcx.LoadCX();
            MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cbbDiemdi.SelectedItem != null && cbbDiemden.SelectedItem != null && !string.IsNullOrWhiteSpace(txbmacx.Text))
            {
                if (!cbbDiemdi.SelectedItem.Equals(cbbDiemden.SelectedItem))
                {
                    qlcx.SuaCX(txbmacx.Text,cbbDiemdi.Text, cbbDiemden.Text, Convert.ToDateTime(dtpngaydi.Text), Convert.ToDecimal(txbgiave.Text));
                    dataGridView1.DataSource = qlcx.LoadCX();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Điểm đi và điểm đến phải khác nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn và nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
