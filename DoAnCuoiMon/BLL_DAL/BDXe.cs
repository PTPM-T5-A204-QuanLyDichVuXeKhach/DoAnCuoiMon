using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDXe
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public List<Xe> LoadX()
        {
            var xs = from x in qldvxk.Xes select x;
            return xs.ToList();
        }
        public List<ChuyenXeS> LoadCX()
        {
            var cxs = qldvxk.GetTable<ChuyenXe>()
                 .Select(cx => new ChuyenXeS { CX = cx.MaCX })
                 .ToList();
            return cxs;
        }
        public void ThemX(string max, string tentx, string bsx, int soghe, int soghedat, string tinhtrang,DateTime giokh, string macx)
        {
            qldvxk.Xes.InsertOnSubmit(new Xe { MaXe = max, Tentx = tentx, BienSX = bsx, SoGhe = soghe, SoGheDaDat = soghedat, TinhTrang = tinhtrang,GioKhoiHanh = giokh, MaCX = macx });
            qldvxk.SubmitChanges();
        }
        public void XoaX(string max)
        {
            Xe xes = qldvxk.Xes.Where(t => t.MaXe == max).FirstOrDefault();
            qldvxk.Xes.DeleteOnSubmit(xes);
            qldvxk.SubmitChanges();
        }
        public void SuaX(string max,string tentx, string biensx, int soghe, int soghedat, string tinhtrang, DateTime gio, string mcx)
        {
            Xe xes = qldvxk.Xes.Where(t => t.MaXe == max).FirstOrDefault();
            xes.Tentx = tentx;xes.BienSX = biensx;xes.SoGhe = soghe; xes.SoGheDaDat = soghedat; xes.TinhTrang = tinhtrang ; xes.GioKhoiHanh = gio;xes.MaCX = mcx;
            qldvxk.SubmitChanges();
        }
    }
}
