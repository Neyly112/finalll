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
    public partial class trangchu : System.Windows.Forms.Form
    {
        string ma;
        string strSql;
        ClassConnect c = new ClassConnect();
        SqlConnection sql = null;
        public trangchu(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDQL f = new FormDSHDQL(ma);
            f.ShowDialog();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHoTroKhachHang f = new FormHoTroKhachHang(ma);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            FormThongKeDoanhThu formThongKeDoanhThu = new FormThongKeDoanhThu();
            formThongKeDoanhThu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trangchu_Load(object sender, EventArgs e)
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
            sqlCm.CommandText = "select Ten from Quan_li where MaQuanLi = '" + ma + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                label2.Text = "Quản lý\n" + tmp;
            }
            reader.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            this.Hide();
            f.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormDanhSachHopDong f = new FormDanhSachHopDong(ma);
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSHDQL f = new FormDSHDQL(ma);
            f.ShowDialog();
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinQuanLy f = new FormThongTinQuanLy(ma);
            f.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSBangPhi f = new FormDSBangPhi(ma);
            f.ShowDialog();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSBangPhi f = new FormDSBangPhi(ma);
            f.ShowDialog();
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSPhongThue f = new FormDSPhongThue(ma);
            f.ShowDialog();
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSPhongThue f = new FormDSPhongThue(ma);
            f.ShowDialog();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSPhongThue f = new FormDSPhongThue(ma);
            f.ShowDialog();
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSNT f = new FormDSNT(ma);
            f.ShowDialog();
                
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSNT f = new FormDSNT(ma);
            f.ShowDialog();
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSNT f = new FormDSNT(ma);
            f.ShowDialog();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDSXE formDSXE = new FormDSXE(ma);
            formDSXE.ShowDialog();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDSXE formDSXE = new FormDSXE(ma);
            formDSXE.ShowDialog();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDSXE formDSXE = new FormDSXE(ma);
            formDSXE.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHoTroKhachHang f = new FormHoTroKhachHang(ma);
            f.ShowDialog();
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            FormDSBangPhi f = new FormDSBangPhi(ma);
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            FormThongKeDoanhThu formThongKeDoanhThu = new FormThongKeDoanhThu();
            formThongKeDoanhThu.ShowDialog();
        }
    }
}
