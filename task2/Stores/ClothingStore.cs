using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Stores;

namespace task2
{
    public class ClothingStore : Store, IStore
    {
        public string Type => "Одежды";
        public ClothingStore(string name, string address) : base(name, address)
        {
        }
    }
}
