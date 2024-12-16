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
    public partial class Thongtinnhanvien : Form
    {
        public Thongtinnhanvien()
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

        private void Thongtinnhanvien_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            Resetvalues();
        }
        DataTable tblnv;
        private void Load_DataGridView()
        {
            string sql;
            sql = "select MaNV, TenNV, SDT, Diachi, TenCV from Nhanvien join Chucvu on Nhanvien.MaCV=Chucvu.MaCV order by MaNV asc";
            tblnv = Class.Functions.GetDataToTable(sql);
            dataGridView_nhanvien.DataSource = tblnv;

            dataGridView_nhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView_nhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView_nhanvien.Columns[2].HeaderText = "Số điện thoại";
            dataGridView_nhanvien.Columns[3].HeaderText = "Địa chỉ";
            dataGridView_nhanvien.Columns[4].HeaderText = "Chức vụ";
            dataGridView_nhanvien.Columns[3].Width = 300;

            dataGridView_nhanvien.AllowUserToAddRows = false;
            dataGridView_nhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Resetvalues()
        {
            txttennhanvien.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            string ten = txttennhanvien.Text;
            if (txttennhanvien.Text == "")
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sql = "select MaNV, TenNV, SDT, Diachi, TenCV from Nhanvien join Chucvu on Nhanvien.MaCV=Chucvu.MaCV where TenNV=N'"+ten+ "' order by MaNV asc";
                tblnv = Functions.GetDataToTable(sql);
            }
            if (tblnv.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                dataGridView_nhanvien.DataSource = tblnv;
            Resetvalues();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string newmanv = GenerateMaNhanVien();
            Forms.CTNhanvien ctnv = new Forms.CTNhanvien(newmanv);
            Functions.Navigate(this, ctnv);
        }
        private string GenerateMaNhanVien()
        {
            string query = "SELECT MAX(CAST(SUBSTRING(MaNV, 3, 5) AS INT)) FROM Nhanvien";
            SqlCommand cmd = new SqlCommand(query, Functions.Conn);  

            object result = cmd.ExecuteScalar();
            int newMaNVNumber = (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;

            return "NV" + newMaNVNumber.ToString("D2");  
        }

        private void dataGridView_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string manv = dataGridView_nhanvien.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                string tennv = dataGridView_nhanvien.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
                string sdt = dataGridView_nhanvien.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                string diachi = dataGridView_nhanvien.Rows[e.RowIndex].Cells["Diachi"].Value.ToString();
                string tencv = dataGridView_nhanvien.Rows[e.RowIndex].Cells["TenCV"].Value.ToString();

                Forms.CTNhanvien ctnv = new Forms.CTNhanvien(manv, tennv, sdt, diachi, tencv);
                Functions.Navigate(this, ctnv);
            }
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
