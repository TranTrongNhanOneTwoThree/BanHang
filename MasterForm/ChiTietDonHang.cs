//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public int MaDh { get; set; }
        public int Masp { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> GiaNhap { get; set; }
        public Nullable<decimal> GiaBan { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
