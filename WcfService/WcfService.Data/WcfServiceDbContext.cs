using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WcfService.Data.Models;

namespace WcfService.Data
{
    public interface IWcfServiceDbContext
    {
        DbSet<Farkle> Farkles { get; set; }
        DbSet<Groob> Groobs { get; set; }
                
        Database Database { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
    public class WcfServiceDbContext : DbContext, IWcfServiceDbContext
    {
        public DbSet<Farkle> Farkles { get; set; }
        public DbSet<Groob> Groobs { get; set; }
    }
}
