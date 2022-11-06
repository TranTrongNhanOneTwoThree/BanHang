namespace MasterForm
{
    partial class UC_DonHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Tao = new System.Windows.Forms.Button();
            this.textBox_TìmKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_TimKiem = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 493);
            this.dataGridView1.TabIndex = 2;
            // 
            // button_Tao
            // 
            this.button_Tao.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Tao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tao.ForeColor = System.Drawing.Color.White;
            this.button_Tao.Location = new System.Drawing.Point(885, 85);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(135, 46);
            this.button_Tao.TabIndex = 1;
            this.button_Tao.Text = "TẠO";
            this.button_Tao.UseVisualStyleBackColor = false;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // textBox_TìmKiem
            // 
            this.textBox_TìmKiem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TìmKiem.ForeColor = System.Drawing.Color.Gray;
            this.textBox_TìmKiem.Location = new System.Drawing.Point(295, 87);
            this.textBox_TìmKiem.Name = "textBox_TìmKiem";
            this.textBox_TìmKiem.Size = new System.Drawing.Size(327, 41);
            this.textBox_TìmKiem.TabIndex = 1;
            this.textBox_TìmKiem.Text = "Tìm Kiếm";
            this.textBox_TìmKiem.TextChanged += new System.EventHandler(this.textBox_TìmKiem_TextChanged_1);
            this.textBox_TìmKiem.Enter += new System.EventHandler(this.textBox_TìmKiem_Enter);
            this.textBox_TìmKiem.Leave += new System.EventHandler(this.textBox_TìmKiem_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "ĐƠN HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tìm Kiếm Theo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_TimKiem
            // 
            this.comboBox_TimKiem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TimKiem.FormattingEnabled = true;
            this.comboBox_TimKiem.Location = new System.Drawing.Point(21, 87);
            this.comboBox_TimKiem.Name = "comboBox_TimKiem";
            this.comboBox_TimKiem.Size = new System.Drawing.Size(226, 43);
            this.comboBox_TimKiem.TabIndex = 5;
            // 
            // UC_DonHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_TimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TìmKiem);
            this.Controls.Add(this.button_Tao);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_DonHang";
            this.Size = new System.Drawing.Size(1023, 664);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Tao;
        private System.Windows.Forms.TextBox textBox_TìmKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_TimKiem;
    }
}
