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
    public class ClsPatients:Connection
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
        public DataTable listPatients()
        {
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM patients";
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
        public void AddDoctor(string fio_pat, string address, string med_policy, string phone,string gender, string dob)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "INSERT INTO `patients` (`fio_pat` , `address` , `med_policy`, `phone`, `gender`, `dob`) " +
            "VALUES(@fio_pat, @address, @med_policy, @phone, @gender ,@dob)";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@med_policy", med_policy);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@dob", dob);

            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
        }
        //
        //Метод для редактирования пользователя
        //
        public void EditDoctor(string fio_pat, string address, string med_policy, string phone, string gender, string dob, int id)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "UPDATE `patients` SET fio_pat=@fio_pat, address=@address, med_policy=@med_policy, phone=@phone, gender=@gender,dob=@dob WHERE id=@id LIMIT 1";
            //"WHERE (id_doc) " +
            //"LIMIT 1";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@med_policy", med_policy);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@gender", gender);
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
            command.CommandText = "DELETE FROM `patients` WHERE id=@id_doc";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id_doc", id);

            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
        }
    }
}
