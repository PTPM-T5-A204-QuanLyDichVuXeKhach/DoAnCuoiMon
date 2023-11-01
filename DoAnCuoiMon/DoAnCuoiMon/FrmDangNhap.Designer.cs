namespace DoAnCuoiMon
{
    partial class FrmDangNhap
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
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.txbtenDN = new System.Windows.Forms.TextBox();
            this.lbtendangnhap = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbtaotk = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.lbthoat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap.Location = new System.Drawing.Point(271, 28);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(261, 55);
            this.lbdangnhap.TabIndex = 0;
            this.lbdangnhap.Text = "Đăng nhập";
            // 
            // txbtenDN
            // 
            this.txbtenDN.Location = new System.Drawing.Point(313, 120);
            this.txbtenDN.Multiline = true;
            this.txbtenDN.Name = "txbtenDN";
            this.txbtenDN.Size = new System.Drawing.Size(320, 52);
            this.txbtenDN.TabIndex = 0;
            this.txbtenDN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbtenDN_KeyPress);
            this.txbtenDN.Leave += new System.EventHandler(this.txbtenDN_Leave);
            // 
            // lbtendangnhap
            // 
            this.lbtendangnhap.AutoSize = true;
            this.lbtendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtendangnhap.Location = new System.Drawing.Point(37, 135);
            this.lbtendangnhap.Name = "lbtendangnhap";
            this.lbtendangnhap.Size = new System.Drawing.Size(235, 37);
            this.lbtendangnhap.TabIndex = 2;
            this.lbtendangnhap.Text = "Tên đăng nhập";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.Location = new System.Drawing.Point(111, 248);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(149, 37);
            this.lbmatkhau.TabIndex = 2;
            this.lbmatkhau.Text = "Mật khẩu";
            // 
            // lbtaotk
            // 
            this.lbtaotk.AutoSize = true;
            this.lbtaotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaotk.Location = new System.Drawing.Point(617, 412);
            this.lbtaotk.Name = "lbtaotk";
            this.lbtaotk.Size = new System.Drawing.Size(171, 29);
            this.lbtaotk.TabIndex = 2;
            this.lbtaotk.Text = "Tạo tài khoản";
            this.lbtaotk.Click += new System.EventHandler(this.lbtaotk_Click);
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(313, 323);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(174, 59);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(313, 233);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbMatKhau.Multiline = true;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(320, 52);
            this.txbMatKhau.TabIndex = 18;
            this.txbMatKhau.UseSystemPasswordChar = true;
            this.txbMatKhau.Leave += new System.EventHandler(this.txbMatKhau_Leave);
            // 
            // lbthoat
            // 
            this.lbthoat.AutoSize = true;
            this.lbthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthoat.Location = new System.Drawing.Point(713, 9);
            this.lbthoat.Name = "lbthoat";
            this.lbthoat.Size = new System.Drawing.Size(75, 29);
            this.lbthoat.TabIndex = 2;
            this.lbthoat.Text = "Thoát";
            this.lbthoat.Click += new System.EventHandler(this.lbthoat_Click);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.lbtaotk);
            this.Controls.Add(this.lbthoat);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbtendangnhap);
            this.Controls.Add(this.txbtenDN);
            this.Controls.Add(this.lbdangnhap);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.TextBox txbtenDN;
        private System.Windows.Forms.Label lbtendangnhap;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.Label lbtaotk;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label lbthoat;
    }
}