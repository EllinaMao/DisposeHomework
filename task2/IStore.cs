using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public interface IStore
    {
        string Name { get; set; }
        string Address { get; set; }
        string Type { get; }
        void PrintInfo();

    }
}
