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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class FormDMKCH : Form
    {
        string ma;
        string strSql;
        ClassConnect c = new ClassConnect();
        SqlConnection sql = null;
        string mk;
        private int soLanThu = 0;
        private const int soLanThuToiDa = 5;
        private DateTime? thoiGianKhoa = null;
        private const int thoiGianChoPhut = 10;
        public FormDMKCH(string ma)
        {
            InitializeComponent();
            strSql = c.SqlConect();
            this.ma = ma;
        }

        private void FormDMKCH_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
        }
        private void upDateMK(string mkMoi)
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
            sqlCm.CommandText = "Update Chu_ho set MatKhau = '" + mkMoi + "' where MaChuHo = '" + ma + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();

            if (kq > 0)
            {
                MessageBox.Show("Đã đổi mật khẩu");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (thoiGianKhoa.HasValue)
            {
                TimeSpan thoiGianDaQua = DateTime.Now - thoiGianKhoa.Value;
                if (thoiGianDaQua.TotalMinutes < thoiGianChoPhut)
                {
                    MessageBox.Show($"Bạn đã nhập sai mật khẩu quá 5 lần. Vui lòng thử lại sau {thoiGianChoPhut - thoiGianDaQua.TotalMinutes:F0} phút.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Đặt lại số lần thử và thời gian khóa sau khi hết thời gian chờ
                    soLanThu = 0;
                    thoiGianKhoa = null;
                }
            }

            // Kiểm tra nếu bất kỳ ô văn bản nào trống
            if (string.IsNullOrEmpty(tbMkCu.Texts) || string.IsNullOrEmpty(tbMkMoi.Texts) || string.IsNullOrEmpty(tbXacNhan.Texts))
            {
                MessageBox.Show("Vui lòng nhập thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu mật khẩu mới trùng với mật khẩu cũ
            if (tbMkCu.Texts == tbMkMoi.Texts)
            {
                MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu mật khẩu xác nhận không khớp với mật khẩu mới
            if (tbXacNhan.Texts != tbMkMoi.Texts)
            {
                MessageBox.Show("Sai mật khẩu xác nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string matKhauCu = tbMkCu.Texts;
            string mkMoi = tbMkMoi.Texts;

            // Định nghĩa chuỗi kết nối và truy vấn SQL sử dụng câu lệnh có tham số để ngăn ngừa SQL Injection
            string connectionString = strSql;
            string query = "SELECT MatKhau FROM Chu_ho WHERE MaChuHo = @ma";

            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    sql.Open();

                    using (SqlCommand sqlCm = new SqlCommand(query, sql))
                    {
                        sqlCm.Parameters.AddWithValue("@ma", ma);

                        using (SqlDataReader reader = sqlCm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string matKhauHienTaiTuDb = reader.GetString(0);

                                if (matKhauHienTaiTuDb != matKhauCu)
                                {
                                    soLanThu++;
                                    if (soLanThu >= soLanThuToiDa)
                                    {
                                        thoiGianKhoa = DateTime.Now;
                                        MessageBox.Show("Bạn đã nhập sai mật khẩu quá 5 lần. Vui lòng thử lại sau 10 phút.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        VoHieuHoaNhap();
                                        return;
                                    }

                                    MessageBox.Show($"Sai mật khẩu cũ. Bạn còn {soLanThuToiDa - soLanThu} lần thử.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    // Cập nhật mật khẩu nếu mật khẩu cũ khớp
                    query = "UPDATE Chu_ho SET MatKhau = @newPassword WHERE MaChuHo = @ma";
                    using (SqlCommand updateCm = new SqlCommand(query, sql))
                    {
                        updateCm.Parameters.AddWithValue("@newPassword", mkMoi);
                        updateCm.Parameters.AddWithValue("@ma", ma);
                        updateCm.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Mật khẩu đã được thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FormThongTinChuHo f = new FormThongTinChuHo(ma);
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VoHieuHoaNhap()
        {
            tbMkCu.Enabled = false;
            tbMkMoi.Enabled = false;
            tbXacNhan.Enabled = false;
            btnThoat.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (tbMkMoi.PasswordChar)
            {
                pictureBox5.BringToFront();
                tbMkMoi.PasswordChar = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!tbMkMoi.PasswordChar)
            {
                pictureBox6.BringToFront();
                tbMkMoi.PasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tbXacNhan.PasswordChar)
            {
                pictureBox3.BringToFront();
                tbXacNhan.PasswordChar = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!tbXacNhan.PasswordChar)
            {
                pictureBox1.BringToFront();
                tbXacNhan.PasswordChar = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (tbMkCu.PasswordChar)
            {
                pictureBox7.BringToFront();
                tbMkCu.PasswordChar = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!tbMkCu.PasswordChar)
            {
                pictureBox4.BringToFront();
                tbMkCu.PasswordChar = true;
            }
        }
    }
}
