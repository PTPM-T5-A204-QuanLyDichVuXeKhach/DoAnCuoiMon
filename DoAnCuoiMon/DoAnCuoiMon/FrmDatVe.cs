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
    public partial class FrmDatVe : Form
    {
        BDDatVe qldv = new BDDatVe();
        public FrmDatVe()
        {
            InitializeComponent();
            LoadData();
        }

        private void FrmDatVe_Load(object sender, EventArgs e)
        {
            cbbdiemdi.Text = "Chọn điểm đi";
            cbbdiemdi.ForeColor = Color.Gray;
            cbbdiemden.Text = "Chọn điểm đến";
            cbbdiemden.ForeColor = Color.Gray;
        }
        private void LoadData()
        {
            var tps = qldv.LoadTP();

            foreach (var tp in tps)
            {
                cbbdiemdi.Items.Add(tp.TP);
                cbbdiemden.Items.Add(tp.TP);
            }

            cbbdiemdi.SelectedIndex = 0;
        }

        private void cbbdiemdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbdiemdi.Text == "Chọn điểm đi")
            {
                cbbdiemdi.ForeColor = Color.Gray;
            }
            else
            {
                cbbdiemdi.ForeColor = Color.Black;
            }
        }

        private void cbbdiemdi_DropDown(object sender, EventArgs e)
        {
            if (cbbdiemdi.Text == "Chọn điểm đi")
            {
                cbbdiemdi.Text = "";
            }
        }

        private void cbbdiemdi_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbdiemdi.Text))
            {
                cbbdiemdi.Text = "Chọn điểm đi";
                cbbdiemdi.ForeColor = Color.Gray;
            }
        }

        private void cbbdiemden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbdiemden.Text == "Chọn điểm đến")
            {
                cbbdiemden.ForeColor = Color.Gray;
            }
            else
            {
                cbbdiemden.ForeColor = Color.Black;
            }
        }

        private void cbbdiemden_DropDown(object sender, EventArgs e)
        {
            if (cbbdiemden.Text == "Chọn điểm đến")
            {
                cbbdiemden.Text = "";
            }
        }

        private void cbbdiemden_DropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbbdiemden.Text))
            {
                cbbdiemden.Text = "Chọn điểm đến";
                cbbdiemden.ForeColor = Color.Gray;
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

        private void btntimcx_Click(object sender, EventArgs e)
        {
            if (!cbbdiemdi.SelectedItem.Equals(cbbdiemden.SelectedItem))
            {
                List<ChuyenXeSS> lstcx = qldv.TimKiemCX(cbbdiemdi.Text, cbbdiemden.Text, Convert.ToDateTime(dtpngaydi.Text));
                dataGridView1.DataSource = lstcx;
            }
            else
            {
                MessageBox.Show("Điểm đi và điểm đến phải khác nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string macx = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                FrmChonChuyen frmChonChuyen = new FrmChonChuyen(macx);
                frmChonChuyen.ShowDialog();
            }
            
        }
    }
}
