using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterForm
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }


        private void textBox_DonGia_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_DonGia_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_SoLuong_Leave(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "")
            {
                txt_SoLuong.Text = "Thêm Số Lượng";
                txt_SoLuong.ForeColor = Color.Gray;
            }
        }

        private void textBox_SoLuong_Enter(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "Thêm Số Lượng")
            {
                txt_SoLuong.Text = "";
                txt_SoLuong.ForeColor = Color.Black;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
