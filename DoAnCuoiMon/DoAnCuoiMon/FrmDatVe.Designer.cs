namespace DoAnCuoiMon
{
    partial class FrmDatVe
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbdiemdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbdiemden = new System.Windows.Forms.ComboBox();
            this.dtpngaydi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btntimcx = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm đi";
            // 
            // cbbdiemdi
            // 
            this.cbbdiemdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdiemdi.FormattingEnabled = true;
            this.cbbdiemdi.Location = new System.Drawing.Point(71, 58);
            this.cbbdiemdi.Name = "cbbdiemdi";
            this.cbbdiemdi.Size = new System.Drawing.Size(177, 37);
            this.cbbdiemdi.TabIndex = 1;
            this.cbbdiemdi.DropDown += new System.EventHandler(this.cbbdiemdi_DropDown);
            this.cbbdiemdi.SelectedIndexChanged += new System.EventHandler(this.cbbdiemdi_SelectedIndexChanged);
            this.cbbdiemdi.DropDownClosed += new System.EventHandler(this.cbbdiemdi_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điểm đến";
            // 
            // cbbdiemden
            // 
            this.cbbdiemden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdiemden.FormattingEnabled = true;
            this.cbbdiemden.Location = new System.Drawing.Point(336, 58);
            this.cbbdiemden.Name = "cbbdiemden";
            this.cbbdiemden.Size = new System.Drawing.Size(177, 37);
            this.cbbdiemden.TabIndex = 1;
            this.cbbdiemden.DropDown += new System.EventHandler(this.cbbdiemden_DropDown);
            this.cbbdiemden.SelectedIndexChanged += new System.EventHandler(this.cbbdiemden_SelectedIndexChanged);
            this.cbbdiemden.DropDownClosed += new System.EventHandler(this.cbbdiemden_DropDownClosed);
            // 
            // dtpngaydi
            // 
            this.dtpngaydi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaydi.Location = new System.Drawing.Point(595, 60);
            this.dtpngaydi.Name = "dtpngaydi";
            this.dtpngaydi.Size = new System.Drawing.Size(256, 35);
            this.dtpngaydi.TabIndex = 2;
            this.dtpngaydi.Leave += new System.EventHandler(this.dtpngaydi_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày đi";
            // 
            // btntimcx
            // 
            this.btntimcx.Location = new System.Drawing.Point(896, 42);
            this.btntimcx.Name = "btntimcx";
            this.btntimcx.Size = new System.Drawing.Size(142, 52);
            this.btntimcx.TabIndex = 3;
            this.btntimcx.Text = "Tìm chuyến xe";
            this.btntimcx.UseVisualStyleBackColor = true;
            this.btntimcx.Click += new System.EventHandler(this.btntimcx_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 329);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntimcx);
            this.Controls.Add(this.dtpngaydi);
            this.Controls.Add(this.cbbdiemden);
            this.Controls.Add(this.cbbdiemdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatVe";
            this.Text = "FrmDatVe";
            this.Load += new System.EventHandler(this.FrmDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbdiemdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbdiemden;
        private System.Windows.Forms.DateTimePicker dtpngaydi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntimcx;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}