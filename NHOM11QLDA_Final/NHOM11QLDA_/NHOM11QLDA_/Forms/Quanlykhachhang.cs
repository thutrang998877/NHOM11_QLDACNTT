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
    public partial class Thongtinkhachhang : Form
    {
        public Thongtinkhachhang()
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
        private void Thongtinkhachhang_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
            Resetvalues();
        }
        DataTable tblkh;
        private void Load_DataGridView()
        {
            string sql;
            sql = "select MaKH, TenKH, SDT, Diachi from Khachhang";
            tblkh = Class.Functions.GetDataToTable(sql);
            dataGridView_khachhang.DataSource = tblkh;

            dataGridView_khachhang.Columns[0].HeaderText = "Mã Khách";
            dataGridView_khachhang.Columns[1].HeaderText = "Tên khách";
            dataGridView_khachhang.Columns[2].HeaderText = "Số điện thoại";
            dataGridView_khachhang.Columns[3].HeaderText = "Địa chỉ";
            dataGridView_khachhang.Columns[3].Width = 300;

            dataGridView_khachhang.AllowUserToAddRows = false;
            dataGridView_khachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void Resetvalues()
        {
            txttenkhachhang.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            string ten = txttenkhachhang.Text;
            if (txttenkhachhang.Text == "")
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sql = "select MaKH, TenKH, SDT, Diachi from Khachhang where TenKH=N'" + ten + "'";
                tblkh = Functions.GetDataToTable(sql);
            }
            if (tblkh.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                dataGridView_khachhang.DataSource = tblkh;
            Resetvalues();
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
