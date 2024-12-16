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
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
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
        private void mnubaocaodoanhthu_Click(object sender, EventArgs e)
        {
            Forms.Baocaodoanhthu baocaodt = new Forms.Baocaodoanhthu();
            Functions.Navigate(this, baocaodt);
        }

        private void mnubaocaotansuat_Click(object sender, EventArgs e)
        {
            Forms.Baocaotansuatsudungphong  baocaots = new Forms.Baocaotansuatsudungphong();
            Functions.Navigate(this, baocaots);
        }
    }
}
