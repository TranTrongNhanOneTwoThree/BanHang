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

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            trangChuNhanVien.BringToFront();    
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            hoaDonNhanVien.BringToFront();
        }
    }
}
