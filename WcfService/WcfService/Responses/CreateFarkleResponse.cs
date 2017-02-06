using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Data.Models;

namespace WcfService.Responses
{
    public class CreateFarkleResponse:WcfServiceResponseBase
    {
        public Farkle NewFarkle { get; set; }
    }
}
