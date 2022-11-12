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
 
        List<DanhMucHang> DanhMucs = new List<DanhMucHang>();
        string maSpSelected;
        private SqlConnection ketNoi()
        {
            String connectionstring;
            SqlConnection cnn;
            connectionstring = @"Data Source = " + nameHost + " ;Initial Catalog=BanHang;"
            + userNamePss + ";";
            return cnn = new SqlConnection(connectionstring);
        }
        private void themSp(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"insert into SanPham(Tensp,DonViTinh,MaDm) values(N'" + txt_TenSP.Text + @"',N'" + txt_DVT.Text + @"'," + comboBoxDanhMuc.SelectedValue + ")";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        private void suaSp(SqlConnection cnn)
        {
            cnn.Open();
            string sql = @"update SanPham set Tensp=N'" + txt_TenSP.Text + @"',DonViTinh=N'" + txt_DVT.Text + @"',MaDm=" + comboBoxDanhMuc.SelectedValue + " where Masp=" + maSpSelected+";";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void xoaSq(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "delete from SanPham where Masp=" + maSpSelected;
            SqlCommand command = new SqlCommand(sql,cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }
        private void getListDm(SqlConnection cnn)
        {
            cnn.Open();
            string sql = "select * from danhmuchang";
            SqlCommand command2 = new SqlCommand(sql, cnn);
            SqlDataReader datareader2 = command2.ExecuteReader();
            while (datareader2.Read())
            {
                DanhMucHang DanhMuc = new DanhMucHang();
                DanhMuc.MaDm = (int)datareader2["MaDm"];
                DanhMuc.TenDm = (string)datareader2["TenDm"];
                DanhMucs.Add(DanhMuc);
            }
            cnn.Close();
            comboBoxDanhMuc.DataSource = DanhMucs;
            comboBoxDanhMuc.ValueMember = "MaDm";
            comboBoxDanhMuc.DisplayMember = "TenDm";

        }
      
        private void getListSp(SqlConnection cnn)
        {
            List<SanPham> SanPhams1 = new List<SanPham>();

            cnn.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sql = "select masp, tensp,dbo.giaban(masp) as gia, donvitinh,tendm, dbo.ktsoluong(masp) as soluong from sanpham sp, danhmuchang dm where sp.madm = dm.madm";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                SanPham sanp = new SanPham();
                sanp.Masp = (int)datareader["masp"];
                sanp.Tensp = (string)datareader["tensp"];
                sanp.Gia = (decimal)datareader["gia"];
                sanp.DonViTinh = (string)datareader["donvitinh"];
                sanp.TenDM = (string)datareader["tendm"];
                sanp.SoLuong = (int)datareader["soluong"];
                SanPhams1.Add(sanp);


            }
            cnn.Close();
            dataGridView1.DataSource = SanPhams1;
            SanPhams = SanPhams1.GetRange(0, SanPhams1.Count);
        }
        private int kiemTraThongTin()
        {
            if(txt_TenSP.Text.Length==0 || txt_DVT.Text.Length==0)
                return 0;
            return 1;
        }
        public UC_SanPham()
        {
            InitializeComponent();
            SqlConnection cnn = ketNoi();
            getListSp(cnn);
            getListDm(cnn);


        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin()==1)
            {
                themSp(ketNoi());
                MessageBox.Show("Thêm thành công !");
                getListSp(ketNoi());
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow rowS = dataGridView1.Rows[e.RowIndex];
                maSpSelected = rowS.Cells[0].Value.ToString();
                txt_TenSP.Text= rowS.Cells[1].Value.ToString();
                txt_DVT.Text= rowS.Cells[3].Value.ToString();
                foreach (DanhMucHang item in DanhMucs)
                {
                    if (rowS.Cells[4].Value.ToString().Equals(item.TenDm))
                    {
                        comboBoxDanhMuc.SelectedValue = item.MaDm;
                        break;
                    }
                } 
            }
        }

        private void BTN_Sua_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin() == 1)
            {
                suaSp(ketNoi());
                MessageBox.Show("Sửa mặt hàng thành công !");
                getListSp(ketNoi());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng muốn sửa !");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemTraThongTin() == 1)
                {
                    xoaSq(ketNoi());
                    MessageBox.Show("Xóa mặt hàng thành công !");
                    getListSp(ketNoi());
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng muốn xóa !");
                }

            }
            catch (Exception loi)
            {
                MessageBox.Show("Không thể xóa mặt hàng này !");
            }
          
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string vanBan=txt_TimKiem.Text;
            List<SanPham> SanPhams3 = new List<SanPham>();
            SanPhams3 = (List<SanPham>)SanPhams.Where(x => x.Tensp.Contains(vanBan)).ToList();
            dataGridView1.DataSource = SanPhams3;

        }

        private void danhMuc_Click(object sender, EventArgs e)
        {

        }
    }
}
