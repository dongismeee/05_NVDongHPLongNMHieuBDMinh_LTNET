using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom5_QuanLyNhanSu.DataAccess
{
    internal class TrinhDoDAL
    {
        DataAccessHelper dah = new DataAccessHelper();

        public DataTable LoadTD()
        {
            string s = "Select * from tb_TrinhDo";
            return dah.get_DaTaTable(s);
        }
    }
}
