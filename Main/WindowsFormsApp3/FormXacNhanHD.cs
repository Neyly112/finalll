using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormXacNhanHD : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string tenNguoiThue;
        string ma;
        string tenPhong;
        string soNg;
        string ngayBD;
        string ngayKT;
        string maNguoiThue;
        string maHD;
        string emailQL;
        public FormXacNhanHD(string ma, string tenPhong, string soNg, string ngayBD, string ngayKT, string maNguoiThue, string maHD)
        {

            InitializeComponent();
            this.ma = ma;
            this.tenPhong = tenPhong;
            this.soNg = soNg;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.maNguoiThue = maNguoiThue;
            this.maHD = maHD;
            strSql = c.SqlConect();
        }

        private void FormXacNhanHD_Load(object sender, EventArgs e)
        {
            getMailQL();
            
            funcGetTenNguoiThue();
            tbTenNguoiThue.Text = tenNguoiThue;
            tbTenPhong.Text = tenPhong;
            dateTimePicker1.Text = ngayBD;
            dateTimePicker2.Text = ngayKT;
            tbSoNg.Text = soNg;
            lbTenPhong.BackColor = System.Drawing.Color.Transparent;
            tbTenPhong.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            tbTenNguoiThue.BackColor = System.Drawing.Color.Transparent;
            tbSoNg.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            
        }

        private void funcGetTenNguoiThue()
        {
            MessageBox.Show(tenNguoiThue);
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
            sqlCm.CommandText = "select Ten from Nguoi_thue where MaNguoiThue = '" + maNguoiThue + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                tenNguoiThue = tmp;
                MessageBox.Show(tenNguoiThue);
            }
            reader.Close();
            sql.Close();
        }
        private void getMailQL()
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
            sqlCm.CommandText = "select top 1 Email from Quan_li where MaQuanLi = dbo.getTopMaQL() order by MaQuanLi desc";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                emailQL = tmp;

            }
            reader.Close();
            sql.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            getMailQL();
           
            
            MailMessage mail = new MailMessage();
            MailAddress to = new MailAddress(emailQL);
            mail.From = new MailAddress("thuanminh1390@gmail.com");
            mail.To.Add(to);
            mail.Subject = "Hợp đồng bị từ chối";
            mail.Body = "Hợp đồng " + maHD + " bị từ chối";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("thuanminh1390@gmail.com", "efrn boew pxah cwhh");
            smtpClient.EnableSsl = true;
            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("Đã từ chối");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.Hide();
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
        }
        private void deleteNT()
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
            sqlCm.CommandText = "delete from Nguoi_thue where MaNguoiThue = '" + maNguoiThue + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
            sql.Close();
        }
        private void deletePhongSoHuu()
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
            sqlCm.CommandText = "delete from Phong_thue_so_huu where MaNguoiThue = '" + maNguoiThue + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
            sql.Close();
        }
        private void funcUpdateTrangThaiPhong()
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
            sqlCm.CommandText = "Update Phong_cho_thue set TrangThaiPhong= N'Đã cho thuê' where MaPhong= '" + tenPhong + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
            sql.Close();
        }
        private void funcUpdateTrangThaiHD()
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
            sqlCm.CommandText = "Update Hop_dong set TrangThai= N'Đã xác nhận' where MaPhong= '" + tenPhong + "'";
            sqlCm.Connection = sql;
            sqlCm.ExecuteNonQuery();
            sql.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getMailQL();
            MailMessage mail = new MailMessage();
            MailAddress to = new MailAddress(emailQL);
            mail.From = new MailAddress("thuanminh1390@gmail.com");
            mail.To.Add(to);
            mail.Subject = "Hợp đồng đã xác nhận";
            mail.Body = "Hợp đồng " + maHD + " đã xác nhận";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("thuanminh1390@gmail.com", "efrn boew pxah cwhh");
            smtpClient.EnableSsl = true;
            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("Đã xác nhận");
            }
            catch (Exception ex)
            {
            }
            funcUpdateTrangThaiHD();
            funcUpdateTrangThaiPhong();
            this.Hide();
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
        }

        private void tbTenNguoiThue_Click(object sender, EventArgs e)
        {

        }
    }
}
