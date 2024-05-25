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
    public partial class FormDSPTCH : Form
    {
        string ma;
        ClassConnect c = new ClassConnect();
        string strSql;
        public FormDSPTCH(string ma)
        {
            InitializeComponent();
            strSql = c.SqlConect();
            this.ma = ma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu3 f = new trangchu3(ma);
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDSPTCH_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

