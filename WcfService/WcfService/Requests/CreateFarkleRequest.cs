using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.Requests
{
    public class CreateFarkleRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFarked { get; set; }
    }
}
