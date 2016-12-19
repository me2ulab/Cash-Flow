using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashFlowManagementSystem.Models.Repositories
{
    public class UsersAccountRepository:Repository<UsersAccount>
    {
       public UsersAccount GetID(UsersAccount usr)
        {
            return DbSet.Single();
        }
        public UsersAccount GetCategory(UsersAccount usr)
        {
            return DbSet.Find(usr.CateID);
        }
    }
}