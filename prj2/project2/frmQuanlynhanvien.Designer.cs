namespace project2
{
    partial class frmQuanlynhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlynhanvien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbQuanLyNhanVien = new System.Windows.Forms.Label();
            this.toolStripqlnv = new System.Windows.Forms.ToolStrip();
            this.tsLamMoi = new System.Windows.Forms.ToolStripButton();
            this.tsThem = new System.Windows.Forms.ToolStripButton();
            this.tsSua = new System.Windows.Forms.ToolStripButton();
            this.tsXoa = new System.Windows.Forms.ToolStripButton();
            this.tsTimKiem = new System.Windows.Forms.ToolStripButton();
            this.tsThoat = new System.Windows.Forms.ToolStripButton();
            this.tsQuayLai = new System.Windows.Forms.ToolStripButton();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txtManv = new System.Windows.Forms.ComboBox();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.lbtimkem = new System.Windows.Forms.Label();
            this.dgNhanVien = new System.Windows.Forms.DataGridView();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.lbSoCMND = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripqlnv.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.lbQuanLyNhanVien);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripqlnv);
            this.splitContainer1.Panel2.Controls.Add(this.grbThongTin);
            this.splitContainer1.Size = new System.Drawing.Size(834, 461);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbQuanLyNhanVien
            // 
            this.lbQuanLyNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbQuanLyNhanVien.AutoSize = true;
            this.lbQuanLyNhanVien.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLyNhanVien.Location = new System.Drawing.Point(247, 20);
            this.lbQuanLyNhanVien.Name = "lbQuanLyNhanVien";
            this.lbQuanLyNhanVien.Size = new System.Drawing.Size(269, 29);
            this.lbQuanLyNhanVien.TabIndex = 0;
            this.lbQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lbQuanLyNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripqlnv
            // 
            this.toolStripqlnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripqlnv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLamMoi,
            this.tsThem,
            this.tsSua,
            this.tsXoa,
            this.tsTimKiem,
            this.tsThoat,
            this.tsQuayLai});
            this.toolStripqlnv.Location = new System.Drawing.Point(0, 0);
            this.toolStripqlnv.Name = "toolStripqlnv";
            this.toolStripqlnv.Size = new System.Drawing.Size(834, 25);
            this.toolStripqlnv.TabIndex = 0;
            this.toolStripqlnv.Text = "toolStrip1";
            // 
            // tsLamMoi
            // 
            this.tsLamMoi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("tsLamMoi.Image")));
            this.tsLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLamMoi.Name = "tsLamMoi";
            this.tsLamMoi.Size = new System.Drawing.Size(77, 22);
            this.tsLamMoi.Text = "Làm mới";
            this.tsLamMoi.Click += new System.EventHandler(this.tsLamMoi_Click);
            // 
            // tsThem
            // 
            this.tsThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsThem.Image = ((System.Drawing.Image)(resources.GetObject("tsThem.Image")));
            this.tsThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThem.Name = "tsThem";
            this.tsThem.Size = new System.Drawing.Size(61, 22);
            this.tsThem.Text = "Thêm";
            this.tsThem.Click += new System.EventHandler(this.tsThem_Click);
            // 
            // tsSua
            // 
            this.tsSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSua.Image = ((System.Drawing.Image)(resources.GetObject("tsSua.Image")));
            this.tsSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSua.Name = "tsSua";
            this.tsSua.Size = new System.Drawing.Size(51, 22);
            this.tsSua.Text = "Sửa";
            this.tsSua.Click += new System.EventHandler(this.tsSua_Click);
            // 
            // tsXoa
            // 
            this.tsXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsXoa.Image")));
            this.tsXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsXoa.Name = "tsXoa";
            this.tsXoa.Size = new System.Drawing.Size(50, 22);
            this.tsXoa.Text = "Xóa";
            this.tsXoa.Click += new System.EventHandler(this.tsXoa_Click);
            // 
            // tsTimKiem
            // 
            this.tsTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsTimKiem.Image")));
            this.tsTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTimKiem.Name = "tsTimKiem";
            this.tsTimKiem.Size = new System.Drawing.Size(81, 22);
            this.tsTimKiem.Text = "Tìm kiếm";
            this.tsTimKiem.Click += new System.EventHandler(this.tsTimKiem_Click);
            // 
            // tsThoat
            // 
            this.tsThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsThoat.Image")));
            this.tsThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThoat.Name = "tsThoat";
            this.tsThoat.Size = new System.Drawing.Size(61, 22);
            this.tsThoat.Text = "Thoát";
            this.tsThoat.Click += new System.EventHandler(this.toolStripthoat_Click);
            // 
            // tsQuayLai
            // 
            this.tsQuayLai.Image = ((System.Drawing.Image)(resources.GetObject("tsQuayLai.Image")));
            this.tsQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuayLai.Name = "tsQuayLai";
            this.tsQuayLai.Size = new System.Drawing.Size(70, 22);
            this.tsQuayLai.Text = "Quay lai";
            this.tsQuayLai.Click += new System.EventHandler(this.tsQuayLai_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grbThongTin.Controls.Add(this.txtManv);
            this.grbThongTin.Controls.Add(this.cbTimKiem);
            this.grbThongTin.Controls.Add(this.lbtimkem);
            this.grbThongTin.Controls.Add(this.dgNhanVien);
            this.grbThongTin.Controls.Add(this.cbGioiTinh);
            this.grbThongTin.Controls.Add(this.txtSoCMND);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Controls.Add(this.txtDienThoai);
            this.grbThongTin.Controls.Add(this.txtTennv);
            this.grbThongTin.Controls.Add(this.lbSoCMND);
            this.grbThongTin.Controls.Add(this.lbDiaChi);
            this.grbThongTin.Controls.Add(this.lbDienThoai);
            this.grbThongTin.Controls.Add(this.lbGioiTinh);
            this.grbThongTin.Controls.Add(this.lbTenNhanVien);
            this.grbThongTin.Controls.Add(this.lbMaNhanVien);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.Location = new System.Drawing.Point(0, 48);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(834, 352);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // txtManv
            // 
            this.txtManv.FormattingEnabled = true;
            this.txtManv.Items.AddRange(new object[] {
            "nv01",
            "nv02",
            "nv03",
            "nv04",
            "mv05"});
            this.txtManv.Location = new System.Drawing.Point(170, 37);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(240, 24);
            this.txtManv.TabIndex = 15;
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Tim kiem theo ma",
            "Tim kiem theo ten",
            "\t"});
            this.cbTimKiem.Location = new System.Drawing.Point(170, 152);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(240, 24);
            this.cbTimKiem.TabIndex = 14;
            // 
            // lbtimkem
            // 
            this.lbtimkem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbtimkem.AutoSize = true;
            this.lbtimkem.Location = new System.Drawing.Point(74, 155);
            this.lbtimkem.Name = "lbtimkem";
            this.lbtimkem.Size = new System.Drawing.Size(93, 16);
            this.lbtimkem.TabIndex = 13;
            this.lbtimkem.Text = " Kiểu Tìm kiếm";
            // 
            // dgNhanVien
            // 
            this.dgNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhanVien.Location = new System.Drawing.Point(8, 196);
            this.dgNhanVien.Name = "dgNhanVien";
            this.dgNhanVien.Size = new System.Drawing.Size(818, 144);
            this.dgNhanVien.TabIndex = 12;
            this.dgNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhanVien_CellClick);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(170, 72);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(240, 24);
            this.cbGioiTinh.TabIndex = 5;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoCMND.Location = new System.Drawing.Point(554, 120);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(240, 23);
            this.txtSoCMND.TabIndex = 11;
            this.txtSoCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoCMND_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(170, 113);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 23);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDienThoai.Location = new System.Drawing.Point(554, 72);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(240, 23);
            this.txtDienThoai.TabIndex = 7;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtTennv
            // 
            this.txtTennv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTennv.Location = new System.Drawing.Point(554, 32);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(240, 23);
            this.txtTennv.TabIndex = 3;
            // 
            // lbSoCMND
            // 
            this.lbSoCMND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSoCMND.AutoSize = true;
            this.lbSoCMND.Location = new System.Drawing.Point(426, 120);
            this.lbSoCMND.Name = "lbSoCMND";
            this.lbSoCMND.Size = new System.Drawing.Size(61, 16);
            this.lbSoCMND.TabIndex = 10;
            this.lbSoCMND.Text = "Số CMND";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(81, 120);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(47, 16);
            this.lbDiaChi.TabIndex = 8;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(426, 80);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(66, 16);
            this.lbDienThoai.TabIndex = 6;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(74, 75);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(54, 16);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Location = new System.Drawing.Point(418, 40);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(89, 16);
            this.lbTenNhanVien.TabIndex = 2;
            this.lbTenNhanVien.Text = "Tên nhân viên";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Location = new System.Drawing.Point(74, 40);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(84, 16);
            this.lbMaNhanVien.TabIndex = 0;
            this.lbMaNhanVien.Text = "Mã nhân viên";
            // 
            // frmQuanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanlynhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHẦN MỀM QUẢN LÝ QUÁN CAFE";
            this.Load += new System.EventHandler(this.frmQuanlynhanvien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripqlnv.ResumeLayout(false);
            this.toolStripqlnv.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbQuanLyNhanVien;
        private System.Windows.Forms.ToolStrip toolStripqlnv;
        private System.Windows.Forms.ToolStripButton tsLamMoi;
        private System.Windows.Forms.ToolStripButton tsThem;
        private System.Windows.Forms.ToolStripButton tsSua;
        private System.Windows.Forms.ToolStripButton tsXoa;
        private System.Windows.Forms.ToolStripButton tsTimKiem;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.DataGridView dgNhanVien;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.Label lbSoCMND;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.ToolStripButton tsThoat;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Label lbtimkem;
        private System.Windows.Forms.ToolStripButton tsQuayLai;
        private System.Windows.Forms.ComboBox txtManv;
    }
}