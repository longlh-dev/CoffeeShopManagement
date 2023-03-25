using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using project2.Business;
using project2.DataAccess;
using project2.Entities;

namespace project2
{
    public partial class frmThongkesanpham : Form
    {
        public frmThongkesanpham()
        {
            InitializeComponent();
        }
       // PhieuXuatBLL pxbll = new PhieuXuatBLL();

        ChiTietPhieuXuatBLL ctpxbll = new ChiTietPhieuXuatBLL();
        private void tsThoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
        private void frmThongkesanpham_Load(object sender, EventArgs e)
        {
            dgThongKesp.DataSource = ctpxbll.Loadctpx();
        }

        private void tsThongKe_Click(object sender, EventArgs e)
        {
            if (cbKieuThongKe.Text == "Thống kê sản phẩm bán chạy")
            {
                dgThongKesp.DataSource = ctpxbll.ThongKeSanPhamBanChay();
               
            }

            else if (cbKieuThongKe.Text == "Thống kê sản phẩm bán chậm")
            {
                dgThongKesp.DataSource = ctpxbll.ThongKeSanPhamBanCham();

            }

            else
                MessageBox.Show("Bạn phải nhập kiêu thống kê");

        }

        private void tsLamMoi_Click(object sender, EventArgs e)
        {
            cbKieuThongKe.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmThongkesanpham_Load(sender, e);
        }
    }
}
