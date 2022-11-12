using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterForm.DTO
{
    public class KhachHangDTO
    {
        private string name;

        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public KhachHangDTO(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public KhachHangDTO() { }
        public KhachHangDTO(DataRow row)
        {
            this.ID = (int)row["Makh"];
            this.Name = row["HoTen"].ToString();
        }
    }
}
