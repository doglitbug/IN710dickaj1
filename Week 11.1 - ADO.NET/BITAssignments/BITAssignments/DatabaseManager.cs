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

        public DatabaseManager()
        {
            //Set up new connection
            bitdevConnection= new SqlConnection();
            //Retrieve connection details
            String source = "bitdev.ict.op.ac.nz";
            String catalog = "IN700001_201601_DICKAJ1";
            String user = "dickaj1";
            //Load password from environment varible to avoid upload to Github
            String password = Environment.GetEnvironmentVariable("BIT_PASSWORD", EnvironmentVariableTarget.User);

            //Build connection string
            String connectionString = String.Format("Data Source = {0};Initial Catalog = {1};User ID = {2};Password = {3};",
                                                    source,catalog,user,password);
            //Apply the connection string
            bitdevConnection.ConnectionString = connectionString;


            bitdevConnection.Open();
            //TODO
            bitdevConnection.Close();
        }
    }
}
