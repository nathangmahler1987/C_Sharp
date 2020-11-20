using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_vs_instance
{

    class Circle
    {
        //it makes sense to make pi static because it will not change, making it static makes it so there is only one copy of the field. Instance fields are copies, so if you have 1000 instances of Circles and you declare PI as an instance variable you will make a seperate copy of PI for each Cirlce object. It can also be applied to methods and classes. AN INSTANCE MEMBER BELONGS TO A SPECIFIC INSTANCE (OBJECT) OF A CLASS., I WILL HAVE 3 SETS OF INSTANCE MEMBERS IN THE MEMORY, WHERE AS THERE WILL EVER BE ONLY ONE COPY OF A STATIC MEMBER, NO MATTER HOW MANY INSTANCES OF A CLASS ARE CREATED.
        //remember the this keyword is referring to an instance of that class (instance), so static cannot use this keyword.
        static float _PI = 3.14F;
        int _Radius;
        // contstructors can also be static
        // the would be one below would be static Circle(). Can't have parameters. We use static constructors to access static methods or fields
        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            //when using static members of a class you need to refer to it with the class name (or if it is in the same scope no name at all) not with an object of the instance.  
            return _PI * this._Radius * this._Radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float area = C1.CalculateArea();

            Console.WriteLine("The area is {0}", area);

            Circle C2 = new Circle(6);
            float area2 = C2.CalculateArea();

            Console.WriteLine("The area is {0}", area2);
        }
    }
}
