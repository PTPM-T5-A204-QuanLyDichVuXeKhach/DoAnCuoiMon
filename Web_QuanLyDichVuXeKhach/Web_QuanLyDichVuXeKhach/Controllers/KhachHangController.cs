using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_QuanLyDichVuXeKhach.Models;

namespace Web_QuanLyDichVuXeKhach.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        DBContext db = new DBContext();
        public ActionResult Index()
        {
            List<KhachHang> khachHangs = db.khachHangs.ToList();
            return View(khachHangs);
        }
        public ActionResult Them()
        {
            ViewBag.Xes = db.Xes.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Them(KhachHang khach)
        {
            db.khachHangs.Add(khach);
            db.SaveChanges();
            return RedirectToAction("Index", "Xe");
        }
    }
}