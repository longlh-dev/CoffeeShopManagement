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
    public partial class frmQuanlynhanvien : Form
    {
        public frmQuanlynhanvien()
        {
            InitializeComponent();
        }
        NhanVienBLL bll = new NhanVienBLL();
        Nhanvien nv = new Nhanvien();
        NhanVienDAL dal = new NhanVienDAL();
        
        private void toolStripthoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void frmQuanlynhanvien_Load(object sender, EventArgs e)
        {
            dgNhanVien.DataSource = bll.LoadNV();
        }

        private void tsLamMoi_Click(object sender, EventArgs e)
        {
            txtSoCMND.Text = "";
            txtTennv.Text = "";
            txtManv.Text = "";
            txtDiaChi.Text = "";
            cbGioiTinh.Text = "";
            txtDienThoai.Text = "";
            cbTimKiem.Text = "";

        }

        private void tsThem_Click(object sender, EventArgs e)
        {

            if (bll.tongbanghi(txtManv.Text) == 1)
                MessageBox.Show("Mã: " + txtManv.Text + " đã tồn tại. Nhập mã khác!");
            else if (bll.tongbanghi(txtManv.Text) == 0)

            {
                if (txtManv.Text != "" && txtTennv.Text != "" && cbGioiTinh.Text != "" && txtDienThoai.Text != "" && txtDiaChi.Text != "" && txtSoCMND.Text != "")
                {
                    bll.ThemNV(txtManv.Text, (txtTennv.Text), cbGioiTinh.Text, txtDienThoai.Text, txtDiaChi.Text, txtSoCMND.Text);
                    MessageBox.Show("Thêm Thành Công!", "Thông Báo");
                    frmQuanlynhanvien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại,Bạn Phải Nhập Đầy Đủ Thông Tin", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void tsSua_Click(object sender, EventArgs e)
        {
              if (txtSoCMND.Text != "" || txtTennv.Text != "" || cbGioiTinh.Text != "" || txtDienThoai.Text != "" || txtDiaChi.Text != "")
            

                {
                    bll.SuaNV(txtManv.Text, txtTennv.Text, cbGioiTinh.Text, txtDienThoai.Text, txtDiaChi.Text,txtSoCMND.Text);
                    MessageBox.Show("Sửa Thành Công!", "Thông Báo");
                    frmQuanlynhanvien_Load(sender, e);

                }
        }

        private void tsTimKiem_Click(object sender, EventArgs e)
        {
          
            if (cbTimKiem.Text == "Tim kiem theo ma")
            
                {
                    dgNhanVien.DataSource = bll.Listmanv(txtManv.Text);
                    txtManv.Text = "";

                }
            
            else

                if (cbTimKiem.Text == "Tim kiem theo ten")
                
                    {
                        dgNhanVien.DataSource = bll.ListTennv(txtTennv.Text);
                        txtTennv.Text = "";

                    }
            
                
                else
                    MessageBox.Show("Bạn phải nhập kiêu tìm kiếm");

        }

        private void dgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hangchon=e.RowIndex;
            txtManv.Text = dgNhanVien[0, hangchon].Value.ToString();
            txtTennv.Text = dgNhanVien[1, hangchon].Value.ToString();
            cbGioiTinh.Text = dgNhanVien[2, hangchon].Value.ToString();
            txtDienThoai.Text=dgNhanVien[3,hangchon].Value.ToString();
            txtDiaChi.Text=dgNhanVien[4,hangchon].Value.ToString();
            txtSoCMND.Text=dgNhanVien[5,hangchon].Value.ToString();
      
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void tsXoa_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Xóa Nhân Viên Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                bll.XoaSP(txtManv.Text, txtTennv.Text, cbGioiTinh.Text, txtDienThoai.Text, txtDiaChi.Text, txtSoCMND.Text);
             frmQuanlynhanvien_Load(sender, e);

            }
        }

        private void tsQuayLai_Click(object sender, EventArgs e)
        {
            dgNhanVien.DataSource = bll.LoadNV();
        }

      
      
    }
}
