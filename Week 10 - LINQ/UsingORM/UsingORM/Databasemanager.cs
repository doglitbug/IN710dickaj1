using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingORM
{
    public class DatabaseManager
    {
        /// <summary>
        /// Holds connection to MS SQL database
        /// </summary>
        private DataClassesDataContext db;

        /// <summary>
        /// Constructor
        /// </summary>
        public DatabaseManager()
        {
            //Connect to database
            db = new DataClassesDataContext();
        }

        /// <summary>
        /// Get average intensity of all strikes
        /// </summary>
        /// <returns>String list of results</returns>
        public List<String> getAverageIntensty()
        {
            //Hold output
            List<String> output=new List<String>();

            //Provide a title
            output.Add("1. Compute and display the average intensity for all strikes");
            output.Add("------------------------------------------------------------");

            //Perform SQl query
            var averageIntensty = (from b in db.tblStrikes
                                  select b.strikeIntensity).Average();

            //Format results for output
            output.Add(averageIntensty.ToString());

            return output;
        }

        /// <summary>
        /// List the complete records of the largest three fires
        /// </summary>
        /// <returns>String list of results</returns>
        public List<String> getThreeLargestFires()
        {
            //Hold output
            List<String> output = new List<String>();

            //Provide a title
            output.Add("2.	List the complete records of the largest three fires (in terms of area).");
            output.Add("----------------------------------------------------------------------------");

            //Perform SQl query
            //TODO
            var threeLargest = (from fire in db.tblFires
                                orderby fire.fireArea
                                select fire).Take(3);

            //Format results for output
            foreach (var fire in threeLargest)
            {
                //Build record
                String record = fire.fireDate + "\t{" + fire.fireLatitude + ", " + fire.fireLongitude + "}\t" + fire.fireArea;
                output.Add(record);
            }

            return output;
        }
    }
}
