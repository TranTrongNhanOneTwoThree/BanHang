using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterForm.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instence;
        public static KhachHangDAO Instance
        {
            get { if (instence == null) instence = new KhachHangDAO(); return KhachHangDAO.instence; } 
            set { KhachHangDAO.instence = value; }
        }
        private KhachHangDAO()
        {

        }
        public List<KhachHang> GetlistKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "select *from KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang khachkhang = new KhachHang(item);
                list.Add(khachkhang);
            }
            
            return list;

        }
    }
}
