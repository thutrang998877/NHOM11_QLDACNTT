using NHOM11QLDA_.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM11QLDA_.Forms
{
    public partial class Danhsachhoadon : Form
    {
        public Danhsachhoadon()
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

        private void Danhsachhoadon_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("Select TenNV from Nhanvien", cbotennhanvien, "TenNV");
            cbotennhanvien.SelectedIndex = -1;
            Load_Datagridview();
        }
        DataTable tbldshd;
        private void Load_Datagridview()
        {
            string sql;
            sql = "select MaHD, Thoigian, TenNV, MaKH, Tongtien from Hoadon join Nhanvien on Hoadon.MaNV=Nhanvien.MaNV order by MaHD desc";
            tbldshd = Class.Functions.GetDataToTable(sql);
            dataGridView_dshd.DataSource = tbldshd;

            dataGridView_dshd.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView_dshd.Columns[1].HeaderText = "Ngày lập";
            dataGridView_dshd.Columns[2].HeaderText = "Tên nhân viên";
            dataGridView_dshd.Columns[3].HeaderText = "Mã khách ";
            dataGridView_dshd.Columns[4].HeaderText = "Tổng tiền";

            dataGridView_dshd.Columns[0].Width = 150;

            dataGridView_dshd.AllowUserToAddRows = false;
            dataGridView_dshd.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            string ngay = Functions.ConvertToDatetime(mskngay.Text);
            if (mskngay.Text == "  /  /")
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(mskngay.Text != "  /  /" && cbotennhanvien.SelectedItem == null)
            {
                sql = "select MaHD, Thoigian, TenNV, MaKH, Tongtien from Hoadon join Nhanvien on Hoadon.MaNV=Nhanvien.MaNV " +
                    "where Thoigian = '" + ngay + "' order by MaHD desc";
                tbldshd = Functions.GetDataToTable(sql);
            }
            else
            {
                sql = "select MaHD, Thoigian, TenNV, MaKH, Tongtien from Hoadon join Nhanvien on Hoadon.MaNV=Nhanvien.MaNV " +
                    "where Thoigian = '"+ ngay +"' and TenNV = N'" +cbotennhanvien.Text+ "' order by MaHD desc";
                tbldshd = Functions.GetDataToTable(sql);
            }
            if (tbldshd.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                dataGridView_dshd.DataSource = tbldshd;
            Resetvalues();
        }
        private void Resetvalues()
        {
            mskngay.Text = "";
            cbotennhanvien.Text = "";
        }
        private void cbotennhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            string ten = cbotennhanvien.Text;
            string ngay = Functions.ConvertToDatetime(mskngay.Text);
            if (mskngay.Text == "  /  /")
            {
                sql = "select MaHD, Thoigian, TenNV, MaKH, Tongtien from Hoadon join Nhanvien on Hoadon.MaNV=Nhanvien.MaNV " +
                    "where TenNV = N'" + ten + "' order by MaHD desc";
                tbldshd = Class.Functions.GetDataToTable(sql);
            }
            else
            {
                sql = "select MaHD, Thoigian, TenNV, MaKH, Tongtien from Hoadon join Nhanvien on Hoadon.MaNV=Nhanvien.MaNV " +
                    "where TenNV = N'" + ten + "' and Thoigian = '" + ngay + "' order by MaHD desc";
                tbldshd = Class.Functions.GetDataToTable(sql);
            }
            dataGridView_dshd.DataSource = tbldshd;
            Resetvalues();
        }

        private void btnxuatexcel_Click(object sender, EventArgs e)
        {
            //Xuất ra danh sách hóa đơn theo các tùy chỉnh danh sách 
        }

        private void dataGridView_dshd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_dshd.Rows[e.RowIndex];
                string maHD = row.Cells["MaHD"].Value.ToString();

                Forms.Chitiethoadon cthd = new Forms.Chitiethoadon(maHD);
                Functions.Navigate(this, cthd);
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
