using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kud_inheritance
{
    /*4 pillars of OOP 1) Inheritance 2) Encapsulation 3) Abstraction 4) Polymorphism
     * Inheritance allows code reuse and code reuse can reduce time and errors
     * A. In this example a derived class inherits from the parent class
     * B. C# supports only single class inheritance (only 1 base class, classes can inherit from another derived class)
     * C. C# supports multiple interface inheritance 
     * D. Child Class is specialization of base class
     * E. Base classes are automatically instantiated before derived classes
     * F. Parent Class constructor executes before Child Class constructor
     *  Remember a class can have more than one constructor and when inheriting from another class with more than one constructor we can use the base key word to specify which constructor we want. 
     *      IE public class Child_Class : Parent_Class
     *      public Child_Class() : base(parameter for constuctor we want called)
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            //why inheritance? Reduces duplicate code (promotes reusability).  
            //Full Time Employee object creation
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FN = "Nathan";
            FTE.LN = "C#";
            FTE.PrintFullName();
            FTE.YearlySalary = 50000;
            //so FTE object will have all code present in base class
            //derived class is specialized version of  base class

        }
    }
}
