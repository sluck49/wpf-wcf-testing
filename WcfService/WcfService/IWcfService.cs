using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Models;
using WcfService.Requests;
using WcfService.Responses;

namespace WcfService
{
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        int GetFarkleCount();

        [OperationContract]
        CreateFarkleResponse CreateFarkle(CreateFarkleRequest request);

        [OperationContract]
        IEnumerable<FarkleModel> GetFarkles();
    }
}
