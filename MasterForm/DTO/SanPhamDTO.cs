using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Effects;

namespace MasterForm.DTO
{
    public class SanPhamDTO
    {
        private string name;
        private int id;
        private string donViTinh;
        private int iddm;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public int Id
        {
            get { return id; }  
            set { id = value; }
        }
        public string DonViTinh
        {
            get { return donViTinh; }   
            set { donViTinh = value; }

        }
        public int IDdm
        {
            get { return iddm; }
            set { iddm = value; }
        }
        public SanPhamDTO(string name, int id, string donViTinh, int iddm)
        {
            this.Name = name;
            this.Id = id;
            this.DonViTinh = donViTinh;
            this.IDdm = iddm;
            
        }
        public SanPhamDTO(DataRow row)
        {
            this.Id=(int)row["id"];
            this.Name = row["name"].ToString();
            this.DonViTinh = row["donViTinh"].ToString();
            this.IDdm = (int)row["iddm"];
        }
    }
}
