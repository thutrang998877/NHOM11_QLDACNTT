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
    public partial class Thongtinphong : Form
    {
        public Thongtinphong()
        {
            InitializeComponent();
        }

        private void mnuTrangchu_Click(object sender, EventArgs e)
        {
            Forms.Trangchu trangchu = new Forms.Trangchu();
            Functions.Navigate(this, trangchu);
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

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            Forms.Thongtinphong ttphong = new Forms.Thongtinphong();
            Functions.Navigate(this, ttphong);
        }
        DataTable tblPhong;

        private void Thongtinphong_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("Select distinct Trangthai from Phong", cbotrangthai, "Trangthai");
            cbotrangthai.SelectedIndex = -1;
            Load_DataGridView();
            Resetvalues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select Maphong, Tenphong, Tenloai, Giathuetheogio, Trangthai, Ghichu " +
                "from Phong inner join Loaiphong on Phong.Maloai=Loaiphong.Maloai " +
                "where Trangthai=N'Trống'";
            tblPhong = Class.Functions.GetDataToTable(sql);
            if (tblPhong.Rows.Count == 0)
            {
                sql = "select Maphong, Tenphong, Tenloai, Giathuetheogio, Trangthai, Ghichu " +
                    "from Phong inner join Loaiphong on Phong.Maloai=Loaiphong.Maloai";
                tblPhong = Class.Functions.GetDataToTable(sql);
            }
            dataGridView_thongtinphong.DataSource = tblPhong;

            dataGridView_thongtinphong.Columns[0].HeaderText = "Mã phòng";
            dataGridView_thongtinphong.Columns[1].HeaderText = "Tên phòng";
            dataGridView_thongtinphong.Columns[2].HeaderText = "Loại phòng";
            dataGridView_thongtinphong.Columns[3].HeaderText = "Đơn giá thuê";
            dataGridView_thongtinphong.Columns[4].HeaderText = "Trạng thái phòng";
            dataGridView_thongtinphong.Columns[5].HeaderText = "Ghi chú thuê";

            dataGridView_thongtinphong.AllowUserToAddRows = false;
            dataGridView_thongtinphong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            string ten = txttenphong.Text;
            if (txttenphong.Text == "")
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sql = "select Maphong, Tenphong, Tenloai, Giathuetheogio, Trangthai, Ghichu " +
                    "from Phong inner join Loaiphong on Phong.Maloai=Loaiphong.Maloai " +
                    "where Tenphong = N'" + ten + "'";
                tblPhong = Functions.GetDataToTable(sql);
            }
            if (tblPhong.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                dataGridView_thongtinphong.DataSource = tblPhong;
            Resetvalues();
        }

        private void Resetvalues()
        {
            txttenphong.Text = "";
            cbotrangthai.Text = "";
        }

        private void cbotrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            string trangthai = cbotrangthai.Text;
            sql = "select Maphong, Tenphong, Tenloai, Giathuetheogio, Trangthai, Ghichu " +
                  "from Phong inner join Loaiphong on Phong.Maloai=Loaiphong.Maloai " +
                  "where Trangthai = N'" + trangthai + "'";
            tblPhong = Class.Functions.GetDataToTable(sql);
            dataGridView_thongtinphong.DataSource = tblPhong;
        }
        private void dataGridView_thongtinphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_thongtinphong.Rows[e.RowIndex];
                string tenPhong = row.Cells["Tenphong"].Value.ToString();
                string loaiPhong = row.Cells["Tenloai"].Value.ToString();
                string donGia = row.Cells["Giathuetheogio"].Value.ToString();
                string trangthai = row.Cells["Trangthai"].Value.ToString();
                if (trangthai == "Đang thuê")
                {
                    MessageBox.Show("Phòng này đang được thuê, không thể tạo hóa đơn mới!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Forms.Hoadonthanhtoan hoadon = new Forms.Hoadonthanhtoan(tenPhong, loaiPhong, donGia);
                Functions.Navigate(this, hoadon);
            }
        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            Forms.CTThongtinphong ctphong = new Forms.CTThongtinphong();
            Class.Functions.Navigate(this, ctphong);
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
