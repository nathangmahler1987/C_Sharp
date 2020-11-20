using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kud_classes
{
    class Customer
    {
        //attributs of class
        string _FN;
        string _LN;
        //initializing class with constructor, same name as class, can take parameters but cannot return a value
        public Customer(string FN, string LN)
        {
            //this keyword refers to an instance of the class, why use "this" as a keyword if we can declare variable without it?
            this._FN = FN;
            this._LN = LN;
        }


        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", _FN + " " + _LN);
        }

    }
}
