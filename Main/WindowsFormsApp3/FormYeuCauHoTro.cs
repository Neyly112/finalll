using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;

            // Load MaQuanLi data into the combobox directly in FormYeuCauHoTro_Load
            LoadMaQuanLiData();
        }

        private void FormYeuCauHoTro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCH2DataSet1.Tin_nhan' table. You can move, or remove it, as needed.
            //this.tin_nhanTableAdapter1.Fill(this.qLCH2DataSet1.Tin_nhan);
            // No need to call tin_nhanTableAdapter.Fill() here
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo kết nối SQL
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tin nhắn !");
                return;
            }
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                sender = ma;
                string receiver = comboBox1.SelectedItem.ToString();
                string content = textBox1.Text;
                string sentDateTime = DateTime.Now.ToString();

                // Mở kết nối
                connection.Open();

                //Truy vấn SQL
                string query = "INSERT INTO Tin_Nhan(Sender, Receiver, Content," +
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
            string query1 = "UPDATE Tin_nhan SET ReadStatus = 1 WHERE Sender = @Sender " +
                "and Receiver = @Receiver";
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query1, conn);
                cmd.Parameters.AddWithValue("@Sender", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Receiver", ma);
                cmd.ExecuteNonQuery();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu2 t = new trangchu2(ma);
            t.ShowDialog();
        }

        private void LoadMaQuanLiData()
        {
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                connection.Open();

                string query = "SELECT MaQuanli FROM Quan_li";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    List<string> listMaQL = new List<string>(); // Create a list to store MaQuanLi values

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listMaQL.Add(reader.GetString(0)); // Get the value at index 0 (MaQuanLi)
                        }
                    }

                    comboBox1.DataSource = listMaQL; // Set the combobox data source to the list
                }

                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lsTinNhan().Tables[0];
        }

        DataSet lsTinNhan()
        {
            DataSet lsTinNhan = new DataSet();
            string query = "SELECT Sender, Content, SentDateTime FROM Tin_nhan" +
                " WHERE (Sender = @maNT and Receiver = @maQL) or (Sender = @maQL and Receiver = @maNT) ORDER BY SentDateTime DESC";
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@maNT", ma);
                command.Parameters.AddWithValue("@maQL", comboBox1.SelectedItem);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(lsTinNhan);
                conn.Close();
            }
            return lsTinNhan;
        }

        DataSet tinNhanMoi()
        {
            DataSet tinNhanMoi = new DataSet();
            string query = "SELECT Sender, Content, SentDateTime FROM Tin_nhan" +
                " WHERE Sender = @Sender and Receiver = @Receiver and ReadStatus = 0 ORDER BY SentDateTime DESC";
            using (SqlConnection conn = new SqlConnection(strSql))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Sender", comboBox1.SelectedItem);
                command.Parameters.AddWithValue("@Receiver", ma);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(tinNhanMoi);
                conn.Close();
            }
            return tinNhanMoi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tinNhanMoi().Tables[0];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
