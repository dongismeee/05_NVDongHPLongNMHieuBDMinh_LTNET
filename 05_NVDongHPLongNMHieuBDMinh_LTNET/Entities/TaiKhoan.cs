using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Entities
{
    internal class TaiKhoan
    {
        private string manhanvien;
        private string password;
        private int mod;

        public TaiKhoan()
        {
        }
        public TaiKhoan(string manhanvien, string password, int mod)
        {
            this.Manhanvien = manhanvien;
            this.Password = password;
            this.Mod = mod;
        }

        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Password { get => password; set => password = value; }
        public int Mod { get => mod; set => mod = value; }
    }
}
