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
    public partial class FormDSHDQL : Form
    {
        string ma;
        string strSql;
        ClassConnect c = new ClassConnect();
        public FormDSHDQL(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            string maHD = Convert.ToString(row.Cells["MaHoaDon"].Value);
            string maPhong = Convert.ToString(row.Cells["MaPhong"].Value);

            this.Hide();
            FormXacNhanHoaDon f = new FormXacNhanHoaDon(ma, maHD, maPhong);
            f.ShowDialog();
        }

        private void FormDSHDQL_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            dataGridView1.DataSource = getAllHopDong().Tables[0];
            DataSet getAllHopDong()
            {
                DataSet dataSet = new DataSet();
                string querry = "select * from Hoa_don";
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
            trangchu t = new trangchu(ma);
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNhapTinhToan f = new FormNhapTinhToan(ma);
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
           
        }
    }
}
