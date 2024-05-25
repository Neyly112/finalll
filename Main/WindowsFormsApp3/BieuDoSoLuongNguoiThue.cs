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
    public partial class BieuDoSoLuongNguoiThue : Form
    {
        
        ClassConnect c = new ClassConnect();
        public BieuDoSoLuongNguoiThue()
        {
            InitializeComponent();
          
        }

        void FillChartNumberOfNguoiThue()
        {
            SqlConnection conn = new SqlConnection(c.SqlConect());
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT thang, so_nguoi_thue FROM Thong_ke", conn);
            adapter.Fill(dt);
            chart1.DataSource = dt;
            conn.Close();

            chart1.Series["Số người thuê"].XValueMember = "thang";
            chart1.Series["Số người thuê"].YValueMembers = "so_nguoi_thue";
            chart1.Titles.Add("Thống kê số người thuê");
        }

        private void BieuDoSoLuongNguoiThue_Load(object sender, EventArgs e)
        {
            FillChartNumberOfNguoiThue();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
