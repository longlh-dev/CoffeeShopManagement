using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using project2.Entities;
using project2.DataAccess;

namespace project2.Business
{
    class NhanVienBLL
    {
        DataAccessHelper dah = new DataAccessHelper();
        NhanVienDAL bll = new NhanVienDAL();
        public DataTable LoadNV()
        {
            return bll.LoadNV();
        }
      
        public void ThemNV(string manv, string tennv, string gioitinh, string dienthoai, string diachi, string socmnd)
        {
            bll.Them(new Nhanvien(manv, tennv,gioitinh,dienthoai,diachi,socmnd));
        }
        public void SuaNV(string manv, string tennv, string gioitinh, string dienthoai, string diachi, string socmnd)
        {
            bll.Sua(new Nhanvien(manv, tennv, gioitinh, dienthoai, diachi, socmnd));
        }
        public void XoaSP(string manv, string tennv, string gioitinh, string dienthoai, string diachi, string socmnd)
        {
            bll.Xoa(new Nhanvien(manv, tennv,gioitinh,dienthoai,diachi,socmnd));
        }
       
        public DataTable Listmanv(string msp)
        {
            return bll.List1(msp);
        }
        public DataTable ListTennv(string tsp)
        {
            return bll.List2(tsp);
        }
        public int tongbanghi(string manv)
        {
            return bll.DemBanGhi(manv);
        }
       
    }
}
