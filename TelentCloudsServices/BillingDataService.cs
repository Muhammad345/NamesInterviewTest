using CandidateNames.Models;
using ITelentCloudsServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelentCloudsServices
{
    public class BillingDataService : IDataService<BillingDetails>
    {
        public IFileService FileService { get; set; }

        private readonly string FileName = "billingAddress-collection.json";

        public BillingDataService(IFileService fileService)
        {
            FileService = fileService;
        }
        public DataServiceResponse Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BillingDetails> GetAll()
        {
            var data = FileService.ReadFile(FileName);

            if (string.IsNullOrWhiteSpace(data))
            {
                return new List<BillingDetails>();
            }

            return JsonConvert.DeserializeObject<IEnumerable<BillingDetails>>(data);
        }

        public BillingDetails GetById(object id)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse Insert(BillingDetails obj)
        {
            try
            {
                var billingDetails = GetAll().ToList();
                var foundItem = billingDetails.Find(x => x.CompanyId == obj.CompanyId);

                 if (foundItem != null)
                 {
                   billingDetails.Remove(foundItem);
                   billingDetails.Add(obj);
                 }
               else
                {
                    billingDetails.Add(obj);
                }

                string data = JsonConvert.SerializeObject(billingDetails);
                var result = FileService.WriteFile(FileName, data);
            }
            catch (Exception exp)
            {
                return new DataServiceResponse { IsSuccessFull = false, ErrorDetails = exp };
            }

            return new DataServiceResponse { IsSuccessFull = true };
        }

        public DataServiceResponse Update(BillingDetails obj)
        {
            throw new NotImplementedException();
        }
    }
}
