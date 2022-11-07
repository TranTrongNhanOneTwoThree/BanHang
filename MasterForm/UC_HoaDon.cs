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
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btn_CTHD_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHoaDon = new FormHoaDon();
            frmHoaDon.ShowDialog();
        }
    }
}
