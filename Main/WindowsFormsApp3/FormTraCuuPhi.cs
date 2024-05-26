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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Runtime.InteropServices;
using System.Collections;
using System.IO;
using iText.Kernel.Exceptions;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout.Font;
using iText.Layout.Properties;
using iText.IO.Font;
using System.Xml.Linq;
using System.Reflection.Emit;

namespace WindowsFormsApp3
{
    public partial class FormTraCuuPhi : Form
    {
        private string taiKhoan;
        ClassConnect c = new ClassConnect();
        public FormTraCuuPhi(string taiKhoan)
        {
            InitializeComponent();            
            this.taiKhoan = taiKhoan;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            LoadDanhSachPhong();

        }
        
        private void LoadDanhSachPhong()
        {
            using (SqlConnection connection = new SqlConnection(c.SqlConect()))
            {
                connection.Open();
                string query = "SELECT MaPhong FROM Phong_thue_so_huu WHERE TaiKhoan = @taiKhoan";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@taiKhoan",taiKhoan);
                    List<string> dsMaPhong = new List<string>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dsMaPhong.Add(reader.GetString(0)); // Get the value at index 0 (MaQuanLi)
                        }
                    }
                    comboBox1.DataSource = dsMaPhong;
                }
                connection.Close();
            }
        }
        private void FormTraCuuPhi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCH2DataSet2.Bang_phi' table. You can move, or remove it, as needed.
            //this.bang_phiTableAdapter.Fill(this.qLCH2DataSet2.Bang_phi);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu2 t = new trangchu2(taiKhoan);
            t.ShowDialog();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            loadMaHoaDon(comboBox1.SelectedItem.ToString());
        }

        private void loadMaHoaDon(string str)
        {
            using (SqlConnection connection = new SqlConnection(c.SqlConect()))
            {
                connection.Open();
                string query = "SELECT MaHoaDon FROM Hoa_don WHERE MaPhong = @maPhong";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maPhong", str);
                    List<string> dsHoaDon = new List<string>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dsHoaDon.Add(reader.GetString(0)); // Get the value at index 0 (MaQuanLi)
                        }
                    }
                    comboBox2.DataSource = dsHoaDon;
                }
                connection.Close();
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(c.SqlConect()))
            {
                connection.Open();
                string qurey = "SELECT * FROM Bang_phi WHERE MaBangPhi = (SELECT MaBangPhi FROM Hoa_don WHERE MaHoaDon = @maHD)";
                using(SqlCommand command = new SqlCommand(qurey, connection))
                {
                    command.Parameters.AddWithValue("@maHD",comboBox2.SelectedItem.ToString()); 
                    DataTable bangPhi = new DataTable();
                    bangPhi.Load(command.ExecuteReader());
                    dataGridView1.DataSource = bangPhi;
                }
                connection.Close() ;
            }
        }
    }
}
