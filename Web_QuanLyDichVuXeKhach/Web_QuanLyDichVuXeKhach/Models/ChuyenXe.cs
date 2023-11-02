using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_QuanLyDichVuXeKhach.Models
{
    public class ChuyenXe
    {
        [Key]
        public long MaCX { get; set; }
        public string DiemDi { get; set; }
        public string DiemDen { get; set; }
        public DateTime NgayDi { get; set; }
        public decimal GiaVe { get; set; }
        public string ImageUrl { get; set; }

        
    }
}