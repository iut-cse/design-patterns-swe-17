using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Preference
    {
        private static Preference instance;

        string serverIp = "localhost";
        string username = "root";
        string password = "rootroot";
        string databaseName = "assignment";

        MySqlConnection connection;
        MySqlCommand mySqlCommand;

        private Preference()
        {
            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);
            this.connection = new MySqlConnection(dbConnectionString);
            connection.Open();
        }
        public static Preference getInstance()
        {
            if (instance == null)
            {
                //acquireThreadLock();
                if (instance == null)
                {
                    instance = new Preference();
                }
            }
            return instance;
        }


        public void setPreference(string key, string val)
        {
            string query = "INSERT INTO pref(key, value) VALUES(@key, @value)";

            MySqlCommand mySqlCommand = new MySqlCommand(query, this.connection);
            mySqlCommand.Parameters.AddWithValue("@key", key);
            mySqlCommand.Parameters.AddWithValue("@key", val);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("DatabaseName Error : " + e);
            }
        }

        public string getPreference(string key)
        {

            string value=null;
            String query = "Select value from pref where key= @key";
            mySqlCommand = new MySqlCommand(query, this.connection);
            mySqlCommand.Parameters.AddWithValue("@key", key);
            var reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                value = reader["value"].ToString();
            }
            return value;
        }
    }
}
