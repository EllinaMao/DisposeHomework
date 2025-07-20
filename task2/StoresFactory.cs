using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class ClothingFactory : IFactory
    {
        public IStore CreateStore(string name, string address)
        {
            return new ClothingStore(name,address);
        }
    }
    public class GroceryFactory : IFactory
    {
        public IStore CreateStore(string name, string address)
        {
            return new GroceryStore(name,address);
        }
    }
    public class HouseholdFactory : IFactory
    {
        public IStore CreateStore(string name, string address)
        {
            return new HouseholdStore(name,address);
        }
    }


}