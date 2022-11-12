using MasterForm.DTO;
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
        public List<KhachHangDTO> GetlistKhachHang()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            string query = "select *from KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO khachkhang = new KhachHangDTO(item);
                list.Add(khachkhang);
            }
            
            return list;

        }
    }
}
