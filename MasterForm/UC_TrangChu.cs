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
using System.Windows.Forms.DataVisualization.Charting;

namespace MasterForm
{
    public partial class UC_TrangChu : UserControl
    {
        private string nameHost = ConfigurationManager.AppSettings.Get("nameHost");
        private string userNamePss = ConfigurationManager.AppSettings.Get("userName");
        public UC_TrangChu()
        {
            InitializeComponent();
            doanhThu_Sodon();
            tongSp();
            fillChart();
        }
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        private void doanhThu_Sodon()
        {
            SqlConnection cnn = ketNoi();
            cnn.Open();
            string sql = "select count(Mahd) as SoDon, sum(dbo.GetTotal(Mahd)-dbo.GetTotalNhap(Mahd)) as DoanhThu   \r\nfrom HoaDon\r\nwhere ngayghi=GETDATE()";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
         
            datareader2.Read();
            lb_soDon.Text = datareader2["SoDon"].ToString();
            lb_doanhThu.Text = datareader2["DoanhThu"].ToString();
            cnn.Close();
        }
        private void tongSp()
        {
            SqlConnection cnn = ketNoi();
            cnn.Open();
            string sql = "select sum(ct.SoLuong) as TongSp from ChiTietHoaDon ct, HoaDon hd where hd.Mahd=ct.MaHd and hd.ngayghi=GETDATE() ";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
            datareader2.Read();
            lb_soSp.Text = datareader2["TongSp"].ToString();
            cnn.Close();
        }
        private void fillChart()
        {
            SqlConnection cnn = ketNoi();
            DataSet ds = new DataSet();
            cnn.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select Top(7) day(ngayghi) as Ngay, (dbo.GetTotal(Mahd)-dbo.GetTotalNhap(Mahd)) as DoanhThu   from HoaDon where ngayghi<=GETDATE()", cnn);
            adapt.Fill(ds);
            chart.DataSource = ds;
            chart.Series["Doanh thu"].XValueMember = "Ngay";
            chart.Series["Doanh thu"].YValueMembers = "DoanhThu";
            cnn.Close();
        }
    }
}
