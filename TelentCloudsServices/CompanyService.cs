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
    public class CompanyService : IService<Company>
    {
        public IFileService FileService { get; set; }

        private readonly string FileName = "companydata.json";

        public CompanyService()
        {
        }

        public CompanyService(IFileService fileService)
        {
            FileService = fileService;
        }
        public DataServiceResponse Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            var data = FileService.ReadFile(FileName);
           
            return JsonConvert.DeserializeObject<IEnumerable<Company>>(data);
        }

        public Company GetById(object id)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse Insert(Company obj)
        {
            try
            {
                var companyData = new List<Company>
                {
                    obj
                };

                string data = JsonConvert.SerializeObject(companyData);
                var result = FileService.WriteFile(FileName, data);
            }
            catch (Exception exp)
            {
                return new DataServiceResponse { IsSuccessFull = false, ErrorDetails = exp };
            }

            return new DataServiceResponse { IsSuccessFull = true };
        }

        public DataServiceResponse Update(Company obj)
        {
            throw new NotImplementedException();
        }
    }
}
