using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.DataAccess
{
    internal class PhongBanDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable LoadPA()
        {
            string s = "Select * from tb_PhongBan";
            return dah.get_DaTaTable(s);
        }
    }
}
