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
    public partial class FormHoTroKhachHang : Form
    {
        string ma;
        string strSql;
        string sender;
        ClassConnect c = new ClassConnect();
        public FormHoTroKhachHang(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            this.strSql = c.SqlConect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo kết nối SQL
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                sender = ma;
                string receiver = textBox2.Text;
                string content = textBox1.Text;
                string sentDateTime = DateTime.Now.ToString();

                // Mở kết nối
                connection.Open();

                //Truy vấn SQL
                string query = "INSERT INTO Tin_nhan(Sender, Receiver, Content," +
                    " SentDateTime, ReadStatus) VALUES (@sender, @receiver, @content, @sentDateTime, @ReadStatus)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Sender", sender);
                    command.Parameters.AddWithValue("@Receiver", receiver);
                    command.Parameters.AddWithValue("@Content", content);
                    command.Parameters.AddWithValue("@sentDateTime", sentDateTime);
                    command.Parameters.AddWithValue("@ReadStatus", 0);

                    //Thực hiện INSERT
                    command.ExecuteNonQuery();

                    MessageBox.Show("Gửi tin nhắn thành công !");
                }
                connection.Close();
            }
        }

        DataSet getLichSuTinNhan()
        {
            DataSet lichSuTinNhan = new DataSet();
            string query = "SELECT Sender, Receiver, Content, SentDateTime FROM Tin_nhan" +
                " WHERE Sender = @maNT or Receiver = @maNT";
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@maNT", textBox3.Text);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(lichSuTinNhan);
                conn.Close();
            }
            return lichSuTinNhan;
        }

        DataSet getTinNhan()
        {
            DataSet tinNhan = new DataSet();
            string query = "SELECT Sender, Receiver, Content, SentDateTime FROM Tin_nhan" +
                " WHERE ReadStatus = 0 and Receiver = @maQL";
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@maQL", ma);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(tinNhan);
                conn.Close();
            }
            return tinNhan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getTinNhan().Tables[0];
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();

                string query = "UPDATE Tin_nhan SET ReadStatus = 1 WHERE ReadStatus = 0 and Receiver = @maQL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maQL", ma);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã người thuê !");
                return;
            }
            dataGridView1.DataSource = getLichSuTinNhan().Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu t = new trangchu(ma);
            t.ShowDialog();
        }

        private void FormHoTroKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
