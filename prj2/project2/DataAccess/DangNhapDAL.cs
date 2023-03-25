using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using project2.Entities;
using System.Data;

namespace project2.DataAccess
{
    class DangNhapDAL
    {
        DataAccessHelper dah = new DataAccessHelper();
        

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
