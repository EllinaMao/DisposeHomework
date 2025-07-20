using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using task2.Stores;

namespace task2
{
    public class ShoesStore(string name, string address) : Store(name, address), IStore
    {
        public new string Type => "Обувной";
    }
}
