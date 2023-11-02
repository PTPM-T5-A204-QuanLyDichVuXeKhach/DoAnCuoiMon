using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web_QuanLyDichVuXeKhach.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("MyCS") { }
        public DbSet<ChuyenXe> ChuyenXes { get; set; }
        public DbSet<Xe> Xes { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
    }
}