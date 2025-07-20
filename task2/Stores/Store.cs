using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Stores
{
    public class Store:IStore
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type => "Магазин";
        public Store(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void Display()
        {
            Console.WriteLine($"{Type} магазин: {Name}, Адрес: {Address}");
        }
        public override string ToString()
        {
            return $"{Type} магазин: {Name}, Адрес: {Address}";
        }
        public void Dispose()
        {
            Console.WriteLine($"Освобождение ресурсов магазина {Name}");
            Name = string.Empty;
            Address = string.Empty;

        }
    }
}
