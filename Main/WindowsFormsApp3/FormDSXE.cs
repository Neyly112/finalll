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
    public partial class FormDSXE : Form
    {
        string ma;
        ClassConnect c = new ClassConnect();
        string strSql;
        SqlConnection sql = null;
        public FormDSXE(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangchu t = new trangchu(ma);
            this.Hide();
            t.ShowDialog();
        }

        private void FormDSXE_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            dataGridView1.DataSource = getAllHopDong().Tables[0];
            DataSet getAllHopDong()
            {
                DataSet dataSet = new DataSet();
                string querry = "select * from Dang_ki_xe";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            string maNT = Convert.ToString(row.Cells["MaNguoiThue"].Value);
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
                sqlCm.CommandText = "delete from Dang_ki_xe where MaNguoiThue = '" + maNT + "'";
                sqlCm.Connection = sql;

                int k = sqlCm.ExecuteNonQuery();
                if (k > 0)
                {
                    MessageBox.Show("Đã xóa xe");
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
                sql.Close();
                this.Hide();
                FormDSXE f = new FormDSXE(ma);
                f.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
