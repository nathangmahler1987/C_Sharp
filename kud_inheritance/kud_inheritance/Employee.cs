using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kud_inheritance
{
    //this will be our base class
    class Employee
    {
        public string FN;
        public string LN;
        public string email;

        public void PrintFullName()
        {
            Console.WriteLine(FN + " " + LN);
        }

    }
}
