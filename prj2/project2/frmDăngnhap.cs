using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using project2.DataAccess;
using project2.Business;



namespace project2
{
    public partial class frmDăngnhap : Form
    {
        static int count = 0;
        public frmDăngnhap()
        {
            InitializeComponent();
        }
    
        public bool kt;
        DangNhapBLL bll = new DangNhapBLL();

        //private void btthoat_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btthoat_Click_1(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {


            kt = false;
            if (bll.KiemTra(txtTenDangNhap.Text, txtMatKhau.Text))
            {


                kt = true;
                MessageBox.Show("Đăng Nhập Thành Công");
               
                {
                    this.Close();

                }
                
            }
            else
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu");
                count = count + 1;
                if (count >= 3)
                {
                    btDangNhap.Enabled = false;
                    MessageBox.Show("không được nhập quá 3 lần");
                   
                }

            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }      
       
    }
}
