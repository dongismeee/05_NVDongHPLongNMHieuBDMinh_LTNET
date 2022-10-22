using Nhom5_QuanLyNhanSu.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Business
{
    internal class TaiKhoanBLL
    {
        TaiKhoanDAL bll = new TaiKhoanDAL();

        public bool KiemTra(string Tendangnhap, string matKhau)
        {
            return bll.KiemTra(Tendangnhap, matKhau);
        }

    }
}
