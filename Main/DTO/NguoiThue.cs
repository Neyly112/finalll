using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class NguoiThue
    {
        
        public string email { get; set; }
        public string diaChi { get; set; }
        public string sdt { get; set; }
        public string ten { get; set; }
        public string mk { get; set; }
        public string maNT { get; set; }
        public bool gioiTinh { get; set; }
        public NguoiThue(string email, string address, string phone, string name, string mk, string maNT, bool gioiTinh)
        {
            this.email = email;
            this.diaChi = address;
            this.sdt = phone;
            this.ten = name;
            this.mk = mk;
            this.maNT = maNT;
            this.gioiTinh = gioiTinh;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getDiaChi()
        {
            return this.diaChi;
        }
        public string getSdt()
        {
            return this.sdt;
        }
        public string getTen()
        {
            return this.ten;
        }
    }
}
