namespace MasterForm
{
    partial class FormNhanVien
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
            this.panelButton = new System.Windows.Forms.Panel();
            this.btn_NhapHang = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelShow = new System.Windows.Forms.Panel();
            this.trangChu2 = new MasterForm.TrangChu();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelButton.SuspendLayout();
            this.panelLabel.SuspendLayout();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelButton.Controls.Add(this.btn_NhapHang);
            this.panelButton.Controls.Add(this.btn_NhanVien);
            this.panelButton.Controls.Add(this.btn_TrangChu);
            this.panelButton.Controls.Add(this.btn_Thoat);
            this.panelButton.Controls.Add(this.btn_SanPham);
            this.panelButton.Controls.Add(this.btn_HoaDon);
            this.panelButton.Location = new System.Drawing.Point(1, 197);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(278, 462);
            this.panelButton.TabIndex = 12;
            // 
            // btn_NhapHang
            // 
            this.btn_NhapHang.BackColor = System.Drawing.Color.White;
            this.btn_NhapHang.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_NhapHang.Image = global::MasterForm.Properties.Resources.Nhập_Hàng;
            this.btn_NhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapHang.Location = new System.Drawing.Point(0, 308);
            this.btn_NhapHang.Name = "btn_NhapHang";
            this.btn_NhapHang.Size = new System.Drawing.Size(281, 70);
            this.btn_NhapHang.TabIndex = 11;
            this.btn_NhapHang.Text = "Nhâp Hàng";
            this.btn_NhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapHang.UseVisualStyleBackColor = false;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.White;
            this.btn_NhanVien.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_NhanVien.Image = global::MasterForm.Properties.Resources.Nhân_Viên;
            this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.Location = new System.Drawing.Point(-1, 232);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(281, 70);
            this.btn_NhanVien.TabIndex = 10;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.Color.White;
            this.btn_TrangChu.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_TrangChu.Image = global::MasterForm.Properties.Resources.Home;
            this.btn_TrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TrangChu.Location = new System.Drawing.Point(-1, 4);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(281, 70);
            this.btn_TrangChu.TabIndex = 9;
            this.btn_TrangChu.Text = "Trang Chủ";
            this.btn_TrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TrangChu.UseVisualStyleBackColor = false;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_Thoat.Image = global::MasterForm.Properties.Resources.Thoát;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(0, 384);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(281, 70);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "LogOut";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.Color.White;
            this.btn_SanPham.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_SanPham.Image = global::MasterForm.Properties.Resources.Sản_Phẩm;
            this.btn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.Location = new System.Drawing.Point(-3, 156);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(281, 70);
            this.btn_SanPham.TabIndex = 7;
            this.btn_SanPham.Text = "Sản Phẩm";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SanPham.UseVisualStyleBackColor = false;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.White;
            this.btn_HoaDon.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_HoaDon.Image = global::MasterForm.Properties.Resources.Hóa_Đơn;
            this.btn_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.Location = new System.Drawing.Point(-1, 80);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(281, 70);
            this.btn_HoaDon.TabIndex = 6;
            this.btn_HoaDon.Text = "Hóa Đơn";
            this.btn_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_HoaDon.UseVisualStyleBackColor = false;
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.label1);
            this.panelLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLabel.Location = new System.Drawing.Point(286, 5);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(903, 186);
            this.panelLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(838, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào Nhân Viên Shop Cầu Lông VNB Sports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.trangChu2);
            this.panelShow.Location = new System.Drawing.Point(287, 201);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(902, 458);
            this.panelShow.TabIndex = 15;
            // 
            // trangChu2
            // 
            this.trangChu2.Location = new System.Drawing.Point(-2, -4);
            this.trangChu2.Name = "trangChu2";
            this.trangChu2.Size = new System.Drawing.Size(903, 454);
            this.trangChu2.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::MasterForm.Properties.Resources.Logo_Shop;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(279, 191);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 16;
            this.pictureLogo.TabStop = false;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1194, 662);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelLabel);
            this.Name = "FormNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNhanVien";
            this.panelButton.ResumeLayout(false);
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Button btn_NhapHang;
        private System.Windows.Forms.Panel panelShow;
        private TrangChu trangChu1;
        private TrangChu trangChu2;
    }
}