using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO1
{
    public class NguoiThue
    {
        
        
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string MaNguoiThue { get; set; }
      
        public NguoiThue(string Ten, string DiaChi, string Email, string SoDienThoai, string MatKhau, string MaNguoiThue)
        {
            this.Ten = Ten;
            this.DiaChi = DiaChi;
            this.Email = Email;
            this.SoDienThoai = SoDienThoai;
            this.MatKhau = MatKhau;
            this.MaNguoiThue = MaNguoiThue;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public string getDiaChi()
        {
            return this.DiaChi;
        }
        public string getSdt()
        {
            return this.SoDienThoai;
        }
        public string getTen()
        {
            return this.Ten;
        }
    }
}
