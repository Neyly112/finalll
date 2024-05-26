using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class checkCode : System.Windows.Forms.Form
    {
        private int soLanThu = 0;
        private const int soLanThuToiDa = 5;
        private DateTime? thoiGianKhoa = null;
        private const int thoiGianChoPhut = 10;

        int code;
        String sdt;
        String mail;
        ClassConnect c = new ClassConnect();
        public checkCode(int code, String sdt, String mail)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.code = code;
            this.sdt = sdt;
            this.mail = mail;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox4.TextChanged += textBox4_TextChanged;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void checkCode_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.TextAlign = HorizontalAlignment.Center;
                // Cắt bớt chuỗi nhập vào để chỉ giữ lại ký tự đầu tiên
                textBox1.Text = textBox1.Text.Substring(0, 1);
                // Di chuyển con trỏ đến cuối chuỗi để người dùng không thể nhập tiếp
                textBox1.SelectionStart = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* SqlConnection con = new SqlConnection(c.SqlConect());
            String cd = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text;
            int cd1 = Convert.ToInt32(cd);
            if(cd1 == code)
            {
                con.Open();
                String sdtN = sdt;
                String mailN = mail;
                String sql = "UPDATE Nguoi_thue set MatKhau = N'" + mkN + "' WHERE SoDienThoai = '" + sdtN +"' and Email = '"+ mailN +"'"; 
                SqlCommand cmd = new SqlCommand(sql, con);
                int rdr = cmd.ExecuteNonQuery();
                if (rdr > 0)
                {
                    MessageBox.Show(this, "Đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
                else
                    MessageBox.Show(this, "Lỗi, đổi mật khẩu thất bại, kiểm tra lại số điện thoại hoặc email của bạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check3();
        }

        private void check3() 
        {
            if (thoiGianKhoa.HasValue)
            {
                TimeSpan thoiGianDaQua = DateTime.Now - thoiGianKhoa.Value;
                if (thoiGianDaQua.TotalMinutes < thoiGianChoPhut)
                {
                    MessageBox.Show(this, $"Bạn đã nhập sai mã quá {soLanThuToiDa} lần. Vui lòng thử lại sau {thoiGianChoPhut - thoiGianDaQua.TotalMinutes:F0} phút.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VoHieuHoaNhap();
                    return;
                }
                else
                {
                    soLanThu = 0;
                    thoiGianKhoa = null;
                }
            }

            if (textBox1.Text.Length != 1 || textBox2.Text.Length != 1 || textBox3.Text.Length != 1 || textBox4.Text.Length != 1)
            {
                MessageBox.Show(this, "Mã xác nhận không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(c.SqlConect());
                String cd = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text;
                int cd1;
                if (!int.TryParse(cd, out cd1))
                {
                    MessageBox.Show(this, "Mã xác nhận không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cd1 == code)
                {
                    MessageBox.Show(this, "Mã xác nhận chính xác", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form_tao_MK NMK = new Form_tao_MK(sdt);
                    this.Hide();
                    timer1.Stop();
                    NMK.ShowDialog();
                }
                else
                {
                    soLanThu++;
                    if (soLanThu >= soLanThuToiDa)
                    {
                        thoiGianKhoa = DateTime.Now;
                        MessageBox.Show(this, "Bạn đã nhập sai mã quá 5 lần. Vui lòng thử lại sau 10 phút.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, $"Mã xác nhận hết hạn hoặc mã không đúng. Bạn còn {soLanThuToiDa - soLanThu} lần thử.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void VoHieuHoaNhap()
        {
            textBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox3.Enabled = false;
            textBox2.Enabled = false;

        }

        static void CloseAllForms()
        {
            FormTongTien[] openForms = Application.OpenForms.Cast<FormTongTien>().ToArray();

            foreach (System.Windows.Forms.Form form in openForms)
            {
                form.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Hide();
            timer1.Stop();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 1)
            {
                textBox2.TextAlign = HorizontalAlignment.Center;
                // Cắt bớt chuỗi nhập vào để chỉ giữ lại ký tự đầu tiên
                textBox2.Text = textBox2.Text.Substring(0, 1);
                // Di chuyển con trỏ đến cuối chuỗi để người dùng không thể nhập tiếp
                textBox2.SelectionStart = 1;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 1)
            {
                textBox3.TextAlign = HorizontalAlignment.Center;
                // Cắt bớt chuỗi nhập vào để chỉ giữ lại ký tự đầu tiên
                textBox3.Text = textBox3.Text.Substring(0, 1);
                // Di chuyển con trỏ đến cuối chuỗi để người dùng không thể nhập tiếp
                textBox3.SelectionStart = 1;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 1)
            {
                textBox4.TextAlign = HorizontalAlignment.Center;
                // Cắt bớt chuỗi nhập vào để chỉ giữ lại ký tự đầu tiên
                textBox4.Text = textBox4.Text.Substring(0, 1);
                // Di chuyển con trỏ đến cuối chuỗi để người dùng không thể nhập tiếp
                textBox4.SelectionStart = 1;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hủy sự kiện nhập liệu
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check3();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hủy sự kiện nhập liệu
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check3();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hủy sự kiện nhập liệu
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check3();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, hủy sự kiện nhập liệu
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check3();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            code = 0;  // Đặt code thành null sau 1 phút
            timer1.Stop();
        }
    }
}
