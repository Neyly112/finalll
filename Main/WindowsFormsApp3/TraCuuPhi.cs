using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLiCanHo
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetBangPhi().Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DataSet GetBangPhi()
        {          
            DataSet dataSet = new DataSet();
            string query = "select * from Bang_phi where Ma_bang_phi = ( select Ma_bang_phi from Hoa_don " +
                "where Ngay_lap_hoa_don = @Ngaylaphoadon and Ma_phong = @Maphong )";
            string dateTime = (dateTimePicker2.Value).ToString().Trim();
            string maPhong = textBox2.Text;
            using(SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Ngaylaphoadon", dateTime);
                command.Parameters.AddWithValue("@Maphong", maPhong);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataSet);
                conn.Close();
            }
            return dataSet;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = GetDanhSachHoaDon().Tables[0];
        }

        DataSet GetDanhSachHoaDon()
        {
            DataSet dataSet = new DataSet();
            String query = "select Ngay_lap_hoa_don from Hoa_don where Ma_phong = @Maphong ORDER BY Ngay_lap_hoa_don DESC";
            string maPhong = textBox2.Text;
            using(SqlConnection conn = new SqlConnection(connectionString.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Maphong",maPhong);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                conn.Close() ;
            }
            return dataSet ;
        }
    }
}
