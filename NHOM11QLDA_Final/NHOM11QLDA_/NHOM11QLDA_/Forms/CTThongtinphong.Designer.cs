namespace NHOM11QLDA_.Forms
{
    partial class CTThongtinphong
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboloaiphong = new System.Windows.Forms.ComboBox();
            this.lbldongiatheogio = new System.Windows.Forms.Label();
            this.lbltenphong = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.lblloaiphong = new System.Windows.Forms.Label();
            this.lblmaphong = new System.Windows.Forms.Label();
            this.txtdongiatheogio = new System.Windows.Forms.TextBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView_thongtinphong = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongtinphong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 36);
            this.label1.TabIndex = 72;
            this.label1.Text = "CẬP NHẬT THÔNG TIN PHÒNG";
            // 
            // cboloaiphong
            // 
            this.cboloaiphong.FormattingEnabled = true;
            this.cboloaiphong.Location = new System.Drawing.Point(814, 172);
            this.cboloaiphong.Name = "cboloaiphong";
            this.cboloaiphong.Size = new System.Drawing.Size(172, 28);
            this.cboloaiphong.TabIndex = 71;
            this.cboloaiphong.SelectedIndexChanged += new System.EventHandler(this.cboloaiphong_SelectedIndexChanged);
            // 
            // lbldongiatheogio
            // 
            this.lbldongiatheogio.AutoSize = true;
            this.lbldongiatheogio.Location = new System.Drawing.Point(663, 236);
            this.lbldongiatheogio.Name = "lbldongiatheogio";
            this.lbldongiatheogio.Size = new System.Drawing.Size(125, 20);
            this.lbldongiatheogio.TabIndex = 68;
            this.lbldongiatheogio.Text = "Đơn giá theo giờ";
            // 
            // lbltenphong
            // 
            this.lbltenphong.AutoSize = true;
            this.lbltenphong.Location = new System.Drawing.Point(222, 236);
            this.lbltenphong.Name = "lbltenphong";
            this.lbltenphong.Size = new System.Drawing.Size(85, 20);
            this.lbltenphong.TabIndex = 70;
            this.lbltenphong.Text = "Tên phòng";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(336, 230);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(172, 26);
            this.txttenphong.TabIndex = 69;
            // 
            // lblloaiphong
            // 
            this.lblloaiphong.AutoSize = true;
            this.lblloaiphong.Location = new System.Drawing.Point(663, 177);
            this.lblloaiphong.Name = "lblloaiphong";
            this.lblloaiphong.Size = new System.Drawing.Size(88, 20);
            this.lblloaiphong.TabIndex = 66;
            this.lblloaiphong.Text = "Loại phòng";
            // 
            // lblmaphong
            // 
            this.lblmaphong.AutoSize = true;
            this.lblmaphong.Location = new System.Drawing.Point(222, 180);
            this.lblmaphong.Name = "lblmaphong";
            this.lblmaphong.Size = new System.Drawing.Size(80, 20);
            this.lblmaphong.TabIndex = 65;
            this.lblmaphong.Text = "Mã phòng";
            // 
            // txtdongiatheogio
            // 
            this.txtdongiatheogio.Location = new System.Drawing.Point(814, 233);
            this.txtdongiatheogio.Name = "txtdongiatheogio";
            this.txtdongiatheogio.Size = new System.Drawing.Size(172, 26);
            this.txtdongiatheogio.TabIndex = 64;
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(336, 174);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(172, 26);
            this.txtmaphong.TabIndex = 62;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(404, 535);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(104, 40);
            this.btnsua.TabIndex = 78;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(574, 535);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(104, 40);
            this.btnluu.TabIndex = 76;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(882, 535);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(104, 40);
            this.btnboqua.TabIndex = 75;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(226, 535);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 40);
            this.btnthem.TabIndex = 73;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dataGridView_thongtinphong
            // 
            this.dataGridView_thongtinphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thongtinphong.Location = new System.Drawing.Point(226, 280);
            this.dataGridView_thongtinphong.Name = "dataGridView_thongtinphong";
            this.dataGridView_thongtinphong.RowHeadersWidth = 62;
            this.dataGridView_thongtinphong.RowTemplate.Height = 28;
            this.dataGridView_thongtinphong.Size = new System.Drawing.Size(760, 237);
            this.dataGridView_thongtinphong.TabIndex = 80;
            this.dataGridView_thongtinphong.Click += new System.EventHandler(this.dataGridView_thongtinphong_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(731, 535);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(104, 40);
            this.btntimkiem.TabIndex = 81;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // CTThongtinphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 665);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dataGridView_thongtinphong);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboloaiphong);
            this.Controls.Add(this.lbldongiatheogio);
            this.Controls.Add(this.lbltenphong);
            this.Controls.Add(this.txttenphong);
            this.Controls.Add(this.lblloaiphong);
            this.Controls.Add(this.lblmaphong);
            this.Controls.Add(this.txtdongiatheogio);
            this.Controls.Add(this.txtmaphong);
            this.Name = "CTThongtinphong";
            this.Text = "CTThongtinphong";
            this.Load += new System.EventHandler(this.CTThongtinphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongtinphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboloaiphong;
        private System.Windows.Forms.Label lbldongiatheogio;
        private System.Windows.Forms.Label lbltenphong;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.Label lblloaiphong;
        private System.Windows.Forms.Label lblmaphong;
        private System.Windows.Forms.TextBox txtdongiatheogio;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView_thongtinphong;
        private System.Windows.Forms.Button btntimkiem;
    }
}