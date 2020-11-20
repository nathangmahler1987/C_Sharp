using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kud_switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////multiple if else statements can be replaced with switch statement
            //Console.WriteLine("Please enter a numer");
            //int userNumber = int.Parse(Console.ReadLine());

            //switch (userNumber)
            //{
            //    case 10:
            //        Console.WriteLine("Your Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Your Number is 20");
            //        break;
            //    case 30:
            //        Console.WriteLine("Your Number is 30");
            //        break;
            //    default:
            //        Console.WriteLine("Your number is not 10, 20 or 30");
            //        break;
            //}
            //with a slight modification we can have some case statement together
            //switch (userNumber)
            //{
            //    case 10:    
            //    case 20:
            //    case 30:
            //        Console.WriteLine("Your number is {0}", userNumber);
            //        break;
            //    default:
            //        Console.WriteLine("Your number is not 10, 20 or 30");
            //        break;
            //}
            // always avoid goto statements when possible
            int totalCoffeeCost = 0;
            Console.WriteLine("1-S, 2-M, 3-L");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    totalCoffeeCost += 1;
                    break;
                case 2:
                    totalCoffeeCost += 2;
                    break;
                case 3:
                    totalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Choose a size of coffee");
                    break;

            }
            //Console.WriteLine("Do you want to buy another coffee? Yes or No");
            //string userDecision = Console.ReadLine();

            //switch (userDecision)
            //{
            //    case "Yes":
            //        //he uses go to so I just skipped the rest of the tutorial, 
            //    default:
            //        break;
            //}

        }
    }
}
