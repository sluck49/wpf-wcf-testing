using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.Data.Repositories
{
    public interface IRepository<T> 
        where T:class
    {
        T Get(int id);
        IQueryable<T> GetAll();
        T Add(T item);
        void Remove(T item);

        void Savechanges();
    }
    public abstract class RepositoryBase<T> : IRepository<T>
        where T : class
    {
        protected IWcfServiceDbContext DbContext { get; }
        protected RepositoryBase(IWcfServiceDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected abstract DbSet<T> GetDbSet();

        public T Add(T item)
        {
            return GetDbSet().Add(item);
        }

        public T Get(int id)
        {
            return GetDbSet().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return GetDbSet();
        }

        public void Remove(T item)
        {
            GetDbSet().Remove(item);
        }

        public void Savechanges()
        {
            DbContext.SaveChanges();
        }
    }
}
