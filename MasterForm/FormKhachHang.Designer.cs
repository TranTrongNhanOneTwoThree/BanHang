namespace MasterForm
{
    partial class FormKhachHang
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
            this.label_ThongTinKhachHang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ThemKhachHang = new System.Windows.Forms.Button();
            this.textBox_MaKhachHang = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ThongTinKhachHang
            // 
            this.label_ThongTinKhachHang.AutoSize = true;
            this.label_ThongTinKhachHang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinKhachHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_ThongTinKhachHang.Location = new System.Drawing.Point(63, 23);
            this.label_ThongTinKhachHang.Name = "label_ThongTinKhachHang";
            this.label_ThongTinKhachHang.Size = new System.Drawing.Size(333, 35);
            this.label_ThongTinKhachHang.TabIndex = 15;
            this.label_ThongTinKhachHang.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label_ThongTinKhachHang.Click += new System.EventHandler(this.label_ThongTinKhachHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.label_ThongTinKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 79);
            this.panel1.TabIndex = 29;
            // 
            // btn_Exit
            // 
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 24;
            this.btn_Exit.Location = new System.Drawing.Point(437, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 25);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox_DiaChi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_SoDienThoai);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_ThemKhachHang);
            this.panel2.Controls.Add(this.textBox_MaKhachHang);
            this.panel2.Controls.Add(this.textBox_HoTen);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 554);
            this.panel2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Địa Chỉ";
            // 
            // textBox_DiaChi
            // 
            this.textBox_DiaChi.BackColor = System.Drawing.Color.White;
            this.textBox_DiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DiaChi.ForeColor = System.Drawing.Color.Gray;
            this.textBox_DiaChi.Location = new System.Drawing.Point(24, 246);
            this.textBox_DiaChi.Multiline = true;
            this.textBox_DiaChi.Name = "textBox_DiaChi";
            this.textBox_DiaChi.Size = new System.Drawing.Size(415, 161);
            this.textBox_DiaChi.TabIndex = 33;
            this.textBox_DiaChi.Text = "Thêm Địa Chỉ";
            this.textBox_DiaChi.Enter += new System.EventHandler(this.textBox_DiaChi_Enter);
            this.textBox_DiaChi.Leave += new System.EventHandler(this.textBox_DiaChi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Số Điện Thoại";
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.BackColor = System.Drawing.Color.White;
            this.textBox_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoDienThoai.ForeColor = System.Drawing.Color.Gray;
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(30, 150);
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(178, 34);
            this.textBox_SoDienThoai.TabIndex = 29;
            this.textBox_SoDienThoai.Text = "Thêm SĐT";
            this.textBox_SoDienThoai.Enter += new System.EventHandler(this.textBox_SoDienThoai_Enter);
            this.textBox_SoDienThoai.Leave += new System.EventHandler(this.textBox_SoDienThoai_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // button_ThemKhachHang
            // 
            this.button_ThemKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_ThemKhachHang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemKhachHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ThemKhachHang.Location = new System.Drawing.Point(24, 474);
            this.button_ThemKhachHang.Name = "button_ThemKhachHang";
            this.button_ThemKhachHang.Size = new System.Drawing.Size(415, 48);
            this.button_ThemKhachHang.TabIndex = 32;
            this.button_ThemKhachHang.Text = "THÊM KHÁCH HÀNG";
            this.button_ThemKhachHang.UseVisualStyleBackColor = false;
            // 
            // textBox_MaKhachHang
            // 
            this.textBox_MaKhachHang.BackColor = System.Drawing.Color.White;
            this.textBox_MaKhachHang.Enabled = false;
            this.textBox_MaKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaKhachHang.Location = new System.Drawing.Point(30, 64);
            this.textBox_MaKhachHang.Name = "textBox_MaKhachHang";
            this.textBox_MaKhachHang.Size = new System.Drawing.Size(178, 34);
            this.textBox_MaKhachHang.TabIndex = 30;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.BackColor = System.Drawing.Color.White;
            this.textBox_HoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HoTen.ForeColor = System.Drawing.Color.Gray;
            this.textBox_HoTen.Location = new System.Drawing.Point(254, 64);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(185, 34);
            this.textBox_HoTen.TabIndex = 31;
            this.textBox_HoTen.Text = "Thêm Họ Tên";
            this.textBox_HoTen.Enter += new System.EventHandler(this.textBox_HoTen_Enter);
            this.textBox_HoTen.Leave += new System.EventHandler(this.textBox_HoTen_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Họ Tên";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_ThongTinKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ThemKhachHang;
        private System.Windows.Forms.TextBox textBox_MaKhachHang;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_Exit;
    }
}