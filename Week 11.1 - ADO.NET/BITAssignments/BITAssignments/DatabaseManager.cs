﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITAssignments
{
    public class DatabaseManager
    {
        SqlConnection bitdevConnection;

        /// <summary>
        /// Constructor
        /// </summary>
        public DatabaseManager()
        {
            //Set up new connection
            bitdevConnection = new SqlConnection();
            //Retrieve connection details
            String source = "bitdev.ict.op.ac.nz";
            String catalog = "IN700001_201601_DICKAJ1";
            String user = "dickaj1";
            //Load password from environment varible to avoid upload to Github
            String password = Environment.GetEnvironmentVariable("BIT_PASSWORD", EnvironmentVariableTarget.User);

            //Build connection string
            String connectionString = String.Format("Data Source = {0};Initial Catalog = {1};User ID = {2};Password = {3};",
                                                    source, catalog, user, password);
            //Apply the connection string
            bitdevConnection.ConnectionString = connectionString;
            //Test Connection
            bitdevConnection.Open();
            //Finally close
            bitdevConnection.Close();
        }

        /// <summary>
        /// Creates a new set of tables and enters seed data
        /// </summary>
        public void createSchema()
        {
            //Drop old tables
            String[] tables = { "tbl_tutor", "tbl_paper", "tbl_assignment" };

            foreach (String table in tables)
            {
                dropTableIfExists(table);
            }

            //Create new tables
            String tutorTable=  "CREATE TABLE tbl_tutor"+
                                "("+
                                "   id int NOT NULL PRIMARY KEY,"+
                                "   name char(30) NOT NULL,"+
                                "   email char(100) NOT NULL,"+
                                ")";
            runQuery(tutorTable);




            //TODO Populate with seed data

            throw new NotImplementedException();
        }

        /// <summary>
        /// Run the given query
        /// </summary>
        /// <param name="query">Query string to run</param>
        private void runQuery(String query)
        {
            bitdevConnection.Open();
            //Create command object
            SqlCommand sqlCommand= new SqlCommand(query, bitdevConnection);
            //Execute the query
            sqlCommand.ExecuteNonQuery();
            //Close connection
            bitdevConnection.Close();
        }

        /// <summary>
        /// Drops a table if it exists
        /// </summary>
        /// <param name="tableName">Table name to drop</param>
        private void dropTableIfExists(String tableName)
        {
            //Create the query string
            String query = String.Format("IF OBJECT_ID('{0}','U') IS NOT NULL DROP TABLE {0};", tableName);
            //Execute
            runQuery(query);
        }

        #region Reporting functions
        /// <summary>
        /// Gets a report for all papers
        /// </summary>
        /// <returns>String List of results</returns>
        public List<String> reportAllPapers()
        {
            //Hold output
            List<String> output = new List<String>();
            //TODO Build report and return
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a report of all assignments due in next two weeks
        /// </summary>
        /// <returns>String List of results</returns>
        public List<String> reportAssignmentsDue()
        {
            //Hold output
            List<String> output = new List<String>();
            //TODO Build report and return
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a report of the average mark for all completed assignments for each paper
        /// </summary>
        /// <returns>String List of results</returns>
        public List<String> reportAverageMarksSoFar()
        {
            //Hold output
            List<String> output = new List<String>();
            //TODO Build report and return
            throw new NotImplementedException();
        }
        #endregion
    }
}
