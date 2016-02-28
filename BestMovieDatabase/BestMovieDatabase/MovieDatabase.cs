using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestMovieDatabase
{
    class MovieDatabase
    {
        /// <summary>
        /// Dictionary to hold movies
        /// </summary>
        Dictionary<int, Movie> movieTable;

        /// <summary>
        /// Earliest year that we can have a movie for
        /// There isn't a point in having a movie before the awards started
        /// TODO Figure out which year this should actually be
        /// </summary>
        const int EARLIEST_YEAR = 1900;

        /// <summary>
        /// Default constructor, initilizes movieTable
        /// </summary>
        public MovieDatabase()
        {
            movieTable = new Dictionary<int, Movie>();
        }

        /// <summary>
        /// Add a new movie to the database
        /// </summary>
        /// <param name="year">Movie year</param>
        /// <param name="title">Movie title</param>
        /// <param name="Director">Movie director</param>
        /// <param name="feedback">Feedback about success of adding movie</param>
        /// <returns>True if addition was successful</returns>
        public Boolean AddMovie(String year, String title, String director, out String feedback)
        {
            int key;
            //TODO Place return false in each check so that user only gets one error message?
            //Check year is valid
            checkYear(year, out key, out feedback);

            //Check that there isn't already a movie for this year!
            if (movieTable.ContainsKey(key))
            {
                feedback += " A movie for " + key + " already exists.";
            }

            //Check a title has been entered
            if (title.Length == 0)
            {
                feedback += " Please enter a title.";
            }

            //Check a director has been entered
            if (director.Length == 0)
            {
                feedback += " Please enter a director.";
            }

            //Check all data is valid
            if (feedback != "")
            {
                return false;
            }

            //Create new movie and add to database now that we know that data is all okay
            Movie movie = new Movie(key, title, director);
            movieTable.Add(key, movie);

            feedback = "Movie was added successfully";
            return true;
        }

        /// <summary>
        /// Delete a movie from the database
        /// </summary>
        /// <param name="year">Year of movie to remove</param>
        /// <param name="feedback">feedback about success of deleting movie</param>
        /// <returns>True if the movie was found and deleted</returns>
        public Boolean DeleteMovie(String year, out String feedback)
        {
            int key;
            //Check year is valid
            if(!checkYear(year, out key, out feedback))
            {
                return false;
            }

            //Check key exists
            if (movieTable.ContainsKey(key))
            {
                movieTable.Remove(key);
                feedback = "Movie was deleted successfully";
                return true;
            }
            else
            {
                feedback = "Movie was not found in database";
                return false;
            }
        }

        public Boolean SearchMovie(String year, out String feedback){
            int key;
            //Check year is valid
            if (!checkYear(year, out key, out feedback))
            {
                return false;
            }
            //Check key exists
            if (movieTable.ContainsKey(key))
            {
                feedback=movieTable[key].ToString();
                return true;
            }
            else
            {
                feedback = "Movie was not found in database";
                return false;
            }
        }

        /// <summary>
        /// Checks the input for year and convert to int/provides feedback
        /// Also checks it is a reasonable year(not before EARLIEST_YEAR or after current year)
        /// </summary>
        /// <param name="input">Input to check</param>
        /// <param name="year">Int of the valid year</param>
        /// <param name="feedback">Feedback regarding the conversion/check. Empty if correct</param>
        /// <returns>True if year is valid</returns>
        private Boolean checkYear(String input, out int year,out String feedback)
        {
            feedback = "";
            //Try convert given year string into a number
            try
            {
                year = Convert.ToInt16(input);                
            }
           //Catch incorrect format i.e letters instead of plain numbers
           catch (FormatException){
                   feedback = "Year was not entered in a correct format, ie 1956.";
                   year = 0;
                   return false;
             }
            //Handle other exceptions
            catch (Exception ex)
            {
                feedback = ex.Message;
                year = 0;
                return false;
            }

            //Check the number is with in reasonable bounds
            if (!((year >= EARLIEST_YEAR) & (year <= DateTime.Now.Year)))
            {
                feedback = "Invalid year: please choose something between "+EARLIEST_YEAR+" and now.";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Provide a string representation of all movies in database
        /// </summary>
        /// <returns>List of all movies or short message if none</returns>
        public override String ToString()
        {
            //Create a stringbuilder to hold the results to be passed back
            StringBuilder result = new StringBuilder();
            
            //Check to see if there are any movies in the database
            if (movieTable.Count() == 0)
            {
                result.Append("There are no movies in the database.");
            }
            else
            {
                //Get all the movies
                foreach (KeyValuePair<int, Movie> currentMovie in movieTable)
                {
                    result.Append("-------------------------------------------\r\n");
                    result.Append(currentMovie.Key.ToString()+"\r\n");
                    result.Append(currentMovie.Value.ToString()+"\r\n");
                }
            }
            return result.ToString();
        }
    }
}