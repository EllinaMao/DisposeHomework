using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task2
{
    public class ShoesStore : IStore
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type => "Обувной";

        public ShoesStore(string name, string address)
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
