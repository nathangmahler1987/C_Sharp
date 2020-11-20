using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace kud_dowhile
{
    class Program
    {
        /// <summary>
        /// Not a dowhile loop, just anexercise I did on my own. I cannot get this to work quite right. I need to get the startt variable to re initialize when the game is played again. and I would like to delay the closing of the program when the user chhoses not to play again.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //start program
            Console.WriteLine("Please enter your target number");
            //create target variable
            int userTarget = int.Parse(Console.ReadLine());
            //create a counter variable
            int start = 0;
            // while loop to play game
            while (start <= userTarget)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
            // ask user if they want to play again?
            Console.WriteLine("Did you want to play again? Y/N");
            //get and store answer
            string userChoice = Console.ReadLine().ToLower();
            //reset start number
            while (userChoice == "y")
            {
                if (userChoice == "y")
                {
                    
                    //loop to play game
                    do
                    {
                        //if user said yes they need to enter a target number again
                        Console.WriteLine("Please enter a target number again");
                        //store target
                        userTarget = int.Parse(Console.ReadLine());
                        Console.WriteLine(start);
                        start = start + 2;
                    } while (start <= userTarget);

                }
            Console.WriteLine("Did you want to play again? Y/N");
            userChoice = Console.ReadLine().ToLower();
            }
            try
            {
                Console.WriteLine("you will leave the program in 5 seconds");
                //await Task.Delay(5000);
            }
            catch (Exception)
            {

                throw;
            }
            
            //difference between do while and while loop
        }
    }
}
