using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


using Common.Cache;

namespace DataAccess
{
    public class ClsPatients:Connection
    {

        //Добавление данных из sql
        MySqlDataReader leer;
        //Чтобы просчитать строки таблицы 
        DataTable table = new DataTable();
        //Добавляем sql-запрос для запуска
        MySqlCommand command = new MySqlCommand();


        //
        //Метод для отображения записи таблицы Patients 
        //
        public DataTable listPatients()
        {
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос 
            command.CommandText = "SELECT * FROM Patients";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполняем запрос
            leer = command.ExecuteReader();
            //Производим очищение таблицы
            table.Clear();
            //Таблица будет заполняться sql-запросом 
            //Заполняем таблицу данными
            table.Load(leer);
            //Закрываем соединение
            ConnClose();
            //Возращаем таблицу
            return table;
        }

        //
        //Метод для добавление пациента
        //
        public void AddPatients(string fio_pat, string med_polis, string street, string num_house, string num_kv, string phone,string dob)
        {
            //MySqlCommand command = new MySqlCommand();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос на добавление новой записи в базе данных
            command.CommandText = "INSERT INTO `Patients` (`fio_pat` , `med_polis` , `street`, `num_house`, `num_kv`, `phone`,`dob`) " +
            "VALUES(@fio_pat, @med_polis,@street, @num_house,@num_kv, @phone, @dob)";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Определяем параметры
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@med_polis", med_polis);
            command.Parameters.AddWithValue("@street", street);
            command.Parameters.AddWithValue("@num_house", num_house);
            command.Parameters.AddWithValue("@num_kv", num_kv);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@dob", dob);
            //Выполняем запрос
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            //Закрываем соединение
            ConnClose();
        }
        //
        //Метод для редактирования пациента
        //
        public void EditPatients(string fio_pat, string med_polis, string street, string num_house, string num_kv, string phone,string dob, int id)
        {
            //MySqlCommand command = new MySqlCommand();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Запрос на обновление данных 
            command.CommandText = "UPDATE `Patients` SET fio_pat=@fio_pat, med_polis=@med_polis, street=@street, num_house=@num_house, num_kv=@num_kv,phone=@phone,dob=@dob WHERE id=@id LIMIT 1";
            //"WHERE (id_doc) " +
            //"LIMIT 1";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Определяем параметры
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@med_polis", med_polis);
            command.Parameters.AddWithValue("@street", street);
            command.Parameters.AddWithValue("@num_house", num_house);
            command.Parameters.AddWithValue("@num_kv", num_kv);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@dob", dob);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }

        //
        //Удаление
        //
        public void DeletePatients(int id)
        {
            command.Connection = ConnOpen();
            command.CommandText = "DELETE FROM `Patients` WHERE id=@id_pat";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id_pat", id);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }

        //Метод для добавления информации в combobox
        public DataTable listStreets()
        {
            //Создаём виртуальную таблицу
            DataTable table = new DataTable();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос
            command.CommandText = "SELECT * FROM t_streets";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполняем запрос
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }
    }
}

