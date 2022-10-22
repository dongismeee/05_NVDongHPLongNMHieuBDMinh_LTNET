using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.Entities
{
    internal class TrinhDoHocVan
    {
        private string matrinhdohocvan;
        private string tentrinhdohocvan;
        private string chuyennganh;

        public string Matrinhdohocvan { get => matrinhdohocvan; set => matrinhdohocvan = value; }
        public string Tentrinhdohocvan { get => tentrinhdohocvan; set => tentrinhdohocvan = value; }
        public string Chuyennganh { get => chuyennganh; set => chuyennganh = value; }

        public TrinhDoHocVan()
        {
        }

        public TrinhDoHocVan(string matrinhdohocvan, string tentrinhdohocvan, string chuyennganh)
        {
            this.matrinhdohocvan = matrinhdohocvan;
            this.tentrinhdohocvan = tentrinhdohocvan;
            this.chuyennganh = chuyennganh;
        }
    }
}
