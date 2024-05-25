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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp3
{
    public partial class FormThongTinKH : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string ma;
        string matKhau;
        string diaChi;
        string sDT;
        string email;
        string ten;
        public FormThongTinKH(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChinhThongTinKH f = new FormChinhThongTinKH(ma, ten, diaChi, sDT, email, matKhau);
            f.ShowDialog();
            
        }

        private void FormThongTinKH_Load(object sender, EventArgs e)
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

            sqlCm.CommandText = "select * from Nguoi_thue where MaNguoiThue='" + ma + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                diaChi = reader.GetString(1);
                sDT = reader.GetString(3);
                email = reader.GetString(2);
                ten = reader.GetString(0);
                matKhau = reader.GetString(4);
                lbTen.Text = ten;
                lbDiaChi.Text = diaChi;
                lbEmail.Text = email;
                
                lbSdt.Text = sDT;
            }
            reader.Close();
            label1.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            lbDiaChi.BackColor = System.Drawing.Color.Transparent;
            lbEmail.BackColor = System.Drawing.Color.Transparent;
            lbSdt.BackColor = System.Drawing.Color.Transparent;
            lbTen.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu2 t = new trangchu2(ma);
            t.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
