using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DTO1;
using DAO1;
using BLL1;

namespace WindowsFormsApp3
{
    public partial class FormDSNT : Form
    {
        ClassConnect c = new ClassConnect();
        string strSql;
        string ma;
        DataTable dataTable;

        public FormDSNT(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showNT()
        {
            dataTable = NT1DAO.Instance.GetAllNT();
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có người thuê nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        private void FormDSNT_Load(object sender, EventArgs e)
        {
            showNT();
            label1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu t = new trangchu(ma);
            t.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
