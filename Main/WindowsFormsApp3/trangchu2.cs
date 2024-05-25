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
    public partial class trangchu2 : System.Windows.Forms.Form
    {
        string ma;
        string strSql;
        ClassConnect c = new ClassConnect();
        SqlConnection sql = null;
        public trangchu2(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormDanhSachHoaDonNguoiThue dshd = new FormDanhSachHoaDonNguoiThue(ma);
            this.Hide();
            dshd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDanhSachHoaDonNguoiThue dshd = new FormDanhSachHoaDonNguoiThue(ma);
            this.Hide();
            dshd.ShowDialog();
        }

        private void trangchu2_Load(object sender, EventArgs e)
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
            sqlCm.CommandText = "select Ten from Nguoi_thue where MaNguoiThue = '" + ma + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                label2.Text = "Người thuê\n" + tmp;
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinKH f = new FormThongTinKH(ma);
            f.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinKH f = new FormThongTinKH(ma);
            f.ShowDialog();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDNT f = new FormDSHDNT(ma);
            f.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDNT f = new FormDSHDNT(ma);
            f.ShowDialog();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDNT f = new FormDSHDNT(ma);
            f.ShowDialog();
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSXENT formDSXENT = new FormDSXENT(ma);
            formDSXENT.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYeuCauHoTro f = new FormYeuCauHoTro(ma);
            f.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormYeuCauHoTro f = new FormYeuCauHoTro(ma);
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDKX f = new FormDKX(ma);
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTraCuuPhi formTraCuuPhi = new FormTraCuuPhi(ma);
            formTraCuuPhi.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTraCuuPhi formTraCuuPhi = new FormTraCuuPhi(ma);
            formTraCuuPhi.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDKX f = new FormDKX(ma);
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSXENT formDSXENT = new FormDSXENT(ma);
            formDSXENT.ShowDialog();
        }
    }
}
