using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.Stores
{
    public class Store : IStore, IDisposable
    {
        //private bool _disposed = false;

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

        protected virtual void Dispose(bool disposing)
        {
            //if (!_disposed)
            //{
                if (disposing)
                {
                    // Free managed resources here
                    Name = string.Empty;
                    Address = string.Empty;
                }
                // Free unmanaged resources here (if any)
                //_disposed = true;
            //}
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Store()
        {
            Dispose(false);
        }
    }
}
