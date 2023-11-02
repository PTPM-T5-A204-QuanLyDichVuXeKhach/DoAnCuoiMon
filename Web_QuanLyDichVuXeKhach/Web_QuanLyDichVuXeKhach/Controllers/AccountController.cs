using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_QuanLyDichVuXeKhach.Models;
using Web_QuanLyDichVuXeKhach.ViewModel;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Web_QuanLyDichVuXeKhach.Identity;

namespace Web_QuanLyDichVuXeKhach.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterVM rmv)
        {
            if (ModelState.IsValid)
            {
                var appDbContext = new AppDbContext();
                var userStore = new AppUserStore(appDbContext);
                var userManager = new AppUserManager(userStore);
                var passHash = Crypto.HashPassword(rmv.Password);
                var user = new AppUser()
                {
                    Email = rmv.Email,
                    UserName = rmv.Username,
                    PasswordHash = passHash,
                    NgaySinh = rmv.NgaySinh,
                    DiaChi = rmv.DiaChi
                };
                IdentityResult identityResult = userManager.Create(user);
                if (identityResult.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Customer");
                    var authenManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    authenManager.SignIn(new AuthenticationProperties(), userIdentity);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("New Error", "Invailid Data");
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM lvm)
        {
            var appDbContext = new AppDbContext();
            var userStore = new AppUserStore(appDbContext);
            var userManager = new AppUserManager(userStore);
            var user = userManager.Find(lvm.Username, lvm.Password);
            if(user != null)
            {
                var authenManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenManager.SignIn(new AuthenticationProperties(), userIdentity);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("myError", "Invail username and password");
                return View();
            }
        }
        public ActionResult Logout()
        {
            var authenManager = HttpContext.GetOwinContext().Authentication;
            authenManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}