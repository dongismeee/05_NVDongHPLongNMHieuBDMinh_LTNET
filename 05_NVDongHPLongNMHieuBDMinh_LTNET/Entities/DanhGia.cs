using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Entities
{
    internal class DanhGia
    {
        private string madanhgia;
        private string loaidanhgia;
        private string nangsuat;

        public string Madanhgia { get => madanhgia; set => madanhgia = value; }
        public string Loaidanhgia { get => loaidanhgia; set => loaidanhgia = value; }
        public string Nangsuat { get => nangsuat; set => nangsuat = value; }

        public DanhGia()
        {
        }

        public DanhGia(string madanhgia, string loaidanhgia, string nangsuat)
        {
            this.madanhgia = madanhgia;
            this.loaidanhgia = loaidanhgia;
            this.nangsuat = nangsuat;
        }
    }
}
