﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MassarAdminDesktop
{
    public class DBConnect
    {
        protected static MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();

        }

        private void Initialize()
        {
            server = "31.220.105.14";
            database = "offerson_masar";
            uid = "offerson_ramzi";
            password = "ramzi150";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            OpenConnection();
        }

        private static bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static bool checkConnection()
        {
            if (connection.State.ToString() == "Open")
                return true;
            CloseConnection();
            OpenConnection();
            if (connection.State.ToString() == "Open")
                return true;
            return false;





        }

        public static bool Post(string query)
        {
            if (!checkConnection())
                return false;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch {
                return false;
            }
            return true;
        }
        public static MySqlDataReader Gets(string query)
        {
            if (!checkConnection())
                return null;
            //create command and assign the query and connection from the constructor
            MySqlCommand cmd = new MySqlCommand(query, connection);

            return cmd.ExecuteReader();
        }

        public static string Get(string query)
        {
            MySqlDataReader r = Gets(query);
            r.Read();
            string rt = r[0].ToString();
            r.Close();
            return rt;
        }

    }

}
