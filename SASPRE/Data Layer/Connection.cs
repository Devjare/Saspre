using System;
using MySql.Data.MySqlClient;

namespace SASPRE.Data_Layer
{
    class Connection
    {
        private MySqlConnection connection;
        private String connectionString;

        public Connection()
        {
            connectionString = Properties.Resources.connectionString;
            Console.WriteLine($"Connection String {connectionString}");

            connection = new MySqlConnection(connectionString);

            Console.WriteLine($"CONSTRUCTOR: Connection state: {connection.State}");
        }

        public MySqlConnection OpenConnection()
        {

            try
            {

                if (connection.State == System.Data.ConnectionState.Open)
                    return connection;
                else
                    connection.Open();

            }
            catch (Exception e)
            {
                return null;
                throw;
            }

            Console.WriteLine($"Connection state: {connection.State}");
            return connection;

        }

        public MySqlConnection CloseConnection()
        {

            try
            {

                if (connection.State == System.Data.ConnectionState.Closed)
                    return connection;
                else
                    connection.Close();

            }
            catch (Exception e)
            {
                return null;
                throw;
            }

            Console.WriteLine($"Connection state: {connection.State}");
            return connection;

        }
    }
}
