using NHOM11QLDA_.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace NHOM11QLDA_.Forms
{
    public partial class Hoadonthanhtoan : Form
    {
        public Hoadonthanhtoan(string tenPhong, string loaiPhong, string donGia)
        {
            InitializeComponent();
            txttenphong.Text = tenPhong;
            txtloaiphong.Text = loaiPhong;
            txtdongia.Text = donGia;

            // Tạo mã hóa đơn tự động
            txtmahoadon.Text = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Lấy ngày lập và giờ vào
            mskngaylap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtgiovao.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Hoadonthanhtoan_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("Select TenNV from Nhanvien", cbotennhanvien, "TenNV");
            cbotennhanvien.SelectedIndex = -1;
            txtmahoadon.Enabled = false;
            mskngaylap.Enabled = false;
            txtmakhachhang.Enabled = false;
            msksodienthoai.Enabled = false;
            txtdiachi.Enabled = false;
            lblghichu.Enabled = false;
            txttenphong.Enabled = false;
            txtloaiphong.Enabled = false;
            txtdongia.Enabled = false;
            txtgiovao.Enabled = false;
            txtgiora.Enabled = false;
            txtthanhtien.Enabled = false;
        }
        private void btnhuyhoadon_Click(object sender, EventArgs e)
        {
            Forms.Thongtinphong ttphong = new Forms.Thongtinphong();
            Class.Functions.Navigate(this, ttphong);
        }

        private void txtsogiothue_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtsogiothue.Text, out double soGioThue) && soGioThue > 0)
            {
                if (DateTime.TryParseExact(txtgiovao.Text, "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime gioVao))
                {
                    DateTime gioRa = gioVao.AddHours(soGioThue);
                    txtgiora.Text = gioRa.ToString("HH:mm:ss");
                }
                CapNhatThanhTien();
            }
            else
            {
                txtgiora.Text = "";
                txtthanhtien.Text = "";
            }
        }
        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void CapNhatThanhTien()
        {
            if (double.TryParse(txtsogiothue.Text, out double soGioThue) && soGioThue > 0 &&
                double.TryParse(txtdongia.Text, out double donGia) &&
                double.TryParse(txtgiamgia.Text, out double giamGia) && giamGia >= 0)
            {
                double thanhTien = (soGioThue * donGia) - giamGia;
                thanhTien = Math.Max(0, thanhTien);
                txtthanhtien.Text = Math.Round(thanhTien, 0).ToString();
            }
            else
            {
                txtthanhtien.Text = "";
            }
        }

        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtthanhtien.Text, out double thanhTien))
            {
                lblbangchu.Text = "Bằng chữ: " + NumberToWords(thanhTien);
            }
            else
            {
                lblbangchu.Text = "Bằng chữ: ";
            }
        }

        private string NumberToWords(double number)
        {
            if (number == 0)
                return "Không";

            string[] unitsMap = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] tensMap = { "", "", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

            string words = "";

            if (number < 0)
            {
                words = "âm ";
                number = Math.Abs(number);
            }

            // Xử lý phần triệu, nghìn, trăm
            if ((number / 1000000) >= 1)
            {
                words += NumberToWords(Math.Floor(number / 1000000)) + " triệu ";
                number %= 1000000;
            }

            if ((number / 1000) >= 1)
            {
                words += NumberToWords(Math.Floor(number / 1000)) + " nghìn ";
                number %= 1000;
            }

            if ((number / 100) >= 1)
            {
                words += NumberToWords(Math.Floor(number / 100)) + " trăm ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "lẻ ";

                if (number < 10)
                    words += unitsMap[(int)number];
                else if (number < 20)
                    words += "mười " + unitsMap[(int)(number % 10)];
                else
                {
                    words += tensMap[(int)(number / 10)];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[(int)(number % 10)];
                }
            }

            return words.Trim();
        }

        private void txttenkhachhang_TextChanged(object sender, EventArgs e)
        {
            msksodienthoai.Enabled = true;
        }
        private void msksodienthoai_Leave(object sender, EventArgs e)
        {
            string sql;
            string ten = txttenkhachhang.Text;
            string sdt = Regex.Replace(msksodienthoai.Text, "[^0-9]", "");
            sql = "select MaKH from Khachhang where TenKH=N'" + ten + "' and SDT='" + sdt + "'";
            if (Class.Functions.Checkey(sql))
            {
                string maKH = Functions.GetFieldValue(sql);
                txtmakhachhang.Text = maKH;
                msksodienthoai.Text = Functions.GetFieldValue("SELECT SDT FROM Khachhang WHERE MaKH = '" + maKH + "'");
                txtdiachi.Text = Functions.GetFieldValue("SELECT Diachi FROM Khachhang WHERE MaKH = '" + maKH + "'");

                //Đếm số MaHD theo MaKH trên và hiển thị label Ghichu
                string sohd = "SELECT COUNT(*) FROM Chitiethoadon join Hoadon on Chitiethoadon.MaHD=Hoadon.MaHD " +
                    "WHERE MaKH = '" + maKH + "'";
                int solan = Convert.ToInt32(Functions.GetFieldValue(sohd));
                lblghichu.Text = $"Khách hàng này đã ghé thăm {solan} lần.";
            }
            else
            {
                //Tự động sinh mã khách hàng mới
                string maxMaKHQuery = "SELECT MAX(CAST(SUBSTRING(MaKH, 3, 5) AS INT)) FROM Khachhang";
                SqlCommand cmdMaxMaKH = new SqlCommand(maxMaKHQuery, Functions.Conn);
                object result = cmdMaxMaKH.ExecuteScalar();
                int newMaKHNumber = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                string newMaKH = "KH" + newMaKHNumber.ToString("D5");

                txtmakhachhang.Text = newMaKH;
                txtdiachi.Enabled = true;
            }
        }

        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            string sql;
            if (cbotennhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chọn tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtsogiothue.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số giờ thuê!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsogiothue.Focus();
                return;
            }
            if (txtgiamgia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giảm giá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiamgia.Focus();
                return;
            }

            //Lưu thông tin Hóa đơn (Hoadon)
            string manv = Functions.GetFieldValue("select MaNV from Nhanvien where TenNV = N'" + cbotennhanvien.Text + "'");
            sql = "insert into Hoadon(MaHD, Thoigian, MaNV, MaKH, Tongtien) " +
                "values('" + txtmahoadon.Text + "', '" + Functions.ConvertToDatetime(mskngaylap.Text) + "', '" + manv + "', '" + txtmakhachhang.Text + "', '" + txtthanhtien.Text + "')";
            Functions.RunSql(sql);

            //Lưu thông tin Chitiethoadon
            string maphong = Functions.GetFieldValue("select Maphong from Phong where Tenphong = '" + txttenphong.Text + "'");
            string maloai = Functions.GetFieldValue("select Maloai from Loaiphong where Tenloai = N'" + txtloaiphong.Text + "'");
            sql = "insert into Chitiethoadon(MaHD, Maphong, Giovao, Giora, Maloai, Thanhtien) " +
                "values('" + txtmahoadon.Text + "', '" + maphong + "', '" + Functions.ConvertToTime(txtgiovao.Text) + "', '" + Functions.ConvertToTime(txtgiora.Text) + "', '" + maloai + "', '" + txtthanhtien.Text + "')";
            Functions.RunSql(sql);

            //Cập nhật trạng thái phòng vừa đặt
            string tt = "Đang thuê";
            string sqltt = "update Phong set Trangthai=N'" + tt + "', Ghichu = '" + Functions.ConvertToTime(txtgiora.Text) + "' where Maphong='" + maphong + "'";
            Functions.RunSql(sqltt);
            
            //Lưu thông tin Khachhang nếu đó là Khách hàng mới
            string sdt = Regex.Replace(msksodienthoai.Text, "[^0-9]", "");
            string makhMax = Functions.GetFieldValue("SELECT TOP 1 MaKH FROM Khachhang WHERE MaKH LIKE 'KH%' ORDER BY CAST(SUBSTRING(MaKH, 3, LEN(MaKH) - 2) AS INT) DESC;");
            if (string.Compare(txtmakhachhang.Text, makhMax, StringComparison.Ordinal) > 0) 
            {
                string sql1 = "INSERT INTO Khachhang(MaKH, TenKH, SDT, Diachi) VALUES('" + txtmakhachhang.Text + "', N'" + txttenkhachhang.Text + "', '" + sdt + "', N'" + txtdiachi.Text + "')";
                Functions.RunSql(sql1);
            }

            //Lưu thông tin xong thì xuất Hóa đơn
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

            // Tiêu đề hóa đơn
            exRange = exSheet.Range["F1", "I1"];
            exRange.Merge();
            exRange.Font.Size = 16;
            exRange.Font.Bold = true;
            exRange.HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Value = "HÓA ĐƠN THANH TOÁN";

            // Thông tin hóa đơn
            exSheet.Cells[4, 4] = "Mã hóa đơn:";
            exSheet.Cells[4, 6] = txtmahoadon.Text;

            exSheet.Cells[5, 4] = "Ngày lập:";
            exSheet.Cells[5, 6] = mskngaylap.Text;

            exSheet.Cells[6, 4] = "Tên nhân viên:";
            exSheet.Cells[6, 6] = cbotennhanvien.Text;

            exSheet.Cells[4, 8] = "Mã khách hàng:";
            exSheet.Cells[4, 10] = txtmakhachhang.Text;

            exSheet.Cells[5, 8] = "Tên khách hàng:";
            exSheet.Cells[5, 10] = txttenkhachhang.Text;

            exSheet.Cells[6, 8] = "Số điện thoại:";
            exSheet.Cells[6, 10] = msksodienthoai.Text;

            exSheet.Cells[7, 8] = "Địa chỉ:";
            exSheet.Cells[7, 10] = txtdiachi.Text;

            // Thông tin đặt phòng
            exSheet.Cells[9, 4] = "Tên phòng:";
            exSheet.Cells[9, 6] = txttenphong.Text;

            exSheet.Cells[10, 4] = "Loại phòng:";
            exSheet.Cells[10, 6] = txtloaiphong.Text;

            exSheet.Cells[11, 4] = "Đơn giá:";
            exSheet.Cells[11, 6] = txtdongia.Text;

            exSheet.Cells[12, 4] = "Thành tiền:";
            exSheet.Cells[12, 6] = txtthanhtien.Text;

            exSheet.Cells[13, 4] = "Bằng chữ:";
            exSheet.Cells[13, 6] = lblbangchu.Text;

            exSheet.Cells[9, 8] = "Giờ vào:";
            exSheet.Cells[9, 10] = txtgiovao.Text;

            exSheet.Cells[10, 8] = "Giờ ra:";
            exSheet.Cells[10, 10] = txtgiora.Text;

            exSheet.Cells[11, 8] = "Giảm giá:";
            exSheet.Cells[11, 10] = txtgiamgia.Text;

            // Định dạng khung viền
            exRange = exSheet.Range["D4", "K13"];
            exRange.Borders.LineStyle = COMExcel.XlLineStyle.xlContinuous;

            // Tạo hộp thoại lưu file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Lưu hóa đơn Excel";
            saveFileDialog.FileName = "HoaDonThanhToan.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    exBook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Forms.Danhsachhoadon dshd = new Forms.Danhsachhoadon();
                    Class.Functions.Navigate(this, dshd);
                    btnluuhoadon.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Hiển thị Excel
            exApp.Visible = true;
        }
    }
}
