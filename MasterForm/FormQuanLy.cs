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

        private void button_TrangChu_Click(object sender, EventArgs e)
        {
            trangChu2.BringToFront();
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            donHang2.BringToFront();
        }

        private void button_SanPham_Click(object sender, EventArgs e)
        {
            sanPham2.BringToFront();
        }

        private void button_KhachHang_Click(object sender, EventArgs e)
        {
            khachHang2.BringToFront();
        }

        private void button_NhapHang_Click(object sender, EventArgs e)
        {
            nhapHang2.BringToFront();
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void button_QuanLy_Click(object sender, EventArgs e)
        {
            quanLyNhanVien2.BringToFront();
        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            caiDat2.BringToFront();
        }
    }
}
