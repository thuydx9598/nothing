//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnzamtechWS
{
    using System;
    using System.Collections.Generic;
    
    public partial class CtNhapHang
    {
        public int MaSP { get; set; }
        public int MaPNH { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
    
        public virtual NhapHang NhapHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
