using NHOM11QLDA_.Class;
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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace NHOM11QLDA_.Forms
{
    public partial class Baocaotansuatsudungphong : Form
    {
        public Baocaotansuatsudungphong()
        {
            InitializeComponent();
        }

        private void rdotheongay_CheckedChanged(object sender, EventArgs e)
        {
            msktheongay.Enabled = rdotheongay.Checked;
            msktu.Enabled = !rdotheongay.Checked;
            mskden.Enabled = !rdotheongay.Checked;
            dataGridView1.DataSource = null;
            resetvalue1();
        }

        private void rdotheokhoangthoigian_CheckedChanged(object sender, EventArgs e)
        {
            msktheongay.Enabled = !rdotheokhoangthoigian.Checked;
            msktu.Enabled = rdotheokhoangthoigian.Checked;
            mskden.Enabled = rdotheokhoangthoigian.Checked;
            dataGridView1.DataSource = null;
            resetvalue();
        }
        private void resetvalue()
        {
            msktheongay.Text = string.Empty;
        }
        private void resetvalue1()
        {
            msktu.Text = string.Empty;
            mskden.Text = string.Empty;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=PHI-HUNG;Initial Catalog=QLDAProject;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();
                string query = "";
                SqlCommand cmd = new SqlCommand();
                if (!rdotheongay.Checked && !rdotheokhoangthoigian.Checked)
                {
                    MessageBox.Show("Vui lòng chọn thời gian", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (rdotheongay.Checked)
                {
                    query = @"
                SELECT 
                    p.Tenphong as [Tên phòng],
                    lp.Tenloai as [Tên loại],
                    COUNT(cthd.Maphong) AS [Số lần sử dụng],
                    SUM(DATEDIFF(HOUR, cthd.Giovao, cthd.Giora)) AS [Tổng thời gian sử dụng]
                FROM 
                    Chitiethoadon as cthd
                JOIN Phong p ON cthd.Maphong = p.Maphong
                JOIN Loaiphong lp ON cthd.Maloai = lp.Maloai
                JOIN Hoadon hd ON cthd.MaHD = hd.MaHD
                WHERE CAST(hd.Thoigian AS DATE) = @ngay
                GROUP BY p.Tenphong, lp.Tenloai";

                    string ngay = DateTime.ParseExact(msktheongay.Text, "dd/MM/yyyy", null).ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@ngay", ngay);
                }
                else if (rdotheokhoangthoigian.Checked)
                {
                    query = @"
                SELECT 
                    p.Tenphong as [Tên phòng],
                    lp.Tenloai as [Tên loại],
                    COUNT(cthd.Maphong) AS [Số lần sử dụng],
                    SUM(DATEDIFF(HOUR, cthd.Giovao, cthd.Giora)) AS [Tổng thời gian sử dụng (giờ)]
                FROM 
                    Chitiethoadon cthd
                JOIN Phong p ON cthd.Maphong = p.Maphong
                JOIN LoaiPhong lp ON cthd.Maloai = lp.Maloai
                JOIN Hoadon hd ON cthd.MaHD = hd.MaHD
                WHERE CAST(hd.Thoigian AS DATE) BETWEEN @tungay AND @denngay
                GROUP BY p.Tenphong, lp.Tenloai";

                    string tungay = DateTime.ParseExact(msktu.Text, "dd/MM/yyyy", null).ToString("yyyy-MM-dd");
                    string denngay = DateTime.ParseExact(mskden.Text, "dd/MM/yyyy", null).ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@tungay", tungay);
                    cmd.Parameters.AddWithValue("@denngay", denngay);
                }

                cmd.CommandText = query;
                cmd.Connection = conn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Cấm thêm dòng mới và chỉ cho phép chỉnh sửa qua chương trình
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

                // Cập nhật lại DataGridView để đảm bảo các thay đổi được áp dụng
                dataGridView1.Refresh();
                dataGridView1.PerformLayout();
            }
        }

        private void Baocaotansuatsudungphong_Load(object sender, EventArgs e)
        {
            msktheongay.Enabled = false;
            msktu.Enabled = false;
            mskden.Enabled = false;
        }

        private void btnxuatbaocao_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu DataGridView không có dữ liệu
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Dừng lại nếu không có dữ liệu
            }

            // Nếu có dữ liệu, tiến hành xuất Excel
            XuatExcel();
        }
        private void XuatExcel()
        {
            // Khởi tạo ứng dụng Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];
            COMExcel.Range exRange;

            // Đặt font chữ và kích thước cho toàn bộ tài liệu
            exSheet.Range["A1:Z300"].Font.Name = "Times New Roman";
            exSheet.Range["A1:Z300"].Font.Size = 12;

            // Thêm tiêu đề báo cáo (dòng 2, chữ đỏ và in đậm, căn giữa)
            int lastCol = dataGridView1.Columns.Count; // Tổng số cột
            exRange = exSheet.Range["A2", exSheet.Cells[2, lastCol]];
            exRange.Merge(); // Gộp các ô
            exRange.HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Font.Bold = true;
            exRange.Font.Size = 16;
            exRange.Font.ColorIndex = 3; // Màu đỏ
            exRange.Value = "BÁO CÁO TẦN SUẤT VÀ THỜI GIAN SỬ DỤNG PHÒNG";

            // Đặt tiêu đề cột (dòng 4)
            for (int col = 0; col < dataGridView1.Columns.Count; col++)
            {
                exSheet.Cells[4, col + 1] = dataGridView1.Columns[col].HeaderText;
                exSheet.Cells[4, col + 1].Font.Bold = true; // In đậm
                exSheet.Cells[4, col + 1].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exSheet.Columns[col + 1].ColumnWidth = 15; // Điều chỉnh độ rộng cột
            }

            // Thêm dữ liệu từ DataGridView vào Excel
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridView1.Columns.Count; col++)
                {
                    exSheet.Cells[row + 5, col + 1] = dataGridView1.Rows[row].Cells[col].Value.ToString();
                    exSheet.Cells[row + 5, col + 1].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                }
            }

            // Thêm viền cho toàn bộ bảng dữ liệu (bao gồm tiêu đề cột và dữ liệu)
            int lastRow = dataGridView1.Rows.Count + 4; // Tổng số dòng dữ liệu + tiêu đề
            exRange = exSheet.Range["A4", exSheet.Cells[lastRow, lastCol]];
            exRange.Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;

            // Tạo hộp thoại lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"; // Chỉ lưu định dạng Excel .xlsx
            saveFileDialog.Title = "Lưu báo cáo Excel";
            saveFileDialog.FileName = "BaoCao_TanSuat.xlsx"; // Tên file mặc định

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Nếu người dùng chọn vị trí lưu file
            {
                try
                {
                    exBook.SaveAs(saveFileDialog.FileName); // Lưu file Excel
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Hiển thị Excel
            exApp.Visible = true;
        }
        private void mnubaocaodoanhthu_Click(object sender, EventArgs e)
        {
            Forms.Baocaodoanhthu baocaodt = new Forms.Baocaodoanhthu();
            Functions.Navigate(this, baocaodt);
        }

        private void mnubaocaotansuat_Click(object sender, EventArgs e)
        {
            Forms.Baocaotansuatsudungphong baocaots = new Forms.Baocaotansuatsudungphong();
            Functions.Navigate(this, baocaots);
        }

        private void mnuTrangchu_Click(object sender, EventArgs e)
        {
            Forms.Trangchu trangchu = new Forms.Trangchu();
            Functions.Navigate(this, trangchu);
        }

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            Forms.Thongtinphong ttphong = new Forms.Thongtinphong();
            Functions.Navigate(this, ttphong);
        }

        private void mnuHoadon_Click(object sender, EventArgs e)
        {
            Forms.Danhsachhoadon hoadon = new Forms.Danhsachhoadon();
            Functions.Navigate(this, hoadon);
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            Forms.Thongtinnhanvien nhanvien = new Forms.Thongtinnhanvien();
            Functions.Navigate(this, nhanvien);
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            Forms.Thongtinkhachhang khachhang = new Forms.Thongtinkhachhang();
            Functions.Navigate(this, khachhang);
        }
    }
}
