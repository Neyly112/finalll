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
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            LoadDanhSachNguoiThue();
            LoadMaNguoiThueData();
        }

        private void LoadMaNguoiThueData()
        {
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                connection.Open();

                string query = "SELECT DISTINCT Sender FROM Tin_nhan WHERE ReadStatus = 0 and Receiver = @Receiver";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Receiver", ma);
                    List<string> listMaNT = new List<string>(); // Create a list to store MaQuanLi values

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listMaNT.Add(reader.GetString(0)); // Get the value at index 0 (MaQuanLi)
                        }
                    }

                    comboBox1.DataSource = listMaNT; // Set the combobox data source to the list
                }

                connection.Close();
            }
        }

        private void LoadMessageDetails(string sender)
        {
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                connection.Open();

                string query = @"
                    SELECT Sender, Content, SentDateTime
                    FROM Tin_nhan
                    WHERE Sender = @Sender AND Receiver = @Receiver AND ReadStatus = 0 ORDER BY SentDateTime DESC;
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Sender", sender);
                    command.Parameters.AddWithValue("@Receiver", ma);

                    DataTable messageDetails = new DataTable();
                    messageDetails.Load(command.ExecuteReader());

                    dataGridView1.DataSource = messageDetails; // Bind data to datagridview
                }

                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu t = new trangchu(ma);
            t.ShowDialog();
        }

        

        private void LoadDanhSachNguoiThue()
        {
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                connection.Open();

                string query = "SELECT DISTINCT MaNguoiThue FROM Nguoi_thue";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    List<string> listMaNT = new List<string>(); // Create a list to store MaQuanLi values

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listMaNT.Add(reader.GetString(0)); // Get the value at index 0 (MaQuanLi)
                        }
                    }

                    comboBox2.DataSource = listMaNT; // Set the combobox data source to the list
                }

                connection.Close();
            }
        }

        private void FormHoTroKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung tin nhắn !");
                return;
            }
            string query = "INSERT INTO Tin_nhan(Sender, Receiver, Content, SentDateTime, ReadStatus) VALUES (@Sender, @Receiver, @Content, @SentDateTime, @ReadStatus)";
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Sender", ma);
                command.Parameters.AddWithValue("@Receiver", comboBox2.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Content", textBox1.Text);
                command.Parameters.AddWithValue("@SentDateTime", DateTime.Now.ToString());
                command.Parameters.AddWithValue("@ReadStatus", 0);
                command.ExecuteNonQuery();

                MessageBox.Show("Gửi tin nhắn thành công !");
                connection.Close();
            }
            if(dataGridView1.Rows.Count != 0)
            {
                string query1 = "UPDATE Tin_nhan SET ReadStatus = 1 WHERE Sender = @Sender " +
                "and Receiver = @Receiver";
                using (SqlConnection conn = new SqlConnection(strSql))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query1, conn);
                    cmd.Parameters.AddWithValue("@Sender", comboBox2.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Receiver", ma);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT Sender, Content, SentDateTime FROM Tin_nhan WHERE " +
                "(Sender = @maNT and Receiver = @maQL) OR " +
                "(Sender = @maQL and Receiver = @maNT) ORDER BY SentDateTime DESC";
            using (SqlConnection connection = new SqlConnection(strSql))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maNT", comboBox2.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@maQL", ma);
                DataTable lsTinNhan = new DataTable();
                lsTinNhan.Load(cmd.ExecuteReader());
                connection.Close();
                dataGridView1.DataSource = lsTinNhan;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1) // Check if an item is selected
            {
                string selectedSender = (string)comboBox1.SelectedItem;
                LoadMessageDetails(selectedSender); // Call the new method to load details
            }
        }
    }
}
