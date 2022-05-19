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
    public class ClsPatCard:Connection
    {
        //Добавление данных из sql
        MySqlDataReader leer;
        //Чтобы просчитать строки таблицы 
        DataTable table = new DataTable();
        //Добавляем sql-запрос для запуска
        MySqlCommand command = new MySqlCommand();


        //
        //Метод для отображения записи таблицы PatCard 
        //
        public DataTable listCard()
        {
            //Открываем соединение
            command.Connection = ConnOpen();
            //Запрос для вывода таблицы
            command.CommandText = "SELECT * FROM PatCard";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполняем запрос
            leer = command.ExecuteReader();
            //Очищается таблица
            table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            //Закрываем соединение
            ConnClose();
            //Возращаем таблицу
            return table;
        }

        //
        //Метод для добавление карточки пациента
        //
        public void AddCard(string fio_pat, string fio_doc, string symptoms, string diagnoses, string service, string treatment, string comments)
        {
            //MySqlCommand command = new MySqlCommand();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Запрос на добавление новой записи в таблице с карточками пациента
            command.CommandText = "INSERT INTO `PatCard` (`fio_pat` ,`fio_doc` , `symptoms` , `diagnoses`, `service`, `treatment`, `comments`) " +
            "VALUES(@fio_pat,@fio_doc, @symptoms,@diagnoses, @service,@treatment, @comments)";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Определяем параметры
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@fio_doc", fio_doc);
            command.Parameters.AddWithValue("@symptoms", symptoms);
            command.Parameters.AddWithValue("@diagnoses", diagnoses);
            command.Parameters.AddWithValue("@service", service);
            command.Parameters.AddWithValue("@treatment", treatment);
            command.Parameters.AddWithValue("@comments", comments);
            //Выполнение запроса на добавление
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            //Закрываем соединение
            ConnClose();
        }
        //
        //Метод для редактирования карточки пациента
        //
        public void EditCard(string fio_pat, string fio_doc, string symptoms, string diagnoses, string service, string treatment, string comments, int id)
        {
            //MySqlCommand command = new MySqlCommand();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос на обновление данных
            command.CommandText = "UPDATE `PatCard` SET fio_pat=@fio_pat, fio_doc=@fio_doc,symptoms=@symptoms, diagnoses=@diagnoses, service=@service, treatment=@treatment,comments=@comments WHERE id=@id LIMIT 1";
            //"WHERE (id_doc) " +
            //"LIMIT 1";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Определяем параметры
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@fio_doc", fio_doc);
            command.Parameters.AddWithValue("@symptoms", symptoms);
            command.Parameters.AddWithValue("@diagnoses", diagnoses);
            command.Parameters.AddWithValue("@service", service);
            command.Parameters.AddWithValue("@treatment", treatment);
            command.Parameters.AddWithValue("@comments", comments);
            command.Parameters.AddWithValue("@id", id);
            //Выполнение запроса на обновление данных
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            //Закрываем соединение
            ConnClose();
        }

        //
        //Удаление
        //
        public void DeleteCard(int id)
        {
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос на удаление записи
            command.CommandText = "DELETE FROM `PatCard` WHERE id=@id";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Определяем параметры
            command.Parameters.AddWithValue("@id", id);
            //Выполнение запрос
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            //Закрываем соединение
            ConnClose();
        }

        //Метод для добавления информации в combobox
        public DataTable listPatients()
        {
            //Создаём виртуальную таблицу
            DataTable table = new DataTable();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос 
            command.CommandText = "SELECT * FROM Patients";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполнение запроса
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            //Закрываем соединение
            ConnClose();
            //Возращаем таблицу
            return table;
        }
        //Метод для добавления информации в combobox
        public DataTable listDoctors()
        {
            //Создаём виртуальную таблицу
            DataTable table = new DataTable();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос 
            command.CommandText = "SELECT * FROM Doctors";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполнение запроса
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            //Закрываем соединение
            ConnClose();
            //Возращаем таблицу
            return table;
        }
        //Метод для добавления информации в combobox
        public DataTable listSymptoms()
        {
            //Создаём виртуальную таблицу
            DataTable table = new DataTable();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос 
            command.CommandText = "SELECT * FROM t_symptoms";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполнение запроса
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            //Закрываем соединение
            ConnClose();
            //Возращаем таблицу
            return table;
        }
        //Метод для добавления информации в combobox
        public DataTable listDiagnoses()
        {
            //Создаём виртуальную таблицу
            DataTable table = new DataTable();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Создаём запрос 
            command.CommandText = "SELECT * FROM t_diagnoses";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            //Выполнение запроса
            leer = command.ExecuteReader();
            //table.Clear();
            //Таблица будет заполняться sql-запросом 
            table.Load(leer);
            //Закрываем соединение
            ConnClose();
            //Возращаем таблицу
            return table;
        }
        //Метод для добавления информации в combobox
        public DataTable listServices()
        {
            //Создаём виртуальную таблицу
            DataTable table = new DataTable();
            //Открываем соединение
            command.Connection = ConnOpen();
            //Формируем столбцы для комбобокса списка услуг
            table.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            table.Columns.Add(new DataColumn("name_service", System.Type.GetType("System.String")));
            //Создаём запрос на добавлений записей
            command.CommandText = "SELECT id,name_service FROM t_services";
            //Устанавливаем чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            try
            {
                //Выполнение запроса
                leer = command.ExecuteReader();
                //Цикл, который читает строки запроса
                while(leer.Read())
                {
                    DataRow rowAdd = table.NewRow();
                    rowAdd["id"] = Convert.ToInt32(leer[0]);
                    rowAdd["name_service"] = leer[1].ToString();
                    table.Rows.Add(rowAdd);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка чтения списка статусов \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                //Закрываем соединение
                ConnClose();
            }
            //Возращаем таблицу
            return table;

            //table.Clear();
            //Таблица будет заполняться sql-запросом 
        }
    }
}
