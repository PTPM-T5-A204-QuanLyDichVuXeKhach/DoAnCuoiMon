using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace BLL_DAL
{
    public class BDDangKy
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public BDDangKy() { }

        //public bool KiemTraMatKhau(string mk, string hashedmk)
        //{
        //    return BCrypt.Net.BCrypt.Verify(mk, hashedmk);
        //}

        //public string HashMK(string mk)
        //{
        //    return BCrypt.Net.BCrypt.HashPassword(mk);
        //}
        public List<TaiKhoan> LoadTK()
        {
            var tks = from tk in qldvxk.TaiKhoans select tk;
            return tks.ToList();
        }

        public void DangKy(string tendk, string mk, string macv)
        {
            //string hashMK = HashMK(mk);
            qldvxk.TaiKhoans.InsertOnSubmit(new TaiKhoan { TenDangNhap = tendk, MatKhau = mk, MaCV = macv});
            qldvxk.SubmitChanges();
        }
        public bool KiemTraTrungTenDK(string tendk)
        {
            var dk = qldvxk.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendk);
            return dk == null;
        }
        public bool KiemTraTrungMaCV(string macv)
        {
            var dk = qldvxk.TaiKhoans.FirstOrDefault(t => t.MaCV == macv);
            return dk == null;
        }
        public string LayMaNV(string cccd)
        {
            var dk = qldvxk.NhanViens.FirstOrDefault(t => t.CCCD == cccd);
            if (dk != null)
            {
                return dk.MaNV.ToString();
            }
            return "Không tìm thấy";
        }
    }
}
