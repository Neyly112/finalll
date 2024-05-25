using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
        public class ClasNT1
        {
        private static ClasNT1 instance;

        public static ClasNT1 Instance
        {
            get { if (instance == null) instance = new ClasNT1(); return instance; }
            private set { instance = value; }
        }
        public ClasNT1() { }

        public DataTable GetAllNT()
        {
            string query = "select * from NhanVien";
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
