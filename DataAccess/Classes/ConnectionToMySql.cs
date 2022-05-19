using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    //          Используется в авторизации
    public  abstract class ConnectionToMySql
    {
        //Создаём поле для чтения типу строки подключения 
        public readonly string connStr;
        public ConnectionToMySql()
        {
            //Строка подключения
            connStr = "server=chuc.caseum.ru; user = st_2_18_11; database= is_2_18_st11_VKR; password = 59173741; port = 33333";
        }
        //Создаём защищенный метод  типа соединение, чтобы получить соединение 
        protected MySqlConnection GetConn()
        {
            return  new MySqlConnection(connStr);
        }
    }
    //server=chuc.caseum.ru;port=33333;user=ЛОГИН;database=БАЗА;password=Пароль;
    public class Connection
    {
        //Создаём экземпляр класса MySqlConnection, в котором указываем строку подключения
        private MySqlConnection connection = new MySqlConnection("server=chuc.caseum.ru; user = st_2_18_11; database= is_2_18_st11_VKR; password = 59173741; port = 33333");
        //Открывает соединение
        public MySqlConnection ConnOpen()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }
        //Закрываем соединение
        public MySqlConnection ConnClose()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }

    }
}
