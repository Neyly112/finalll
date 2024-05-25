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
    public partial class FormCTHDNT : Form
    {
        SqlConnection sql = null;
        string tenNguoiThue;
        string ma;
        string tenPhong;
        string soNg;
        string ngayBD;
        string ngayKT;
        string maNguoiThue;
        string strSql;
        string maHD;
        ClassConnect c = new ClassConnect();
        public FormCTHDNT(string ma, string tenPhong, string soNg, string ngayBD, string ngayKT, string maNguoiThue, string maHD)
        {
            InitializeComponent();
            this.ma = ma;
            this.tenPhong = tenPhong;
            this.soNg = soNg;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.maNguoiThue = maNguoiThue;
            this.maHD = maHD;
            strSql = c.SqlConect();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDNT f = new FormDSHDNT(ma);
            f.ShowDialog();
        }

        private void FormCTHDNT_Load(object sender, EventArgs e)
        {
            funcGetTenNguoiThue();
            tbTenNguoiThue.Text = tenNguoiThue;
            tbTenPhong.Text = tenPhong;
            dateTimePicker1.Text = ngayBD;
            dateTimePicker2.Text = ngayKT;
            tbSoNg.Text = soNg;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            tbSoNg.BackColor = System.Drawing.Color.Transparent;
            tbTenNguoiThue.BackColor = System.Drawing.Color.Transparent;
            tbTenPhong.BackColor = System.Drawing.Color.Transparent;
           
        }

        private void funcGetTenNguoiThue()
        {
            if (sql == null)
            {
                sql = new SqlConnection(strSql);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "exec getTenNguoiThue '" + tenPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                tenNguoiThue = tmp;

            }
            reader.Close();
        }
    }
}
