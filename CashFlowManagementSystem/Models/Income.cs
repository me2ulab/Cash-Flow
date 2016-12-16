using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashFlowManagementSystem.Models
{
    public class Income
    {
        public int IncomeID { get; set; }
        public double Amount { get; set; }
        public DateTime Time { get; set; }
        public int UserID { get; set; }
        public virtual UsersAccount UsersAccount { get; set; }
    }
}