using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestMovieDatabase
{
    /// <summary>
    /// Class to represent an individual movie
    /// </summary>
    class Movie
    {
        /// <summary>
        /// Year of movie
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Title of movie
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// Director of movie
        /// </summary>
        public String Director { get; set; }

        /// <summary>
        /// Create a new Movie object constructor
        /// </summary>
        /// <param name="year">Movie year</param>
        /// <param name="title">Movie title</param>
        /// <param name="director">Movie director(s)</param>
        public Movie(int year, String title, String director)
        {
            Year = year;
            Title = title;
            Director = director;
        }

        /// <summary>
        /// Overridden method to nicely format the movie as a string
        /// </summary>
        /// <returns>String representation of this movie</returns>
        public override String ToString()
        {
            return Year.ToString() + ", " + Title + ", " + Director;
        }
    }
}