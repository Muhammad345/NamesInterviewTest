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
            throw new NotImplementedException();
        }

        public Company GetById(object id)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse Insert(Company obj)
        {
            string companyData = JsonConvert.SerializeObject(obj);
            var result = FileService.WriteFile("companydata.json", companyData);
            return null;
        }

        public DataServiceResponse Update(Company obj)
        {
            throw new NotImplementedException();
        }
    }
}
