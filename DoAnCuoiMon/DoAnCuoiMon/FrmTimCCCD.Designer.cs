namespace DoAnCuoiMon
{
    partial class FrmTimCCCD
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
            this.btnchon = new System.Windows.Forms.Button();
            this.txbnhapcccd = new System.Windows.Forms.TextBox();
            this.btndong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Căn cước công dân";
            // 
            // btnchon
            // 
            this.btnchon.Location = new System.Drawing.Point(582, 61);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(79, 36);
            this.btnchon.TabIndex = 1;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // txbnhapcccd
            // 
            this.txbnhapcccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbnhapcccd.Location = new System.Drawing.Point(275, 55);
            this.txbnhapcccd.Multiline = true;
            this.txbnhapcccd.Name = "txbnhapcccd";
            this.txbnhapcccd.Size = new System.Drawing.Size(278, 42);
            this.txbnhapcccd.TabIndex = 2;
            this.txbnhapcccd.Enter += new System.EventHandler(this.txbnhapcccd_Enter);
            this.txbnhapcccd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbnhapcccd_KeyPress);
            this.txbnhapcccd.Leave += new System.EventHandler(this.txbnhapcccd_Leave);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(667, 61);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(79, 36);
            this.btndong.TabIndex = 1;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // FrmTimCCCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.txbnhapcccd);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.label1);
            this.Name = "FrmTimCCCD";
            this.Text = "TimCCCD";
            this.Load += new System.EventHandler(this.FrmTimCCCD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.Button btndong;
        public System.Windows.Forms.TextBox txbnhapcccd;
    }
}