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
    public partial class BieuDoSoPhongChuaDat : Form
    {
        ClassConnect c = new ClassConnect();
        public BieuDoSoPhongChuaDat()
        {
            InitializeComponent();
        }
        void FillChartNumberOfPhongChuaDat()
        {
            SqlConnection conn = new SqlConnection(c.SqlConect());
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT thang, so_phong_con_trong FROM Thong_ke", conn);
            adapter.Fill(dt);
            chart1.DataSource = dt;
            conn.Close();

            chart1.Series["Số phòng chưa đặt"].XValueMember = "thang";
            chart1.Series["Số phòng chưa đặt"].YValueMembers = "so_phong_con_trong";
            chart1.Titles.Add("Thống kê số phòng chưa được thuê");
        }
        private void BieuDoSoPhongChuaDat_Load(object sender, EventArgs e)
        {
            FillChartNumberOfPhongChuaDat();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
