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
    public partial class BieuDoTongThanhToan : Form
    {
        ClassConnect c = new ClassConnect();
        public BieuDoTongThanhToan()
        {
            InitializeComponent();
        }

        void FillChartTongThanhToan()
        {
            SqlConnection conn = new SqlConnection(c.SqlConect());
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT thang, tong_thanh_toan FROM Thong_ke", conn);
            adapter.Fill(dt);
            chart1.DataSource = dt;
            conn.Close();

            chart1.Series["Tổng thanh toán"].XValueMember = "thang";
            chart1.Series["Tổng thanh toán"].YValueMembers = "tong_thanh_toan";
            chart1.Titles.Add("Thống kê tổng thanh toán");
        }

        private void BieuDoTongThanhToan_Load(object sender, EventArgs e)
        {
            FillChartTongThanhToan();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
