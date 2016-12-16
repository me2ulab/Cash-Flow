using CashFlowManagementSystem.Models;
using CashFlowManagementSystem.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashFlowManagementSystem.Controllers
{
    public class UsersAccountController : Controller
    {
        // GET: UsersAccount
        UsersAccountRepository user = new UsersAccountRepository();
        public ActionResult Index()
        {
            return View(user.GetAllUsers());
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UsersAccount account)
        {
            if (ModelState.IsValid)
            {
                user.AddToUser(account);
          
                user.SaveChanges();
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " Has been created successfully";
                return RedirectToAction("Login");
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UsersAccount user)
        {
            using (UserDbContext context = new UserDbContext())
            {
                var usr = context.UsersAccount.Single(u => u.UserName == user.UserName && u.PassWord == user.PassWord);
                if (usr != null)
                {
                    Session["UserId"] = user.UserID.ToString();
                    Session["UserName"] = user.UserName.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or password is wrong");
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}