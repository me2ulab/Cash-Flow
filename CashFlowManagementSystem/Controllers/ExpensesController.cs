using CashFlowManagementSystem.Models;
using CashFlowManagementSystem.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashFlowManagementSystem.Controllers
{
    public class ExpensesController : Controller
    {
        // GET: Expenses
        ExpensesRepository repo = new ExpensesRepository();
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewExpenses()
        {
            
                return View();
        }
    }
}