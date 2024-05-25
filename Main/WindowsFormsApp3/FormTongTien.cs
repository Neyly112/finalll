using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormTongTien : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string ma;
        string maCanHo;
        double tongTienNuoc;
        double tongTienDien;
        double phiSinhHoat;
        double tongTien;
        string maBangPhi;
        string ngayLap;
        double so_m3;
        double soKwh;
        double giaPhong;
        double tongTienXe;
        int xeMay;
        int xeDap;
        int xeDuoi15Tan;
        string ngayKT;
        public FormTongTien(string ma, string maCanHo, double tongTienNuoc, double tongTienDien, double phiSinhHoat, double tongTien, string maBangPhi, string ngayLap, string ngayKT, double so_m3, double soKwh, int xeMay, int xeDap, int xeDuoi15Tan, double tongTienXe)
        {
            InitializeComponent();
            this.ma = ma;
            this.maCanHo = maCanHo;
            this.tongTienNuoc = tongTienNuoc;
            this.tongTienDien = tongTienDien;
            this.phiSinhHoat = phiSinhHoat;
            this.tongTien = tongTien;
            this.maBangPhi = maBangPhi;
            this.ngayLap = ngayLap;
            this.soKwh = soKwh;
            this.so_m3 = so_m3;
            this.ngayKT = ngayKT;
            giaPhong = 0;
            this.tongTienXe = tongTienXe;
            this.xeMay = xeMay;
            this.xeDap = xeDap;
            this.xeDuoi15Tan = xeDuoi15Tan;
            strSql = c.SqlConect();
        }

        private void FormTongTien_Load(object sender, EventArgs e)
        {
            getGiaPhong();
            tongTien += giaPhong;
            lbMaCanHo.Text = maCanHo;
            lbTongTienDien.Text = tongTienDien.ToString() + " VNĐ";
            lbTongTienNuoc.Text = tongTienNuoc.ToString() + " VNĐ";
            lbPhiSinhHoat.Text = phiSinhHoat.ToString() + " VNĐ";
            lbTongTien.Text = tongTien.ToString() + " VNĐ";
            lbNgayLap.Text = ngayLap.ToString();
            lbTienThuePhong.Text = giaPhong.ToString() + " VNĐ";
            lbTienXe.Text = tongTienXe.ToString() + " VNĐ";
            label3.Text = ngayKT.ToString();
            lbXeDap.Text = "Xe đạp: " + xeDap.ToString() + " chiếc";
            lbXeMay.Text = "Xe máy: " + xeMay.ToString() + " chiếc";
            lbXeDuoi15Tan.Text = "Xe dưới 1,5 tấn: " + xeDuoi15Tan.ToString() + " chiếc";
            lbMaCanHo.BackColor = System.Drawing.Color.Transparent;
            lbNgayLap.BackColor = System.Drawing.Color.Transparent;
            lbPhiSinhHoat.BackColor = System.Drawing.Color.Transparent;
            lbTienThuePhong.BackColor = System.Drawing.Color.Transparent;
            lbTienXe.BackColor = System.Drawing.Color.Transparent;
            lbTongTien.BackColor = System.Drawing.Color.Transparent;
            lbTongTienDien.BackColor = System.Drawing.Color.Transparent;
            lbTongTienNuoc.BackColor = System.Drawing.Color.Transparent;
            lbXeDap.BackColor = System.Drawing.Color.Transparent;
            lbXeDuoi15Tan.BackColor= System.Drawing.Color.Transparent;
            lbXeMay.BackColor= System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label9.BackColor = System.Drawing.Color.Transparent;
            label10.BackColor = System.Drawing.Color.Transparent;
            label11.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getGiaPhong()
        {
            double tmp;
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec getGiaPhong '" + maCanHo + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                tmp = reader.GetDouble(0);
                giaPhong = tmp;
            }
            reader.Close();
        }
        private void funcAddHoaDon(double tongTien, string maBangPhi, string maPhong, string ngayLap, string ngayKT)
        {
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec insertToHoaDon '" + ngayLap + "', '" + ngayKT + "', '" + maPhong + "', '" + maBangPhi + "', '" + tongTien + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đã lưu");
                
            }
            else
            {
                MessageBox.Show("ko");
            }
        }
        private void funcAddNuoc(double so_m3, double tongTienNuoc)
        {
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec insertToNuoc '" + so_m3 + "', '" + tongTienNuoc + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
        }
        private void funcAddDien(double soKwh, double tongTienDien)
        {
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec insertToDien '" + soKwh + "', '" + tongTienDien + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
        }
        private void funcAddTienXe(double tongTienXe)
        {
            int soLuongXe = xeMay + xeDap + xeDuoi15Tan;

            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec insertToTienXe '" + soLuongXe + "', '" + tongTienXe + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            funcAddHoaDon(tongTien, maBangPhi, maCanHo, ngayLap, ngayKT);
            funcAddDien(soKwh, tongTienDien);
            funcAddNuoc(so_m3, tongTienNuoc);
            funcAddTienXe(tongTienXe);
            this.Hide();
            FormNhapTinhToan f = new FormNhapTinhToan(ma);
            f.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
