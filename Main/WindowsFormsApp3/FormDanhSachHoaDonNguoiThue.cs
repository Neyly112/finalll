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
    public partial class FormDanhSachHoaDonNguoiThue : Form
    {
        string ma;
        SqlConnection sql = null;
        int xeMay = 0;
        int xeDap = 0;
        int xe_duoi_1_5_tan = 0;

        public FormDanhSachHoaDonNguoiThue(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "SELECT Dien.so_kwh, Dien.Tong_tien_dien FROM Dien INNER JOIN Hoa_don ON Dien.MaHoaDon = Hoa_don.MaHoaDon INNER JOIN Phong_thue_so_huu ON Hoa_don.MaPhong = Phong_thue_so_huu.MaPhong WHERE Phong_thue_so_huu.TaiKhoan = '" + ma + "'";

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

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "SELECT Nuoc.So_m3, Nuoc.Tong_tien_nuoc FROM Nuoc INNER JOIN Hoa_don ON Nuoc.MaHoaDon = Hoa_don.MaHoaDon INNER JOIN Phong_thue_so_huu ON Hoa_don.MaPhong = Phong_thue_so_huu.MaPhong WHERE Phong_thue_so_huu.TaiKhoan = '" + ma + "'";

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

            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "SELECT Tien_xe.soLuongXe, Tien_xe.Tong_tien_xe FROM Tien_xe INNER JOIN Hoa_don ON Tien_xe.MaHoaDon = Hoa_don.MaHoaDon INNER JOIN Phong_thue_so_huu ON Hoa_don.MaPhong = Phong_thue_so_huu.MaPhong WHERE Phong_thue_so_huu.TaiKhoan = '" + ma + "'";

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            getCodeRoom();
        }

        private void getCodeRoom()
        {
            try
            {
                ClassConnect c = new ClassConnect();
                using (SqlConnection con = new SqlConnection(c.SqlConect()))
                {
                    con.Open();
                    string query = "SELECT SUM(TongTien) AS TongTien_Phong FROM Hoa_don WHERE MaPhong = (SELECT MaPhong FROM Phong_thue_so_Huu WHERE TaiKhoan = '" + ma + "' )";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            MessageBox.Show("Tổng tiền của quý khách là: " + Convert.ToDecimal(result),"Tiền",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClassConnect c = new ClassConnect();
                SqlConnection con = new SqlConnection(c.SqlConect());
                using (SqlConnection connection = con)
                {
                    connection.Open();
                    string query = "select Phong_cho_thue.GiaPhong, Phong_cho_thue.MaPhong, MoTaPhong from Phong_cho_thue where MaPhong = (select MaPhong from Phong_thue_so_Huu where TaiKhoan = '" + ma +"' )";

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            trangchu2 t = new trangchu2(ma);
            t.ShowDialog();
        }

        private void FormDanhSachHoaDonNguoiThue_Load(object sender, EventArgs e)
        {

        }
    }

    
}