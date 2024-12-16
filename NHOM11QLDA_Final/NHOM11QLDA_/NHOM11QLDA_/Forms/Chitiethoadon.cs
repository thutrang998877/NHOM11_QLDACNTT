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

namespace NHOM11QLDA_.Forms
{
    public partial class Chitiethoadon : Form
    {
        public Chitiethoadon(string maHD)
        {
            InitializeComponent();
            txtmahoadon.Text = maHD;
            txtmahoadon.Enabled = false;
            mskngaylap.Enabled = false;
            txttennhanvien.Enabled = false;
            txttenkhachhang.Enabled = false;
            msksodienthoai.Enabled = false;
            txtdiachi.Enabled = false;
            txttenphong.Enabled = false;
            txtloaiphong.Enabled = false;
            txtdongia.Enabled = false;
            txtgiovao.Enabled = false;
            txtgiora.Enabled = false;
            txtthanhtien.Enabled = false;
            LoadChiTietHoaDon(maHD);
        }
        DataTable tblcthd;
        private void LoadChiTietHoaDon(string maHD)
        {
            string sql = "select Hoadon.MaHD, Thoigian, TenNV, TenKH, Khachhang.SDT, Khachhang.Diachi, Tongtien, " +
                "Tenphong, Giovao, Giora, Tenloai, Giathuetheogio " +
                "from Hoadon join Chitiethoadon on Hoadon.MaHD = Chitiethoadon.MaHD " +
                "join Khachhang on Khachhang.MaKH=Hoadon.MaKH " +
                "join Nhanvien on Nhanvien.MaNV=Hoadon.MaNV " +
                "join Phong on Phong.Maphong=Chitiethoadon.Maphong " +
                "join Loaiphong on Loaiphong.Maloai=Chitiethoadon.Maloai " +
                "where Hoadon.MaHD = '" + maHD + "'";

            tblcthd = Functions.GetDataToTable(sql);

            if (tblcthd.Rows.Count > 0)
            {
                DataRow row = tblcthd.Rows[0];
                mskngaylap.Text = row["Thoigian"].ToString();
                txttennhanvien.Text = row["TenNV"].ToString();
                txttenkhachhang.Text = row["TenKH"].ToString();
                msksodienthoai.Text = row["SDT"].ToString();
                txtdiachi.Text = row["Diachi"].ToString();
                txttenphong.Text = row["Tenphong"].ToString();
                txtloaiphong.Text = row["Tenloai"].ToString();
                txtdongia.Text = row["Giathuetheogio"].ToString();
                txtgiovao.Text = Convert.ToDateTime(row["Giovao"]).ToString("HH:mm:ss");
                txtgiora.Text = Convert.ToDateTime(row["Giora"]).ToString("HH:mm:ss");
                txtthanhtien.Text = row["Tongtien"].ToString();
            }

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

        private void bntdong_Click(object sender, EventArgs e)
        {
            Forms.Danhsachhoadon dshd = new Forms.Danhsachhoadon();
            Functions.Navigate(this, dshd);
        }
    }
}
