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
    public partial class FormDSHDCH : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        string ma;
       
        public FormDSHDCH(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            string maHD = Convert.ToString(row.Cells["MaHopDong"].Value);
            string maPhong = Convert.ToString(row.Cells["MaPhong"].Value);
            string ngayBD = Convert.ToString(row.Cells["NgayBatDau"].Value);
            string ngayKT = Convert.ToString(row.Cells["NgayKetThuc"].Value);
            string soNg = Convert.ToString(row.Cells["SoNguoiO"].Value);
            string maNguoiThue = Convert.ToString(row.Cells["MaNguoiThue"].Value);
            this.Hide();
            FormXacNhanHD f = new FormXacNhanHD(ma, maPhong, soNg, ngayBD, ngayKT, maNguoiThue, maHD);
            f.ShowDialog();
            
        }

        private void FormDSHDCH_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            dataGridView1.DataSource = getAllHopDong().Tables[0];
            DataSet getAllHopDong()
            {
                DataSet dataSet = new DataSet();
                string querry = "select * from Hop_dong";
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
            this.Hide();
            trangchu3 f = new trangchu3(ma);
            f.ShowDialog();
        }
    }
}
