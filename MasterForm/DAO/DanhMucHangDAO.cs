using MasterForm.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterForm.DAO
{
    public class DanhMucHangDAO
    {
        private static DanhMucHangDAO instence;
        public static DanhMucHangDAO Instance
        {
            get { if (instence == null) instence = new DanhMucHangDAO(); return DanhMucHangDAO.instence; }
            set { DanhMucHangDAO.instence = value; }
        }
        private DanhMucHangDAO()
        {

        }
        public List<DanhMucHangDTO> GetlistDanhMucHang()
        {
            List<DanhMucHangDTO> list = new List<DanhMucHangDTO>();
            string query = "select *from DanhMucHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DanhMucHangDTO danhmuchang = new DanhMucHangDTO(item);
                list.Add(danhmuchang);
            }

            return list;

        }
    }
}

