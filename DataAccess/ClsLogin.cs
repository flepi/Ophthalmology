using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Common.Cache;

namespace DataAccess
{
    public class ClsLogin:ConnectionToMySql
    {
        //Вычисление хэша строки и возрат его из метода
        static string sha256(string randomString)
        {
            //Тут происходит криптографическая магия. Смысл данного метода заключается в том, что строка залетает в метод
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        //Метод входа
        public bool Login(string user, string pass)
        {
            //using- блок гарантирует вызов метода одноразово т.е соединение базового класса будет существовать
            //до тех пор, пока строки внутри блока не закончатся,когда закончатся их просто выбросят и отпустит используемые ресурсы 
            //var неявная переменная 
            using(var connection = GetConn())
            {
                connection.Open();
                using(var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Users where login=@user and password=@pass";
                    //Пользовательский параметр  со значением 
                    command.Parameters.AddWithValue("@user" , user);
                    command.Parameters.AddWithValue("@pass", pass);
                    //Какой тип команды 
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    //Если у reader есть строки, которые мы возращаем, то запрос успешный
                    if (reader.HasRows)
                    {
                        //Добавляем значение столбца к статическим полям класса 
                        //Загружает данные из пользователей в класс UserCache
                        while(reader.Read())
                        {
                            UserCache.id = reader.GetInt32(0);
                            UserCache.name = reader.GetString(1);
                            UserCache.role = reader.GetString(4);
                        }
                        return true;
                    }    
                    else
                    {
                        return false;
                    }
                }
            }
        }
        //Метод который возращает значения логина и пароля

            public bool LoginUser(string user, string pass)
            {
                return Login(user, pass);
            }



        //"Любой метод" для безопасности и права пользователя 
        public void AnyMethod()
        {
            //Условие,где спрашиваем, что такое позиция пользователя, вошедшего в систему 
            if (UserCache.role == Positions.Administrator)
            {
                //Код
            }
            if (UserCache.role == Positions.Director || UserCache.role == Positions.Register)
            {
                //Код
            }
        }
    }
}
