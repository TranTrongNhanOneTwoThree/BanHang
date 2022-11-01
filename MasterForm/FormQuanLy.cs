using System;
using System.Windows.Forms;
using System.Xml;

namespace MasterForm
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void btn_ListNV_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_TrangChu_Click(object sender, System.EventArgs e)
        {
            trangChuQuanLy.BringToFront();
        }

        private void panelLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void labelDate_Click(object sender, EventArgs e)
        {
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            hoaDonQuanLy.BringToFront();
        }

        private void hoaDonQuanLy_Load(object sender, EventArgs e)
        {

        }
    }
}
