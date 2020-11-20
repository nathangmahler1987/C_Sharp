using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe01
{
    class Video
    {
        /// <summary>
        /// class attributes
        /// </summary>
        public string title;
        public double time;
        public char rating;

        //constructor method
        public Video(string aTitle, double aTime, char aRating)
        {
            title = aTitle;
            time = aTime;
            rating = aRating;
        }

    }
}
