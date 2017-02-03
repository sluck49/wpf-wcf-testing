using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Data.Models;

namespace WcfService.Data
{
    public class WcfServiceDataContext:DbContext
    {
        public DbSet<Farkle> Farkles { get; set; }
        public DbSet<Groob> Groobs { get; set; }
    }
}
