namespace NHOM11QLDA_.Forms
{
    partial class Thongtinnhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView_nhanvien = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaodoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaotansuat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltennhanhvien = new System.Windows.Forms.Label();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(1234, 214);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(139, 40);
            this.btnthem.TabIndex = 28;
            this.btnthem.Text = "Thêm nhân viên";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridView_nhanvien
            // 
            this.dataGridView_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhanvien.Location = new System.Drawing.Point(161, 260);
            this.dataGridView_nhanvien.Name = "dataGridView_nhanvien";
            this.dataGridView_nhanvien.RowHeadersWidth = 62;
            this.dataGridView_nhanvien.RowTemplate.Height = 28;
            this.dataGridView_nhanvien.Size = new System.Drawing.Size(1212, 319);
            this.dataGridView_nhanvien.TabIndex = 19;
            this.dataGridView_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_nhanvien_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrangchu,
            this.mnuPhong,
            this.mnuHoadon,
            this.mnuNhanvien,
            this.mnuKhachhang,
            this.mnuBaocao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1557, 36);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTrangchu
            // 
            this.mnuTrangchu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTrangchu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuTrangchu.Name = "mnuTrangchu";
            this.mnuTrangchu.Size = new System.Drawing.Size(132, 32);
            this.mnuTrangchu.Text = "Trang chủ";
            this.mnuTrangchu.Click += new System.EventHandler(this.mnuTrangchu_Click);
            // 
            // mnuPhong
            // 
            this.mnuPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPhong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuPhong.Name = "mnuPhong";
            this.mnuPhong.Size = new System.Drawing.Size(196, 32);
            this.mnuPhong.Text = "Thông tin phòng";
            this.mnuPhong.Click += new System.EventHandler(this.mnuPhong_Click);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHoadon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(116, 32);
            this.mnuHoadon.Text = "Hóa đơn";
            this.mnuHoadon.Click += new System.EventHandler(this.mnuHoadon_Click);
            // 
            // mnuNhanvien
            // 
            this.mnuNhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNhanvien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(131, 32);
            this.mnuNhanvien.Text = "Nhân viên";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuKhachhang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(152, 32);
            this.mnuKhachhang.Text = "Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubaocaodoanhthu,
            this.mnubaocaotansuat});
            this.mnuBaocao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBaocao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(109, 32);
            this.mnuBaocao.Text = "Báo cáo";
            // 
            // mnubaocaodoanhthu
            // 
            this.mnubaocaodoanhthu.Name = "mnubaocaodoanhthu";
            this.mnubaocaodoanhthu.Size = new System.Drawing.Size(368, 34);
            this.mnubaocaodoanhthu.Text = "Báo cáo doanh thu";
            this.mnubaocaodoanhthu.Click += new System.EventHandler(this.mnubaocaodoanhthu_Click);
            // 
            // mnubaocaotansuat
            // 
            this.mnubaocaotansuat.Name = "mnubaocaotansuat";
            this.mnubaocaotansuat.Size = new System.Drawing.Size(368, 34);
            this.mnubaocaotansuat.Text = "Báo cáo tần suất sử dụng";
            this.mnubaocaotansuat.Click += new System.EventHandler(this.mnubaocaotansuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 75;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // lbltennhanhvien
            // 
            this.lbltennhanhvien.AutoSize = true;
            this.lbltennhanhvien.Location = new System.Drawing.Point(157, 224);
            this.lbltennhanhvien.Name = "lbltennhanhvien";
            this.lbltennhanhvien.Size = new System.Drawing.Size(108, 20);
            this.lbltennhanhvien.TabIndex = 83;
            this.lbltennhanhvien.Text = "Tên nhân viên";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(271, 218);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(172, 26);
            this.txttennhanvien.TabIndex = 82;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(459, 204);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(139, 40);
            this.btntimkiem.TabIndex = 84;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // Thongtinnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 671);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.lbltennhanhvien);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView_nhanvien);
            this.Name = "Thongtinnhanvien";
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.Thongtinnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView_nhanvien;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTrangchu;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltennhanhvien;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaodoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaotansuat;
    }
}