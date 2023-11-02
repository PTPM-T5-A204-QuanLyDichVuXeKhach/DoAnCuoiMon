using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_QuanLyDichVuXeKhach.Models;

namespace Web_QuanLyDichVuXeKhach.Controllers
{
    public class ChuyenXeController : Controller
    {
        // GET: ChuyenXe
        DBContext db = new DBContext();
        public ActionResult Index(string Search ="")
        {
            // Search
            List<ChuyenXe> chuyenXes = db.ChuyenXes.Where(t => t.DiemDen.Contains(Search)).ToList();
            ViewBag.Search = Search;

            return View(chuyenXes);
        }
        public ActionResult Detail(string id)
        {
            long maCX = long.Parse(id);
            ChuyenXe cx = db.ChuyenXes.Where(row => row.MaCX == maCX).FirstOrDefault();
            return View(cx);
        }
        public ActionResult Edit(string id)
        {
            long ma = long.Parse(id);
            ChuyenXe cx = db.ChuyenXes.Where(row => row.MaCX == ma).FirstOrDefault();
            return View(cx);
        }
        [HttpPost]
        public ActionResult Edit(ChuyenXe chuyenXe)
        {
            ChuyenXe cx = db.ChuyenXes.Where(row => row.MaCX == chuyenXe.MaCX).FirstOrDefault();
            cx.DiemDi = chuyenXe.DiemDi;
            cx.DiemDen = chuyenXe.DiemDen;
            cx.NgayDi = chuyenXe.NgayDi;
            cx.GiaVe = chuyenXe.GiaVe;
            cx.ImageUrl = chuyenXe.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index", "ChuyenXe");
        }
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(ChuyenXe chuyenXe)
        {
            db.ChuyenXes.Add(chuyenXe);
            db.SaveChanges();
            return RedirectToAction("Index", "ChuyenXe");
        }
        public ActionResult Delete(string id)
        {
            long ma = long.Parse(id);
            ChuyenXe cx = db.ChuyenXes.Where(row => row.MaCX == ma).FirstOrDefault();
            return View(cx);
        }

        [HttpPost]
        public ActionResult Delete(string id,ChuyenXe chuyenXe)
        {
            long ma = long.Parse(id);
            ChuyenXe cx = db.ChuyenXes.Where(row => row.MaCX == ma).FirstOrDefault();
            db.ChuyenXes.Remove(cx);
            db.SaveChanges();
            return RedirectToAction("Index", "ChuyenXe");
        }
    }
}