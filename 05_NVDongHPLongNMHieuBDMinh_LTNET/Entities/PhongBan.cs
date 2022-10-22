using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Entities
{
    internal class PhongBan
    {
        private string maphongban;
        private string tenphongban;
        private string sdtphongban;

        public string Maphongban { get => maphongban; set => maphongban = value; }
        public string Tenphongban { get => tenphongban; set => tenphongban = value; }
        public string Sdtphongban { get => sdtphongban; set => sdtphongban = value; }

        public PhongBan(string maphongban, string tenphongban, string sdtphongban)
        {
            this.maphongban = maphongban;
            this.tenphongban = tenphongban;
            this.sdtphongban = sdtphongban;
        }
        public PhongBan()
        {
        }
    }
}
