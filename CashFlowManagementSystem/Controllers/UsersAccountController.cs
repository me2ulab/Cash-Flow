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
        CashFlowDbContext context = new CashFlowDbContext();
        public ActionResult Index()
        {
            return View(user.GetAllUsers());
        }
        public ActionResult Register()
        {
            ViewBag.CateID = new SelectList(context.UsersCategory, "CateID", "Name");
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
            using (CashFlowDbContext context = new CashFlowDbContext())
            {
                var usr = context.UsersAccount.Single(u => u.UserName == user.UserName && u.PassWord == user.PassWord);
                if (usr != null)
                {
                    Session["UserId"] = user.UserID.ToString();
                    Session["UserName"] = user.UserName.ToString();
                    Session["CateID"] = user.CateID;
                    
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
                ViewBag.catid = Session["CateID"];
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

       
    }
}