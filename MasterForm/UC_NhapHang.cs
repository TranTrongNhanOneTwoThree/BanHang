﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class UC_NhapHang : UserControl
    {
        public UC_NhapHang()
        {
            InitializeComponent();
        }

        private void textBox_TìmKiem_Leave(object sender, EventArgs e)
        {
            if (textBox_TìmKiem.Text == "")
            {
                textBox_TìmKiem.Text = "Tìm Kiếm";
                textBox_TìmKiem.ForeColor = Color.Gray;
            }
        }

        private void textBox_TìmKiem_Enter(object sender, EventArgs e)
        {
            if (textBox_TìmKiem.Text == "Tìm Kiếm")
            {
                textBox_TìmKiem.Text = "";
                textBox_TìmKiem.ForeColor = Color.Black;
            }
        }

        private void button_Nhap_Click(object sender, EventArgs e)
        {
            FormNhapHang frmNhapHang = new FormNhapHang();
            frmNhapHang.ShowDialog();
        }
    }
}
