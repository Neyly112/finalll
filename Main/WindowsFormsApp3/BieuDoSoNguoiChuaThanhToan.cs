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
    public partial class BieuDoSoNguoiChuaThanhToan : Form
    {
        ClassConnect c = new ClassConnect();
        public BieuDoSoNguoiChuaThanhToan()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        void FillChartNumberOfSoNguoiChuaThanhToan()
        {
            SqlConnection conn = new SqlConnection(c.SqlConect());
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT thang, so_nguoi_chua_thanh_toan FROM Thong_ke", conn);
            adapter.Fill(dt);
            chart1.DataSource = dt;
            conn.Close();

            chart1.Series["Số cư dân chưa thanh toán"].XValueMember = "thang";
            chart1.Series["Số cư dân chưa thanh toán"].YValueMembers = "so_nguoi_chua_thanh_toan";
            chart1.Titles.Add("Thống kê số người chưa thanh toán");
        }

        private void BieuDoSoNguoiChuaThanhToan_Load(object sender, EventArgs e)
        {
            FillChartNumberOfSoNguoiChuaThanhToan();
        }
    }
}
