using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormThongTinHopDong : Form
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

        public FormThongTinHopDong(string ma, string tenPhong, string soNg, string ngayBD, string ngayKT, string maNguoiThue)
        {
            InitializeComponent();
            this.ma = ma;
            this.tenPhong = tenPhong;
            this.soNg = soNg;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.maNguoiThue = maNguoiThue;
            strSql = c.SqlConect();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {

        }
        private void funcGetTenNguoiThue()
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
            sqlCm.CommandText = "exec getTenNguoiThue '" + tenPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                tenNguoiThue = tmp;
                
            }
            reader.Close();
            sql.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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
            sqlCm.CommandText = "delete from Hop_dong where MaPhong= '" + tenPhong + "'";
            
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đã hủy hợp đồng");
            }
            else
            {
                MessageBox.Show("Hợp đồng không tồn tại");
            }
            sql.Close();
            funcDeletePhongThue();
            deleteNT();
            this.Hide();
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dateTimePicker2.Value.ToString("yyyy-MM-dd") == dateTimePicker1.Value.ToString("yyyy-MM-dd"))
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày lập");
                return;
            }
            if (dateTimePicker2 == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }
            if (Convert.ToInt32(tbSoNg.Text) <= 0 )
            {
                MessageBox.Show("Số người ở không phù hợp");
                return;
            }
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
            sqlCm.CommandText = "update Hop_dong set NgayKetThuc = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "', SoNguoiO='" + tbSoNg.Text + "' where MaPhong = '" + tenPhong + "'";
            sqlCm.Connection = sql;
            
           
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                funcDoiTenNguoiThue(tenPhong);
                MessageBox.Show("Sửa thông tin thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            sql.Close();
            this.Hide();
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
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
            sqlCm.CommandText = "delete from Nguoi_thue where MaNguoiThue ='" + maNguoiThue + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            sql.Close();
        }
        private void funcDoiTenNguoiThue(string maPhong)
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
            sqlCm.CommandText = "update Nguoi_thue set Ten = N'" + tbTenNguoiThue.Text.Trim() + "' where MaNguoiThue = '" + maNguoiThue + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            sql.Close();
            
        }
        private void funcDeletePhongThue()
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
            sqlCm.CommandText = "delete from Phong_thue_so_huu where MaPhong= '" + tenPhong + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            sql.Close();
        }
        private void FormHuyHopDong_Load(object sender, EventArgs e)
        {
            funcGetTenNguoiThue();
            tbTenNguoiThue.Text = tenNguoiThue;
            tbTenPhong.Text = tenPhong;
            dateTimePicker1.Text = ngayBD;
            dateTimePicker2.Text = ngayKT;
            tbSoNg.Text = soNg;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            tbTenPhong.BackColor = System.Drawing.Color.Transparent;
            
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            lbTenPhong.BackColor = System.Drawing.Color.Transparent;

        }

        
        private void lbNgayKetThuc_Click(object sender, EventArgs e)
        {
            
        }

        private void lbTenNguoiThue_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnTimPhong_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            
        }

        private void tbSoNg_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoNg_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbSoNg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbTenNguoiThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = false;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
