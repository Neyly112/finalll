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
    public partial class FormYeuCauHoTro : Form
    {
        ClassConnect c = new ClassConnect();
        string ma;
        string strSql;
        string sender;
        public FormYeuCauHoTro(string ma)
        {
            InitializeComponent();
            this.strSql = c.SqlConect();
            this.ma = ma;
        }

        private void FormYeuCauHoTro_Load(object sender, EventArgs e)
        {

        }
        DataSet getLichSuTinNhan()
        {
            DataSet lichSuTinNhan = new DataSet();
            string query = "SELECT Sender, Receiver, Content, SentDateTime FROM Tin_nhan" +
                " WHERE Sender = @taiKhoan or Receiver = @taiKhoan";
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@taiKhoan", ma);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(lichSuTinNhan);
                conn.Close();
            }
            return lichSuTinNhan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo kết nối SQL
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                sender = ma;
                string receiver = getMaQuanLi();
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getTinNhan().Tables[0];
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();

                string query = "UPDATE Tin_nhan SET ReadStatus = 1 WHERE ReadStatus = 0 and Sender = @maQL";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maQL", getMaQuanLi());
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        DataSet getTinNhan()
        {
            DataSet tinNhan = new DataSet();
            string query = "SELECT Sender, Receiver, Content, SentDateTime FROM Tin_nhan" +
                " WHERE ReadStatus = 0 and Sender = @maQL";
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@maQL", getMaQuanLi());
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(tinNhan);
                conn.Close();
            }
            return tinNhan;
        }

        public string getMaQuanLi()
        {
            string latestMaQuanLi = "";

            // Tạo kết nối SQL
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                // Mở kết nối
                connection.Open();

                // Tạo truy vấn SQL
                string query = "SELECT MAX(MaQuanLi) FROM Quan_li";

                // Tạo SqlCommand và thực thi truy vấn
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thực hiện truy vấn và lấy kết quả
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem kết quả có null không
                    if (result != null && result != DBNull.Value)
                    {
                        latestMaQuanLi = result.ToString();
                    }
                }
                connection.Close();
            }
            return latestMaQuanLi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getLichSuTinNhan().Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu2 t = new trangchu2(ma);
            t.ShowDialog();
        }
    }
}
