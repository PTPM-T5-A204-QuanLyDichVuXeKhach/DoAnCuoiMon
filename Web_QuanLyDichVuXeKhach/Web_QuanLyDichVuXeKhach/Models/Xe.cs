using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_QuanLyDichVuXeKhach.Models
{
    public class Xe
    {
        [Key]
        public long MaXe { get; set; }
        public string TenTX { get; set; }
        public string BienSX { get; set; }
        public int SoGhe { get; set; }
        public DateTime GioKhoiHanh { get; set; }
        public DateTime GioDenDuKien { get; set; }
        public long MaCX { get; set; }
        public string ImageUrl { get; set; }
        public virtual ChuyenXe ChuyenXe { get; set; }
    }
}