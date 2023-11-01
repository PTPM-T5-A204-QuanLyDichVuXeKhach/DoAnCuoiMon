namespace DoAnCuoiMon
{
    partial class FrmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btntimkiemnv = new System.Windows.Forms.Button();
            this.txbtimkiemnv = new System.Windows.Forms.TextBox();
            this.lbchucvu = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.lbcccd = new System.Windows.Forms.Label();
            this.lbmanv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbchucvu = new System.Windows.Forms.ComboBox();
            this.txbmanv = new System.Windows.Forms.TextBox();
            this.txbtennv = new System.Windows.Forms.TextBox();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbcccd = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbrefresh = new System.Windows.Forms.Label();
            this.chbtimkiem = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimkiemnv
            // 
            this.btntimkiemnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiemnv.Location = new System.Drawing.Point(860, 73);
            this.btntimkiemnv.Name = "btntimkiemnv";
            this.btntimkiemnv.Size = new System.Drawing.Size(115, 44);
            this.btntimkiemnv.TabIndex = 12;
            this.btntimkiemnv.Text = "Tìm kiếm";
            this.btntimkiemnv.UseVisualStyleBackColor = true;
            this.btntimkiemnv.Click += new System.EventHandler(this.btntimkiemnv_Click);
            // 
            // txbtimkiemnv
            // 
            this.txbtimkiemnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtimkiemnv.Location = new System.Drawing.Point(322, 73);
            this.txbtimkiemnv.Multiline = true;
            this.txbtimkiemnv.Name = "txbtimkiemnv";
            this.txbtimkiemnv.Size = new System.Drawing.Size(506, 44);
            this.txbtimkiemnv.TabIndex = 0;
            this.txbtimkiemnv.Enter += new System.EventHandler(this.txbtimkiemnv_Enter);
            this.txbtimkiemnv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbtimkiemnv_KeyPress);
            this.txbtimkiemnv.Leave += new System.EventHandler(this.txbtimkiemnv_Leave);
            // 
            // lbchucvu
            // 
            this.lbchucvu.AutoSize = true;
            this.lbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbchucvu.Location = new System.Drawing.Point(112, 314);
            this.lbchucvu.Name = "lbchucvu";
            this.lbchucvu.Size = new System.Drawing.Size(117, 32);
            this.lbchucvu.TabIndex = 5;
            this.lbchucvu.Text = "Chức vụ";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(854, 161);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(86, 32);
            this.lbemail.TabIndex = 6;
            this.lbemail.Text = "Email";
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtennv.Location = new System.Drawing.Point(46, 239);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(194, 32);
            this.lbtennv.TabIndex = 7;
            this.lbtennv.Text = "Tên nhân viên";
            // 
            // lbcccd
            // 
            this.lbcccd.AutoSize = true;
            this.lbcccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcccd.Location = new System.Drawing.Point(688, 239);
            this.lbcccd.Name = "lbcccd";
            this.lbcccd.Size = new System.Drawing.Size(257, 32);
            this.lbcccd.TabIndex = 8;
            this.lbcccd.Text = "Căn cước công dân";
            // 
            // lbmanv
            // 
            this.lbmanv.AutoSize = true;
            this.lbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmanv.Location = new System.Drawing.Point(56, 161);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(184, 32);
            this.lbmanv.TabIndex = 9;
            this.lbmanv.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhân viên";
            // 
            // cbbchucvu
            // 
            this.cbbchucvu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbchucvu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbchucvu.DropDownHeight = 150;
            this.cbbchucvu.DropDownWidth = 400;
            this.cbbchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbchucvu.FormattingEnabled = true;
            this.cbbchucvu.IntegralHeight = false;
            this.cbbchucvu.Location = new System.Drawing.Point(245, 311);
            this.cbbchucvu.Name = "cbbchucvu";
            this.cbbchucvu.Size = new System.Drawing.Size(249, 40);
            this.cbbchucvu.TabIndex = 0;
            this.cbbchucvu.DropDown += new System.EventHandler(this.cbbchucvu_DropDown);
            this.cbbchucvu.SelectedIndexChanged += new System.EventHandler(this.cbbchucvu_SelectedIndexChanged);
            this.cbbchucvu.DropDownClosed += new System.EventHandler(this.cbbchucvu_DropDownClosed);
            // 
            // txbmanv
            // 
            this.txbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmanv.Location = new System.Drawing.Point(245, 149);
            this.txbmanv.Multiline = true;
            this.txbmanv.Name = "txbmanv";
            this.txbmanv.ReadOnly = true;
            this.txbmanv.Size = new System.Drawing.Size(366, 44);
            this.txbmanv.TabIndex = 11;
            // 
            // txbtennv
            // 
            this.txbtennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtennv.Location = new System.Drawing.Point(245, 227);
            this.txbtennv.Multiline = true;
            this.txbtennv.Name = "txbtennv";
            this.txbtennv.Size = new System.Drawing.Size(366, 44);
            this.txbtennv.TabIndex = 1;
            this.txbtennv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbtennv_KeyPress);
            this.txbtennv.Leave += new System.EventHandler(this.txbtennv_Leave);
            // 
            // txbemail
            // 
            this.txbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemail.Location = new System.Drawing.Point(946, 155);
            this.txbemail.Multiline = true;
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(366, 44);
            this.txbemail.TabIndex = 2;
            this.txbemail.Leave += new System.EventHandler(this.txbemail_Leave);
            // 
            // txbcccd
            // 
            this.txbcccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcccd.Location = new System.Drawing.Point(946, 233);
            this.txbcccd.Multiline = true;
            this.txbcccd.Name = "txbcccd";
            this.txbcccd.Size = new System.Drawing.Size(366, 44);
            this.txbcccd.TabIndex = 3;
            this.txbcccd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcccd_KeyPress);
            this.txbcccd.Leave += new System.EventHandler(this.txbcccd_Leave);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(1159, 373);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(136, 80);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1159, 476);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(136, 80);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(1159, 575);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(136, 80);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "<<";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbrefresh
            // 
            this.lbrefresh.AutoSize = true;
            this.lbrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefresh.Location = new System.Drawing.Point(1232, 9);
            this.lbrefresh.Name = "lbrefresh";
            this.lbrefresh.Size = new System.Drawing.Size(97, 29);
            this.lbrefresh.TabIndex = 0;
            this.lbrefresh.Text = "Refresh";
            this.lbrefresh.Click += new System.EventHandler(this.lbrefresh_Click);
            // 
            // chbtimkiem
            // 
            this.chbtimkiem.AutoSize = true;
            this.chbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbtimkiem.Location = new System.Drawing.Point(45, 75);
            this.chbtimkiem.Name = "chbtimkiem";
            this.chbtimkiem.Size = new System.Drawing.Size(271, 36);
            this.chbtimkiem.TabIndex = 15;
            this.chbtimkiem.Text = "Tìm kiếm thông tin";
            this.chbtimkiem.UseVisualStyleBackColor = true;
            this.chbtimkiem.CheckedChanged += new System.EventHandler(this.chbtimkiem_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(203, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(910, 399);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 783);
            this.Controls.Add(this.chbtimkiem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cbbchucvu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntimkiemnv);
            this.Controls.Add(this.txbcccd);
            this.Controls.Add(this.txbtennv);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.txbmanv);
            this.Controls.Add(this.txbtimkiemnv);
            this.Controls.Add(this.lbchucvu);
            this.Controls.Add(this.lbrefresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbtennv);
            this.Controls.Add(this.lbcccd);
            this.Controls.Add(this.lbmanv);
            this.Controls.Add(this.label1);
            this.Name = "FrmNhanVien";
            this.Text = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btntimkiemnv;
        private System.Windows.Forms.TextBox txbtimkiemnv;
        private System.Windows.Forms.Label lbchucvu;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label lbcccd;
        private System.Windows.Forms.Label lbmanv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbchucvu;
        private System.Windows.Forms.TextBox txbmanv;
        private System.Windows.Forms.TextBox txbtennv;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbcccd;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbrefresh;
        private System.Windows.Forms.CheckBox chbtimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}