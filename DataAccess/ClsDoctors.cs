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
    public class ClsDoctors:Connection
    {
        //Добавление данных из sql
        MySqlDataReader leer;
        //Чтобы просчитать строки таблицы 
        DataTable table = new DataTable();
        //Добавляем sql-запрос для запуска
        MySqlCommand command = new MySqlCommand();

        //
        //Метод для отображения записи таблицы doctors 
        //
        public DataTable listDoctors()
        {
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM Doctors";
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
        //Метод для добавление пользователя
        //

        public void AddDoctor(string fio_doc, string position, string cabinet, string phone, string dob)
        {
            //MySqlCommand command = new MySqlCommand();
                command.Connection = ConnOpen();
                command.CommandText = "INSERT INTO `Doctors` (`fio_doc` , `position` , `cab`, `phone`, `dob`) " +
                "VALUES(@fio_doc, @position, @cabinet, @phone, @dob)";
            //Исправляем. чтобы можно использовать несколько строк
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@fio_doc", fio_doc);
                command.Parameters.AddWithValue("@position", position);
                command.Parameters.AddWithValue("@cabinet", cabinet);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@dob", dob);

                command.ExecuteNonQuery();
                //Очищает параметры 
                command.Parameters.Clear();
        }


        //
        //Метод для редактирования пользователя
        //

        public void EditDoctor(string fio_doc, string position, string cabinet, string phone, string dob, int id)
        {
            //MySqlCommand command = new MySqlCommand();
                command.Connection = ConnOpen();
                command.CommandText = "UPDATE `Doctors` SET fio_doc=@fio_doc, position=@position,cab=@cabinet,phone=@phone,dob=@dob WHERE id=@id LIMIT 1";
            //"WHERE (id_doc) " +
            //"LIMIT 1";
            //Исправляем. чтобы можно использовать несколько строк
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@fio_doc", fio_doc);
                command.Parameters.AddWithValue("@position", position);
                command.Parameters.AddWithValue("@cabinet", cabinet);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@dob", dob);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                //Очищает параметры 
                command.Parameters.Clear();
        }

        //
        //Удаление
        //
        public void DeleteDoctor(int id)
        {
            command.Connection = ConnOpen();
            command.CommandText = "DELETE FROM `Doctors` WHERE id=@id_doc";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id_doc", id);

            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
        }

        //Метод для добавления информации в combobox
        public DataTable listPosition()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM t_position ";
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
