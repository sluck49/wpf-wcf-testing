using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Data;
using WcfService.Data.Models;
using WcfService.Data.Repositories;

namespace WcfService
{
    public class WcfService : IWcfService
    {
        private IFarkleRepository _farkleRepository;

        public WcfService()
        {
            _farkleRepository = new FarkleRepository(new WcfServiceDbContext()); //WCF sucks at DI apparently
        }
        public int GetFarkleCount()
        {            
            return _farkleRepository.GetCount();
        }
        public Farkle CreateFarkle(Farkle farkle)
        {
            var result = _farkleRepository.Add(farkle);
            _farkleRepository.SaveChanges();
            return result;
        }
    }
}
