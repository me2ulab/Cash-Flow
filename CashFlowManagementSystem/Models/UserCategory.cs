using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CashFlowManagementSystem.Models
{
    public class UserCategory
    {
        [Key()]
        public int CateID { get; set; }
        public string Name { get; set; }
       
    }
}