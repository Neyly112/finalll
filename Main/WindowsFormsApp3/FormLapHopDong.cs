using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlTypes;
using System.Net.Mail;
using System.Text.RegularExpressions;
namespace DemoLapHopDong
{
    public partial class FormLapHopDong : Form
    {
        string strSQL = @"Data Source=MSI;Initial Catalog=QLCH;Integrated Security=True";
        SqlConnection sql = null;  
        public FormLapHopDong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerNL_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNL.Format = DateTimePickerFormat.Custom;
            dateTimePickerNL.CustomFormat = "yyyy-MM-dd";
        }

        private void dateTimePickerNKT_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerNKT.Format = DateTimePickerFormat.Custom;
            dateTimePickerNKT.CustomFormat = "yyyy-MM-dd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguoiThue n = new NguoiThue(tbEmail.Text, tbDC.Text, tbSDT.Text, txTen.Text);
            HopDong h = new HopDong(dateTimePickerNL.Text.ToString(), Convert.ToInt32(tbSNG.Text), dateTimePickerNKT.Text.ToString());
            if (sql == null)
            {
                sql = new SqlConnection(strSQL);
            }
            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }

            if ((tbDC.Text == "") || (tbEmail.Text == "") || (tbSDT.Text == "") || (tbSNG.Text == "") || (txTen.Text == ""))
            {
                MessageBox.Show("Không để trống ô");
                return;
            }
            

            string email = n.getEmail().Trim();
            if (isEmail(email) == false)
            {
                MessageBox.Show("Nhap sai email");
                return;
            }
            string phone = n.getSdt().Trim();
            string name = n.getTen().Trim();
            string NL = dateTimePickerNL.Text.ToString().Trim();
            string NKT = dateTimePickerNKT.Text.ToString().Trim();
            int nMember = Convert.ToInt32(tbSNG.Text);
            string address = n.getDiaChi().Trim();

            funcAddKH(n.getEmail().Trim(), n.getDiaChi().Trim(), n.getSdt().Trim(), n.getTen().Trim());
            funcAddHD(h.getNgayKetThuc().Trim(), Convert.ToInt32(h.getSoNguoi()), h.getNgayLap().Trim());        
        }
        private void funcAddHD(string NKT, int songuoi, string NL)
        {
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
            sqlCm.CommandText = "exec insertToHD '" + NKT + "', '" + songuoi + "', '" + NL + "'";
            sqlCm.Connection = sql;
            int k = sqlCm.ExecuteNonQuery();
            if (k > 0)
            {
                MessageBox.Show("Đã gửi cho chủ hộ, vui lòng chờ xác nhận!");
            }
            else
            {
                MessageBox.Show("Chua xac nhan");
            }

        }
        private void funcAddKH(string emailKH, string dc, string sdt, string TenKh)
        {
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
            sqlCm.CommandText = "exec insertToNguoiThue N'" + emailKH + "', N'" + dc + "','" + sdt + "', '" + TenKh + "', 'matkhau123'";
            sqlCm.Connection = sql;
            bool ok = false;
            int k = sqlCm.ExecuteNonQuery();
            if (k > 0)
            {
                ok = true;
            }
            else
            {
                ok = false;
            }
        }
        private bool isEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }

        private void tbDC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNL_Click(object sender, EventArgs e)
        {

        }

        private void lbTenKH_Click(object sender, EventArgs e)
        {

        }

        private void lbNKT_Click(object sender, EventArgs e)
        {

        }
    }
}
