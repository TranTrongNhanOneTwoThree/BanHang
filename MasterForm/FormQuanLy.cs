using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
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
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_TrangChu());
        }

        private void button_DonHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_DonHang());
        }

        private void button_SanPham_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_SanPham());
        }

        private void button_KhachHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_KhachHang());
        }

        private void button_NhapHang_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_NhapHang());
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void button_QuanLy_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_QuanLyNhanVien());
        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            panelShow.Controls.Clear();
            panelShow.Controls.Add(new UC_CaiDat());
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            // add các controll vào panelShow
            
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
