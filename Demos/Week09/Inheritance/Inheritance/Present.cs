using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Present
    {
        public string Name;
        public int Quantity;
        public string Size;

        public Present(string name, int quantity, string size)
        {
            Name = name;
            Quantity = quantity;
            Size = size;
        }
    }
}
