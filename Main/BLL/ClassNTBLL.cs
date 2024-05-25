using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
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
            DataTable dt = ClasNT1.Instance.GetAccount(maNguoiThue);
            string matKhau = dt.Rows[0]["matKhau"].ToString();
            string sdt = dt.Rows[0]["SoDienThoai"].ToString();
            string email = dt.Rows[0]["Email"].ToString();
            string diaChi = dt.Rows[0]["DiaChi"].ToString();
            string ten = dt.Rows[0]["Ten"].ToString();
            bool gioiTinh = (bool)dt.Rows[0]["gioiTinh"];
            return new NguoiThue(email, diaChi, sdt, ten, matKhau, maNguoiThue, gioiTinh);
        }
        public List<NhanVien> GetAllEmployee()
        {
            DataTable dt = NhanVienDAO.Instance.GetAllEmployee();
            List<NhanVien> list = new List<NhanVien>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maNhanVien = dt.Rows[i]["maNhanVien"].ToString();
                string matKhau = dt.Rows[i]["matKhau"].ToString();
                string matKhauAn = new string('*', matKhau.Length);
                int phanQuyen = (int)dt.Rows[i]["phanQuyen"];
                string chucVu = dt.Rows[i]["chucVu"].ToString();
                string hoTen = dt.Rows[i]["hoTen"].ToString();
                bool gioiTinh = (bool)dt.Rows[i]["gioiTinh"];
                list.Add(new NhanVien(maNhanVien, matKhauAn, phanQuyen, chucVu, hoTen, gioiTinh));
            }
            return list;
        }
    }
}
