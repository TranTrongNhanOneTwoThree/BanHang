using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox_TenDangNhap_Leave(object sender, EventArgs e)
        {
            if (textBox_TenDangNhap.Text == "")
            {
                textBox_TenDangNhap.Text = "Tên Đăng Nhập";
                textBox_TenDangNhap.ForeColor = Color.Gray;
            }
        }

        private void textBox_TenDangNhap_Enter(object sender, EventArgs e)
        {
            if (textBox_TenDangNhap.Text == "Tên Đăng Nhập")
            {
                textBox_TenDangNhap.Text = "";
                textBox_TenDangNhap.ForeColor = Color.Black;
            }
        }

        private void textBox_MatKhau_Leave(object sender, EventArgs e)
        {
            if (textBox_MatKhau.Text == "")
            {
                textBox_MatKhau.Text = "Mật Khẩu";
                textBox_MatKhau.ForeColor = Color.Gray;
            }
        }

        private void textBox_MatKhau_Enter(object sender, EventArgs e)
        {
            if (textBox_MatKhau.Text == "Mật Khẩu")
            {
                textBox_MatKhau.Text = "";
                textBox_MatKhau.ForeColor = Color.Black;
            }
        }

        private void textBox_MatKhau_Click(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
