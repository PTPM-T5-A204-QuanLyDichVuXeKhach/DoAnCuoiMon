using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_QuanLyDichVuXeKhach.Models;

namespace Web_QuanLyDichVuXeKhach.Controllers
{
    public class XeController : Controller
    {
        DBContext db = new DBContext();
        // GET: Xe
        public ActionResult Index()
        {
            
            List<Xe> xes = db.Xes.ToList();
            return View(xes);
        }
        public ActionResult Detail(string id)
        {
            long maXe = long.Parse(id);
            Xe xe = db.Xes.Where(row => row.MaXe == maXe).FirstOrDefault();
            return View(xe);
        }
        
    }
}