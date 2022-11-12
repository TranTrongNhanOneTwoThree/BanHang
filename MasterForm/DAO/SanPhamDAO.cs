using MasterForm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterForm.DAO
{
    public class SanPhamDAO
    {
        private static SanPhamDAO instence;
        public static SanPhamDAO Instance
        {
            get { if (instence == null) instence = new SanPhamDAO(); return SanPhamDAO.instence; }
            set { SanPhamDAO.instence = value; }
        }
        private SanPhamDAO()
        {

        }
        public List<SanPhamDTO> GetSanPham(int id)
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            string query = "select *from SanPham where MaDM ="+ id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO sanpham = new SanPhamDTO();
                list.Add(sanpham);
            }
            
            return list;
        }

   
    }
}
