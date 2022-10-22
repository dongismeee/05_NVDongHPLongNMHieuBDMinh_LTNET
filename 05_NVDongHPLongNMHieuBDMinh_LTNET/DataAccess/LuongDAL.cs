using Nhom5_QuanLyNhanSu.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.DataAccess
{
    internal class LuongDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable LoadPA()
        {
            string s = "Select * from PhieuAn";
            return dah.get_DaTaTable(s);
        }
        public void Them(Luong luong)
        {
            String s = "insert into Luong values(N'" + luong.Bacluong + "', N'" + luong.Bacluong + "', N'" + luong.Bacluong + "', N'" + luong.Bacluong + "', N'" + luong.Bacluong + "')";
            dah.ThucThiCL(s);
        }
        //public void Xoa(Luong pa)
        //{
        //    dah.ThucThiCL("delete from PhieuAn where mapa= N'" + pa.Mapa + "'");
        //}
        //public void Sua(Luong pa)
        //{
        //    string caulenh = "Update PhieuAn set hansd= N'" + pa.Hansd + "' where mapa='" + pa.Mapa + "'";
        //    dah.ThucThiCL(caulenh);
        //}
        //public DataTable List1(string mapa)
        //{
        //    string caulenh = "select * from PhieuAn where mapa='" + mapa + "'";
        //    return dah.get_DaTaTable(caulenh);
        //}
        //public DataTable List2(string tenkh)
        //{
        //    string caulenh = "select * from PhieuAn where tenkh=N'" + tenkh + "'";
        //    return dah.get_DaTaTable(caulenh);
        //}
        //public int DemBanGhi(string mapa)
        //{
        //    int banghi;
        //    banghi = dah.TongBanGhi("select * from PhieuAn where mapa='" + mapa + "' ");
        //    return banghi;
        //}
    }
}
