using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class FormChinhThongTinKH : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string ma;
        string ten;
        string diaChi;
        string sDT;
        string email;
        string matKhau;
        public FormChinhThongTinKH(string ma, string ten, string diaChi, string sDT, string email, string matKhau)
        {
            InitializeComponent();
            this.ma = ma;
            this.ten = ten;
            this.matKhau = matKhau;
            this.sDT = sDT;
            this.email = email;
            this.diaChi = diaChi;
            strSql = c.SqlConect();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private bool isEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbMk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormChinhThongTinKH_Load(object sender, EventArgs e)
        {
            tbDiaChi.Text = diaChi;
            tbEmail.Text = email;
            tbTen.Text = ten;
            tbSdt.Text = sDT;
            label1.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDMKNT f = new FormDMKNT(ma);
            f.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tbSdt.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (isEmail(tbEmail.Text.Trim()) == false)
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if ((tbEmail.Text.Trim() == "") || (tbDiaChi.Text.Trim() == "") || (tbSdt.Text.Trim() == "") || (tbTen.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng không để trống thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ten = tbTen.Text.Trim();
            string Sdt = tbSdt.Text.Trim();
            string email = tbEmail.Text.Trim();
            string diaChi = tbDiaChi.Text.Trim();

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
            sqlCm.CommandText = "Update Nguoi_thue set DiaChi=N'" + diaChi + "', SoDienThoai='" + Sdt + "', Email='" + email + "', Ten= N'" + ten + "', MatKhau= N'" + matKhau + "' where MaNguoiThue= '" + ma + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đã sửa thông tin");
            }
            else
            {
                MessageBox.Show("Lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Hide();
            FormThongTinKH f = new FormThongTinKH(ma);
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinKH f = new FormThongTinKH(ma);
            f.ShowDialog();
        }

        private void tbSdt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDMKNT formDMKNT = new FormDMKNT(ma);
            formDMKNT.ShowDialog();
        }
    }
}
