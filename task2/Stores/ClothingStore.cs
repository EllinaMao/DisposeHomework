using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Stores;

namespace task2
{
    public class ClothingStore(string name, string address) : Store(name, address), IStore
    {
        public new string Type => "Одежды";
    }
}
