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
    public partial class FormDSPhongThue : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string ma;

        public FormDSPhongThue(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }
        private bool checkPhongDaThue(string maPhong)
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
            sqlCm.CommandText = "select * from Phong_thue_so_huu where MaPhong= '" + maPhong + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            int kq = 0;
            while (reader.Read())
            {
                kq = 1;
            }
            reader.Close();
            if (kq == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void FormDSPhongThue_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            dataGridView1.DataSource = getAllHopDong().Tables[0];
            DataSet getAllHopDong()
            {
                DataSet dataSet = new DataSet();
                string querry = "select * from Phong_cho_thue";
                using (SqlConnection connection = new SqlConnection(strSql))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(querry, connection);
                    adapter.Fill(dataSet);
                    connection.Close();
                }
                return dataSet;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangchu t = new trangchu(ma);
            this.Hide();
            t.Show();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            string maPhong = Convert.ToString(row.Cells["MaPhong"].Value);
            if (checkPhongDaThue(maPhong) == true)
            {
                MessageBox.Show("Phòng đang được thuê, không thể xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                if (MessageBox.Show("Bạn có chắc muốn xóa không ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    sqlCm.CommandText = "delete from Phong_cho_thue where MaPhong = '" + maPhong + "'";
                    sqlCm.Connection = sql;

                    int k = sqlCm.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("Đã xóa");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                    sql.Close();
                    this.Hide();
                    FormDSPhongThue f = new FormDSPhongThue(ma);
                    f.ShowDialog();
                } 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThemPhong f = new FormThemPhong(ma);
            f.ShowDialog();
        }
    }
}
