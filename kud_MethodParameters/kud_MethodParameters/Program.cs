using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kud_MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //methods continued (video 16, method parameters): Methods can have 4 different types of parameters: 1) Value parameters 2) Reference parameters 3) out parameters 4) Parameter Arrays. Also, method parameters vs method aarguments.
            //method call, illustrating pass by value
            //int i = 0;
            //SimpleMethod(i);
            //Console.WriteLine(i);
            //method call, illustrating pass by reference
            //int i = 0;
            //SimpleMethod(ref i);
            //Console.WriteLine(i);
            //out parameter method call
            //int Total = 0;
            //int Product = 0;
            ////must use the out keyword when doing the method call, must line up with method signature
            //Calculate(10, 20, out Total, out Product);
            //Console.WriteLine(Total + " " + Product);

            //creating a new array for method
            int[] Numbers = new int[3];

            Numbers[0] = 1;
            Numbers[1] = 2;
            Numbers[2] = 3;
            //method call. B/C we have aprams keyword passing in an array is optional
            ParamsMethod(Numbers);

        }
        //method illustrating pass by value
        //public static void SimpleMethod(int j)
        //{
        //    j = 101;
        //}
        //pass by reference, you have to put the ref keyword in the method parameter and in your method call
        //public static void SimpleMethod(ref int j)
        //{
        //    j = 101;
        //}
        //output parameter, can only have 1 return value in function so for a second value we can make use of output parameters. must use the out keyword in the method signature.
        //public static void Calculate(int FN, int SN, out int Sum, out int Product)
        //{
        //    Sum = FN + SN;
        //    Product = FN * SN;
        //}

        //parameter arrays example, to create parameter arrays we need the params keyword. Params keyword also makes passing in an array optional.
        //Perhaps greatest advantag of using params key word is ability to pass any number of items we would like:) in method call.
        //params keyword had to be last, and can only have one array
        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine(Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
        //parameters v arguments, parameters in method signature when actually passed (used) they are refererred to as arguments
    }
}
