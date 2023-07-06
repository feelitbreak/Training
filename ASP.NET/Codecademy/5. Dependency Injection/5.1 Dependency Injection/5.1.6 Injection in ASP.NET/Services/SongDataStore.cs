using System;
using System.Collections.Generic;

namespace DependencyInjection.Services
{
    public class SongDataStore : IDataStore
    {
        public List<string> GetAll()
        {
            return new List<string>
      {
        "What's Going On",
        "Signed, Sealed, Delivered I'm Yours",
        "War",
        "Ain't No Mountain High Enough",
        "ABC"
      };
        }
    }
}
