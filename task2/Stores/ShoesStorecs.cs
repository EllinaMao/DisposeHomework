using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task2.Stores
{
    public class ShoesStore(string name, string address) : Store(name, address), IStore
    {
        public new string Type => "Обувной";
    }
}
