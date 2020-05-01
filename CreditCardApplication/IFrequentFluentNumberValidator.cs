﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardApplication
{
    public interface IFrequentFluentNumberValidator
    {
        bool IsValid(string frequentFluentNumber);

        void IsValid(string frequentFluentNumber, out bool isValid);
    }
}
