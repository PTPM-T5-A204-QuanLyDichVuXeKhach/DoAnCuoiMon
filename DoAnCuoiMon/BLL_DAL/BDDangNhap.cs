using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDDangNhap
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public BDDangNhap() { }
        public string KiemTraDangNhap(string tendn, string mk)
        {
            var dn = qldvxk.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendn && t.MatKhau == mk);
            if (dn != null)
            {
                return dn.MaCV;
            }
            return null;
        }
    }
}
