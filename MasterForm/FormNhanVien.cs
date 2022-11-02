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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void button_TrangChu_Click_1(object sender, EventArgs e)
        {
            trangChu1.BringToFront();
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            donHang1.BringToFront();
        }

        private void button_SanPham_Click(object sender, EventArgs e)
        {
            sanPham1.BringToFront();
        }

        private void button_KhachHang_Click(object sender, EventArgs e)
        {
            khachHang1.BringToFront();
        }

        private void button_NhapHang_Click(object sender, EventArgs e)
        {
            nhapHang1.BringToFront();
        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            caiDat1.BringToFront();
        }
    }
}
