using CandidateNames.Models;
using ITelentCloudsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelentCloudsServices
{
    public class BillingDetailsService : IService<BillingDetails>
    {
        public IFileService FileService { get; set; }

        public BillingDetailsService(IFileService fileService)
        {
            FileService = fileService;
        }
        public DataServiceResponse Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BillingDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public BillingDetails GetById(object id)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse Insert(BillingDetails obj)
        {

            //FileService.WriteFile("company",)
            return null;
        }

        public DataServiceResponse Update(BillingDetails obj)
        {
            throw new NotImplementedException();
        }
    }
}
