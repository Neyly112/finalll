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
    public partial class FormHDCHUHO : Form
    {
        string ma;
        string maHD;
        string maPhong;
        string strSql;
        ClassConnect c = new ClassConnect();
        SqlConnection sql = null;
        public FormHDCHUHO(string ma, string maHD, string maPhong)
        {
            InitializeComponent();
            this.ma = ma;
            this.maHD = maHD;
            this.maPhong = maPhong;
            strSql = c.SqlConect();

        }

        private void Hoa_Don_Tien_Dien_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "SELECT Dien.so_kwh, Dien.Tong_tien_dien FROM Dien where MaHoaDon = '" + maHD + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Hoa_Don_Tien_Nuoc_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "SELECT Nuoc.So_m3, Nuoc.Tong_tien_nuoc FROM Nuoc where MaHoaDon = '" + maHD + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void Hoa_Don_Tien__Gui_Xe_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "SELECT Tien_xe.soLuongXe, Tien_xe.Tong_tien_xe FROM Tien_xe where MaHoaDon = '" + maHD + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "select Phong_cho_thue.GiaPhong, Phong_cho_thue.MaPhong, MoTaPhong from Phong_cho_thue where MaPhong = '" + maPhong + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "select PhiSinhHoat from Bang_phi where MaBangPhi = dbo.getTopMaBP()";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachHoaChuHo f = new FormDanhSachHoaChuHo(ma);
            f.ShowDialog();
        }

        private void FormHDCHUHO_Load(object sender, EventArgs e)
        {

        }
    }
}
