using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Entities
{
    internal class ChucVu
    {
        private string machucvu;
        private string tenchucvu;

        public string Machucvu { get => machucvu; set => machucvu = value; }
        public string Tenchucvu { get => tenchucvu; set => tenchucvu = value; }

        public ChucVu()
        {
        }

        public ChucVu(string machucvu, string tenchucvu)
        {
            this.machucvu = machucvu;
            this.tenchucvu = tenchucvu;
        }
    }
}
