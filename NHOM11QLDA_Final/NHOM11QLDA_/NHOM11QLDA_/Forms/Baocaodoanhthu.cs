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
using System.Windows.Forms.DataVisualization.Charting;


namespace NHOM11QLDA_.Forms
{
    public partial class Baocaodoanhthu : Form
    {
        public Baocaodoanhthu()
        {
            InitializeComponent();
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

        private void Baocaodoanhthu_Load(object sender, EventArgs e)
        {
            msktheongay.Enabled = false;
            msktu.Enabled = false;
            mskden.Enabled = false;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            DataTable dt = null;

            // Kiểm tra nếu người dùng chọn chế độ "Theo ngày"
            if (rdotheongay.Checked)
            {
                // Kiểm tra nếu người dùng đã nhập ngày
                if (string.IsNullOrEmpty(msktheongay.Text))
                {
                    MessageBox.Show("Vui lòng nhập ngày để báo cáo theo ngày.");
                    return;
                }

                // Truy vấn báo cáo theo ngày
                string query = "SELECT CONVERT(VARCHAR, Giora, 103) AS Ngay, SUM(Thanhtien) AS DoanhThu " +
                               "FROM Chitiethoadon " +
                               "WHERE CONVERT(DATE, Giora) = @Ngay " +
                               "GROUP BY CONVERT(VARCHAR, Giora, 103)";
                var parameters = new Dictionary<string, object>
            {
                { "@Ngay", DateTime.Parse(msktheongay.Text) }
            };

                // Lấy dữ liệu từ cơ sở dữ liệu
                dt = ExecuteQuery(query, parameters);
            }
            // Kiểm tra nếu người dùng chọn chế độ "Khoảng thời gian"
            else if (rdotheokhoangthoigian.Checked)
            {
                // Kiểm tra nếu người dùng đã nhập đầy đủ khoảng thời gian
                if (string.IsNullOrEmpty(msktu.Text) || string.IsNullOrEmpty(mskden.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ khoảng thời gian.");
                    return;
                }

                // Truy vấn báo cáo theo khoảng thời gian
                string query = "SELECT CONVERT(VARCHAR, Giora, 103) AS Ngay, SUM(Thanhtien) AS DoanhThu " +
                               "FROM Chitiethoadon " +
                               "WHERE CONVERT(DATE, Giora) BETWEEN @TuNgay AND @DenNgay " +
                               "GROUP BY CONVERT(VARCHAR, Giora, 103)";
                var parameters = new Dictionary<string, object>
            {
                { "@TuNgay", DateTime.Parse(msktu.Text) },
                { "@DenNgay", DateTime.Parse(mskden.Text) }
            };

                // Lấy dữ liệu từ cơ sở dữ liệu
                dt = ExecuteQuery(query, parameters);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thời gian");
                return;
            }

            // Nếu có dữ liệu, hiển thị lên biểu đồ cột
            if (dt != null && dt.Rows.Count > 0)
            {
                DisplayChart(dt);  // Hiển thị biểu đồ
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!");
            }
        }
        private DataTable ExecuteQuery(string query, Dictionary<string, object> parameters)
        {
            string connectionString = "Data Source=PHI-HUNG;Initial Catalog=QLDAProject;Integrated Security=True;Encrypt=False";  // Đảm bảo thay đổi chuỗi kết nối của bạn
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                foreach (var param in parameters)
                {
                    da.SelectCommand.Parameters.AddWithValue(param.Key, param.Value);
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void DisplayChart(DataTable dt)
        {
            chartdoanhthu.Series.Clear();
            chartdoanhthu.Series.Add("Doanh Thu");

            chartdoanhthu.Series["Doanh Thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartdoanhthu.Series["Doanh Thu"].IsValueShownAsLabel = true;

            // Lặp qua từng dòng dữ liệu để thêm vào biểu đồ
            foreach (DataRow row in dt.Rows)
            {
                string ngay = row["Ngay"].ToString();
                decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);

                // Thêm dữ liệu vào biểu đồ
                chartdoanhthu.Series["Doanh Thu"].Points.AddXY(ngay, doanhThu);
            }

            chartdoanhthu.Invalidate();  // Cập nhật lại biểu đồ

        }

        private void rdotheongay_CheckedChanged(object sender, EventArgs e)
        {
            msktheongay.Enabled = rdotheongay.Checked;
            msktu.Enabled = !rdotheongay.Checked;
            mskden.Enabled = !rdotheongay.Checked;
            chartdoanhthu.Series.Clear();
            resetvalue1();
        }

        private void rdotheokhoangthoigian_CheckedChanged(object sender, EventArgs e)
        {
            msktheongay.Enabled = !rdotheokhoangthoigian.Checked;
            msktu.Enabled = rdotheokhoangthoigian.Checked;
            mskden.Enabled = rdotheokhoangthoigian.Checked;
            chartdoanhthu.Series.Clear();
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
    }
}
