using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kud_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer("Nate", "Mahler");
            C1.PrintFullName();
        }
    }
}
