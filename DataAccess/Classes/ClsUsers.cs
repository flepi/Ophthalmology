using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DataAccess
{
    public class ClsUsers : Connection
    {
        //Добавление данных из sql
        MySqlDataReader leer;
        //Чтобы просчитать строки таблицы 
        DataTable table = new DataTable();
        //Добавляем sql-запрос для запуска
        MySqlCommand command = new MySqlCommand();

        //
        //Вывод информации о пользователях
        //
        public DataTable listUsers()
        {
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM Users";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }
        //
        //Добавление пользователей
        //
        public void AddUsers(string name, string login, string password, string role)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "INSERT INTO `Users` (`name` , `login` , `password`, `role`) " +
            "VALUES(@name, @login, @password, @role)";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", role);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }
        //
        //Метод для редактирования пользователя
        //
        public void EditUsers(string name, string login, string password, string role, int id)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "UPDATE `Users` SET name=@name, login=@login,password=@password,role=@role WHERE id=@id LIMIT 1";
            //"WHERE (id_doc) " +
            //"LIMIT 1";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", role);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
        }

        //
        //Удаление
        //
        public void DeleteUsers(int id)
        {
            command.Connection = ConnOpen();
            command.CommandText = "DELETE FROM `Users` WHERE id=@id";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
        }
        //Метод для добавления информации в combobox
        public DataTable listRole()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM t_role";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }
    }
}
