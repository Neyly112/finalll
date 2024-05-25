using DTO1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO1
{
    public class NT1DAO
    {
        private static NT1DAO instance;

        public static NT1DAO Instance
        {
            get { if (instance == null) instance = new NT1DAO(); return instance; }
            private set { instance = value; }
        }
        public NT1DAO() { }

        public DataTable GetAllNT()
        {
            string query = "select * from Nguoi_thue";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAccount(string maNguoiThue)
        {
            string query = $"select * from Nguoi_thue where MaNguoiThue = '{maNguoiThue}'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
