namespace NHOM11QLDA_.Forms
{
    partial class Baocaotansuatsudungphong
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
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblbaocaodoanhthu = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mskden = new System.Windows.Forms.MaskedTextBox();
            this.lblden = new System.Windows.Forms.Label();
            this.msktheongay = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msktu = new System.Windows.Forms.MaskedTextBox();
            this.tbltu = new System.Windows.Forms.Label();
            this.btnxuatbaocao = new System.Windows.Forms.Button();
            this.rdotheongay = new System.Windows.Forms.RadioButton();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.rdotheokhoangthoigian = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mnubaocaodoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaotansuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubaocaodoanhthu,
            this.mnubaocaotansuat});
            this.mnuBaocao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBaocao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(109, 30);
            this.mnuBaocao.Text = "Báo cáo";
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuKhachhang.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(152, 30);
            this.mnuKhachhang.Text = "Khách hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuNhanvien
            // 
            this.mnuNhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNhanvien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(131, 30);
            this.mnuNhanvien.Text = "Nhân viên";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHoadon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(116, 30);
            this.mnuHoadon.Text = "Hóa đơn";
            this.mnuHoadon.Click += new System.EventHandler(this.mnuHoadon_Click);
            // 
            // mnuPhong
            // 
            this.mnuPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPhong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuPhong.Name = "mnuPhong";
            this.mnuPhong.Size = new System.Drawing.Size(196, 30);
            this.mnuPhong.Text = "Thông tin phòng";
            this.mnuPhong.Click += new System.EventHandler(this.mnuPhong_Click);
            // 
            // mnuTrangchu
            // 
            this.mnuTrangchu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTrangchu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuTrangchu.Name = "mnuTrangchu";
            this.mnuTrangchu.Size = new System.Drawing.Size(132, 30);
            this.mnuTrangchu.Text = "Trang chủ";
            this.mnuTrangchu.Click += new System.EventHandler(this.mnuTrangchu_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1371, 34);
            this.menuStrip1.TabIndex = 83;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblbaocaodoanhthu
            // 
            this.lblbaocaodoanhthu.AutoSize = true;
            this.lblbaocaodoanhthu.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaocaodoanhthu.Location = new System.Drawing.Point(417, 68);
            this.lblbaocaodoanhthu.Name = "lblbaocaodoanhthu";
            this.lblbaocaodoanhthu.Size = new System.Drawing.Size(607, 36);
            this.lblbaocaodoanhthu.TabIndex = 76;
            this.lblbaocaodoanhthu.Text = "BÁO CÁO TẦN SUẤT SỬ DỤNG PHÒNG";
            // 
            // mskden
            // 
            this.mskden.Location = new System.Drawing.Point(242, 8);
            this.mskden.Mask = "00/00/0000";
            this.mskden.Name = "mskden";
            this.mskden.Size = new System.Drawing.Size(100, 26);
            this.mskden.TabIndex = 13;
            this.mskden.ValidatingType = typeof(System.DateTime);
            // 
            // lblden
            // 
            this.lblden.AutoSize = true;
            this.lblden.Location = new System.Drawing.Point(183, 10);
            this.lblden.Name = "lblden";
            this.lblden.Size = new System.Drawing.Size(39, 20);
            this.lblden.TabIndex = 3;
            this.lblden.Text = "Đến";
            // 
            // msktheongay
            // 
            this.msktheongay.Location = new System.Drawing.Point(486, 134);
            this.msktheongay.Mask = "00/00/0000";
            this.msktheongay.Name = "msktheongay";
            this.msktheongay.Size = new System.Drawing.Size(64, 26);
            this.msktheongay.TabIndex = 82;
            this.msktheongay.ValidatingType = typeof(System.DateTime);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mskden);
            this.panel2.Controls.Add(this.msktu);
            this.panel2.Controls.Add(this.tbltu);
            this.panel2.Controls.Add(this.lblden);
            this.panel2.Location = new System.Drawing.Point(486, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 39);
            this.panel2.TabIndex = 79;
            // 
            // msktu
            // 
            this.msktu.Location = new System.Drawing.Point(58, 9);
            this.msktu.Mask = "00/00/0000";
            this.msktu.Name = "msktu";
            this.msktu.Size = new System.Drawing.Size(100, 26);
            this.msktu.TabIndex = 14;
            this.msktu.ValidatingType = typeof(System.DateTime);
            // 
            // tbltu
            // 
            this.tbltu.AutoSize = true;
            this.tbltu.Location = new System.Drawing.Point(15, 12);
            this.tbltu.Name = "tbltu";
            this.tbltu.Size = new System.Drawing.Size(27, 20);
            this.tbltu.TabIndex = 4;
            this.tbltu.Text = "Từ";
            // 
            // btnxuatbaocao
            // 
            this.btnxuatbaocao.Location = new System.Drawing.Point(1220, 628);
            this.btnxuatbaocao.Name = "btnxuatbaocao";
            this.btnxuatbaocao.Size = new System.Drawing.Size(123, 36);
            this.btnxuatbaocao.TabIndex = 77;
            this.btnxuatbaocao.Text = "Xuất báo cáo";
            this.btnxuatbaocao.UseVisualStyleBackColor = true;
            this.btnxuatbaocao.Click += new System.EventHandler(this.btnxuatbaocao_Click);
            // 
            // rdotheongay
            // 
            this.rdotheongay.AutoSize = true;
            this.rdotheongay.Location = new System.Drawing.Point(231, 136);
            this.rdotheongay.Name = "rdotheongay";
            this.rdotheongay.Size = new System.Drawing.Size(108, 24);
            this.rdotheongay.TabIndex = 80;
            this.rdotheongay.TabStop = true;
            this.rdotheongay.Text = "Theo ngày";
            this.rdotheongay.UseVisualStyleBackColor = true;
            this.rdotheongay.CheckedChanged += new System.EventHandler(this.rdotheongay_CheckedChanged);
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(1039, 628);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(115, 36);
            this.btnhienthi.TabIndex = 78;
            this.btnhienthi.Text = "Hiển thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // rdotheokhoangthoigian
            // 
            this.rdotheokhoangthoigian.AutoSize = true;
            this.rdotheokhoangthoigian.Location = new System.Drawing.Point(231, 192);
            this.rdotheokhoangthoigian.Name = "rdotheokhoangthoigian";
            this.rdotheokhoangthoigian.Size = new System.Drawing.Size(191, 24);
            this.rdotheokhoangthoigian.TabIndex = 81;
            this.rdotheokhoangthoigian.TabStop = true;
            this.rdotheokhoangthoigian.Text = "Theo khoảng thời gian";
            this.rdotheokhoangthoigian.UseVisualStyleBackColor = true;
            this.rdotheokhoangthoigian.CheckedChanged += new System.EventHandler(this.rdotheokhoangthoigian_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 389);
            this.dataGridView1.TabIndex = 84;
            // 
            // mnubaocaodoanhthu
            // 
            this.mnubaocaodoanhthu.Name = "mnubaocaodoanhthu";
            this.mnubaocaodoanhthu.Size = new System.Drawing.Size(437, 34);
            this.mnubaocaodoanhthu.Text = "Báo cáo doanh thu";
            this.mnubaocaodoanhthu.Click += new System.EventHandler(this.mnubaocaodoanhthu_Click);
            // 
            // mnubaocaotansuat
            // 
            this.mnubaocaotansuat.Name = "mnubaocaotansuat";
            this.mnubaocaotansuat.Size = new System.Drawing.Size(437, 34);
            this.mnubaocaotansuat.Text = "Báo cáo tần suất sử dụng phòng";
            this.mnubaocaotansuat.Click += new System.EventHandler(this.mnubaocaotansuat_Click);
            // 
            // Baocaotansuatsudungphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 686);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblbaocaodoanhthu);
            this.Controls.Add(this.msktheongay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnxuatbaocao);
            this.Controls.Add(this.rdotheongay);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.rdotheokhoangthoigian);
            this.Name = "Baocaotansuatsudungphong";
            this.Text = "Baocaotansuatsudungphong";
            this.Load += new System.EventHandler(this.Baocaotansuatsudungphong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuTrangchu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblbaocaodoanhthu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox mskden;
        private System.Windows.Forms.Label lblden;
        private System.Windows.Forms.MaskedTextBox msktheongay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox msktu;
        private System.Windows.Forms.Label tbltu;
        private System.Windows.Forms.Button btnxuatbaocao;
        private System.Windows.Forms.RadioButton rdotheongay;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.RadioButton rdotheokhoangthoigian;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaodoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaotansuat;
    }
}