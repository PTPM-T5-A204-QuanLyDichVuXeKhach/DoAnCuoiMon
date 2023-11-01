using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDDatVe
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public BDDatVe() { }
        public List<DiaDiemTP> LoadTP()
        {
            var tps = qldvxk.GetTable<DiaDiem>()
                 .Select(tp => new DiaDiemTP { TP = tp.ThanhPho })
                 .ToList();
            return tps;
        }
        public List<ChuyenXeSS> TimKiemCX(string diemdi, string diemden, DateTime ngaydi)
        {
            var cxs = (from cx in qldvxk.ChuyenXes where (cx.DiemDi == diemdi && cx.DiemDen == diemden && cx.NgayDi == ngaydi ) select new ChuyenXeSS{macx = cx.MaCX, diemdi = cx.DiemDi,diemden = cx.DiemDen, ngaydi = cx.NgayDi, giave = cx.GiaVe}).ToList();
            return cxs;
        }
        public List<XeS> LayXeTheoMaCX(string macx)
        {
            var xs = (from x in qldvxk.Xes select new XeS {max = x.MaXe, tentx = x.Tentx, biensx = x.BienSX, soghe = x.SoGhe, tinhtrang = x.TinhTrang, gioKH = x.GioKhoiHanh }).ToList();
            return xs;
        }
    }
}
