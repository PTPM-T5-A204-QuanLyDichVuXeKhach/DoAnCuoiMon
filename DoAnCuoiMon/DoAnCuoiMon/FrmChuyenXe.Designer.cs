namespace DoAnCuoiMon
{
    partial class FrmChuyenXe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbmacx = new System.Windows.Forms.TextBox();
            this.txbgiave = new System.Windows.Forms.TextBox();
            this.cbbDiemden = new System.Windows.Forms.ComboBox();
            this.cbbDiemdi = new System.Windows.Forms.ComboBox();
            this.dtpngaydi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbmanv = new System.Windows.Forms.TextBox();
            this.btntaomcx = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lbtrove = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbrefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(949, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txbmacx
            // 
            this.txbmacx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmacx.Location = new System.Drawing.Point(286, 84);
            this.txbmacx.Multiline = true;
            this.txbmacx.Name = "txbmacx";
            this.txbmacx.ReadOnly = true;
            this.txbmacx.Size = new System.Drawing.Size(249, 41);
            this.txbmacx.TabIndex = 1;
            // 
            // txbgiave
            // 
            this.txbgiave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbgiave.Location = new System.Drawing.Point(938, 161);
            this.txbgiave.Multiline = true;
            this.txbgiave.Name = "txbgiave";
            this.txbgiave.Size = new System.Drawing.Size(200, 41);
            this.txbgiave.TabIndex = 1;
            this.txbgiave.Leave += new System.EventHandler(this.txbgiave_Leave);
            // 
            // cbbDiemden
            // 
            this.cbbDiemden.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbDiemden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDiemden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemden.FormattingEnabled = true;
            this.cbbDiemden.Location = new System.Drawing.Point(286, 226);
            this.cbbDiemden.Name = "cbbDiemden";
            this.cbbDiemden.Size = new System.Drawing.Size(249, 40);
            this.cbbDiemden.TabIndex = 2;
            this.cbbDiemden.DropDown += new System.EventHandler(this.cbbDiemden_DropDown);
            this.cbbDiemden.SelectedIndexChanged += new System.EventHandler(this.cbbDiemden_SelectedIndexChanged);
            this.cbbDiemden.DropDownClosed += new System.EventHandler(this.cbbDiemden_DropDownClosed);
            // 
            // cbbDiemdi
            // 
            this.cbbDiemdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbDiemdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDiemdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemdi.FormattingEnabled = true;
            this.cbbDiemdi.Location = new System.Drawing.Point(286, 157);
            this.cbbDiemdi.Name = "cbbDiemdi";
            this.cbbDiemdi.Size = new System.Drawing.Size(249, 40);
            this.cbbDiemdi.TabIndex = 2;
            this.cbbDiemdi.DropDown += new System.EventHandler(this.cbbDiemdi_DropDown);
            this.cbbDiemdi.SelectedIndexChanged += new System.EventHandler(this.cbbDiemdi_SelectedIndexChanged);
            this.cbbDiemdi.DropDownClosed += new System.EventHandler(this.cbbDiemdi_DropDownClosed);
            // 
            // dtpngaydi
            // 
            this.dtpngaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaydi.Location = new System.Drawing.Point(938, 104);
            this.dtpngaydi.Name = "dtpngaydi";
            this.dtpngaydi.Size = new System.Drawing.Size(200, 39);
            this.dtpngaydi.TabIndex = 3;
            this.dtpngaydi.Leave += new System.EventHandler(this.dtpngaydi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã chuyến xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Điểm đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(713, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày đi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(713, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá vé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(713, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 37);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã nhân viên";
            // 
            // txbmanv
            // 
            this.txbmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmanv.Location = new System.Drawing.Point(938, 233);
            this.txbmanv.Multiline = true;
            this.txbmanv.Name = "txbmanv";
            this.txbmanv.ReadOnly = true;
            this.txbmanv.Size = new System.Drawing.Size(200, 41);
            this.txbmanv.TabIndex = 1;
            // 
            // btntaomcx
            // 
            this.btntaomcx.Location = new System.Drawing.Point(553, 82);
            this.btntaomcx.Name = "btntaomcx";
            this.btntaomcx.Size = new System.Drawing.Size(61, 58);
            this.btntaomcx.TabIndex = 5;
            this.btntaomcx.Text = "Tạo macx";
            this.btntaomcx.UseVisualStyleBackColor = true;
            this.btntaomcx.Click += new System.EventHandler(this.btntaomcx_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(1030, 309);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 60);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lbtrove
            // 
            this.lbtrove.AutoSize = true;
            this.lbtrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrove.Location = new System.Drawing.Point(12, 9);
            this.lbtrove.Name = "lbtrove";
            this.lbtrove.Size = new System.Drawing.Size(41, 29);
            this.lbtrove.TabIndex = 7;
            this.lbtrove.Text = "<<";
            this.lbtrove.Click += new System.EventHandler(this.lbtrove_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(1030, 503);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 60);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1030, 406);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(127, 60);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 52);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chuyến xe";
            // 
            // lbrefresh
            // 
            this.lbrefresh.AutoSize = true;
            this.lbrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefresh.Location = new System.Drawing.Point(1168, 9);
            this.lbrefresh.Name = "lbrefresh";
            this.lbrefresh.Size = new System.Drawing.Size(97, 29);
            this.lbrefresh.TabIndex = 8;
            this.lbrefresh.Text = "Refresh";
            this.lbrefresh.Click += new System.EventHandler(this.lbrefresh_Click);
            // 
            // FrmChuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 726);
            this.Controls.Add(this.lbrefresh);
            this.Controls.Add(this.lbtrove);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btntaomcx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpngaydi);
            this.Controls.Add(this.cbbDiemden);
            this.Controls.Add(this.cbbDiemdi);
            this.Controls.Add(this.txbmanv);
            this.Controls.Add(this.txbgiave);
            this.Controls.Add(this.txbmacx);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmChuyenXe";
            this.Text = "FrmChuyenXe";
            this.Load += new System.EventHandler(this.FrmChuyenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbmacx;
        private System.Windows.Forms.TextBox txbgiave;
        private System.Windows.Forms.ComboBox cbbDiemden;
        private System.Windows.Forms.ComboBox cbbDiemdi;
        private System.Windows.Forms.DateTimePicker dtpngaydi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbmanv;
        private System.Windows.Forms.Button btntaomcx;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lbtrove;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbrefresh;
    }
}