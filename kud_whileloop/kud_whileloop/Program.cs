using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kud_whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target number");
            int userChoice = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userChoice)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
