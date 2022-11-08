using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
         private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        List<SanPham> SanPhams = new List<SanPham>();
 
        List<string> DanhMucs = new List<string>();
        String[] TimKiemTheo = { "Mã sản phẩm", "Tên sản phẩm" };
       
        public UC_SanPham()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
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
        }

    }
}
