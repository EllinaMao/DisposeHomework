using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Stores
{
    public class GroceryStore(string name, string address) : Store(name, address), IStore
    {
        public new string Type => "Продовольственный";
    }
}   
