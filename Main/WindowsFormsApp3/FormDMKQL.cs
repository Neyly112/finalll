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
    public partial class FormDMKQL : Form
    {
        string ma;
        ClassConnect c = new ClassConnect();
        SqlConnection sql = null;
        string strSql;
        string mk;
        public FormDMKQL(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((tbMkCu.Texts == "") || (tbMkMoi.Texts == "") || (tbXacNhan.Texts == ""))
            {
                MessageBox.Show("Vui lòng nhập thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbMkCu.Texts.ToString() == tbMkMoi.Texts.ToString())
            {
                MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbMkMoi.Texts != tbXacNhan.Texts)
            {
                MessageBox.Show("Sai mật khẩu xác nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string matKhauCu = tbMkCu.Texts;
            string mkMoi = tbMkMoi.Texts;
            string mkXacNhan = tbXacNhan.Texts;
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
            sqlCm.CommandText = "Select MatKhau from Quan_li where MaQuanLi = '" + ma + "'";
            sqlCm.Connection = sql;
            SqlDataReader reader = sqlCm.ExecuteReader();
            while (reader.Read())
            {
                string tmp = reader.GetString(0);
                mk = tmp;

            }
            reader.Close();
            sql.Close();
            if (mk != matKhauCu)
            {
                MessageBox.Show("Sai mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                upDateMK(mkMoi);
            }
            this.Hide();
            FormThongTinQuanLy f = new FormThongTinQuanLy(ma);
            f.ShowDialog();

        }

        private void FormDMKQL_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
        }
        private void upDateMK(string mkMoi)
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
            sqlCm.CommandText = "Update Quan_li set MatKhau = '" + mkMoi + "' where MaQuanLi = '" + ma + "'";
            sqlCm.Connection = sql;
            int kq = sqlCm.ExecuteNonQuery();

            if (kq > 0)
            {
                MessageBox.Show("Đã đổi mật khẩu");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinQuanLy f = new FormThongTinQuanLy(ma);
            f.ShowDialog();
        }
    }
}
