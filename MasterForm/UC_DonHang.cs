using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class UC_DonHang : UserControl
    {
        List<DonHang> DonHangs= new List<DonHang>();
        String[] TimKiem = { "Mã đơn hàng" };
        public UC_DonHang()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"data source=LAPTOP-75IRC5C7\SQLEXPRESS; initial catalog=BanHang;integrated security=true";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select maDh,NgayLap, manv,MaNhaCungCap  from DonHang  ";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                DonHang donh = new DonHang();
                donh.MaDh = (int)datareader["MaDh"];
                donh.NgayLap = (DateTime)datareader["Ngaylap"];
                donh.Manv = (int)datareader["Manv"];
                donh.MaNhaCungCap = (int)datareader["MaNhaCungCap"];
                
                DonHangs.Add(donh);


            }
            cnn.Close();
            InitializeComponent();

            dataGridView1.DataSource = DonHangs;
            // comboBox_BoLoc.DataSource = new BindingSource(DanhMucs, null); 
        
        }

      
        private void comboBox_HoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TìmKiem_Enter(object sender, EventArgs e)
        {
            if(textBox_TìmKiem.Text == "Tìm Kiếm")
            {
                textBox_TìmKiem.Text = "";
                textBox_TìmKiem.ForeColor = Color.Black;
            }
        }

        private void textBox_TìmKiem_Leave(object sender, EventArgs e)
        {
            if (textBox_TìmKiem.Text == "")
            {
                textBox_TìmKiem.Text = "Tìm Kiếm";
                textBox_TìmKiem.ForeColor = Color.Gray;
            }
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            FormHoaDon frmHoaDon = new FormHoaDon();
            frmHoaDon.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
