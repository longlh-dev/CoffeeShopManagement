using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace project2
{
    public partial class frmquanly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmquanly()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDăngnhap frm = new frmDăngnhap();
            frm.ShowDialog();
            if (frm.kt == true)
            {
                //MessageBox.Show("Đăng Nhập Thành Công");
                Dangnhapthanhcong();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThaydoitaikhoan a = new frmThaydoitaikhoan();
            a.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmQuanlynhanvien qlnv = new frmQuanlynhanvien();
            qlnv.ShowDialog();
        }

        private void btsanpham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSanPham qlsp = new frmSanPham();
            qlsp.ShowDialog();
        }

        private void btphieuxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanlyphieuxuat qlpx = new frmQuanlyphieuxuat();
            qlpx.ShowDialog();
        }

        private void bttksp_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongkesanpham tksp = new frmThongkesanpham();
            tksp.ShowDialog();
        }

        private void bttkpx_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmthongkephieuxuat tkpx = new frmthongkephieuxuat();
            tkpx.ShowDialog();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void frmquanly_Load(object sender, EventArgs e)
        {
            //SoundPlayer a = new SoundPlayer("aa.wav");
            //a.Play();
            btthaydoitaikhoan.Enabled = false;
            //rbquanly.Enabled = false;
            //rbthongke.Enabled = false;
            bttrogiup.Enabled = true;
            btnhanvien.Enabled = false;
            btsanpham.Enabled = false;
            btphieuxuat.Enabled = false;
            bttksp.Enabled = false;
            bttkpx.Enabled = false;
        }
        public void Dangnhapthanhcong()
        {
            btthaydoitaikhoan.Enabled = true;
            //tsQuanLy.Enabled = true;
            //tsThongKe.Enabled = true;
            bttrogiup.Enabled = true;
            btnhanvien.Enabled = true;
            btsanpham.Enabled = true;
            bttkpx.Enabled = true;
            bttksp.Enabled = true;
            btphieuxuat.Enabled = true;
        }
        private void bttrogiup_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTroGiup tg = new frmTroGiup();
            tg.ShowDialog();
        }

        private void frmquanly_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát hay không?", "Thoát khỏi chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            { e.Cancel = false; }
            else e.Cancel = true;
        }
    }
}