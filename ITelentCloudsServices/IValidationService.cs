﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITelentCloudsServices
{
    public interface IValidationService
    {
        bool IsValid(string fullName);
    }
}
