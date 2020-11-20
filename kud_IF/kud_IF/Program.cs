using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace kud_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement
            Console.WriteLine("Please enter a Number.");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber == 1)
            {
                Console.WriteLine("Your number is one.");
            }
            if (userNumber == 2)
            {
                Console.WriteLine("Your number is two.");
            }
            if (userNumber == 3)
            {
                Console.WriteLine("Your number is three.");
            }
            if (userNumber != 1 && userNumber != 2 && userNumber !=3)
            {
                Console.WriteLine("Your number is not one, two or three");
            }
            //above program is not effiecient
            //we can use else if to make it more efficient since else ifs are only processed if the other conditions are false, the above ifs process every line of code.
            //if else and else if statement
            if (userNumber == 1)
            {
                Console.WriteLine("Your number is one.");
            }
            else  if (userNumber == 2)
            {
                Console.WriteLine("Your number is two.");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Your number is three.");
            }
            else  
            {
                Console.WriteLine("Your number is not one, two or three");
            }


            //difference between && and &
            //same concept as || and |
            //difference between || and |, if || then if first condition is true it does not bother to check next condition, double pipes are generally faster
            if (userNumber == 10 || userNumber ==20)
            {
                Console.WriteLine("Hello there!");
            }
            // generally always use double || or &&
        }
    }
}
