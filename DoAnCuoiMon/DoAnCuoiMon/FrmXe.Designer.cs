namespace DoAnCuoiMon
{
    partial class FrmXe
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
            this.lbrefresh = new System.Windows.Forms.Label();
            this.lbtrove = new System.Windows.Forms.Label();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntaomx = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmacx = new System.Windows.Forms.ComboBox();
            this.txbbiensx = new System.Windows.Forms.TextBox();
            this.txbmax = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbtentx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbsoghe = new System.Windows.Forms.ComboBox();
            this.txbghedat = new System.Windows.Forms.TextBox();
            this.txbtt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpgiokh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbrefresh
            // 
            this.lbrefresh.AutoSize = true;
            this.lbrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefresh.Location = new System.Drawing.Point(1329, 9);
            this.lbrefresh.Name = "lbrefresh";
            this.lbrefresh.Size = new System.Drawing.Size(97, 29);
            this.lbrefresh.TabIndex = 28;
            this.lbrefresh.Text = "Refresh";
            this.lbrefresh.Click += new System.EventHandler(this.lbrefresh_Click);
            // 
            // lbtrove
            // 
            this.lbtrove.AutoSize = true;
            this.lbtrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtrove.Location = new System.Drawing.Point(12, 9);
            this.lbtrove.Name = "lbtrove";
            this.lbtrove.Size = new System.Drawing.Size(41, 29);
            this.lbtrove.TabIndex = 27;
            this.lbtrove.Text = "<<";
            this.lbtrove.Click += new System.EventHandler(this.lbtrove_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(1263, 522);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(127, 60);
            this.btnxoa.TabIndex = 26;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(1263, 636);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 60);
            this.btnsua.TabIndex = 25;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(1263, 412);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 60);
            this.btnthem.TabIndex = 24;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntaomx
            // 
            this.btntaomx.Location = new System.Drawing.Point(570, 101);
            this.btntaomx.Name = "btntaomx";
            this.btntaomx.Size = new System.Drawing.Size(61, 58);
            this.btntaomx.TabIndex = 0;
            this.btntaomx.Text = "Tạo max";
            this.btntaomx.UseVisualStyleBackColor = true;
            this.btntaomx.Click += new System.EventHandler(this.btntaomx_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1219, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mã chuyến xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 20;
            this.label3.Text = "Biển số xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số ghế đã được đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên tài xế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(808, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số ghế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(617, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 52);
            this.label7.TabIndex = 17;
            this.label7.Text = "Xe khách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã xe";
            // 
            // cbbmacx
            // 
            this.cbbmacx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbmacx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbmacx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmacx.FormattingEnabled = true;
            this.cbbmacx.Location = new System.Drawing.Point(1226, 328);
            this.cbbmacx.Name = "cbbmacx";
            this.cbbmacx.Size = new System.Drawing.Size(200, 40);
            this.cbbmacx.TabIndex = 14;
            this.cbbmacx.DropDown += new System.EventHandler(this.cbbmacx_DropDown);
            this.cbbmacx.SelectedIndexChanged += new System.EventHandler(this.cbbmacx_SelectedIndexChanged);
            this.cbbmacx.DropDownClosed += new System.EventHandler(this.cbbmacx_DropDownClosed);
            // 
            // txbbiensx
            // 
            this.txbbiensx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbbiensx.Location = new System.Drawing.Point(303, 252);
            this.txbbiensx.Multiline = true;
            this.txbbiensx.Name = "txbbiensx";
            this.txbbiensx.Size = new System.Drawing.Size(249, 41);
            this.txbbiensx.TabIndex = 11;
            this.txbbiensx.Leave += new System.EventHandler(this.txbbiensx_Leave);
            // 
            // txbmax
            // 
            this.txbmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmax.Location = new System.Drawing.Point(303, 103);
            this.txbmax.Multiline = true;
            this.txbmax.Name = "txbmax";
            this.txbmax.ReadOnly = true;
            this.txbmax.Size = new System.Drawing.Size(249, 41);
            this.txbmax.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 405);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txbtentx
            // 
            this.txbtentx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtentx.Location = new System.Drawing.Point(303, 176);
            this.txbtentx.Multiline = true;
            this.txbtentx.Name = "txbtentx";
            this.txbtentx.Size = new System.Drawing.Size(249, 41);
            this.txbtentx.TabIndex = 10;
            this.txbtentx.Leave += new System.EventHandler(this.txbtentx_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(763, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 37);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tình trạng";
            // 
            // cbbsoghe
            // 
            this.cbbsoghe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbsoghe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbsoghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsoghe.FormattingEnabled = true;
            this.cbbsoghe.Location = new System.Drawing.Point(955, 122);
            this.cbbsoghe.Name = "cbbsoghe";
            this.cbbsoghe.Size = new System.Drawing.Size(217, 40);
            this.cbbsoghe.TabIndex = 14;
            this.cbbsoghe.DropDown += new System.EventHandler(this.cbbsoghe_DropDown);
            this.cbbsoghe.SelectedIndexChanged += new System.EventHandler(this.cbbsoghe_SelectedIndexChanged);
            this.cbbsoghe.DropDownClosed += new System.EventHandler(this.cbbsoghe_DropDownClosed);
            // 
            // txbghedat
            // 
            this.txbghedat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbghedat.Location = new System.Drawing.Point(955, 184);
            this.txbghedat.Multiline = true;
            this.txbghedat.Name = "txbghedat";
            this.txbghedat.Size = new System.Drawing.Size(217, 41);
            this.txbghedat.TabIndex = 10;
            this.txbghedat.Leave += new System.EventHandler(this.txbtentx_Leave);
            // 
            // txbtt
            // 
            this.txbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtt.Location = new System.Drawing.Point(952, 256);
            this.txbtt.Multiline = true;
            this.txbtt.Name = "txbtt";
            this.txbtt.Size = new System.Drawing.Size(220, 41);
            this.txbtt.TabIndex = 10;
            this.txbtt.Leave += new System.EventHandler(this.txbtentx_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1219, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "Giờ khởi hành";
            // 
            // dtpgiokh
            // 
            this.dtpgiokh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpgiokh.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpgiokh.Location = new System.Drawing.Point(1226, 186);
            this.dtpgiokh.Name = "dtpgiokh";
            this.dtpgiokh.Size = new System.Drawing.Size(200, 39);
            this.dtpgiokh.TabIndex = 29;
            // 
            // FrmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 760);
            this.Controls.Add(this.dtpgiokh);
            this.Controls.Add(this.lbrefresh);
            this.Controls.Add(this.lbtrove);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btntaomx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbsoghe);
            this.Controls.Add(this.cbbmacx);
            this.Controls.Add(this.txbbiensx);
            this.Controls.Add(this.txbtt);
            this.Controls.Add(this.txbghedat);
            this.Controls.Add(this.txbtentx);
            this.Controls.Add(this.txbmax);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmXe";
            this.Text = "FrmXe";
            this.Load += new System.EventHandler(this.FrmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbrefresh;
        private System.Windows.Forms.Label lbtrove;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btntaomx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbmacx;
        private System.Windows.Forms.TextBox txbbiensx;
        private System.Windows.Forms.TextBox txbmax;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbtentx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbsoghe;
        private System.Windows.Forms.TextBox txbghedat;
        private System.Windows.Forms.TextBox txbtt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpgiokh;
    }
}