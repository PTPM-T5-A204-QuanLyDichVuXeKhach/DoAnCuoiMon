namespace DoAnCuoiMon
{
    partial class FrmTrangChuDatVe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lndangnhap = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.đặtVéToolStripMenuItem,
            this.lịchTrìnhToolStripMenuItem,
            this.traCứuVéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(163, 42);
            this.trangChủToolStripMenuItem.Text = "Trang chủ ";
            // 
            // đặtVéToolStripMenuItem
            // 
            this.đặtVéToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đặtVéToolStripMenuItem.Name = "đặtVéToolStripMenuItem";
            this.đặtVéToolStripMenuItem.Size = new System.Drawing.Size(112, 42);
            this.đặtVéToolStripMenuItem.Text = "Đặt vé";
            this.đặtVéToolStripMenuItem.Click += new System.EventHandler(this.đặtVéToolStripMenuItem_Click);
            // 
            // lịchTrìnhToolStripMenuItem
            // 
            this.lịchTrìnhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lịchTrìnhToolStripMenuItem.Name = "lịchTrìnhToolStripMenuItem";
            this.lịchTrìnhToolStripMenuItem.Size = new System.Drawing.Size(148, 42);
            this.lịchTrìnhToolStripMenuItem.Text = "Lịch trình";
            // 
            // traCứuVéToolStripMenuItem
            // 
            this.traCứuVéToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traCứuVéToolStripMenuItem.Name = "traCứuVéToolStripMenuItem";
            this.traCứuVéToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            this.traCứuVéToolStripMenuItem.Text = "Tra cứu vé";
            // 
            // lndangnhap
            // 
            this.lndangnhap.AutoSize = true;
            this.lndangnhap.Location = new System.Drawing.Point(817, 48);
            this.lndangnhap.Name = "lndangnhap";
            this.lndangnhap.Size = new System.Drawing.Size(88, 20);
            this.lndangnhap.TabIndex = 1;
            this.lndangnhap.Text = "Đăng nhập";
            this.lndangnhap.Click += new System.EventHandler(this.lndangnhap_Click);
            // 
            // FrmTrangChuDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 445);
            this.Controls.Add(this.lndangnhap);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTrangChuDatVe";
            this.Text = "FrmTrangChuDatVe";
            this.Load += new System.EventHandler(this.FrmTrangChuDatVe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuVéToolStripMenuItem;
        private System.Windows.Forms.Label lndangnhap;
    }
}