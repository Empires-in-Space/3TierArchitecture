using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTier.DataConnectors
{
    class SqlConnector
    {
        public static SqlConnection getConnection()
        {
            //to use System.Configuration.ConfigurationManager, the project references had to be extended by "System.Configuration"
            // the appConfig file that will be used is part of the calling project! (either ClientApp or WebServerClient)
            // I am always switching between multiple connection strings - this way I only have to change the Cofig file
            string currentKey = System.Configuration.ConfigurationManager.AppSettings["activeConnection"];

            string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[currentKey].ToString();

            SqlConnection connection = new SqlConnection(ConnectionString);
            return connection;
        }

        //just an example
        public static MiddleTier.Core.Data.Ship getShip(int _shipId)
        {
            MiddleTier.Core.Data.Ship ship = null;

            // remove this if you have database demoDataBase on a local sqlServer with default name (the "." in the connection string) -> 
            new MiddleTier.Core.Data.Ship(1);
            return ship;
            // <- 

            SqlConnection connection = getConnection();
            using (connection)
            {
                SqlCommand command = new SqlCommand(
                  @"SELECT  TOP 1
                    [id]
                      ,[userid]
                      ,[NAME]
                      ,[movementPoints]                     
                FROM [engine].[v_Ships] where [id] = " + _shipId,
                  connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        int id = reader.GetInt32(0);
                        int userid = reader.GetInt32(1);

                        ship = new MiddleTier.Core.Data.Ship(id);
                       
                        ship.userid = userid;
                        ship.name = reader.GetString(2);                   

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception source: {0}", e.Source);
                        break;
                    }
                }

                reader.Close();
            }

            //ship may be null! 
            return ship;
        }
    }
}
