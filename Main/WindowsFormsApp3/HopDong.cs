using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class HopDong
    {
        private string ngayLap;
        private int soNguoi;
        private string ngayKetThuc;
        private string tenPhong;
        public HopDong(string ngayLap, int soNguoi, string ngayKetThuc, string tenPhong)
        {
            this.ngayLap = ngayLap;
            this.soNguoi = soNguoi;
            this.ngayKetThuc = ngayKetThuc;
            this.tenPhong = tenPhong;
        }
        public string getNgayLap()
        {
            return ngayLap;
        }
        public int getSoNguoi()
        {
            return soNguoi;
        }
        public string getNgayKetThuc()
        {
            return ngayKetThuc;
        }
        public string getTenPhong()
        {
            return tenPhong;
        }
    }
}
