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
    public class  ClsRegisters: Connection
    {
        //Добавление данных из sql
        MySqlDataReader leer;
        //Чтобы просчитать строки таблицы 
        DataTable table = new DataTable();
        //Добавляем sql-запрос для запуска
        MySqlCommand command = new MySqlCommand();

        //Проверка пациента на полис
        public bool Check(string med_polis)
        {
                //Открываем соединение
                command.Connection = ConnOpen();
                //Устанавливаем чтобы можно использовать несколько строк
                command.CommandType = CommandType.Text;
                //Создаём запрос (Выбрать всех пациентов, где мед.полис = переменной полис)
                command.CommandText = "Select * from Patients where med_polis=@polis";
                //Пользовательский параметр  со значением 
                command.Parameters.AddWithValue("@polis", med_polis);
                //Читаем запрос
                leer = command.ExecuteReader();
                //Если у reader есть строки, которые мы возращаем, то запрос успешный
                if (leer.HasRows)
                {
                    ConnClose();
                    return true;
                }
                else
                {
                    ConnClose();
                    return false;
                }
        }

        //Вывод информации о регистрации
        public DataTable listRegisters()
        {
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM Registration";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }
        public void AddRegisters(string fio, string position, string doc, string date, string time)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "INSERT INTO `Registration` (`fio` , `position` , `doc`, `date`, `time`) " +
            "VALUES(@fio, @position, @doc, @date, @time)";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@fio", fio);
            command.Parameters.AddWithValue("@position", position);
            command.Parameters.AddWithValue("@doc", doc);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@time", time);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }
        //
        //Метод для редактирования пользователя
        //

        public void EditRegisters(string fio, string position, string doc, string date, string time, int id)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "UPDATE `Registration` SET fio=@fio, position=@position,doc=@doc,date=@date,time=@time WHERE id=@id LIMIT 1";
            //"WHERE (id_doc) " +
            //"LIMIT 1";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@fio", fio);
            command.Parameters.AddWithValue("@position", position);
            command.Parameters.AddWithValue("@doc", doc);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
        }

        //
        //Удаление
        //
        public void DeleteRegisters(int id)
        {
            command.Connection = ConnOpen();
            command.CommandText = "DELETE FROM `Registration` WHERE id=@id";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
        }
        //Метод для добавления информации в combobox
        public DataTable listPosition()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM t_position";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }
        //Метод для добавления информации в combobox
        public DataTable listDoctors()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM Doctors";
            //SELECT id, fio_doc FROM Doctors where position = @position
            //Исправляем. чтобы можно использовать несколько строк
            //command.CommandType = CommandType.Text;
            //command.Parameters.AddWithValue("@position", position);
            leer = command.ExecuteReader();
            ////Очищает параметры 
            //command.Parameters.Clear();
            table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }

        //
        //Метод для добавление пользователя
        //
        public void AddPatients(string fio_pat, string med_polis, string street, string num_house, string num_kv, string phone, string dob)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "INSERT INTO `Patients` (`fio_pat` , `med_polis` , `street`, `num_house`, `num_kv`, `phone`,`dob`) " +
            "VALUES(@fio_pat, @med_polis,@street, @num_house,@num_kv, @phone, @dob)";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@med_polis", med_polis);
            command.Parameters.AddWithValue("@street", street);
            command.Parameters.AddWithValue("@num_house", num_house);
            command.Parameters.AddWithValue("@num_kv", num_kv);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@dob", dob);
            //Выполнение запроса
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }
        //Метод для добавления информации о улицах в combobox
        public DataTable listStreets()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM t_streets";
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
        //Метод для отображения записи таблицы Patients 
        //
        public DataTable listPatients()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM Patients";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            ConnClose();
            return table;
        }
        //Составление списка выработки
        public DataTable StatsTime(string doc, string date1, string date2)
        {
            //MySqlCommand command = new MySqlCommand();
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT id, doc, position, fio, date,time FROM Registration WHERE doc=@doc and (date >= @date1 and date <= @date2)";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@doc", doc);
            command.Parameters.AddWithValue("@date1", date1);
            command.Parameters.AddWithValue("@date2", date2);
            leer = command.ExecuteReader();
            //Очищает параметры 
            command.Parameters.Clear();
            table.Load(leer);
            ConnClose();
            return table;
        }
        public DataTable listDoc(string position)
        {
            //MySqlCommand command = new MySqlCommand();
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT id, fio_doc FROM Doctors where position = @position)";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@position", position);
            leer = command.ExecuteReader();
            //Очищает параметры 
            command.Parameters.Clear();
            table.Load(leer);
            ConnClose();
            return table;
        }
    }
}
