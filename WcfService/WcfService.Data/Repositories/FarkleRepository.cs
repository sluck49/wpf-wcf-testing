﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Data.Models;

namespace WcfService.Data.Repositories
{
    public interface IFarkleRepository : IRepository<Farkle> { }
    public class FarkleRepository : RepositoryBase<Farkle>, IFarkleRepository
    {
        public FarkleRepository(IWcfServiceDbContext dbContext) : base(dbContext)
        {
        }

        protected override DbSet<Farkle> GetDbSet()
        {
            return DbContext.Farkles;
        }
    }
}