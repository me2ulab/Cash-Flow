using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CashFlowManagementSystem.Models
{
    public class CashFlowDbContext:DbContext
    {
        public DbSet<UsersAccount> UsersAccount { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
    }
}