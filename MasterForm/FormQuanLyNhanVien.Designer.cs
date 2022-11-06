namespace MasterForm
{
    partial class FormQuanLyNhanVien
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
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.textBox_MaNV = new System.Windows.Forms.TextBox();
            this.button_ThemNhanVien = new System.Windows.Forms.Button();
            this.textBox_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label_ThongTinKhachHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.BackColor = System.Drawing.Color.White;
            this.textBox_HoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HoTen.ForeColor = System.Drawing.Color.Gray;
            this.textBox_HoTen.Location = new System.Drawing.Point(73, 66);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(306, 34);
            this.textBox_HoTen.TabIndex = 1;
            this.textBox_HoTen.Text = "Thêm Họ Tên";
            this.textBox_HoTen.Enter += new System.EventHandler(this.textBox_HoTen_Enter);
            this.textBox_HoTen.Leave += new System.EventHandler(this.textBox_HoTen_Leave);
            // 
            // textBox_MaNV
            // 
            this.textBox_MaNV.BackColor = System.Drawing.Color.White;
            this.textBox_MaNV.Enabled = false;
            this.textBox_MaNV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaNV.Location = new System.Drawing.Point(73, 169);
            this.textBox_MaNV.Name = "textBox_MaNV";
            this.textBox_MaNV.Size = new System.Drawing.Size(306, 32);
            this.textBox_MaNV.TabIndex = 0;
            // 
            // button_ThemNhanVien
            // 
            this.button_ThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.button_ThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemNhanVien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_ThemNhanVien.Location = new System.Drawing.Point(73, 470);
            this.button_ThemNhanVien.Name = "button_ThemNhanVien";
            this.button_ThemNhanVien.Size = new System.Drawing.Size(305, 48);
            this.button_ThemNhanVien.TabIndex = 18;
            this.button_ThemNhanVien.Text = "THÊM NHÂN VIÊN";
            this.button_ThemNhanVien.UseVisualStyleBackColor = false;
            // 
            // textBox_SoDienThoai
            // 
            this.textBox_SoDienThoai.BackColor = System.Drawing.Color.White;
            this.textBox_SoDienThoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoDienThoai.ForeColor = System.Drawing.Color.Gray;
            this.textBox_SoDienThoai.Location = new System.Drawing.Point(73, 370);
            this.textBox_SoDienThoai.Name = "textBox_SoDienThoai";
            this.textBox_SoDienThoai.Size = new System.Drawing.Size(306, 34);
            this.textBox_SoDienThoai.TabIndex = 0;
            this.textBox_SoDienThoai.Text = "Thêm SĐT";
            this.textBox_SoDienThoai.Enter += new System.EventHandler(this.textBox_SoDienThoai_Enter);
            this.textBox_SoDienThoai.Leave += new System.EventHandler(this.textBox_SoDienThoai_Leave);
            // 
            // label_ThongTinKhachHang
            // 
            this.label_ThongTinKhachHang.AutoSize = true;
            this.label_ThongTinKhachHang.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinKhachHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_ThongTinKhachHang.Location = new System.Drawing.Point(54, 18);
            this.label_ThongTinKhachHang.Name = "label_ThongTinKhachHang";
            this.label_ThongTinKhachHang.Size = new System.Drawing.Size(305, 35);
            this.label_ThongTinKhachHang.TabIndex = 28;
            this.label_ThongTinKhachHang.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Thời Gian Vào Làm";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 34);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox_HoTen);
            this.panel1.Controls.Add(this.textBox_MaNV);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button_ThemNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_SoDienThoai);
            this.panel1.Location = new System.Drawing.Point(-4, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 565);
            this.panel1.TabIndex = 41;
            // 
            // btn_Exit
            // 
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btn_Exit.IconColor = System.Drawing.Color.Red;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 24;
            this.btn_Exit.Location = new System.Drawing.Point(400, -2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 25);
            this.btn_Exit.TabIndex = 42;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FormQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 633);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_ThongTinKhachHang);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.TextBox textBox_MaNV;
        private System.Windows.Forms.Button button_ThemNhanVien;
        private System.Windows.Forms.TextBox textBox_SoDienThoai;
        private System.Windows.Forms.Label label_ThongTinKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_Exit;
    }
}