using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CashFlowManagementSystem.Models.Repositories
{
    public class Repository<T> where T:class
    {
        private CashFlowDbContext Context = null;
        protected DbSet<T> DbSet { set; get; }
        public Repository()
        {
            Context = new CashFlowDbContext();
            DbSet = Context.Set<T>();
        }
        public Repository(CashFlowDbContext context)
        {
            this.Context = context;
        }
        public List<T> GetAllUsers()
        {
            return DbSet.ToList();
        }
        public void AddToUser(T entity)
        {
            DbSet.Add(entity);
        }
        public T GetUser(int ID)
        {
            return DbSet.Find(ID);
        }
        public void SaveChanges()
        {
            Context.SaveChanges();
        }
        public void Update(T entity)
        {
            Context.Entry<T>(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

    }
}