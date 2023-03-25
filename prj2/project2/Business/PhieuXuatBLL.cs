using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using project2.Entities;
using project2.DataAccess;
namespace project2.Business
{
    class PhieuXuatBLL
    {
        DataAccessHelper dah = new DataAccessHelper();
        PhieuXuatDAL bll = new PhieuXuatDAL();
        public DataTable LoadPX()
        {
            return bll.LoadPX();
        }

        /// <summary>
        /// Thêm phiếu xuất
        /// </summary>
        /// <param name="mapx">Mã phiếu xuất</param>
        /// <param name="manvxuat">Mã nhân viên xuất</param>
        /// <param name="ngayxuat">Ngày xuất</param>
        /// <param name="banso">Số bàn</param>
        public void Thempx(string mapx, string manvxuat, string banso)
        {
            bll.Them(new PhieuXuat(mapx,manvxuat,banso));
        }
        public void Xoapx(string mapx, string manvxuat, string banso)
        {
            bll.Xoa(new PhieuXuat(mapx, manvxuat,banso));
        }
        public DataTable Listpx(string mapx)
        {
            return bll.px(mapx);
        }
        public int tongbanghi(string mapx)
        {
            return bll.DemBanGhi(mapx);
        }
    }
}
