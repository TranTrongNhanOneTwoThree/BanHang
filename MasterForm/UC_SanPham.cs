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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterForm
{
    public partial class UC_SanPham : UserControl
    {
        List<SanPham> SanPhams = new List<SanPham>();
 
        List<string> DanhMucs = new List<string>();
        String[] TimKiemTheo = { "Mã sản phẩm", "Tên sản phẩm" };
       
        public UC_SanPham()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = LAPTOP-AAL40GA9\SQLEXPRESS ;Initial Catalog=BanHang;
            User ID=sa; Password=demo123";
            cnn = new SqlConnection(connectionstring);
            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select masp, tensp,dbo.giaban(masp) as gia, donvitinh, madm, dbo.ktsoluong(masp) as soluong from sanpham  ";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();



            while (datareader.Read())
            {
                SanPham sanp = new SanPham();
                sanp.Masp = (int)datareader["masp"];
                sanp.Tensp = (string)datareader["tensp"];
                sanp.Gia = (decimal)datareader["gia"];
                sanp.DonViTinh = (string)datareader["donvitinh"];
                sanp.MaDM = (int)datareader["madm"];
                sanp.SoLuong = (int)datareader["soluong"];
                SanPhams.Add(sanp);


            }
            cnn.Close();


            cnn.Open();
            sql = "select * from danhmuchang";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command.ExecuteReader();
            while (datareader2.Read())
            {
                DanhMucs.Add( Convert.ToString(datareader2.GetValue(1)));

            }
            cnn.Close();

            InitializeComponent();
            
            dataGridView1.DataSource = SanPhams;
            foreach(string item in DanhMucs)
            {
                comboBox_BoLoc.Items.Add(item);
            }
           // comboBox_BoLoc.DataSource = new BindingSource(DanhMucs, null); 
            comboBox_BoLoc.DisplayMember = "Value";
            comboBox_BoLoc.ValueMember = "Key";
        }
        private void textBox_TìmKiem_TextChanged(object sender, EventArgs e)
        {
            List<SanPham> SanPhams2 = new List<SanPham>();
            if (comboBox_BoLoc.SelectedItem != null && comboBox_TimKiem.SelectedItem != null)
            {
                string TenDm = comboBox_BoLoc.SelectedItem.ToString();
                string timkiemtheo = comboBox_TimKiem.SelectedItem.ToString();
                string content = "%"+textBox_TìmKiem.Text.ToString()+"%";

                // MessageBox.Show(TenDm);
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=(local); Initial Catalog=BanHang;integrated security=true";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                String sql = @"select Masp, Tensp, dbo.GiaBan(Masp) as Gia, DonViTinh, sp.MaDM, dbo.KtSoLuong(Masp) as SoLuong 
                               from SanPham sp, DanhMucHang dm where sp.MaDM= dm.MaDm and dm.TenDm= N'"+ TenDm + @"'and sp.Tensp like N'"+content+@"'";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    SanPham SanP = new SanPham();
                    SanP.Masp = (int)dataReader["Masp"];
                    SanP.Tensp = (String)dataReader["Tensp"];
                    SanP.Gia = (decimal)dataReader["Gia"];
                    SanP.DonViTinh = (String)dataReader["DonViTinh"];
                    SanP.MaDM = (int)dataReader["MaDM"];
                    SanP.SoLuong = (int)dataReader["SoLuong"];
                    SanPhams2.Add(SanP);


                }
                dataGridView1.DataSource = SanPhams2;
                cnn.Close();
            }

        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            FormSanPham frmSanPham = new FormSanPham();
            frmSanPham.ShowDialog();
        }
    }
}
