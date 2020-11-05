using CandidateNames.Models;
using ITelentCloudsServices;
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

            //FileService.WriteFile("company",)
            return null;
        }

        public DataServiceResponse Update(UserDetail obj)
        {
            throw new NotImplementedException();
        }

    }
}
