using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_QuanLyDichVuXeKhach.Models
{
    public class KhachHang
    {
        [Key]
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public long MaXe { get; set; }
        public virtual Xe Xe { get; set; }
    }
}