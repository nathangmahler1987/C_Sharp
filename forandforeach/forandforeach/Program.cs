using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forandforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //create integer array
            int[] Numbers = new int[3];
            //creat individual elements of array
            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;
            //we are going to print to the console for each element in this array, we will do this with each loop
            //while loop
            //creat counter variable
            //int i = 0;
            //while (i < Numbers.Length)
            //{
            //    Console.WriteLine(Numbers[i]);
            //    i++;
            //}
            //for loop, same logic as while loop but we can do all (initialization, condition and increment, all in one place)
            //for (int j = 0; j < Numbers.Length; j++)
            //{
            //    Console.WriteLine(Numbers[j]);
            //}
            //for each loop, advantage is that you do not need to know how many elements in your collection, simple loop to loop through elements in collection. Best used for this purpose.
            //foreach (int k in Numbers)
            //{
            //    Console.WriteLine(k);
            //}
            //two important key words in loop break and continue, break gets you out of loop while continue just starts the loop over again?
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(i);
                
            }


        }
    }
}
