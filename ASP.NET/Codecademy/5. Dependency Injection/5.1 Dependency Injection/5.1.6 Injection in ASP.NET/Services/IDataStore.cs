using System;
using System.Collections.Generic;

namespace DependencyInjection.Services
{
    public interface IDataStore
    {
        List<string> GetAll();
    }
}
