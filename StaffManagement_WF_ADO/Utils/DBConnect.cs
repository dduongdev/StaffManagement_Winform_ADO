using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace StaffManagement_WF_ADO.Utils
{
    public class DBConnect
    {
        private static SqlConnection _conn = null;

        private static void initConnection(string connectionStrName)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[connectionStrName].ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new ArgumentNullException($"The connection string {connectionStrName} is null or empty");
                }

                _conn = new SqlConnection(connectionString);
            }
            catch (ConfigurationErrorsException ex)
            {
                throw new ConfigurationErrorsException("An error occurred while reading " +
                    "the connection string from the configuration file.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("An unexpected error occured while retrieving the " +
                    "connection string.", ex);
            }
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                if(_conn == null)
                {
                    initConnection("myconnect");
                }

                if(_conn.State == System.Data.ConnectionState.Closed)
                {
                    _conn.Open();
                }

                return _conn;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occured while opening the database connection.", ex); ;
            }
        }

        public static void CloseConnection()
        {
            if(_conn != null && _conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
            }
        }
    }
}
