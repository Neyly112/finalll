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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form_tao_MK : Form
    {
        string sdt;
        ClassConnect c = new ClassConnect();

        public Form_tao_MK(string sdt)
        {
            InitializeComponent();
            this.sdt = sdt;
        }

        private void Form_tao_MK_Load(object sender, EventArgs e)
        {

        }

        private Boolean IsPasswordValid(string password, int minLength)
        {
            // Kiểm tra độ dài của mật khẩu
            if (password.Length < minLength)
                return false;

            // Kiểm tra mật khẩu có chứa ít nhất một ký tự chữ thường
            if (!password.Any(char.IsLower))
                return false;

            // Kiểm tra mật khẩu có chứa ít nhất một ký tự chữ hoa
            if (!password.Any(char.IsUpper))
                return false;

            // Kiểm tra mật khẩu có chứa ít nhất một ký tự số
            if (!password.Any(char.IsDigit))
                return false;

            // Kiểm tra mật khẩu có chứa ít nhất một ký tự đặc biệt
            string specialCharsPattern = @"[!@#$%^&*()\-_=+[\]{}|;:',.<>?]";
            if (!Regex.IsMatch(password, specialCharsPattern))
                return false;

            return true;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Nhập mật khẩu mới";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = '\0';
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nhập mật khẩu mới")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Xác nhận mật khẩu")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.PasswordChar = '*';

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Xác nhận mật khẩu";
                textBox3.ForeColor = Color.Silver;
                textBox3.PasswordChar = '\0';
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                pictureBox5.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox6.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                pictureBox7.BringToFront();
                textBox3.PasswordChar = '\0';
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '\0')
            {
                pictureBox9.BringToFront();
                textBox3.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(c.SqlConect());
            con.Open();

            if (textBox2.Text == "Nhập mật khẩu mới" && textBox3.Text == "Xác nhận mật khẩu")
            { 
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox2.Text == "Nhập mật khẩu mới") 
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox3.Text == "Xác nhận mật khẩu")
            {
                MessageBox.Show("Vui lòng lại nhập mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Nhập mật khẩu mới không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!IsPasswordValid(textBox3.Text, 6))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự, có ít nhất một ký tự thường, một ký tự viết hoa, một ký tự số và một ký tự đặt biệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                String soDienThoai = sdt;
                String newPassword = textBox3.Text; // Mật khẩu mới cần cập nhật
                String sql = @"
                IF EXISTS (SELECT 1 FROM Nguoi_thue WHERE SoDienThoai = @SoDienThoai )
                BEGIN
                    UPDATE Nguoi_thue 
                    SET Matkhau = @NewPassword 
                    WHERE SoDienThoai = @SoDienThoai;
                END
                ELSE IF EXISTS (SELECT 1 FROM Quan_li WHERE SoDienThoai = @SoDienThoai )
                BEGIN
                    UPDATE Quan_li 
                    SET Matkhau = @NewPassword  
                    WHERE SoDienThoai = @SoDienThoai ;
                END
                ELSE IF EXISTS (SELECT 1 FROM Chu_ho WHERE SoDienThoai = @SoDienThoai )
                BEGIN
                    UPDATE Chu_ho 
                    SET Matkhau = @NewPassword 
                    WHERE SoDienThoai = @SoDienThoai;
                END";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 f = new Form1();
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin số điện thoại hoặc email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                con.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
