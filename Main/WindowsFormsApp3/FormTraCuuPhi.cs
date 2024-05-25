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

namespace WindowsFormsApp3
{
    public partial class FormTraCuuPhi : Form
    {
        private string taiKhoan;
        ClassConnect c = new ClassConnect();
        public FormTraCuuPhi(string taiKhoan)
        {
            InitializeComponent();
            textBox2.KeyDown += textBox2_KeyDown;
            dateTimePicker2.KeyPress += dateTimePicker2_KeyPress;
            this.taiKhoan = taiKhoan;
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button3.PerformClick();
            }
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void FormTraCuuPhi_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng !");
            }
            else
            {
                string maPhong = textBox2.Text;
                if (!getDanhSachPhong().Contains(maPhong))
                {
                    MessageBox.Show("Phòng thuê này không thuộc quyền sở hữu của bạn !");
                }
                else if (getDanhSachHoaDon().Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Phòng chưa có hóa đơn nào !");
                }
                else
                {
                    dataGridView2.DataSource = getDanhSachHoaDon().Tables[0];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu2 t = new trangchu2(taiKhoan);
            t.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getBangPhi().Tables[0];
        }
        DataSet getBangPhi()
        {
            DataSet dataSet = new DataSet();
            string query = "select * from Bang_phi where Ma_bang_phi = ( select MaBangPhi from Hoa_don " +
                "where NgayLapHoaDon = @Ngaylaphoadon and MaPhong = @Maphong )";
            string dateTime = (dateTimePicker2.Value).ToString().Trim();
            string maPhong = textBox2.Text;
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NFN54M67\SQLEXPRESS;Initial Catalog=QLCH2;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Ngaylaphoadon", dateTime);
                command.Parameters.AddWithValue("@Maphong", maPhong);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                sqlDataAdapter.Fill(dataSet);
                conn.Close();
            }
            return dataSet;
        }
        DataSet getDanhSachHoaDon()
        {
            DataSet dataSet = new DataSet();
            String query = "select NgayLapHoaDon from Hoa_don where MaPhong = @Maphong ORDER BY NgayLapHoaDon DESC";
            string maPhong = textBox2.Text;
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Maphong", maPhong);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet);
                conn.Close();
            }
            return dataSet;
        }
        List<string> getDanhSachPhong()
        {
            List<string> danhSachPhong = new List<string>();
            String query = "select MaPhong from Phong_thue_so_huu where TaiKhoan = @taiKhoan";
            using (SqlConnection conn = new SqlConnection(c.SqlConect()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@taiKhoan", taiKhoan);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSachPhong.Add(reader["MaPhong"].ToString());
                }
                conn.Close();
            }
            return danhSachPhong;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng !");
            }
            else if (getDanhSachHoaDon().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Phòng chưa được lập bất kì hóa đơn nào !");
            }
            else if (getBangPhi().Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Xin vui lòng chọn ngày để hiển thị bảng phí !");
            }
            else
            {
                string directoryPath = @"d:\Bảng Phí\";
                string filePath = directoryPath + "Bảng Phí Tháng " + dateTimePicker2.Value.Month
                    .ToString() + " Năm " + dateTimePicker2.Value.Year.ToString() + " Phòng "
                    + textBox2.Text + ".pdf";

                // Kiểm tra và tạo thư mục nếu không tồn tại
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                /// Đường dẫn đến tập tin font
                string fontPath = @"D:\font-times-new-roman\SVN-Times New Roman.ttf";

                // Tạo một font từ tập tin
                PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdfDoc = new PdfDocument(writer))
                using (Document document = new Document(pdfDoc))
                {
                    // Tiêu đề của bảng phí
                    Paragraph heading = new Paragraph("Bảng phí tháng " + dateTimePicker2.Value.Month.ToString()
                         + " năm " + dateTimePicker2.Value.Year.ToString() + " phòng " + textBox2.Text).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER
                         ).SetFontSize(25).SetFont(font);
                    document.Add(heading);
                    // Tạo một danh sách chứa các tiêu đề mới
                    List<string> newColumnHeaders = new List<string>
                    {
                        "Tiền nước",
                        "Phí sinh hoạt",
                        "Tiền điện",
                        "Tiền xe máy",
                        "Tiền xe đạp",
                        "Tiền xe hơi",
                        "Mã bảng phí",
                        "Mã chủ hộ"
                    };

                    // Thay đổi tiêu đề của các cột trong dataGridView1
                    for (int i = 0; i < newColumnHeaders.Count; i++)
                    {
                        dataGridView1.Columns[i].HeaderText = newColumnHeaders[i];
                    }

                    // Tạo bảng PDF
                    Table pdfTable = new Table(dataGridView1.Columns.Count);

                    // Thêm tiêu đề của các cột vào bảng PDF
                    foreach (DataGridViewColumn dgvCol in dataGridView1.Columns)
                    {
                        pdfTable.AddHeaderCell(new Cell().Add(new Paragraph(dgvCol.HeaderText).SetFont(font)));
                    }

                    // Thêm dữ liệu từ dataGridView1 vào bảng PDF
                    foreach (DataGridViewRow dgvRow in dataGridView1.Rows)
                    {
                        // Tạo một biến để kiểm tra xem hàng có dữ liệu không
                        bool hasData = false;

                        foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                        {
                            // Kiểm tra nếu ô dữ liệu không rỗng
                            if (!string.IsNullOrEmpty(Convert.ToString(dgvCell.Value)))
                            {
                                hasData = true;
                                break; // Nếu có dữ liệu, thoát khỏi vòng lặp và thêm hàng vào bảng PDF
                            }
                        }

                        // Kiểm tra nếu hàng có dữ liệu
                        if (hasData)
                        {
                            foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                            {
                                // Thêm dữ liệu từ ô vào bảng PDF
                                pdfTable.AddCell(new Cell().Add(new Paragraph(Convert.ToString(
                                    dgvCell.Value)).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                                    .SetFont(font)));
                            }
                        }
                        else
                        {
                            // Nếu hàng không có dữ liệu, không thêm vào bảng PDF và tiếp tục với hàng tiếp theo
                            continue;
                        }
                    }

                    // Thêm bảng PDF vào tài liệu
                    document.Add(pdfTable);
                }
                MessageBox.Show("Xuất PDF thành công!");
                try
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở file PDF. Lỗi: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
