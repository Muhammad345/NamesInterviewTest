using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelentCloudsServices
{
    public class DataServiceResponse
    {
        public bool IsSuccessFull { get; set; }
        public Exception ErrorDetails { get; set; }
    }
}
