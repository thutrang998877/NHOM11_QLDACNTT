namespace NHOM11QLDA_.Forms
{
    partial class Trangchu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaodoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubaocaotansuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 38;
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
            // 
            // mnubaocaodoanhthu
            // 
            this.mnubaocaodoanhthu.Name = "mnubaocaodoanhthu";
            this.mnubaocaodoanhthu.Size = new System.Drawing.Size(374, 34);
            this.mnubaocaodoanhthu.Text = "Báo cáo doanh thu";
            this.mnubaocaodoanhthu.Click += new System.EventHandler(this.mnubaocaodoanhthu_Click);
            // 
            // mnubaocaotansuat
            // 
            this.mnubaocaotansuat.Name = "mnubaocaotansuat";
            this.mnubaocaotansuat.Size = new System.Drawing.Size(374, 34);
            this.mnubaocaotansuat.Text = "Báo cáo tần suất sử dụng ";
            this.mnubaocaotansuat.Click += new System.EventHandler(this.mnubaocaotansuat_Click);
            // 
            // Trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NHOM11QLDA_.Properties.Resources.choidii_club_resized;
            this.ClientSize = new System.Drawing.Size(1557, 671);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Trangchu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Trangchu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTrangchu;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaodoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnubaocaotansuat;
    }
}