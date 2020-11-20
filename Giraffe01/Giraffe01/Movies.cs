using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe01
{
    class Movies
    {
        //class attruibutes
        //the only rating available are G, PG, PG-13, R, NR so basically we will only want these values so we will use getters and setters to basically perform data validation
        public string title;
        public string director;
        // 1st part of using getters and setters is making the class attribute private. Private means that it can only be accessed by code in the class it is in. Getters and Setters allow us to modify attributes marked as private
        private string rating;
        //constructor method
        public Movies(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }
        //we are now creating the getters and setters, they are defined through properties which are basically like special methods for getters and setters
        //properties for getters and setters
        public string Rating
        {
            get { return rating; }
            set 
            { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}
