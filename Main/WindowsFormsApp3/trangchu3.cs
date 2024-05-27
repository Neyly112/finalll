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
    public partial class trangchu3 : System.Windows.Forms.Form
    {
        string ma;
        string strSql;
        ClassConnect c = new ClassConnect();
        SqlConnection sql = null;
        public trangchu3(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSBP f = new FormDSBP(ma);
            f.ShowDialog();
           
        }

        private void trangchu3_Load(object sender, EventArgs e)
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
            sqlCm.CommandText = "select Ten from Chu_ho where MaChuHo = '" + ma + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                label2.Text = "Chủ hộ\n" + tmp;
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinChuHo f = new FormThongTinChuHo(ma);
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormThongKeDoanhThu formThongKeDoanhThu = new FormThongKeDoanhThu();
            formThongKeDoanhThu.ShowDialog();   
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSBP f = new FormDSBP(ma);
            f.ShowDialog();
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSPTCH f = new FormDSPTCH(ma);
            f.ShowDialog();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSPTCH f = new FormDSPTCH(ma);
            f.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDCH f = new FormDSHDCH(ma);
            f.ShowDialog();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSNTCH formDSNTCH = new FormDSNTCH(ma);
            formDSNTCH.ShowDialog();
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSNTCH formDSNTCH = new FormDSNTCH(ma);
            formDSNTCH.ShowDialog();
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSNTCH formDSNTCH = new FormDSNTCH(ma);
            formDSNTCH.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormDanhSachHoaChuHo ds = new FormDanhSachHoaChuHo(ma);
            this.Hide();
            ds.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSXECH f = new FormDSXECH(ma);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSXECH f = new FormDSXECH(ma);
            f.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSXECH f = new FormDSXECH(ma);
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormThongKeDoanhThu formThongKeDoanhThu = new FormThongKeDoanhThu();
            formThongKeDoanhThu.ShowDialog();
        }
    }
}
