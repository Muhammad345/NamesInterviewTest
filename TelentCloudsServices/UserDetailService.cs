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
    public class UserDetailService : IService<UserDetail>
    {
        public IFileService FileService { get; set; }

        public UserDetailService(IFileService fileService)
        {
            FileService = fileService;
        }
        public DataServiceResponse Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserDetail GetById(object id)
        {
            throw new NotImplementedException();
        }

        public DataServiceResponse Insert(UserDetail obj)
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(obj);
                var result = FileService.WriteFile("userDetail.json", jsonData);
            }
            catch (Exception exp)
            {

                return new DataServiceResponse { IsSuccessFull = false , ErrorDetails = exp };
            }


            return new DataServiceResponse { IsSuccessFull = true };
        }

        public DataServiceResponse Update(UserDetail obj)
        {
            throw new NotImplementedException();
        }

    }
}
