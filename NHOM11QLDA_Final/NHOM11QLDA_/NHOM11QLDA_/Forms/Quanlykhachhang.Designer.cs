namespace NHOM11QLDA_.Forms
{
    partial class Thongtinkhachhang
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
            this.dataGridView_khachhang = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.lbltenkhachhang = new System.Windows.Forms.Label();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.mnubaocaodoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaotansuat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_khachhang
            // 
            this.dataGridView_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_khachhang.Location = new System.Drawing.Point(128, 174);
            this.dataGridView_khachhang.Name = "dataGridView_khachhang";
            this.dataGridView_khachhang.RowHeadersWidth = 62;
            this.dataGridView_khachhang.RowTemplate.Height = 28;
            this.dataGridView_khachhang.Size = new System.Drawing.Size(1212, 420);
            this.dataGridView_khachhang.TabIndex = 2;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(476, 123);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(104, 32);
            this.btntimkiem.TabIndex = 12;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // lbltenkhachhang
            // 
            this.lbltenkhachhang.AutoSize = true;
            this.lbltenkhachhang.Location = new System.Drawing.Point(124, 126);
            this.lbltenkhachhang.Name = "lbltenkhachhang";
            this.lbltenkhachhang.Size = new System.Drawing.Size(123, 20);
            this.lbltenkhachhang.TabIndex = 8;
            this.lbltenkhachhang.Text = "Tên khách hàng";
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(272, 123);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(172, 26);
            this.txttenkhachhang.TabIndex = 4;
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
            this.menuStrip1.Size = new System.Drawing.Size(1557, 34);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
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
            // mnuPhong
            // 
            this.mnuPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPhong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuPhong.Name = "mnuPhong";
            this.mnuPhong.Size = new System.Drawing.Size(196, 30);
            this.mnuPhong.Text = "Thông tin phòng";
            this.mnuPhong.Click += new System.EventHandler(this.mnuPhong_Click);
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
            // mnuNhanvien
            // 
            this.mnuNhanvien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuNhanvien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(131, 30);
            this.mnuNhanvien.Text = "Nhân viên";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click);
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
//            this.mnuBaocao.Click += new System.EventHandler(this.mnuBaocao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 36);
            this.label1.TabIndex = 74;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
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
            // Thongtinkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1557, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.lbltenkhachhang);
            this.Controls.Add(this.txttenkhachhang);
            this.Controls.Add(this.dataGridView_khachhang);
            this.Name = "Thongtinkhachhang";
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.Thongtinkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachhang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_khachhang;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label lbltenkhachhang;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTrangchu;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaodoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaotansuat;
    }
}