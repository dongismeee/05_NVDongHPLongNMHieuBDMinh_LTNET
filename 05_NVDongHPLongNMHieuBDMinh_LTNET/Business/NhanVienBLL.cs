using Nhom5_QuanLyNhanSu.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Business
{
    internal class NhanVienBLL
    {
        DataAccessHelper dah = new DataAccessHelper();
        NhanVienDAL bll = new NhanVienDAL();
        public DataTable LoadNV()
        {
            return bll.LoadNV();
        }
        //public void ThemKh(string makh, string tenkh, string sodienthoai, string diachi)
        //{
        //    bll.Them(new KhachHang(makh, tenkh, sodienthoai, diachi));
        //}
        //public void SuaKH(string makh, string tenkh, string sodienthoai, string diachi)
        //{
        //    bll.Sua(new KhachHang(makh, tenkh, sodienthoai, diachi));
        //}
        //public void XoaSP(string makh, string tenkh, string sodienthoai, string diachi)
        //{
        //    bll.Xoa(new KhachHang(makh, tenkh, sodienthoai, diachi));
        //}
        //public DataTable Listmakh(string msp)
        //{
        //    return bll.List1(msp);
        //}
        //public DataTable Listtenkh(string tsp)
        //{
        //    return bll.List2(tsp);
        //}
        //public int tongbanghi(string makh)
        //{
        //    return bll.DemBanGhi(makh);
        //}
        //public DataTable ThongTinKH()
        //{
        //    return bll.ThongTin();
        //}
        //public DataTable ThongTinDTKH()
        //{
        //    return bll.ThongTinTien();
        //}
        //public DataTable ThongTinPA()
        //{
        //    return bll.ThongTinPA();
        //}
        //public DataTable ThongTinSL()
        //{
        //    return bll.ThongTinSL();
        //}
    }
}
