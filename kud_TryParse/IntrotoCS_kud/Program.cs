using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoCS_kud
{
    class Program
    {
        static void Main(string[] args)
        {
            //data type conversions
            float f = 123.45F;
            //explicit conversion 2 ways
            //1) type-cast
            int i = (int)f;
            //use convert class
            //int i = Convert.ToInt32(f);
            //what is the difference?
            //The Convert class is more likely to give us a better message. 
            Console.WriteLine(i);

            string strNumber = "200";
            //Parse method
            int a = int.Parse(strNumber);
            //Try.Parse Method
            string SomeNum = "8fgh";
            
            int result = 0;
            //TryParse method returns true or false
            //the out parameter tells us where we will store the data
            bool IsConversionSuccessful = int.TryParse(SomeNum, out result);
            if (IsConversionSuccessful)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
