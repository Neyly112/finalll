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
    public partial class FormGiaHanHD : Form
    {
        string strSQL = @"Data Source=MSI;Initial Catalog=QLCH1;Integrated Security=True";
        SqlConnection sql = null;

        string giaHan;
        string ngayKetThuc;
        public FormGiaHanHD(string giaHan, string ngayKetThuc)
        {
            InitializeComponent();
            this.giaHan = giaHan;
            this.ngayKetThuc = ngayKetThuc;
        }

        private void FormGiaHanHD_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = ngayKetThuc;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1 == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }
            if (sql == null)
            {
                sql = new SqlConnection(strSQL);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            
            SqlCommand sqlCm = new SqlCommand();
            sqlCm.CommandType = CommandType.Text;
            sqlCm.CommandText = "update Hop_dong set Ngay_ket_thuc = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' where Ma_phong = '" + giaHan + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();
            if (kq > 0) {
                MessageBox.Show("Gia hạn thành công");
            } else
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
