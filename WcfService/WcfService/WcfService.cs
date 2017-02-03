using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Data;
using WcfService.Data.Repositories;

namespace WcfService
{
    public class WcfService : IWcfService
    {
        private readonly IFarkleRepository _farkleRepository;

        public WcfService()
        {
            _farkleRepository = new FarkleRepository(new WcfServiceDbContext());
        }
        public int GetFarkleCount()
        {
            return _farkleRepository.GetAll().Count();
        }        
    }
}
