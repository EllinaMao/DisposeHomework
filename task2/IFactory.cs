using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public interface IFactory
    {
        IStore CreateStore(string storeType, string name, string address);

    }
}
