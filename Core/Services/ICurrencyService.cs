﻿using Shared.Models.Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface ICurrencyService
    {
        IEnumerable<ModelCurrency> Available();
    }
}