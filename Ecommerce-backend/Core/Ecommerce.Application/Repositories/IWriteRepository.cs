﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : class
    {
    }
}
