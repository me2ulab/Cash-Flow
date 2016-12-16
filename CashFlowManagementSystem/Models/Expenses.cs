using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CashFlowManagementSystem.Models
{
    public class Expenses
    { 
        [Key]
        public int ID { get; set; }
        public double Amount { get; set; }
        public DateTime Time { get; set; }
        public int UserID { get; set; }
        public virtual UsersAccount UsersAccounts { get; set; }

    }
}