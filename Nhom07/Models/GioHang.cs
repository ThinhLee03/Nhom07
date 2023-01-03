﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Nhom07.Models
{
    public class GioHang
    {
        public int ID { get; set; }

        [DisplayName("Khách hàng")]
        public int TaiKhoanID { get; set; }

        // Reference navigation property cho khóa ngoại đến TaiKhoan
        [DisplayName("Khách hàng")]
        public TaiKhoan TaiKhoan { get; set; }

        [DisplayName("Sản phẩm")]
        public int SanPhamID { get; set; }

        // Reference navigation property cho khóa ngoại đến SanPham
        [DisplayName("Sản phẩm")]
        public SanPham SanPham { get; set; }

        [DisplayName("Số lượng")]
        [DefaultValue(1)]
        public int SoLuong { get; set; } = 1;


    }
}
