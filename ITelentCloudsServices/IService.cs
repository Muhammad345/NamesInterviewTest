using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelentCloudsServices;

namespace ITelentCloudsServices
{ 
    public interface IService<T>
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        DataServiceResponse Insert(T obj);
        DataServiceResponse Update(T obj);
        DataServiceResponse Delete(object id);
    }
}
