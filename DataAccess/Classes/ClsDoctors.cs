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
        //Объект для чтения ответа сервера
        MySqlDataReader leer;
        //Объект, который создаёт таблицу  
        DataTable table = new DataTable();
        //Объект для выполнения SQL-запроса
        MySqlCommand command = new MySqlCommand();

        //
        //Метод для отображения записи таблицы doctors 
        //
        public DataTable listDoctors()
        {
            //Открытие соединения
            command.Connection = ConnOpen();
            //Запрос
            command.CommandText = "SELECT * FROM Doctors";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполняем запрос
            leer = command.ExecuteReader();
            //Очищается таблица
            table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            //Закрытие соединения
            ConnClose();
            //Возращается таблица
            return table;
        }

        //
        //Метод для добавление докторов
        //
        public void AddDoctor(string fio_doc, string position, string cabinet, string phone, string dob)
        {
            //MySqlCommand command = new MySqlCommand();
                //Открываем соединение
                command.Connection = ConnOpen();
                //Запрос для добавления нового доктора
                command.CommandText = "INSERT INTO `Doctors` (`fio_doc` , `position` , `cab`, `phone`, `dob`) " +
                "VALUES(@fio_doc, @position, @cabinet, @phone, @dob)";
            //Устанавливаем. чтобы можно использовать несколько строк
                command.CommandType = CommandType.Text;
            //Определяем параметры
                command.Parameters.AddWithValue("@fio_doc", fio_doc);
                command.Parameters.AddWithValue("@position", position);
                command.Parameters.AddWithValue("@cabinet", cabinet);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@dob", dob);
            //Выполнение запроса на добавление
                command.ExecuteNonQuery();
            //Очищает параметры 
                command.Parameters.Clear();
            //Закрываем соединение
                command.Connection = ConnClose();
        }


        //
        //Метод для редактирования доктора
        //
        public void EditDoctor(string fio_doc, string position, string cabinet, string phone, string dob, int id)
        {
            //MySqlCommand command = new MySqlCommand();
            //Открываем соединение
                command.Connection = ConnOpen();
            //Создаём запрос для обновления данных у определенного доктора
                command.CommandText = "UPDATE `Doctors` SET fio_doc=@fio_doc, position=@position,cab=@cabinet,phone=@phone,dob=@dob WHERE id=@id LIMIT 1";
            //Устанавливаем. чтобы можно использовать несколько строк
                command.CommandType = CommandType.Text;
            //Определяем параметры
                command.Parameters.AddWithValue("@fio_doc", fio_doc);
                command.Parameters.AddWithValue("@position", position);
                command.Parameters.AddWithValue("@cabinet", cabinet);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@dob", dob);
                command.Parameters.AddWithValue("@id", id);
            //Выполнение запроса на добавление
                command.ExecuteNonQuery();
                //Очищает параметры 
                command.Parameters.Clear();
                //Закрываем соединение
                command.Connection = ConnClose();
        }

        //
        //Удаление
        //
        public void DeleteDoctor(int id)
        {
            //Открываем соединение
            command.Connection = ConnOpen();
            //Запрос на удаление
            command.CommandText = "DELETE FROM `Doctors` WHERE id=@id_doc";
            //Устанавливаем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Определяем параметры
            command.Parameters.AddWithValue("@id_doc", id);
            //Выполнение запрос на удаление строки
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            //Закрываем соединение
            command.Connection = ConnClose();
        }

        //Метод для добавления информации в combobox
        public DataTable listPosition()
        {
            //Создаём виртуальную таблицу
            DataTable table = new DataTable();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Производим запрос на добавление должности врачей
            command.CommandText = "SELECT * FROM t_position ";
            //Устанавливаем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполнение запроса
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            //Закрытие соединения
            ConnClose();
            //Возращение таблицы
            return table;
        }
    }
}
