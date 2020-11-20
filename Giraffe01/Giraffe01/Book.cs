using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe01
{
    //It is helpful for me to think of classes as creating a new data type and in the class we have attributes of this new datatype or new class.
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //constructor method
        //we set it up to take 3 args and we set the attributes equal to those args so we don't have to explicitly define it like we did in the first book example on the Program.cs page
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
