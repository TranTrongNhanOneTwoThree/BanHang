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
        public List<SanPham> GetSanPham(int id)
        {
            List<SanPham> list = new List<SanPham>();
            string query = "select *from SanPham where MaDM ="+ id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPham sanpham = new SanPham();
                list.Add(sanpham);
            }
            
            return list;
        }

   
    }
}
