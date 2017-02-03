using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Data.Models;

namespace WcfService
{
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        int GetFarkleCount();

        [OperationContract]
        Farkle CreateFarkle(Farkle farkle);
    }    
}
