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
    public partial class FormDanhSachHoaChuHo : Form
    {
        public FormDanhSachHoaChuHo()
        {
            InitializeComponent();
            ds();
        }

        public void ds()
        {
            try
            {
                ClassConnect c = new ClassConnect();
                using (SqlConnection con = new SqlConnection(c.SqlConect()))
                {
                    con.Open();
                    string query = "SELECT * FROM Hoa_don";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                        {
                            
                            DataTable dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dshd.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            trangchu3 t = new trangchu3("");
            t.ShowDialog();
        }

        private void FormDanhSachHoaChuHo_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
          
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
