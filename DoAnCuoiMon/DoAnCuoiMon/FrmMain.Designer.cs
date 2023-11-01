namespace DoAnCuoiMon
{
    partial class FrmMain
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
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChuyếnXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbdangxuat = new System.Windows.Forms.Label();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýChuyếnXeToolStripMenuItem,
            this.quảnLýXeToolStripMenuItem,
            this.quảnLýVéToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1468, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(174, 49);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(290, 49);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýChuyếnXeToolStripMenuItem
            // 
            this.quảnLýChuyếnXeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýChuyếnXeToolStripMenuItem.Name = "quảnLýChuyếnXeToolStripMenuItem";
            this.quảnLýChuyếnXeToolStripMenuItem.Size = new System.Drawing.Size(295, 49);
            this.quảnLýChuyếnXeToolStripMenuItem.Text = "Quản lý chuyến xe";
            this.quảnLýChuyếnXeToolStripMenuItem.Click += new System.EventHandler(this.quảnLýChuyếnXeToolStripMenuItem_Click);
            // 
            // quảnLýXeToolStripMenuItem
            // 
            this.quảnLýXeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýXeToolStripMenuItem.Name = "quảnLýXeToolStripMenuItem";
            this.quảnLýXeToolStripMenuItem.Size = new System.Drawing.Size(185, 49);
            this.quảnLýXeToolStripMenuItem.Text = "Quản lý xe";
            this.quảnLýXeToolStripMenuItem.Click += new System.EventHandler(this.quảnLýXeToolStripMenuItem_Click);
            // 
            // quảnLýVéToolStripMenuItem
            // 
            this.quảnLýVéToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýVéToolStripMenuItem.Name = "quảnLýVéToolStripMenuItem";
            this.quảnLýVéToolStripMenuItem.Size = new System.Drawing.Size(185, 49);
            this.quảnLýVéToolStripMenuItem.Text = "Quản lý vé";
            this.quảnLýVéToolStripMenuItem.Click += new System.EventHandler(this.quảnLýVéToolStripMenuItem_Click);
            // 
            // lbdangxuat
            // 
            this.lbdangxuat.AutoSize = true;
            this.lbdangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangxuat.Location = new System.Drawing.Point(1299, 64);
            this.lbdangxuat.Name = "lbdangxuat";
            this.lbdangxuat.Size = new System.Drawing.Size(143, 32);
            this.lbdangxuat.TabIndex = 1;
            this.lbdangxuat.Text = "Đăng xuất";
            this.lbdangxuat.Click += new System.EventHandler(this.lbdangxuat_Click);
            // 
            // lbwelcome
            // 
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbwelcome.Location = new System.Drawing.Point(12, 64);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(0, 29);
            this.lbwelcome.TabIndex = 2;
            this.lbwelcome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbwelcome.Click += new System.EventHandler(this.lbwelcome_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 765);
            this.Controls.Add(this.lbwelcome);
            this.Controls.Add(this.lbdangxuat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChuyếnXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVéToolStripMenuItem;
        private System.Windows.Forms.Label lbdangxuat;
        private System.Windows.Forms.Label lbwelcome;
    }
}