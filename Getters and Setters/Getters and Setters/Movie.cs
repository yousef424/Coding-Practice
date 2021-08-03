using System;
using System.Collections.Generic;
using System.Text;

namespace Getters_and_Setters
{
    class Movie
    {
        public string name;
        public string director;
        private string rating;

        public Movie ( string aName, string aDirector, string aRating)
        {
            name = aName;
            director = aDirector;
            Rating = aRating;
        }


        public string Rating
        {
            get
            { 
                return rating; 
            }
            set
            { 
                if(value == "G" || value == "PG" || value == "NR" || value == "PG-13")
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
