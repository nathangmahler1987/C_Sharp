using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe01
{
    class Song
    {
        //class attributes
        public string title;
        public string artist;
        public int duration;
        //static attribute
        //static attributes are attributes for the entire class not an individual object
        public static int songCount = 0;
        // constructor method
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            //we are incrementing the songCount variable
            songCount++;
        }
        //I could make a method with the songCount static attribute and it would make it possible for the individual objects to use that attribute via a method.
        public int getSongCount()
        {
            return songCount;
        }

    }
}
