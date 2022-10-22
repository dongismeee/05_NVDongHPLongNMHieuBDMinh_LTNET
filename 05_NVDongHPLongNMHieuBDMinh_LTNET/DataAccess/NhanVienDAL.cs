using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom5_QuanLyNhanSu.Entities;

namespace Nhom5_QuanLyNhanSu.DataAccess
{
    internal class NhanVienDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable LoadNV()
        {
            string s = "Select * from tb_NhanVien";
            return dah.get_DaTaTable(s);
        }
        //public void Them(NhanVien kh)
        //{
        //    string s = "insert into KhachHang values(N'" + kh.Makh + "', N'" + kh.Tenkh + "', N'" + kh.Sodienthoai + "', N'" + kh.Diachi + "')";
        //    dah.ThucThiCL(s);
        //}
        //public void Xoa(KhachHang kh)
        //{
        //    dah.ThucThiCL("delete from KhachHang where makh= N'" + kh.Makh + "'");
        //}
        //public void Sua(KhachHang kh)
        //{
        //    string caulenh = "Update KhachHang set tenkh= N'" + kh.Tenkh + "',sodienthoai= N'" + kh.Sodienthoai + "',diachi=N'" + kh.Diachi + "' where makh='" + kh.Makh + "'";
        //    dah.ThucThiCL(caulenh);
        //}
        //public DataTable List1(string makh)
        //{
        //    string caulenh = "select * from KhachHang where makh='" + makh + "'";
        //    return dah.get_DaTaTable(caulenh);
        //}
        //public DataTable List2(string tenkh)
        //{
        //    string caulenh = "select * from KhachHang where tenkh=N'" + tenkh + "'";
        //    return dah.get_DaTaTable(caulenh);
        //}
        //public int DemBanGhi(string makh)
        //{
        //    int banghi;
        //    banghi = dah.TongBanGhi("select * from KhachHang where makh='" + makh + "' ");
        //    return banghi;
        //}
        //public DataTable ThongTin()
        //{
        //    string caulenh = "select KhachHang.Tenkh, SanPham.Tensp,PhieuXuat.Ngayxuat, ChiTietPhieuXuat.Soluong,ChiTietPhieuXuat.Thanhtien from(((PhieuXuat inner join ChiTietPhieuXuat on PhieuXuat.Mapx = ChiTietPhieuXuat.Mapx) inner join KhachHang on PhieuXuat.Makh = KhachHang.Makh) inner join SanPham on ChiTietPhieuXuat.Masp = SanPham.Masp)";
        //    return dah.get_DaTaTable(caulenh);
        //}
        //public DataTable ThongTinTien()
        //{
        //    string caulenh = "select KhachHang.Tenkh as [Tên khách hàng], SUm(Thanhtien) AS [Tổng] from((PhieuXuat inner join KhachHang on PhieuXuat.Makh = KhachHang.Makh) inner join ChiTietPhieuXuat on PhieuXuat.Mapx = ChiTietPhieuXuat.Mapx) Group by Tenkh";
        //    return dah.get_DaTaTable(caulenh);
        //}
        //public DataTable ThongTinPA()
        //{
        //    string caulenh = "select KhachHang.Tenkh as [Tên khách hàng],PhieuAn.Mapa as [Mã phiếu ăn],PhieuAn.Hansd as[Hạn sử dụng] from(KhachHang inner join PhieuAn on KhachHang.Makh = PhieuAn.Makh); ";
        //    return dah.get_DaTaTable(caulenh);
        //}
        //public DataTable ThongTinSL()
        //{
        //    string caulenh = "select KhachHang.Tenkh as [Tên khách hàng],count(PhieuXuat.Mapx) as [Sô lần ăn] from(KhachHang inner join PhieuXuat on KhachHang.Makh = PhieuXuat.Makh) Group by Tenkh";
        //    return dah.get_DaTaTable(caulenh);
        //}
    }
}
