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

        public List<String> getAverageIntensty()
        {
            //Hold output
            List<String> output=new List<String>();

            //Provide a title
            output.Add("1. Compute and display the average intensity for all strikes");
            output.Add("------------------------------------------------------------");

            return output;
        }
    }
}
