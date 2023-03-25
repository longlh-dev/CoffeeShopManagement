namespace project2
{
    partial class frmDăngnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDăngnhap));
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.grbNhapThongTin = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.grbNhapThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(112, 16);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(128, 27);
            this.lbDangNhap.TabIndex = 0;
            this.lbDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // grbNhapThongTin
            // 
            this.grbNhapThongTin.Controls.Add(this.btThoat);
            this.grbNhapThongTin.Controls.Add(this.btDangNhap);
            this.grbNhapThongTin.Controls.Add(this.txtMatKhau);
            this.grbNhapThongTin.Controls.Add(this.txtTenDangNhap);
            this.grbNhapThongTin.Controls.Add(this.lbMatKhau);
            this.grbNhapThongTin.Controls.Add(this.lbTenDangNhap);
            this.grbNhapThongTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhapThongTin.Location = new System.Drawing.Point(8, 56);
            this.grbNhapThongTin.Name = "grbNhapThongTin";
            this.grbNhapThongTin.Size = new System.Drawing.Size(328, 176);
            this.grbNhapThongTin.TabIndex = 1;
            this.grbNhapThongTin.TabStop = false;
            this.grbNhapThongTin.Text = "Nhập thông tin";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(192, 128);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(91, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "&Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btthoat_Click_1);
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(48, 128);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(104, 24);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "&Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(120, 72);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(144, 23);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(120, 40);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(144, 23);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(16, 72);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(60, 16);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(16, 40);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(94, 16);
            this.lbTenDangNhap.TabIndex = 0;
            this.lbTenDangNhap.Text = "Tên đăng nhập";
            // 
            // frmDăngnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(340, 240);
            this.Controls.Add(this.grbNhapThongTin);
            this.Controls.Add(this.lbDangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDăngnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ QUÁN CAFE";
            this.grbNhapThongTin.ResumeLayout(false);
            this.grbNhapThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.GroupBox grbNhapThongTin;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbTenDangNhap;

    }
}