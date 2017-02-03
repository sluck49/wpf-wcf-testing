using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Data;

namespace WcfService
{
    public class WcfService : IWcfService
    {
        public WcfService()
        {
        }
        public string GetData(int value)
        {
            using (var context = new WcfServiceDataContext())
            {
                var farkle = context.Farkles.Add(new Data.Models.Farkle()
                {
                    Id = 5,
                    Name = "sdkfhskjd"
                });
                context.SaveChanges();
            }
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public string GetFaultyData(int value)
        {
            throw new ApplicationException($"The value you entered ({value}) is not valid.");
        }
    }
}
