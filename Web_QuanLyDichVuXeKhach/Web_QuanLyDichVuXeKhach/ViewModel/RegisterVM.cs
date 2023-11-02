using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_QuanLyDichVuXeKhach.ViewModel
{
    public class RegisterVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
    }
}