﻿using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface ICurrencyRepository
    {
        public IEnumerable<Currency> All();

    }
}
