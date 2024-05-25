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

namespace WindowsFormsApp3
{
    public partial class FormChinhSuaThongTinCH : Form
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
        public FormChinhSuaThongTinCH(string ma, string ten, string matKhau, string diaChi, string email, string sDT)
        {
            InitializeComponent();
            this.ma = ma;
            this.matKhau = matKhau;
            this.diaChi = diaChi;
            this.sDT = sDT;
            this.email = email;
            this.ten = ten;
            strSql = c.SqlConect();
        }
     
        private bool IsValidEmailRegex(string email)
        {
            // Regular expression pattern for a simple email format
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbSdt.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsValidEmail(tbEmail.Text) == false)
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if ((tbEmail.Text == "") || (tbDiaChi.Text == "") || (tbSdt.Text == "") || (tbTen.Text == ""))
            {
                MessageBox.Show("Vui lòng không để trống thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ten = tbTen.Text;
            string Sdt = tbSdt.Text;
            string email = tbEmail.Text;
            string diaChi = tbDiaChi.Text;

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
            sqlCm.CommandText = "Update Chu_ho set DiaChi=N'" + diaChi + "', SoDienThoai='" + Sdt + "', Email='" + email + "', Ten= N'" + ten + "', MatKhau= N'" + matKhau + "' where MaChuHo= '" + ma + "'";
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
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }

        private void FormChinhSuaThongTinCH_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDMKCH f = new FormDMKCH(ma);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }

        private void tbEmail_Load(object sender, EventArgs e)
        {

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

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDMKCH f = new FormDMKCH(ma);
            f.ShowDialog();
        }
    }
}
