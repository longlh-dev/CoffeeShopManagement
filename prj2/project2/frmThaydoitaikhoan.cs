using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using project2.DataAccess;

namespace project2
{
    public partial class frmThaydoitaikhoan : Form
    {
        public frmThaydoitaikhoan()
        {
            InitializeComponent();
        }
        
        DataAccessHelper dah = new DataAccessHelper();
        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void btthaydoi_Click(object sender, EventArgs e)

        {
          
            if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
            {
                string caulenh = "Insert into dangnhap values('"+txtTenDangNhap.Text+"','"+txtMatKhau.Text+"')";
                dah.ThucThiCL(caulenh);
                MessageBox.Show("thay đổi tài khoản thành công");
                this.Close();
            }
        }

        private void btkiemtra_Click(object sender, EventArgs e)
        {          
            if (KiemTra(txtTenDangNhap.Text, txtMatKhau.Text))
            {

                {
                    MessageBox.Show("Xác thực thành công");
                }
                DialogResult q = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thay Đổi Tài Khoản Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q.Equals(DialogResult.Yes))
                {
                    if (txtTenDangNhap.Text != "" && txtMatKhau.Text != "")
                    {
                        string caulenh = "delete from dangnhap where tendangnhap='" + txtTenDangNhap.Text + "'";
                        dah.ThucThiCL(caulenh);
                        MessageBox.Show("Giờ bạn hãy nhập vào tài khoản mới theo ý bạn!!!");
                    }
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Text = "";
                    btthaydoi.Enabled = true;
                    btkiemtra.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Mời bạn nhập lại tên đăng nhập và mật khẩu");


            }

        }

        private void frmThaydoitaikhoan_Load(object sender, EventArgs e)
        {
            btthaydoi.Enabled = false;
        
        }
        public bool KiemTra(string tendangnhap, string matKhau)
        {
            int r = dah.TongBanGhi("select * from DangNhap where Tendangnhap='" + tendangnhap + "'and MatKhau='" + matKhau + "'");
            if (r > 0)
                return true;
            else
                return false;
        }

       

        
    }
}
