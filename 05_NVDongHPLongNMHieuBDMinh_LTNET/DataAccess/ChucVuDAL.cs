using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.DataAccess
{
    internal class ChucVuDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable LoadCV()
        {
            string s = "Select * from tb_ChucVu";
            return dah.get_DaTaTable(s);
        }
    }
}
