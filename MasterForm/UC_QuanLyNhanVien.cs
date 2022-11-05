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
    public partial class UC_QuanLyNhanVien : UserControl
    {
        public UC_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            FormQuanLyNhanVien frmQuanLyNhanVien = new FormQuanLyNhanVien();
            frmQuanLyNhanVien.ShowDialog();
        }
    }
}
