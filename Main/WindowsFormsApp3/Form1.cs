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
#pragma warning disable CS0105 
using System.Data.SqlClient;
#pragma warning restore CS0105 
namespace WindowsFormsApp3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
            string ma = textBox1.Text.Trim();
            trangchu t = new trangchu(ma);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nhập tài khoản";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CloseAllForms();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            quenMK fg = new quenMK();
            this.Hide();
            fg.ShowDialog();
            fg.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox6.BringToFront();
                textBox2.PasswordChar = '*';
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập tài khoản")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Nhập mật khẩu";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = '\0';
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nhập mật khẩu")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        static void CloseAllForms()
        {
          
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (System.Windows.Forms.Form form in openForms)
            {
                form.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        public void check() 
        {   
            if(textBox1.Text == "Nhập tài khoản" && textBox2.Text == "Nhập mật khẩu") 
            {
                MessageBox.Show(this, "Vui lòng nhập tài khoản và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(textBox1.Text == "Nhập tài khoản")
            {
                MessageBox.Show(this, "Vui lòng nhập tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "Nhập mật khẩu")
            {
                MessageBox.Show(this, "Vui lòng nhập mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox1.Text.Length != 5)
            {
                MessageBox.Show(this, "Tài khoảng không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                try
                {
                    con.Open();
                    String tk = textBox1.Text;
                    String mk = textBox2.Text;
                    string twoChars = tk.Substring(0, 2);
                    if (twoChars == "NT")
                    {
                        String sql = "select * from Nguoi_thue where MaNguoiThue  = '" + tk + " ' and MatKhau = '" + mk + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            string ma = textBox1.Text.Trim();
                            MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            trangchu2 trangchu = new trangchu2(ma);
                            this.Hide();
                            trangchu.ShowDialog();
                            rdr.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (twoChars == "QL")
                    {
                        
                        String sql = "select * from Quan_li where MaQuanLi  = '" + tk + " ' and MatKhau = '" + mk + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            string ma = textBox1.Text.Trim();
                            MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            trangchu trangchu = new trangchu(ma);
                            this.Hide();
                            trangchu.ShowDialog();
                            rdr.Close();

                        }
                        else 
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else if (twoChars == "CH")
                    {

                        String sql = "select * from Chu_ho where MaChuHo  = '" + tk + " ' and MatKhau = '" + mk + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.Read())
                        {
                            string ma = textBox1.Text.Trim();
                            MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            trangchu3 trangchu = new trangchu3(ma);
                            this.Hide();
                            trangchu.ShowDialog();
                            rdr.Close();
                        }
                        else
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();

                }
                catch (Exception a)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không Đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                check();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
