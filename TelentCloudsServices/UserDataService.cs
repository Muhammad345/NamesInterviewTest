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
    public class UserDataService : IDataService<UserDetail>
    {
        public IFileService FileService { get; set; }

        private readonly string FileName = "userDetail-collection.json";

        public UserDataService(IFileService fileService)
        {
            FileService = fileService;
        }
        public DataServiceResponse Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDetail> GetAll()
        {
            var data = FileService.ReadFile(FileName);

            if (string.IsNullOrWhiteSpace(data))
            {
                return new List<UserDetail>();
            }

            return JsonConvert.DeserializeObject<IEnumerable<UserDetail>>(data);
        }

        public UserDetail GetById(object id)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse Insert(UserDetail obj)
        {
            try
            {
                var userDetails = GetAll().ToList();

                var foundItem = userDetails.Find(x => x.CompanyId == obj.CompanyId);

                if (foundItem != null)
                {
                    userDetails.Remove(foundItem);
                    userDetails.Add(obj);
                }
                else
                {
                    userDetails.Add(obj);
                }

                string data = JsonConvert.SerializeObject(userDetails);
                var result = FileService.WriteFile(FileName, data);
            }
            catch (Exception exp)
            {
                return new DataServiceResponse { IsSuccessFull = false, ErrorDetails = exp };
            }

            return new DataServiceResponse { IsSuccessFull = true };
        }

        public DataServiceResponse Update(UserDetail obj)
        {
            throw new NotImplementedException();
        }

    }
}
