using NHOM11QLDA_.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM11QLDA_.Forms
{
    public partial class CTNhanvien : Form
    {
        //Luồng Thêm mới
        public CTNhanvien(string newmanv)
        {
            InitializeComponent();
            Functions.FillCombo("Select TenCV from Chucvu", cbochucvu, "TenCV");
            cbochucvu.SelectedIndex = -1;
            txtmanhanvien.Text = newmanv;
            txtmanhanvien.Enabled = false;
            btnluusua.Hide();
            btnsua.Hide();
            btnxoa.Hide();
        }
        private void btnluuthem_Click(object sender, EventArgs e)
        {
            if (txttennhanvien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhanvien.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (msksodienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập SDT nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msksodienthoai.Focus();
                return;
            }
            if (cbochucvu.Text == "")
            {
                MessageBox.Show("Bạn phải chọn chức vụ cho nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql;
            string sdt = Regex.Replace(msksodienthoai.Text, "[^0-9]", "");
            string cv = Functions.GetFieldValue("select MaCV from Chucvu where TenCV=N'" + cbochucvu.Text + "'");
            sql = "insert into Nhanvien(MaNV, TenNV, SDT, Diachi, MaCV) values('" + txtmanhanvien.Text + "', N'" + txttennhanvien.Text + "', '" + sdt + "', N'" + txtdiachi.Text + "', '" + cv + "')";
            Functions.RunSql(sql);
            Resetvalues();
            Forms.Thongtinnhanvien nv = new Forms.Thongtinnhanvien();
            Functions.Navigate(this, nv);
        }

        //Luồng Sửa, Xóa
        public CTNhanvien(string manv, string tennv, string sdt, string diachi, string tencv)
        {
            InitializeComponent();
            Functions.FillCombo("Select TenCV from Chucvu", cbochucvu, "TenCV");
            cbochucvu.SelectedIndex = -1;
            txtmanhanvien.Text = manv;
            txttennhanvien.Text=tennv;
            msksodienthoai.Text = sdt;
            txtdiachi.Text = diachi;
            cbochucvu.Text = tencv;
            txtmanhanvien.Enabled = false;
            txttennhanvien.Enabled = false;
            msksodienthoai.Enabled = false;
            txtdiachi.Enabled = false;
            cbochucvu.Enabled = false;
            btnluusua.Enabled = false;
            btnluuthem.Hide();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txttennhanvien.Enabled = true;
            msksodienthoai.Enabled = true;
            txtdiachi.Enabled = true;
            cbochucvu.Enabled = true;
            txttennhanvien.Focus();
            btnsua.Enabled = false;
            btnluusua.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txttennhanvien.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhanvien.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (msksodienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập SDT nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msksodienthoai.Focus();
                return;
            }
            string sql;
            string sdt = Regex.Replace(msksodienthoai.Text, "[^0-9]", "");
            string cv = Functions.GetFieldValue("select MaCV from Chucvu where TenCV=N'" + cbochucvu.Text + "'");
            sql = "update Nhanvien set TenNV=N'" + txttennhanvien.Text + "', SDT='" + sdt + "', Diachi=N'" + txtdiachi.Text + "', MaCV='" + cv + "'" +
                "where MaNV='"+txtmanhanvien.Text+"'";
            Functions.RunSql(sql);
            btnluusua.Enabled = false;
            btnsua.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa thông tin nhân viên này không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = "delete from Nhanvien where MaNV='" + txtmanhanvien.Text + "'";
                Functions.RunSql(sql);

                Forms.Thongtinnhanvien nv = new Forms.Thongtinnhanvien();
                Functions.Navigate(this, nv);
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            Resetvalues();
            Forms.Thongtinnhanvien nv = new Forms.Thongtinnhanvien();
            Functions.Navigate(this, nv);
        }
        private void Resetvalues()
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            msksodienthoai.Text = "";
            txtdiachi.Text = "";
            cbochucvu.Text = "";
        }
    }
}
