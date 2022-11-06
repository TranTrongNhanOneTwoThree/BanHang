namespace MasterForm
{
    partial class FormSanPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_LoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MaSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_GiaSanPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.textBox_ThongTinSanPham = new System.Windows.Forms.TextBox();
            this.label_ThongTinSanPham = new System.Windows.Forms.Label();
            this.button_ThemSanPham = new System.Windows.Forms.Button();
            this.label_SanPhamMoi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox_LoaiSanPham);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_TenSanPham);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_MaSanPham);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_GiaSanPham);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox_SoLuong);
            this.panel2.Controls.Add(this.textBox_ThongTinSanPham);
            this.panel2.Controls.Add(this.label_ThongTinSanPham);
            this.panel2.Controls.Add(this.button_ThemSanPham);
            this.panel2.Controls.Add(this.label_SanPhamMoi);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(340, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 613);
            this.panel2.TabIndex = 3;
            // 
            // btn_Exit
            // 
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 24;
            this.btn_Exit.Location = new System.Drawing.Point(473, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 25);
            this.btn_Exit.TabIndex = 43;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Loại Sản Phẩm";
            // 
            // comboBox_LoaiSanPham
            // 
            this.comboBox_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LoaiSanPham.FormattingEnabled = true;
            this.comboBox_LoaiSanPham.Location = new System.Drawing.Point(271, 193);
            this.comboBox_LoaiSanPham.Name = "comboBox_LoaiSanPham";
            this.comboBox_LoaiSanPham.Size = new System.Drawing.Size(203, 36);
            this.comboBox_LoaiSanPham.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tên Sản Phẩm";
            // 
            // textBox_TenSanPham
            // 
            this.textBox_TenSanPham.BackColor = System.Drawing.Color.White;
            this.textBox_TenSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenSanPham.ForeColor = System.Drawing.Color.Gray;
            this.textBox_TenSanPham.Location = new System.Drawing.Point(271, 105);
            this.textBox_TenSanPham.Name = "textBox_TenSanPham";
            this.textBox_TenSanPham.Size = new System.Drawing.Size(203, 34);
            this.textBox_TenSanPham.TabIndex = 1;
            this.textBox_TenSanPham.Text = "Thêm Tên Sản Phẩm";
            this.textBox_TenSanPham.Enter += new System.EventHandler(this.textBox_TenSanPham_Enter);
            this.textBox_TenSanPham.Leave += new System.EventHandler(this.textBox_TenSanPham_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // textBox_MaSanPham
            // 
            this.textBox_MaSanPham.BackColor = System.Drawing.Color.White;
            this.textBox_MaSanPham.Enabled = false;
            this.textBox_MaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaSanPham.Location = new System.Drawing.Point(38, 105);
            this.textBox_MaSanPham.Name = "textBox_MaSanPham";
            this.textBox_MaSanPham.Size = new System.Drawing.Size(203, 34);
            this.textBox_MaSanPham.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Giá Sản Phẩm";
            // 
            // textBox_GiaSanPham
            // 
            this.textBox_GiaSanPham.BackColor = System.Drawing.Color.White;
            this.textBox_GiaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GiaSanPham.ForeColor = System.Drawing.Color.Gray;
            this.textBox_GiaSanPham.Location = new System.Drawing.Point(38, 192);
            this.textBox_GiaSanPham.Name = "textBox_GiaSanPham";
            this.textBox_GiaSanPham.Size = new System.Drawing.Size(203, 34);
            this.textBox_GiaSanPham.TabIndex = 0;
            this.textBox_GiaSanPham.Text = "Thêm Giá Sản Phẩm";
            this.textBox_GiaSanPham.Enter += new System.EventHandler(this.textBox_GiaSanPham_Enter);
            this.textBox_GiaSanPham.Leave += new System.EventHandler(this.textBox_GiaSanPham_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Số Lượng";
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.BackColor = System.Drawing.Color.White;
            this.textBox_SoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoLuong.ForeColor = System.Drawing.Color.Gray;
            this.textBox_SoLuong.Location = new System.Drawing.Point(38, 276);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(203, 34);
            this.textBox_SoLuong.TabIndex = 0;
            this.textBox_SoLuong.Text = "Thêm Số Lượng";
            this.textBox_SoLuong.Enter += new System.EventHandler(this.textBox_SoLuong_Enter);
            this.textBox_SoLuong.Leave += new System.EventHandler(this.textBox_SoLuong_Leave);
            // 
            // textBox_ThongTinSanPham
            // 
            this.textBox_ThongTinSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ThongTinSanPham.ForeColor = System.Drawing.Color.Gray;
            this.textBox_ThongTinSanPham.Location = new System.Drawing.Point(38, 371);
            this.textBox_ThongTinSanPham.Multiline = true;
            this.textBox_ThongTinSanPham.Name = "textBox_ThongTinSanPham";
            this.textBox_ThongTinSanPham.Size = new System.Drawing.Size(436, 126);
            this.textBox_ThongTinSanPham.TabIndex = 14;
            this.textBox_ThongTinSanPham.Text = "Thêm Thông Tin Sản Phẩm";
            this.textBox_ThongTinSanPham.TextChanged += new System.EventHandler(this.textBox_ThongTinSanPham_TextChanged);
            this.textBox_ThongTinSanPham.Enter += new System.EventHandler(this.textBox_ThongTinSanPham_Enter);
            this.textBox_ThongTinSanPham.Leave += new System.EventHandler(this.textBox_ThongTinSanPham_Leave);
            // 
            // label_ThongTinSanPham
            // 
            this.label_ThongTinSanPham.AutoSize = true;
            this.label_ThongTinSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinSanPham.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_ThongTinSanPham.Location = new System.Drawing.Point(34, 345);
            this.label_ThongTinSanPham.Name = "label_ThongTinSanPham";
            this.label_ThongTinSanPham.Size = new System.Drawing.Size(200, 23);
            this.label_ThongTinSanPham.TabIndex = 13;
            this.label_ThongTinSanPham.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // button_ThemSanPham
            // 
            this.button_ThemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_ThemSanPham.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemSanPham.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ThemSanPham.Location = new System.Drawing.Point(38, 527);
            this.button_ThemSanPham.Name = "button_ThemSanPham";
            this.button_ThemSanPham.Size = new System.Drawing.Size(436, 45);
            this.button_ThemSanPham.TabIndex = 9;
            this.button_ThemSanPham.Text = "THÊM SẢN PHẨM";
            this.button_ThemSanPham.UseVisualStyleBackColor = false;
            // 
            // label_SanPhamMoi
            // 
            this.label_SanPhamMoi.AutoSize = true;
            this.label_SanPhamMoi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SanPhamMoi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_SanPhamMoi.Location = new System.Drawing.Point(147, 18);
            this.label_SanPhamMoi.Name = "label_SanPhamMoi";
            this.label_SanPhamMoi.Size = new System.Drawing.Size(208, 35);
            this.label_SanPhamMoi.TabIndex = 0;
            this.label_SanPhamMoi.Text = "SẢN PHẨM MỚI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 610);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSanPham";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ThemSanPham;
        private System.Windows.Forms.TextBox textBox_GiaSanPham;
        private System.Windows.Forms.Label label_SanPhamMoi;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.TextBox textBox_MaSanPham;
        private System.Windows.Forms.TextBox textBox_ThongTinSanPham;
        private System.Windows.Forms.Label label_ThongTinSanPham;
        private System.Windows.Forms.ComboBox comboBox_LoaiSanPham;
        private System.Windows.Forms.TextBox textBox_TenSanPham;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_Exit;
    }
}