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
    public class ClsServices:Connection
    {
        //Добавление данных из sql
        MySqlDataReader leer;
        //Чтобы просчитать строки таблицы 
        DataTable table = new DataTable();
        //Добавляем sql-запрос для запуска
        MySqlCommand command = new MySqlCommand();
        //
        //Метод для отображения записей
        //
        public DataTable listServices()
        {
            // ORDER BY `name`
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM t_services";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }
        //
        //Метод для добавление услуги
        //
        public void AddServices(string service, decimal price, string doc)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "INSERT INTO `t_services` (`name_service` , `price` , `doc`)" +
            "VALUES(@service, @price,@doc)";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@service", service);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@doc", doc);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }
        //
        //Метод для редактирования пользователя
        //
        public void EditServices(string service, decimal price, string doc, int id)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "UPDATE `t_services` SET name_service=@service, price=@price, doc=@doc WHERE id=@id LIMIT 1";
            //"WHERE (id_doc) " +
            //"LIMIT 1";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@service", service);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@doc", doc);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }

        //
        //Удаление
        //
        public void DeleteServices(int id)
        {
            command.Connection = ConnOpen();
            command.CommandText = "DELETE FROM `t_services` WHERE id=@id";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }

        //Метод для добавления информации в combobox
        public DataTable listDoctors()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM Doctors";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //command.Parameters.AddWithValue("@position", position);
            leer = command.ExecuteReader();
            table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }
    }
}
