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
    public class Users:ConnectionToMySql
    {
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
                    command.CommandText = "Select *from Users where Login=@user and Password=@pass";
                    //Пользовательский параметр  со значением 
                    command.Parameters.AddWithValue("@user" , user);
                    command.Parameters.AddWithValue("@pass", pass);
                    //Какой тип командфы 
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    //Если у reader есть строки, которые мы возращаем, то запрос успешный
                    if (reader.HasRows)
                    {
                        //Добавляем значение столбца к статическим полям класса 
                        //Загружает данные из пользователей в класс UserCache
                        while(reader.Read())
                        {
                            UserCache.Id = reader.GetInt32(0);
                            UserCache.Name = reader.GetString(3);
                            UserCache.Position = reader.GetString(4);
                            UserCache.Email = reader.GetString(5);
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
        //"Любой метод" для безопасности и права пользователя 
        public void AnyMethod()
        {
            //Условие,где спрашиваем, что такое позиция пользователя, вошедшего в систему 
            if(UserCache.Position == Positions.Administrator)
            {
                //Код
            }
            if(UserCache.Position == Positions.Employees || UserCache.Position == Positions.Guest)
            {
                //Kod
            }
        }
    }
}
