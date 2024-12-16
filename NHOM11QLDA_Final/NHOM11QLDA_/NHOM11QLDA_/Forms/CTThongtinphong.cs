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
    public partial class CTThongtinphong : Form
    {
        DataTable tblCTPhong;
        public CTThongtinphong()
        {
            InitializeComponent();
        }

        private void CTThongtinphong_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("Select distinct Tenloai from Loaiphong", cboloaiphong, "Tenloai");
            cboloaiphong.SelectedIndex = -1;

            txtmaphong.Enabled = false;
            txtdongiatheogio.Enabled = false;
            btnluu.Enabled = false;
            Load_DataGridView();
            Resetvalues();
        }

        private void Load_DataGridView()
        {
            string sql;
            sql = "select Maphong, Tenphong, Tenloai, Giathuetheogio " +
                "from Phong inner join Loaiphong on Phong.Maloai=Loaiphong.Maloai ";
            tblCTPhong = Class.Functions.GetDataToTable(sql);
            dataGridView_thongtinphong.DataSource = tblCTPhong;

            dataGridView_thongtinphong.Columns[0].HeaderText = "Mã phòng";
            dataGridView_thongtinphong.Columns[1].HeaderText = "Tên phòng";
            dataGridView_thongtinphong.Columns[2].HeaderText = "Loại phòng";
            dataGridView_thongtinphong.Columns[3].HeaderText = "Đơn giá thuê";

            dataGridView_thongtinphong.AllowUserToAddRows = false;
            dataGridView_thongtinphong.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView_thongtinphong_Click(object sender, EventArgs e)
        {
            txttenphong.Enabled = false;
            if (tblCTPhong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtmaphong.Text = dataGridView_thongtinphong.CurrentRow.Cells["Maphong"].Value.ToString();
            txttenphong.Text = dataGridView_thongtinphong.CurrentRow.Cells["Tenphong"].Value.ToString();
            cboloaiphong.Text = dataGridView_thongtinphong.CurrentRow.Cells["Tenloai"].Value.ToString();
            txtdongiatheogio.Text = dataGridView_thongtinphong.CurrentRow.Cells["Giathuetheogio"].Value.ToString();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            Resetvalues();
            Forms.Thongtinphong ttphong = new Forms.Thongtinphong();
            Class.Functions.Navigate(this, ttphong);
        }

        private void Resetvalues()
        {
            txtmaphong.Text = "";
            txttenphong.Text = "";
            cboloaiphong.Text = "";
            txtdongiatheogio.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btntimkiem.Enabled = false;
            string sql;
            string tenloai = cboloaiphong.Text;
            string maphong = txtmaphong.Text;
            sql = "update Phong set Maloai = (select Maloai from Loaiphong where Tenloai = N'" + tenloai + "')" +
                "where Maphong = N'" + maphong + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            Resetvalues();
        }

        private void cboloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql;
            string tenloai = cboloaiphong.Text;
            if (cboloaiphong.Text != "")
            {
                sql = "select Giathuetheogio from Loaiphong where Tenloai = N'" + tenloai + "'";
                tblCTPhong = Functions.GetDataToTable(sql);
                txtdongiatheogio.Text = tblCTPhong.Rows[0]["Giathuetheogio"].ToString();
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Resetvalues();
            //Mã phòng tự sinh
            string newMaphong = GenerateNewMaphong();
            txtmaphong.Text = newMaphong;
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btntimkiem.Enabled = false;
        }

        private string GenerateNewMaphong()
        {
            // Truy vấn để lấy danh sách mã phòng hiện có
            string sql = "SELECT Maphong FROM Phong";
            DataTable dt = Functions.GetDataToTable(sql);

            int maxIndex = 0;

            // Duyệt qua danh sách mã phòng để tìm số thứ tự lớn nhất
            foreach (DataRow row in dt.Rows)
            {
                string maphong = row["Maphong"].ToString();

                // Kiểm tra mã phòng có dạng "Pxx"
                if (maphong.StartsWith("P") && int.TryParse(maphong.Substring(1), out int index))
                {
                    if (index > maxIndex)
                    {
                        maxIndex = index;
                    }
                }
            }

            // Sinh mã phòng mới với số thứ tự tiếp theo
            int newIndex = maxIndex + 1;
            return "P" + newIndex.ToString("D2"); // Định dạng số có 2 chữ số (P01, P02, ...)
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            string trangthai = "Trống";
            string tenloai = cboloaiphong.Text;
            if (txttenphong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenphong.Focus();
                return;
            }
            if (cboloaiphong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sql = "insert into Phong(Maphong, Tenphong, Trangthai, Maloai) values (N'" + txtmaphong.Text + "', N'" + txttenphong.Text + "', " +
                "N'" + trangthai + "', (select Maloai from Loaiphong where Tenloai=N'" + tenloai + "'))";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            Resetvalues();
            btnthem.Enabled = true;
            btnluu.Enabled = false;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            cboloaiphong.Enabled = false;
            string sql;
            string ten = txttenphong.Text;
            if (txttenphong.Text == "")
            {
                MessageBox.Show("Hãy nhập điều kiện tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sql = "select Maphong, Tenphong, Tenloai, Giathuetheogio " +
                "from Phong inner join Loaiphong on Phong.Maloai=Loaiphong.Maloai " +
                "where Tenphong=N'"+ten+"'";
                tblCTPhong = Functions.GetDataToTable(sql);
            }
            if (tblCTPhong.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                dataGridView_thongtinphong.DataSource = tblCTPhong;
            Resetvalues();
        }
    }
}
