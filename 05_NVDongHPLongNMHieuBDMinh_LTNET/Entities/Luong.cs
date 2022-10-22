using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Entities
{
    internal class Luong
    {
        private float bacluong;
        private float luongcoban;
        private float hesoluong;
        private float hesophucap;

        public float Bacluong { get => bacluong; set => bacluong = value; }
        public float Luongcoban { get => luongcoban; set => luongcoban = value; }
        public float Hesoluong { get => hesoluong; set => hesoluong = value; }
        public float Hesophucap { get => hesophucap; set => hesophucap = value; }

        public Luong()
        {
        }

        public Luong(float bacluong, float luongcoban, float hesoluong, float hesophucap)
        {
            this.bacluong = bacluong;
            this.luongcoban = luongcoban;
            this.hesoluong = hesoluong;
            this.hesophucap = hesophucap;
        }
    }
}
