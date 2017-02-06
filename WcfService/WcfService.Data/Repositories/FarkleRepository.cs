using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Data.Models;

namespace WcfService.Data.Repositories
{
    public interface IFarkleRepository : IRepository<Farkle>
    {
        int GetCount();
        bool IsNameInUse(string name);
        void Remove(int id);
    }
    public class FarkleRepository : RepositoryBase<Farkle>, IFarkleRepository
    {
        public FarkleRepository(IWcfServiceDbContext dbContext) : base(dbContext)
        {
        }

        public int GetCount()
        {
            return DbContext.Farkles.Count();
        }

        public bool IsNameInUse(string name)
        {
            return DbContext.Farkles.Any(x => x.Name == name);
        }

        public void Remove(int id)
        {
            var farkle = Get(id);
            if (farkle != null)
            {
                Remove(farkle);
                DbContext.SaveChanges();
            }
        }

        protected override DbSet<Farkle> GetDbSet()
        {
            return DbContext.Farkles;
        }
    }
}
