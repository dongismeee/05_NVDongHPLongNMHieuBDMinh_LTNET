using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Entities
{
    internal class HoSo
    {
        private string mahopdonglaodong;
        private string loaihopdong;
        private string ngaybatdau;
        private string ngayketthuc;
        private string manhanvien;

        public HoSo(string mahopdonglaodong, string loaihopdong, string ngaybatdau, string ngayketthuc, string manhanvien)
        {
            this.mahopdonglaodong = mahopdonglaodong;
            this.loaihopdong = loaihopdong;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.manhanvien = manhanvien;
        }
        public HoSo()
        {

        }
        public string Mahopdonglaodong { get => mahopdonglaodong; set => mahopdonglaodong = value; }
        public string Loaihopdong { get => loaihopdong; set => loaihopdong = value; }
        public string Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public string Ngayketthuc { get => ngayketthuc; set => ngayketthuc = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
    }
}
