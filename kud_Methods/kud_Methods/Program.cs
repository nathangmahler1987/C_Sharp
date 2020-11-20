using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kud_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //methods extremely useful because they allow you to define your logic once and use it many times.
            //also make maintenance of application easier.

            //function call, since we are calling an instance method we need to create an instance of the class first
            //Program p = new Program();
            //function call
            //p.EvenNumbers();
            //static method call
            Program.EvenNumbers(30);
            EvenNumbers(30);
            //instance method call
            Program p = new Program();
            int Sum = p.Add(10, 20);
            Console.WriteLine(Sum);
            
        }
        //function method to print even numbers, instance method if not specified otherwise
        //public void EvenNumbers()
        //{
        //    int start = 0;

        //    while (start <= 20)
        //    {
        //        Console.WriteLine(start);
        //        start = start + 2;
        //    }
        //}
        //to make static just add static keyword before return type.
        public static void EvenNumbers(int Target)
        {
            int start = 0;

            while (start <= Target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
        //this is an instance method
        public int Add(int FN, int SN)
        {
            return FN + SN;
        }
 
    }
}
