namespace MasterForm
{
    partial class NhapHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_NhapHang = new System.Windows.Forms.GroupBox();
            this.textBox_TìmKiem = new System.Windows.Forms.TextBox();
            this.button_Nhap = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_NhapHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_NhapHang
            // 
            this.groupBox_NhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.groupBox_NhapHang.Controls.Add(this.textBox_TìmKiem);
            this.groupBox_NhapHang.Controls.Add(this.button_Nhap);
            this.groupBox_NhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_NhapHang.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NhapHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox_NhapHang.Location = new System.Drawing.Point(0, 0);
            this.groupBox_NhapHang.Name = "groupBox_NhapHang";
            this.groupBox_NhapHang.Size = new System.Drawing.Size(1023, 664);
            this.groupBox_NhapHang.TabIndex = 3;
            this.groupBox_NhapHang.TabStop = false;
            this.groupBox_NhapHang.Text = "NHẬP HÀNG";
            // 
            // textBox_TìmKiem
            // 
            this.textBox_TìmKiem.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TìmKiem.ForeColor = System.Drawing.Color.Black;
            this.textBox_TìmKiem.Location = new System.Drawing.Point(15, 90);
            this.textBox_TìmKiem.Name = "textBox_TìmKiem";
            this.textBox_TìmKiem.Size = new System.Drawing.Size(327, 38);
            this.textBox_TìmKiem.TabIndex = 1;
            // 
            // button_Nhap
            // 
            this.button_Nhap.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Nhap.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Nhap.ForeColor = System.Drawing.Color.White;
            this.button_Nhap.Location = new System.Drawing.Point(850, 90);
            this.button_Nhap.Name = "button_Nhap";
            this.button_Nhap.Size = new System.Drawing.Size(135, 38);
            this.button_Nhap.TabIndex = 1;
            this.button_Nhap.Text = "THÊM";
            this.button_Nhap.UseVisualStyleBackColor = false;
            // 
            // NhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox_NhapHang);
            this.Name = "NhapHang";
            this.Size = new System.Drawing.Size(1023, 664);
            this.groupBox_NhapHang.ResumeLayout(false);
            this.groupBox_NhapHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_NhapHang;
        private System.Windows.Forms.TextBox textBox_TìmKiem;
        private System.Windows.Forms.Button button_Nhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
