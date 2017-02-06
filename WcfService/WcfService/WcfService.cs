using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Data;
using WcfService.Data.Models;
using WcfService.Data.Repositories;
using WcfService.Requests;
using WcfService.Responses;

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
        public CreateFarkleResponse CreateFarkle(CreateFarkleRequest request)
        {
            var response = new CreateFarkleResponse();
            
            try
            {
                var result = _farkleRepository.Add(new Farkle()
                {
                    Name = request.Name,
                    Description = request.Description,
                    IsFarked = request.IsFarked
                });
                _farkleRepository.SaveChanges();
                response.NewFarkle = result;
                response.IsSuccess = true;
            }
            catch
            {
                response.FailureReason = "An error has occurred.";
            }
            return response;
        }
    }
}
