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
    public partial class FormThemPhong : Form
    {
        string ma;
        ClassConnect c = new ClassConnect();
        SqlConnection sql = null;
        public FormThemPhong(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maPhong = textBox1.Text.Trim();
            if (checkPhong(maPhong) == true)
            {
                MessageBox.Show("Mã phòng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToDouble(textBox3.Text.Trim()) <= 0)
            {
                MessageBox.Show("Giá phòng không phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 

            if (sql == null)
            {
                sql = new SqlConnection(c.SqlConect());
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "insert into Phong_cho_thue values('" + textBox1.Text.Trim() + "', '" + textBox2.Text.Trim() + "', '" + textBox3.Text.Trim() + "', N'Chưa được thuê')";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Đã thêm");
            } else
            {
                MessageBox.Show("Lỗi");
            }
            sql.Close();
            this.Hide();
            FormDSPhongThue f = new FormDSPhongThue(ma);
            f.ShowDialog();
        }
        private bool checkPhong(string maPhong)
        {
            if (sql == null)
            {
                sql = new SqlConnection(c.SqlConect());
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "select * from Phong_cho_thue where MaPhong= '" + maPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            int kq = 0;
            while (reader.Read())
            {
                kq = 1;
            }
            reader.Close();
            sql.Close();
            if (kq == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        private void FormThemPhong_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSPhongThue f = new FormDSPhongThue(ma);
            f.ShowDialog();
        }
    }
}
