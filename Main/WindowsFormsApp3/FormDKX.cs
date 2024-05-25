using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormDKX : Form
    {
        string ma;
        Boolean isButton1Clicked = false;
        Boolean isButton2Clicked = false;
        Boolean isButton3Clicked = false;
        ClassConnect c = new ClassConnect();
        string strSql;
        public FormDKX(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            strSql = c.SqlConect();
        }

        private void FormDKX_Load(object sender, EventArgs e)
        {

        }
        private void insertBienSoXe()
        {
            
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure only one CheckBox is checked at a time
            if (sender == bt1 && bt1.Checked)
            {
                bt3.Checked = false;
            }
            else if (sender == bt3 && bt3.Checked)
            {
                bt1.Checked = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            insertBienSoXe();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu2 t = new trangchu2(ma);
            t.ShowDialog();
        }

        public static bool check_bien_so(string plate)
        {
            string bikePlatePattern = @"^\d{5}$";

            return Regex.IsMatch(plate, bikePlatePattern);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isButton1Clicked)
            {

                DateTime now = DateTime.Now;
                string thoi_gian = now.ToString("yyyy-MM-dd");


                if (string.IsNullOrWhiteSpace(bienSoXe.Text))
                {
                    MessageBox.Show("Vui lòng nhập biển số xe.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string bien_so = bienSoXe.Text;
                    if (check_bien_so(bien_so))
                    {
                        using (SqlConnection con = new SqlConnection(strSql))
                        {
                            try
                            {

                                con.Open();
                                string query = "INSERT INTO Dang_ki_xe (Ngay_dang_ki, bien_so, loai_xe, MaNguoiThue) VALUES (@formattedDate,@bien_so,@InputText,@ma)";

                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {
                                    cmd.Parameters.AddWithValue("@formattedDate", thoi_gian);
                                    cmd.Parameters.AddWithValue("@bien_so", bien_so);
                                    cmd.Parameters.AddWithValue("@InputText", "Xe máy");
                                    cmd.Parameters.AddWithValue("@ma", ma);

                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Đã xảy ra lỗi khi lưu dữ liệu.", "Thát Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Biển số xe máy không hợp lệ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (isButton3Clicked)
            {

                string loai_xe = bt3.Text;
                DateTime now = DateTime.Now;
                string thoi_gian = now.ToString("yyyy-MM-dd");
                if (string.IsNullOrWhiteSpace(bienSoXe.Text))
                {
                    MessageBox.Show("Vui lòng nhập biển số xe.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string bien_so = bienSoXe.Text;
                    if (check_bien_so(bien_so))
                    {
                        using (SqlConnection con = new SqlConnection(strSql))
                        {
                            try
                            {

                                con.Open();
                                string query = "INSERT INTO Dang_ki_xe (Ngay_dang_ki, bien_so, loai_xe, MaNguoiThue) VALUES (@formattedDate,@bien_so,@InputText,@ma)";

                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {
                                    cmd.Parameters.AddWithValue("@formattedDate", thoi_gian);
                                    cmd.Parameters.AddWithValue("@bien_so", bien_so);
                                    cmd.Parameters.AddWithValue("@InputText", "Xe dưới 1.5 tấn");
                                    cmd.Parameters.AddWithValue("@ma", ma);

                                    int rowsAffected = cmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Dữ liệu đã được lưu thành công!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Đã xảy ra lỗi khi lưu dữ liệu.");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Biển số xe dưới 1.5 tấn không hợp lệ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {

                MessageBox.Show("Vui lòng chọn loại xe!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bt1_CheckedChanged(object sender, EventArgs e)
        {
            if (bt1 != null && bt1.Checked)
            {
                isButton1Clicked = true;
            }
        }

        private void bt3_CheckedChanged(object sender, EventArgs e)
        {
            if (bt3 != null && bt3.Checked)
            {
                isButton3Clicked = true;
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            trangchu2 t = new trangchu2(ma);
            t.ShowDialog();
        }
    }
}
