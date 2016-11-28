﻿using Persons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Abstract
{
    interface IRepository<T> where T: class
    {
        Task<List<T>> GetListAsync();
        Task<T> GetItemAsync(int Id);
    }
}
