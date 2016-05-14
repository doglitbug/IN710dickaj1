using System;
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
            String[] tables = { "tbl_assignment", "tbl_paper", "tbl_tutor"};

            foreach (String table in tables)
            {
                dropTableIfExists(table);
            }

            //Create new tables
            //TODO On update/on delete for dropping out of a paper
            String tutorTable = "CREATE TABLE tbl_tutor" +
                                "(" +
                                "   id int NOT NULL PRIMARY KEY," +
                                "   name char(30) NOT NULL," +
                                "   email char(100) NOT NULL," +
                                ")";
            runQuery(tutorTable);

            String paperTable = "CREATE TABLE tbl_paper" +
                                "(" +
                                "   id int NOT NULL PRIMARY KEY," +
                                "   name char(50) NOT NULL," +
                                "   tutor_id int NOT NULL," +
                                "   CONSTRAINT FK_tutor_paper FOREIGN KEY(tutor_id) REFERENCES tbl_tutor(id)" +
                                ")";
            runQuery(paperTable);

            String assignmentTable = "CREATE TABLE tbl_assignment" +
                                     "(" +
                                     "  id int NOT NULL PRIMARY KEY," +
                                     "  paper_id int NOT NULL," +
                                     "  name char(50) NOT NULL," +
                                     "  mark int NULL," +
                                     "  dateDue date NOT NULL," +
                                     "  CONSTRAINT FK_paper_assignment FOREIGN KEY(paper_id) REFERENCES tbl_paper(id)" +
                                     ")";
            runQuery(assignmentTable);

            //Populate with seed data
            //TODO Make method that takes parameters?
            String seedTutorTable = "INSERT INTO tbl_tutor VALUES (1,'Bob','bob@school.nz');" +
                                    "INSERT INTO tbl_tutor VALUES (2,'Mary','mary@school.nz');" +
                                    "INSERT INTO tbl_tutor VALUES (3,'John','john@school.nz');";
            runQuery(seedTutorTable);

            String seedPaperTable = "INSERT INTO tbl_paper VALUES (1,'IN710 OOSD',1);" +
                                    "INSERT INTO tbl_paper VALUES (2,'IN712 Web 3',2);" +
                                    "INSERT INTO tbl_paper VALUES (3,'IN721 Mobile',3);" +
                                    "INSERT INTO tbl_paper VALUES (4,'Project',3);";

            runQuery(seedPaperTable);

            String seedAssignmentTable = "INSERT INTO tbl_assignment VALUES (1,1,'SQL',50,'20160327');" +
                                         "INSERT INTO tbl_assignment VALUES (2,1,'Threads',25,'20160325');" +
                                         "INSERT INTO tbl_assignment VALUES (3,1,'Exam',0,'20160521');" +
                                         "INSERT INTO tbl_assignment VALUES (4,2,'Javascript',50,'20160314');" +
                                         "INSERT INTO tbl_assignment VALUES (5,2,'Django',0,'20160528');" +
                                         "INSERT INTO tbl_assignment VALUES (6,3,'Play store',0,'20161001');" +
                                         "INSERT INTO tbl_assignment VALUES (7,4,'Final mark',0,'20161009');";

            runQuery(seedAssignmentTable);
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
