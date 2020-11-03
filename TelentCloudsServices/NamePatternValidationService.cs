using ITelentCloudsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelentCloudsServices
{
    public class NamePatternValidationService : IValidationService
    {
        private readonly char NameSeparator;

        public NamePatternValidationService()
        {
            NameSeparator = ',';
        }

        public bool IsValid(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return false;

            if (!fullName.Contains(NameSeparator))
                return false;

            var names = fullName.Split(NameSeparator);

            if(names.Count() > 1)
            {
                if (string.IsNullOrWhiteSpace(names[0]) || string.IsNullOrWhiteSpace(names[1]))
                    return false;
            }

            return true;
        }
    }
}
