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
    public partial class CaiDat : UserControl
    {
        public CaiDat()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_HoTen_Leave(object sender, EventArgs e)
        {
            if(textBox_HoTen.Text == "")
            {
                textBox_HoTen.Text = "Họ tên";
                textBox_HoTen.ForeColor = Color.Gray;
            }
        }

        private void textBox_HoTen_Enter(object sender, EventArgs e)
        {
            if (textBox_HoTen.Text == "Họ tên")
            {
                textBox_HoTen.Text = "";
                textBox_HoTen.ForeColor = Color.Black;
            }
        }

        private void textBox_SoDienThoai_Leave(object sender, EventArgs e)
        {
            if (textBox_SoDienThoai.Text == "")
            {
                textBox_SoDienThoai.Text = "Số điện thoại";
                textBox_SoDienThoai.ForeColor = Color.Gray;
            }
        }

        private void textBox_SoDienThoai_Enter(object sender, EventArgs e)
        {
            if (textBox_SoDienThoai.Text == "Số điện thoại")
            {
                textBox_SoDienThoai.Text = "";
                textBox_SoDienThoai.ForeColor = Color.Black;
            }
        }

        private void textBox_DiaChi_Leave(object sender, EventArgs e)
        {
            if (textBox_DiaChi.Text == "")
            {
                textBox_DiaChi.Text = "Địa chỉ";
                textBox_DiaChi.ForeColor = Color.Gray;
            }
        }

        private void textBox_DiaChi_Enter(object sender, EventArgs e)
        {
            if (textBox_DiaChi.Text == "Địa chỉ")
            {
                textBox_DiaChi.Text = "";
                textBox_DiaChi.ForeColor = Color.Black;
            }
        }

        private void textBox_Email_Leave(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "")
            {
                textBox_Email.Text = "Email";
                textBox_Email.ForeColor = Color.Gray;
            }
        }

        private void textBox_Email_Enter(object sender, EventArgs e)
        {
            if (textBox_Email.Text == "Email")
            {
                textBox_Email.Text = "";
                textBox_Email.ForeColor = Color.Black;
            }
        }
    }
}
