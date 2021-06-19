﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IClient
    {
        public Task<T> GetAsync<T>(string endpoint);
        public Task<T> PostAsync<T>(string endpoint, object body);

    }
}
