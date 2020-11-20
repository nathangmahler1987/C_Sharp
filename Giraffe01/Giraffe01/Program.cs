using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe01
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a book object, this in an instance of the book class
            //Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            // we are naming the title attribute of this class
            //book1.title = "Harry Potter";
            //author
            //book1.author = "JK Rowling";
            //pages
            //book1.pages = 400;
            //we can print out any title we want
            // Console.WriteLine(book1.title);
            // creating a book object, this in an instance of the book class
            Book book2 = new Book("LOR","Tolkien", 800);

            //student class objects
            //the parts are like naming a variable: 1) datatype (in this case a class)2)name of our object3) on the other side of the object we basically say new Student(object information) to call the constructor method and then we terminate with a ;
            Student Student1 = new Student("Jim", "Business", 2.8);
            Student Student2 = new Student("Pam", "Art", 3.6);

            //calling Student object methods, depending on which object calls it  it will use the different arguments
            //Console.WriteLine(Student1.HasHonors());
            //Console.WriteLine(Student2.HasHonors());
            //Console.WriteLine(Student1.Department());
            //Console.WriteLine(Student2.Department());

            //create class objects
            //Movies avengers = new Movies("The Avengers", "Josh Whedon", "PG-13");
            //Movies shrek = new Movies("Shrek", "Adam Adamson", "PG");
            //Console.WriteLine(avengers.Rating);

            //Song holiday = new Song("Holiday", "Green Day", 200);
            //Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            //Console.WriteLine(Song.songCount);
            
            // a static method is a method that belongs to the class itself so we do not have to create an instance of the class to use it.

            // end program
            Console.ReadLine();    
        }
        //object methods

    }
}
