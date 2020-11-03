using ITelentCloudsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelentCloudsServices
{
    public class CounterService : ICounterService
    {
        public int CountOccurance(char letter, string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return 0;

            return fullName.ToLower().ToCharArray().Where(x => x == letter).Count();
        }
    }
}
