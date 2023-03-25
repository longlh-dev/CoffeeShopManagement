using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using project2.Entities;
using project2.DataAccess;
using System.Data;

namespace project2.Business
{
    class DangNhapBLL

    {
        DangNhapDAL bll = new DangNhapDAL();
       
        public bool KiemTra(string Tendangnhap, string matKhau)
        {
            return bll.KiemTra(Tendangnhap, matKhau);
        }
        
    }
}
