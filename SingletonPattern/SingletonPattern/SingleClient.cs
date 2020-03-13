using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class SingleClient
    {
        private static SingleClient instance = new SingleClient();
        public static SingleClient GetSingleClient()
        {
            return instance;
        }
        public Index ConnectToIndex()
        {
            Index singleIndex = Index.GetIndex();
            return singleIndex;
        }
    }
}
