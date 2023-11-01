namespace DoAnCuoiMon
{
    partial class FrmDangKy
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
            this.lbdangky = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbtenDK = new System.Windows.Forms.TextBox();
            this.txbmacv = new System.Windows.Forms.TextBox();
            this.btndangky = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbmkDK = new System.Windows.Forms.TextBox();
            this.txbxnmk = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbdangky
            // 
            this.lbdangky.AutoSize = true;
            this.lbdangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangky.Location = new System.Drawing.Point(465, 13);
            this.lbdangky.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdangky.Name = "lbdangky";
            this.lbdangky.Size = new System.Drawing.Size(182, 52);
            this.lbdangky.TabIndex = 0;
            this.lbdangky.Text = "Đăng ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã chức vụ";
            // 
            // txbtenDK
            // 
            this.txbtenDK.Location = new System.Drawing.Point(450, 114);
            this.txbtenDK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbtenDK.Multiline = true;
            this.txbtenDK.Name = "txbtenDK";
            this.txbtenDK.Size = new System.Drawing.Size(398, 33);
            this.txbtenDK.TabIndex = 0;
            this.txbtenDK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbtenDK_KeyPress);
            this.txbtenDK.Leave += new System.EventHandler(this.txbtenDK_Leave);
            // 
            // txbmacv
            // 
            this.txbmacv.Location = new System.Drawing.Point(450, 351);
            this.txbmacv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbmacv.Multiline = true;
            this.txbmacv.Name = "txbmacv";
            this.txbmacv.ReadOnly = true;
            this.txbmacv.Size = new System.Drawing.Size(398, 33);
            this.txbmacv.TabIndex = 3;
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(445, 432);
            this.btndangky.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(202, 77);
            this.btndangky.TabIndex = 4;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "<<";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbmkDK
            // 
            this.txbmkDK.Location = new System.Drawing.Point(450, 190);
            this.txbmkDK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbmkDK.Multiline = true;
            this.txbmkDK.Name = "txbmkDK";
            this.txbmkDK.PasswordChar = '*';
            this.txbmkDK.Size = new System.Drawing.Size(398, 33);
            this.txbmkDK.TabIndex = 1;
            this.txbmkDK.Leave += new System.EventHandler(this.txbmkDK_Leave);
            // 
            // txbxnmk
            // 
            this.txbxnmk.Location = new System.Drawing.Point(450, 274);
            this.txbxnmk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbxnmk.Multiline = true;
            this.txbxnmk.Name = "txbxnmk";
            this.txbxnmk.PasswordChar = '*';
            this.txbxnmk.Size = new System.Drawing.Size(398, 33);
            this.txbxnmk.TabIndex = 2;
            this.txbxnmk.Leave += new System.EventHandler(this.txbxnmk_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(987, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(551, 495);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(858, 335);
            this.btnTim.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(119, 49);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Search";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // FrmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.txbmacv);
            this.Controls.Add(this.txbxnmk);
            this.Controls.Add(this.txbmkDK);
            this.Controls.Add(this.txbtenDK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbdangky);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDangKy";
            this.Text = "FrmDangKy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdangky;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbtenDK;
        private System.Windows.Forms.TextBox txbmacv;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbmkDK;
        private System.Windows.Forms.TextBox txbxnmk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTim;
    }
}