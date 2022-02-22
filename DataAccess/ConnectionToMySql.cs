﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public  abstract class ConnectionToMySql
    {
        //Создаём поле для чтения типу строки подключения 
        public readonly string connStr;
        public ConnectionToMySql()
        {
            connStr = "server= caseum.ru; user = st_2_11; database= st_2_11; password = 53259459; port = 33333";
        }
        //Создаём защищенный метод  типа соединение, чтобы получить соединение 
        protected MySqlConnection GetConn()
        {
            return  new MySqlConnection(connStr);
        }
    }

    public class Connection
    {
        private MySqlConnection connection = new MySqlConnection("server= caseum.ru; user = st_2_11; database= st_2_11; password = 53259459; port = 33333");

        public MySqlConnection ConnOpen()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }
        public MySqlConnection ConnClose()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }
    }
}
