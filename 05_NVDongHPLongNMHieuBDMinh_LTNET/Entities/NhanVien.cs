using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Entities
{
    internal class NhanVien
    {
        private string manhanvien;
        private string hoten;
        private string quequan;
        private string gioitinh;
        private string ngaysinh;
        private string sodienthoai;
        private string maphongban;
        private string bacluong;
        private string trinhdo;
        private string chucvu;

        public NhanVien()
        {
        }

        public NhanVien(string manhanvien, string hoten, string quequan, string gioitinh, string ngaysinh, string sodienthoai, string maphongban, string bacluong, string trinhdo,string chucvu)
        {
            this.manhanvien = manhanvien;
            this.hoten = hoten;
            this.quequan = quequan;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.sodienthoai = sodienthoai;
            this.maphongban = maphongban;
            this.bacluong = bacluong;
            this.Trinhdo = trinhdo;
            this.Chucvu = chucvu;
        }

        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Maphongban { get => maphongban; set => maphongban = value; }
        public string Bacluong { get => bacluong; set => bacluong = value; }
        public string Trinhdo { get => trinhdo; set => trinhdo = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
    }
}

