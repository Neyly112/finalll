using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO1;
using DAO1;
namespace BLL1
{
    public class ClassNTBLL
    {
        private static ClassNTBLL instance;

        public static ClassNTBLL Instance
        {
            get { if (instance == null) instance = new ClassNTBLL(); return instance; }
            private set { instance = value; }
        }
        private ClassNTBLL() { }

        public NguoiThue GetAccount(string maNguoiThue)
        {
            DataTable dt = NT1DAO.Instance.GetAccount(maNguoiThue);
            string matKhau = dt.Rows[0]["matKhau"].ToString();
            string sdt = dt.Rows[0]["SoDienThoai"].ToString();
            string email = dt.Rows[0]["Email"].ToString();
            string diaChi = dt.Rows[0]["DiaChi"].ToString();
            string ten = dt.Rows[0]["Ten"].ToString();
           
            return new NguoiThue(ten, diaChi, email, sdt, matKhau, maNguoiThue);
        }
        public List<NguoiThue> GetAllNT()
        {
            DataTable dt = NT1DAO.Instance.GetAllNT();
            List<NguoiThue> list = new List<NguoiThue>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maNguoiThue = dt.Rows[i]["MaNguoiThue"].ToString();
                string matKhau = dt.Rows[i]["matKhau"].ToString();
                string matKhauAn = new string('*', matKhau.Length);
                string sdt = dt.Rows[i]["SoDienThoai"].ToString();
                string email = dt.Rows[i]["Email"].ToString();
                string diaChi = dt.Rows[i]["DiaChi"].ToString();
                string ten = dt.Rows[i]["Ten"].ToString();
                
                list.Add(new NguoiThue(ten, diaChi, email, sdt, matKhauAn, maNguoiThue));
            }
            return list;
        }
    }
}
