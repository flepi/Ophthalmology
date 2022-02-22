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
        public string name;

        //
        //Метод для отображения записей
        //
        public DataTable listServices()
        {
            // ORDER BY `name`
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM t_services ";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }

        //        SELECT name_service, price
        //FROM t_services
        //INNER JOIN Diagnostics ON t_services.`name` = Diagnostics.id

        //Правильный  в sql, но не работает
        //select Diagnostics.id , Diagnostics.name_service, Diagnostics.price from Diagnostics INNER JOIN t_services WHERE t_services.id = Diagnostics.name_service
        //public  DataTable listDiagnostics()
        //{
        //    DataTable table = new DataTable();
        //    command.Connection = ConnOpen();
        //    command.CommandText = "SELECT All_services.`сategory`, All_services.name_services , All_services.price  FROM All_services INNER JOIN t_services ON  t_services.`name`= All_services.`сategory` where t_services.`name` = 'Диагностика'";
        //    //Исправляем. чтобы можно использовать несколько строк
        //    command.CommandType = CommandType.Text;
        //    leer = command.ExecuteReader();
        //    //table.Clear();
        //    ////Таблица будет заполняться sql-запросом 
        //    table.Load(leer);
        //    ConnClose();
        //    return table;
        //}

        //public DataSet Addqwe(ComboBox cmd)
        //{
        //    //MySqlCommand command = new MySqlCommand();
        //    DataSet table = new DataSet();
        //    command.Connection = ConnOpen();
        //    command.CommandText = "select * from  Diagnostics INNER JOIN t_services where t_services.`name` = @name";
        //    //Исправляем. чтобы можно использовать несколько строк
        //    command.CommandType = CommandType.Text;
        //    command.Parameters.AddWithValue("@name", cmd);
        //    command.ExecuteNonQuery();
        //    //Очищает параметры 
        //    command.Parameters.Clear();
        //    ConnClose();
        //    return table;

        //}


        public DataTable listLaser()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT All_services.`сategory`, All_services.name_services , All_services.price  FROM All_services INNER JOIN t_services ON  t_services.`name`= All_services.`сategory` where t_services.`name` = 'Консультация'"; 
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            //table.Clear();
            ////Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }




    }
}
