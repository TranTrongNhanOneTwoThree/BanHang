using MasterForm.DAO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }

        void loadKhachHang()
        {
            List<KhachHang> listKhachHang = KhachHangDAO.Instance.GetlistKhachHang();

            comboBox_MaKH.DataSource = listKhachHang;
            comboBox_MaKH.DisplayMember = "HoTen";
        }
        void loadSanPham(int id)
        {
            List<SanPham> listSanPhan= SanPhamDAO.Instance.GetSanPham(id);
            comboBox_TenSP.DataSource = listSanPhan;
            comboBox_TenSP.DisplayMember = "Tensp";
        }
        void loadDanhMuc()
        {
            List<DanhMucHang> listDanhMuc = DanhMucHangDAO.Instance.GetlistDanhMucHang();
            comboBox_LoaiHang.DataSource = listDanhMuc;
            comboBox_LoaiHang.DisplayMember = "TenDm";
        }
        private void textBox_DonGia_Leave(object sender, EventArgs e)
        {

        }

        private void textBox_DonGia_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_SoLuong_Leave(object sender, EventArgs e)
        {
            if (textBox_SoLuong.Text == "")
            {
                textBox_SoLuong.Text = "Thêm Số Lượng";
                textBox_SoLuong.ForeColor = Color.Gray;
            }
        }

        private void textBox_SoLuong_Enter(object sender, EventArgs e)
        {
            if (textBox_SoLuong.Text == "Thêm Số Lượng")
            {
                textBox_SoLuong.Text = "";
                textBox_SoLuong.ForeColor = Color.Black;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox_MaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadKhachHang();
        }

        private void comboBox_TenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb= sender as ComboBox;
            if (cb.SelectedItem == null) return;
            DanhMucHang selected = cb.SelectedItem as DanhMucHang;
            id = selected.MaDm;
            loadSanPham(id);

        
        }
    }
}
