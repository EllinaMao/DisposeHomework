using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class GroceryStore : IStore
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type => "Продовольственный";

        public GroceryStore(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Type} магазин: {Name}, Адрес: {Address}");
        }
        public override string ToString()
        {
            return $"{Type} магазин: {Name}, Адрес: {Address}";
        }
        }
    }   
}
