using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CashFlowManagementSystem.Models
{
    public class UsersAccount
    {
        [Key()]
        public int UserID { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string UserName { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required()]
        [DataType(DataType.Password)]
        public string PassWord { get; set; }

        [Required()]
        [Compare("PassWord")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public int UserCategory { get; set; }
        public virtual List<Expenses> Expenses { get; set; }
        public virtual List<Income> Incomes { get; set; }
    }
}