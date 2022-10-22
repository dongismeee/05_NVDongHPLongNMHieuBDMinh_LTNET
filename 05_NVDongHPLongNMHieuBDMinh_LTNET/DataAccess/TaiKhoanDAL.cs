using Nhom5_QuanLyNhanSu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Nhom5_QuanLyNhanSu.DataAccess
{
    internal class TaiKhoanDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public bool KiemTra(string tendangnhap, string matKhau)
        {
            int r = dah.TongBanGhi("select * from tb_TaiKhoan where manhanvien ='" + tendangnhap + "'and password ='" + matKhau + "'");
            if (r > 0)
                return true;
            else
                return false;
        }
        public bool KiemTraQuyen(string tendangnhap, string matKhau)
        {
            int r = dah.TongBanGhi("select * from tb_TaiKhoan where manhanvien ='" + tendangnhap + "'and password ='" + matKhau + "' and mod = 1");
            if (r > 0)
                return true;
            else
                return false;
        }
        public void Update(string tendangnhap, string matKhau)
        {
            string caulenh = "Update tb_TaiKhoan set password = N'" + matKhau + "' where manhanvien='" + tendangnhap + "'";
            dah.ThucThiCL(caulenh);
        }
    }
}
