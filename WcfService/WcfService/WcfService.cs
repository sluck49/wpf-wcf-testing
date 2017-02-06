using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Data;
using WcfService.Data.Models;
using WcfService.Data.Repositories;
using WcfService.Models;
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

            if (string.IsNullOrWhiteSpace(request.Name))
            {
                response.FailureReason = "Name is required.";
            }
            else if(request.Name.Length > 100)
            {
                response.FailureReason = "The maximum length of Name is 100.";
            }
            else if (_farkleRepository.IsNameInUse(request.Name))
            {
                response.FailureReason = "That Name is already in use.";
            }

            if (string.IsNullOrWhiteSpace(response.FailureReason))
            {
                try
                {
                    var result = _farkleRepository.Add(new Farkle()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        IsFarked = request.IsFarked
                    });
                    _farkleRepository.SaveChanges();

                    response.NewFarkle = new FarkleModel()
                    {
                        Id= result.Id,
                        Name = result.Name,
                        Description = result.Description,
                        IsFarked = result.IsFarked
                    };
                    response.IsSuccess = true;
                }
                catch
                {
                    response.FailureReason = "An error has occurred.";
                }
            }
            return response;
        }

        public IEnumerable<FarkleModel> GetFarkles()
        {
            return _farkleRepository.GetAll().Select(x => new FarkleModel()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                IsFarked = x.IsFarked
            }).ToArray();
        }

        public void RemoveFarkle(int id)
        {
            _farkleRepository.Remove(id);                
        }
    }
}
