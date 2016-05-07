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
            List<String> output = new List<String>();

            //Provide a title
            output.Add("1. Compute and display the average intensity for all strikes");
            output.Add("------------------------------------------------------------");

            //Perform SQl query
            try
            {
                double averageIntensty = (from b in db.tblStrikes
                                          select b.strikeIntensity).Average();

                //Format results for output
                output.Add(averageIntensty.ToString());
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                output.Add("SQL Client error: " + e);
            }
            
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
            output.Add("2.	List the complete records of the largest three fires (in terms of area)");
            output.Add("---------------------------------------------------------------------------");

            //Perform SQl query
            try
            {
                IEnumerable<tblFire> threeLargest = (from fire in db.tblFires
                                                     orderby fire.fireArea
                                                     select fire).Take(3);

                //Format results for output
                foreach (tblFire fire in threeLargest)
                {
                    //Build record
                    String record = fire.fireDate + "\t{" + fire.fireLatitude + ", " + fire.fireLongitude + "}\t" + fire.fireArea;
                    output.Add(record);
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                output.Add("SQL Client error: " + e);
            }

            return output;
        }

        /// <summary>
        /// Display the latitude, longitude and filename for each picture
        /// </summary>
        /// <returns>String list of results</returns>
        public List<String> getLocationPicture()
        {
            //Hold output
            List<String> output = new List<String>();

            //Provide a title
            output.Add("3.	Display the latitude, longitude and filename for each picture");
            output.Add("-----------------------------------------------------------------");

            //Perform SQl query
            try
            {
                var locationPicture = from picture in db.tblPictures
                                      join strike in db.tblStrikes
                                      on picture.strikeID equals strike.strikeID
                                      select new { strike.strikeLatitude, strike.strikeLongitude, picture.pictureFileName };

                //Format results for output
                foreach (var result in locationPicture)
                {
                    //Build record
                    String record = "{" + result.strikeLatitude + ", " + result.strikeLongitude + "}\t" + result.pictureFileName;
                    output.Add(record);
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                output.Add("SQL Client error: " + e);
            }
            return output;
        }

        /// <summary>
        /// List all fires that were caused by a lightning strike.
        /// </summary>
        /// <returns>String list of results</returns>
        public List<String> getFireStrikes()
        {
            //Hold output
            List<String> output = new List<String>();

            //Provide a title
            output.Add("4.	List all fires that were caused by a lightning strike");
            output.Add("---------------------------------------------------------");

            //Perform SQl query
            try
            {
                IEnumerable<tblFire> fireStrikes = from fire in db.tblFires
                                                   join strike in db.tblStrikes
                                                   on new { A = fire.fireLatitude, B = fire.fireLongitude, C = fire.fireDate }
                                                   equals new { A = strike.strikeLatitude, B = strike.strikeLongitude, C = strike.strikeDate }
                                                   select fire;

                //Format results for output
                foreach (tblFire result in fireStrikes)
                {
                    //Build record
                    String record = result.fireDate + "\t {" + result.fireLatitude + ", " + result.fireLongitude + "}\t" + result.fireArea;
                    output.Add(record);
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                output.Add("SQL Client error: " + e);
            }
            return output;
        }
    }
}
