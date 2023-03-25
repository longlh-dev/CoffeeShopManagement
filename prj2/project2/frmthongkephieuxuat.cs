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
    public partial class frmthongkephieuxuat : Form
    {
        public frmthongkephieuxuat()
        {
            InitializeComponent();
        }
        PhieuXuatBLL pxbll = new PhieuXuatBLL();

        ChiTietPhieuXuatBLL ctpxbll = new ChiTietPhieuXuatBLL();
        DataTable dt = new DataTable();
        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
         private void frmthongkephieuxuat_Load(object sender, EventArgs e)
        {
            dgThongKepx.DataSource = ctpxbll.Loadctpx();

        }
        double Tong = 0;
        public double TongTien(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tong = Tong + double.Parse(dt.Rows[i][3].ToString());
            }
            return Tong;
        }

        private void cbKieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            Tong = 0;
            switch (cbKieuThongKe.Text.ToString())
            {               
                case "Thống kê ngày ":
                    dtpTuNgay.Value = DateTime.Parse(dt.ToShortDateString());
                    dtpDenNgay.Value = DateTime.Parse(dt.ToShortDateString());
                    break;
                case "Theo tháng":
                    dtpTuNgay.Value = DateTime.Parse(String.Format("{0}/1/{1}", dt.Month, dt.Year));
                    dtpDenNgay.Value = DateTime.Parse(String.Format("{0}/1/{1}", dt.Month+1, dt.Year));
                    break;
                case "Theo năm":
                    dtpTuNgay.Value = DateTime.Parse(String.Format("1/1/{0}", dt.Year));
                    dtpDenNgay.Value = DateTime.Parse(String.Format("1/1/{0}", dt.Year+1 ));
                    break;
            }
        }

       
        private void tsThongKe_Click(object sender, EventArgs e)
        {
            DataTable dt = ctpxbll.TimKiemPX(dtpTuNgay.Value.ToShortDateString(), dtpDenNgay.Value.ToShortDateString());

            {
                dgThongKepx.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    txtTongTien.Text = TongTien(dt).ToString();
                }
                else
                {
                    txtTongTien.Text = "";
                }
            }
        }

        private void tsThoat_Click(object sender, EventArgs e)
        {

            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
