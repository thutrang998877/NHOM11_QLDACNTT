namespace NHOM11QLDA_.Forms
{
    partial class CTNhanvien
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
            this.cbochucvu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblchucvu = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluusua = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.msksodienthoai = new System.Windows.Forms.MaskedTextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblsodienthoai = new System.Windows.Forms.Label();
            this.lbltennhanhvien = new System.Windows.Forms.Label();
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.btnluuthem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbochucvu
            // 
            this.cbochucvu.FormattingEnabled = true;
            this.cbochucvu.Location = new System.Drawing.Point(446, 292);
            this.cbochucvu.Name = "cbochucvu";
            this.cbochucvu.Size = new System.Drawing.Size(172, 28);
            this.cbochucvu.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 36);
            this.label1.TabIndex = 90;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // lblchucvu
            // 
            this.lblchucvu.AutoSize = true;
            this.lblchucvu.Location = new System.Drawing.Point(332, 300);
            this.lblchucvu.Name = "lblchucvu";
            this.lblchucvu.Size = new System.Drawing.Size(66, 20);
            this.lblchucvu.TabIndex = 89;
            this.lblchucvu.Text = "Chức vụ";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(449, 393);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 40);
            this.btnsua.TabIndex = 88;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(622, 393);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(104, 40);
            this.btnxoa.TabIndex = 87;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluusua
            // 
            this.btnluusua.Location = new System.Drawing.Point(782, 393);
            this.btnluusua.Name = "btnluusua";
            this.btnluusua.Size = new System.Drawing.Size(104, 40);
            this.btnluusua.TabIndex = 86;
            this.btnluusua.Text = "Lưu";
            this.btnluusua.UseVisualStyleBackColor = true;
            this.btnluusua.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(941, 393);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(104, 40);
            this.btnboqua.TabIndex = 85;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // msksodienthoai
            // 
            this.msksodienthoai.Location = new System.Drawing.Point(890, 183);
            this.msksodienthoai.Mask = "(999) 000-0000";
            this.msksodienthoai.Name = "msksodienthoai";
            this.msksodienthoai.Size = new System.Drawing.Size(172, 26);
            this.msksodienthoai.TabIndex = 84;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(773, 246);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(57, 20);
            this.lbldiachi.TabIndex = 83;
            this.lbldiachi.Text = "Địa chỉ";
            // 
            // lblsodienthoai
            // 
            this.lblsodienthoai.AutoSize = true;
            this.lblsodienthoai.Location = new System.Drawing.Point(773, 186);
            this.lblsodienthoai.Name = "lblsodienthoai";
            this.lblsodienthoai.Size = new System.Drawing.Size(102, 20);
            this.lblsodienthoai.TabIndex = 82;
            this.lblsodienthoai.Text = "Số điện thoại";
            // 
            // lbltennhanhvien
            // 
            this.lbltennhanhvien.AutoSize = true;
            this.lbltennhanhvien.Location = new System.Drawing.Point(332, 246);
            this.lbltennhanhvien.Name = "lbltennhanhvien";
            this.lbltennhanhvien.Size = new System.Drawing.Size(108, 20);
            this.lbltennhanhvien.TabIndex = 81;
            this.lbltennhanhvien.Text = "Tên nhân viên";
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Location = new System.Drawing.Point(332, 186);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(103, 20);
            this.lblmanhanvien.TabIndex = 80;
            this.lblmanhanvien.Text = "Mã nhân viên";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(890, 240);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(172, 26);
            this.txtdiachi.TabIndex = 79;
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(446, 240);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(172, 26);
            this.txttennhanvien.TabIndex = 78;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(446, 180);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(172, 26);
            this.txtmanhanvien.TabIndex = 77;
            // 
            // btnluuthem
            // 
            this.btnluuthem.Location = new System.Drawing.Point(782, 393);
            this.btnluuthem.Name = "btnluuthem";
            this.btnluuthem.Size = new System.Drawing.Size(104, 40);
            this.btnluuthem.TabIndex = 92;
            this.btnluuthem.Text = "Lưu";
            this.btnluuthem.UseVisualStyleBackColor = true;
            this.btnluuthem.Click += new System.EventHandler(this.btnluuthem_Click);
            // 
            // CTNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 643);
            this.Controls.Add(this.btnluuthem);
            this.Controls.Add(this.cbochucvu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblchucvu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluusua);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.msksodienthoai);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lblsodienthoai);
            this.Controls.Add(this.lbltennhanhvien);
            this.Controls.Add(this.lblmanhanvien);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.txtmanhanvien);
            this.Name = "CTNhanvien";
            this.Text = "CTNhanvien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbochucvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblchucvu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluusua;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.MaskedTextBox msksodienthoai;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblsodienthoai;
        private System.Windows.Forms.Label lbltennhanhvien;
        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Button btnluuthem;
    }
}