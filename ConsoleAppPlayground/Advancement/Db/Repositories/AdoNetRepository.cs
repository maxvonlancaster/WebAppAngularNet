using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Db.Repositories
{
    public class AdoNetRepository
    {
        private readonly string _connectionString;

        public AdoNetRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Main() 
        {
            SqlConnectionBasics();
        }

        public void SqlConnectionBasics() 
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString)) 
            {
                sqlConnection.Open();
                Console.WriteLine("connection opened");

                Console.WriteLine("Properties:");
                Console.WriteLine("\tConnection string: {0}", sqlConnection.ConnectionString);
                Console.WriteLine("\tDatabase: {0}", sqlConnection.Database);
                Console.WriteLine("\tServer: {0}", sqlConnection.DataSource);
                Console.WriteLine("\tServer version: {0}", sqlConnection.ServerVersion);
                Console.WriteLine("\tState: {0}", sqlConnection.State);
                Console.WriteLine("\tWorkstationld: {0}", sqlConnection.WorkstationId);
            }
        }

        public void TableCreationAndSeeding() { }

        public void Joins() { }

        public void Having() { }



        public void DropTables() { }
    }
}
