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
    public partial class FormDSHDNT : Form
    {
        string ma;
        string strSql;
        ClassConnect c = new ClassConnect();
        public FormDSHDNT(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            this.strSql = c.SqlConect();
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
            FormCTHDNT f = new FormCTHDNT(ma, maPhong, soNg, ngayBD, ngayKT, maNguoiThue, maHD);
            f.ShowDialog();
        }

        private void FormDSHDNT_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            dataGridView1.DataSource = getAllHopDong().Tables[0];
            DataSet getAllHopDong()
            {
                DataSet dataSet = new DataSet();
                string querry = "select * from Hop_dong where MaNguoiThue = '" + ma + "'";
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
            trangchu2 t = new trangchu2(ma);
            t.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
