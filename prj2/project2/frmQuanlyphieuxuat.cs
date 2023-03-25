using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using project2.DataAccess;
using project2.Entities;
using project2.Business;


namespace project2
{
    public partial class frmQuanlyphieuxuat : Form
    {
        public frmQuanlyphieuxuat()
        {
            InitializeComponent();
        }
        PhieuXuat px = new PhieuXuat();
        PhieuXuatBLL pxb = new PhieuXuatBLL();
        SanPhamBLL dtb = new SanPhamBLL();
        ChiTietPhieuXuatBLL ctx = new ChiTietPhieuXuatBLL();
        DataTable dt = new DataTable();     
     // form load
        private void frmQuanlyphieuxuat_Load_1(object sender, EventArgs e)
        {
            // load các phiếu xuất đã có
             dgPhieuXuat.DataSource = pxb.LoadPX();
            //load ma nhan vien
            NhanVienBLL nvnll = new NhanVienBLL();
            cbManv.DataSource = nvnll.LoadNV();
            cbManv.DisplayMember = "manv";
            
            //// load ngay bán là ngày hiện tại
            msNgayBan.Text = DateTime.Today.ToShortDateString();
        }
        // thêm phiếu xuất
        private void tstThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Kiểm tra mã có trùng hay không?
                if (pxb.tongbanghi(txtMapx.Text) == 1)
                    MessageBox.Show("Mã: " + txtMapx.Text + " đã tồn tại. Nhập mã khác!");
                else if (pxb.tongbanghi(txtMapx.Text) == 0)
                {
                    
                    if (txtMapx.Text != "" && cbManv.Text != "" && cbBanSo.Text != "" && msNgayBan.Text != "")
                    {
                        pxb.Thempx(txtMapx.Text, cbManv.Text, cbBanSo.Text);
                        MessageBox.Show("them thanh cong");
                        frmQuanlyphieuxuat_Load_1(sender, e);                       
                    }
                 
                
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại","thôngbao",MessageBoxButtons.OK);
            }         
        }
        // làm mới các textbook
        private void tstLamMoi_Click_1(object sender, EventArgs e)
        {
            txtMapx.Text = "";
            cbBanSo.Text = "";
            cbManv.Text = "";          
        }
        // gọi form chi tiết phiếu xuất
        private void tstChiTietPhieuXuat_Click_1(object sender, EventArgs e)
        {
            frmchitietphieuxuat ct = new frmchitietphieuxuat();
            ct.ShowDialog();
        }
        // thoát khỏi form
        private void tstThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        // xóa phiếu xuát
        private void tsXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu xuất này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pxb.Xoapx(txtMapx.Text, cbManv.Text, cbBanSo.Text);
                MessageBox.Show("xoa thanh cong");
                 frmQuanlyphieuxuat_Load_1(sender, e);
            }
        }
        // sự kiện cellclick
        private void dgPhieuXuat_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMapx.Text = dgPhieuXuat[0, hang].Value.ToString();
            cbManv.Text = dgPhieuXuat[1, hang].Value.ToString();
            msNgayBan.Text = dgPhieuXuat[2, hang].Value.ToString();
            cbBanSo.Text = dgPhieuXuat[3, hang].Value.ToString();
        }
        // tìm kiếm phiếu xuất
        private void tsTimKiem_Click(object sender, EventArgs e)
        {
            dgPhieuXuat.DataSource = pxb.Listpx(txtMapx.Text);
            txtMapx.Text = "";
        }
        // trở lại form ban đầu nhu mới load
        private void tsQuayLai_Click(object sender, EventArgs e)
        {             
            frmQuanlyphieuxuat_Load_1(sender, e);
        }

        private void txtMapx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
