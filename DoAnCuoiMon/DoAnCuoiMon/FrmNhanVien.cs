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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL_DAL;

namespace DoAnCuoiMon
{
    public partial class FrmNhanVien : Form
    {
        BDNhanVien qlnv = new BDNhanVien();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlnv.LoadNhanVien();
            txbtimkiemnv.Text = "Nhập mã hoặc họ tên hoặc cccd";
            txbtimkiemnv.ForeColor = Color.Gray;
            cbbchucvu.Items.Add("Nhân Viên");
            cbbchucvu.Items.Add("Quản Lý");
            cbbchucvu.Text = "Chọn chức vụ";
            cbbchucvu.ForeColor = Color.Gray;
            txbtimkiemnv.Hide();
            btntimkiemnv.Hide();
            btnxoa.Hide();
            btnsua.Hide();
        }

        private void cbbchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbchucvu.Text == "Chọn chức vụ" && cbbchucvu.SelectedIndex == 0)
            {
                cbbchucvu.ForeColor = Color.Gray;
            } 
            else
            {
                cbbchucvu.ForeColor = Color.Black;
                string chonGiaTri = cbbchucvu.SelectedItem.ToString();
                string giaTriDinhDang = LayGiaTri(chonGiaTri); 
                txbmanv.Text = giaTriDinhDang;
            }
        }

        private void cbbchucvu_DropDown(object sender, EventArgs e)
        {
            if (cbbchucvu.Text == "Chọn chức vụ")
            {
                cbbchucvu.Text = ""; 
            }
        }

        private void cbbchucvu_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbchucvu.Text))
            {
                cbbchucvu.Text = "Chọn chức vụ";
                cbbchucvu.ForeColor = Color.Gray;
            }
        }

        private void txbtimkiemnv_Enter(object sender, EventArgs e)
        {
            if (txbtimkiemnv.Text == "Nhập mã hoặc họ tên hoặc cccd")
            {
                txbtimkiemnv.Text = "";
                txbtimkiemnv.ForeColor = Color.Black; 
            }
        }
        
        private void txbtimkiemnv_Leave(object sender, EventArgs e)
        {
            
        }

        private string LayGiaTri(string chonGiaTri)
        {
            string[] cau = chonGiaTri.Split(' '); 
            string ketqua = "";

            foreach (string tu in cau)
            {
                if (tu.Length >= 2)
                {
                    ketqua += tu.Substring(0, 1);
                }
            }

            ketqua += NgauNhienKhongTrung();
            return ketqua;
        }
        private string NgauNhienKhongTrung()
        {
            Random random = new Random();
            int randomSo;

            do
            {
                randomSo = random.Next(1000, 10000); 
            } while (SoDuocSD(randomSo));

            return randomSo.ToString();
        }

        private List<int> lstSo = new List<int>();

        private bool SoDuocSD(int so)
        {
            return lstSo.Contains(so);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbtimkiemnv_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txbtennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txbtennv_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbtennv.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtennv.Focus(); 
            }
            else if (txbtennv.Text.Length < 5 || txbtennv.Text.Length > 50)
            {
                MessageBox.Show("Vui lòng nhập từ 5 đến 50 ký tự");
                txbtennv.Focus();
            }
            else if (txbtennv.Text.Contains("  "))
            {
                MessageBox.Show("Vui lòng chỉ nhập một khoảng trắng giữa các ký tự");
                txbtennv.Focus();
            }
        }

        private void txbemail_Leave(object sender, EventArgs e)
        {
            string dinhDangMail = @"^[a-zA-Z0-9!@#\$%\^&*\(\)_\-\+=\[\]\{\};:'"",<>./?\\|]+@gmail\.com$";
            if (string.IsNullOrEmpty(txbemail.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtennv.Focus();
            }
            else if (Regex.IsMatch(txbemail.Text, dinhDangMail))
            {
            }
            else
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng thử lại");
                txbemail.Clear();
                txbemail.Focus();
            }

        }

        private void txbcccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbcccd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbcccd.Text))
            {
                MessageBox.Show("Vui lòng không để trống");
                txbtennv.Focus();
            }
            else if (txbcccd.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập đúng 12 số");
                txbcccd.Focus();
            }
        }

        private void lbrefresh_Click(object sender, EventArgs e)
        {
            txbmanv.Clear();
            txbtennv.Clear();
            txbemail.Clear();
            txbcccd.Clear();
            cbbchucvu.Show();
            cbbchucvu.Focus();
            btnxoa.Hide();
            btnsua.Hide();
            dataGridView1.DataSource = qlnv.LoadNhanVien();
        }

        private void chbtimkiem_CheckedChanged(object sender, EventArgs e)
        {
            txbtimkiemnv.Visible = chbtimkiem.Checked;
            btntimkiemnv.Visible = chbtimkiem.Checked;

            lbmanv.Visible = !chbtimkiem.Checked;
            lbtennv.Visible = !chbtimkiem.Checked;
            lbemail.Visible = !chbtimkiem.Checked;
            lbcccd.Visible = !chbtimkiem.Checked;
            lbchucvu.Visible = !chbtimkiem.Checked;
            txbmanv.Visible = !chbtimkiem.Checked;
            txbtennv.Visible = !chbtimkiem.Checked;
            txbemail.Visible = !chbtimkiem.Checked;
            txbcccd.Visible = !chbtimkiem.Checked;
            cbbchucvu.Visible = !chbtimkiem.Checked;
            btnthem.Visible = !chbtimkiem.Checked;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!qlnv.KiemTraTrungMaNV(txbmanv.Text))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!qlnv.KiemTraTrungEmail(txbemail.Text))
            {
                MessageBox.Show("Email đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!qlnv.KiemTraTrungCCCD(txbcccd.Text))
            {
                MessageBox.Show("Số căn cước công dân đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbchucvu.SelectedItem != null)
            {
                qlnv.ThemNV(txbmanv.Text, txbtennv.Text, txbemail.Text, txbcccd.Text, cbbchucvu.Text);
                dataGridView1.DataSource = qlnv.LoadNhanVien();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Chọn và nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 )
            {
                string manv = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tennv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string email = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string cccd = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txbmanv.Text = manv;
                txbtennv.Text = tennv;
                txbemail.Text = email;
                txbcccd.Text = cccd;
                cbbchucvu.Hide();
                btnxoa.Show();
                btnsua.Show();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            qlnv.XoaNV(txbmanv.Text);
            dataGridView1.DataSource = qlnv.LoadNhanVien();
            MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            qlnv.SuaNV(txbmanv.Text, txbtennv.Text, txbemail.Text, txbcccd.Text);
            dataGridView1.DataSource = qlnv.LoadNhanVien();
            MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btntimkiemnv_Click(object sender, EventArgs e)
        {
            var timKiem = qlnv.TimKiemNV(txbmanv.Text, txbtennv.Text,txbcccd.Text);
            if (timKiem.Count > 0)
            {
                dataGridView1 .DataSource = timKiem;
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
