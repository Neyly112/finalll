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
    public partial class FormThongKeDoanhThu : Form
    {
        ClassConnect c = new ClassConnect();
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCH1DataSet.Thong_ke' table. You can move, or remove it, as needed.
            this.thong_keTableAdapter.Fill(this.qLCH1DataSet.Thong_ke);
            string thang = getThang();
            string soNguoiThue = getSoNguoiThue();
            string soPhongChuaThue = getSoPhongChuaThue();
            string soNguoiChuaThanhToan = getSoNguoiChuaThanhToan();
            string tongThanhToan = getTongThanhToan();

            if (IsThangExisted(thang))
            {
                MessageBox.Show("Hóa đơn tháng mới chưa được cập nhật !");
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(c.SqlConect()))
                {
                    conn.Open();

                    string query = "INSERT INTO Thong_ke(thang, so_nguoi_thue, so_phong_con_trong, so_nguoi_chua_thanh_toan, tong_thanh_toan)" +
                        "VALUES (@thang, @soNguoiThue, @soPhongChuaThue, @soNguoiChuaThanhToan, @tongThanhToan)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@thang", thang);
                        cmd.Parameters.AddWithValue("@soNguoiThue", soNguoiThue);
                        cmd.Parameters.AddWithValue("@soPhongChuaThue", soPhongChuaThue);
                        cmd.Parameters.AddWithValue("@soNguoiChuaThanhToan", soNguoiChuaThanhToan);
                        cmd.Parameters.AddWithValue("@tongThanhToan", tongThanhToan);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            dataGridView1.DataSource = getThongKe().Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        string getThang()
        {
            string thang = "";
            string query = "SELECT TOP 1 Month(TuNgay) as thang FROM Hoa_don ORDER BY TuNgay DESC";
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Chuyển đổi giá trị từ object sang int
                        thang = Convert.ToString(reader["thang"]);
                    }
                }
            }
            return thang;
        }

        string getSoNguoiThue()
        {
            string soNguoiThue = ""; // Khởi tạo giá trị mặc định

            string query = "SELECT COUNT(*) AS so_nguoi_thue FROM Nguoi_thue";
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Chuyển đổi giá trị từ object sang int
                        soNguoiThue = Convert.ToString(reader["so_nguoi_thue"]);
                    }
                }
            }
            return soNguoiThue;
        }


        string getSoPhongChuaThue()
        {
            string soPhongChuaThue = "";
            string query = "SELECT COUNT(*) AS so_phong_chua_thue FROM Phong_cho_thue WHERE TrangThaiPhong = N'Chưa được thuê'";
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Chuyển đổi giá trị từ object sang int
                        soPhongChuaThue = Convert.ToString(reader["so_phong_chua_thue"]);
                    }
                }
            }
            return soPhongChuaThue;
        }

        string getSoNguoiChuaThanhToan()
        {
            string soNguoiChuaThanhToan = "";
            string query = "SELECT COUNT(*) as so_nguoi_chua_thanh_toan FROM Hoa_don WHERE TrangThai = N'Chưa thanh toán';";
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Chuyển đổi giá trị từ object sang int
                        soNguoiChuaThanhToan = Convert.ToString(reader["so_nguoi_chua_thanh_toan"]);
                    }
                }
                conn.Close();
            }
            return soNguoiChuaThanhToan;
        }

        string getTongThanhToan()
        {
            string tongThanhToan = "";
            string query = "SELECT SUM(TongTien) AS tong_tien FROM Hoa_don";
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Chuyển đổi giá trị từ object sang int
                        tongThanhToan = Convert.ToString(reader["tong_tien"]);
                    }
                }
                conn.Close();
            }
            return tongThanhToan;
        }

        DataSet getThongKe()
        {
            DataSet thongKe = new DataSet();
            string query = "SELECT * FROM Thong_ke";
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(thongKe);
                conn.Close();
            }
            return thongKe;
        }
        private bool IsThangExisted(string thang)
        {
            bool isExisted = false;
            string query = "SELECT COUNT(*) FROM Thong_ke WHERE thang = @thang";
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@thang", thang);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    isExisted = (count > 0);
                }
            }
            return isExisted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BieuDoSoLuongNguoiThue bieuDoSoLuongNguoiThue = new BieuDoSoLuongNguoiThue();
            bieuDoSoLuongNguoiThue.ShowDialog();
            BieuDoSoPhongChuaDat bieuDoSoPhongChuaDat = new BieuDoSoPhongChuaDat();
            bieuDoSoPhongChuaDat.ShowDialog();
            BieuDoSoNguoiChuaThanhToan bieuDoSoNguoiChuaThanhToan = new BieuDoSoNguoiChuaThanhToan();
            bieuDoSoNguoiChuaThanhToan.ShowDialog();
            BieuDoTongThanhToan bieuDoTongThanhToan = new BieuDoTongThanhToan();
            bieuDoTongThanhToan.ShowDialog();
        }

        private void thongkeBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
