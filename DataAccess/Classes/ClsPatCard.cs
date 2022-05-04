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
        //Метод для отображения записи таблицы doctors 
        //
        public DataTable listCard()
        {
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM PatCard";
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
        public void AddCard(string fio_pat, string fio_doc, string symptoms, string diagnoses, string service, string treatment, string comments)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "INSERT INTO `PatCard` (`fio_pat` ,`fio_doc` , `symptoms` , `diagnoses`, `service`, `treatment`, `comments`) " +
            "VALUES(@fio_pat,@fio_doc, @symptoms,@diagnoses, @service,@treatment, @comments)";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@fio_doc", fio_doc);
            command.Parameters.AddWithValue("@symptoms", symptoms);
            command.Parameters.AddWithValue("@diagnoses", diagnoses);
            command.Parameters.AddWithValue("@service", service);
            command.Parameters.AddWithValue("@treatment", treatment);
            command.Parameters.AddWithValue("@comments", comments);

            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }
        //
        //Метод для редактирования пользователя
        //
        public void EditCard(string fio_pat, string fio_doc, string symptoms, string diagnoses, string service, string treatment, string comments, int id)
        {
            //MySqlCommand command = new MySqlCommand();
            command.Connection = ConnOpen();
            command.CommandText = "UPDATE `PatCard` SET fio_pat=@fio_pat, fio_doc=@fio_doc,symptoms=@symptoms, diagnoses=@diagnoses, service=@service, treatment=@treatment,comments=@comments WHERE id=@id LIMIT 1";
            //"WHERE (id_doc) " +
            //"LIMIT 1";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@fio_pat", fio_pat);
            command.Parameters.AddWithValue("@fio_doc", fio_doc);
            command.Parameters.AddWithValue("@symptoms", symptoms);
            command.Parameters.AddWithValue("@diagnoses", diagnoses);
            command.Parameters.AddWithValue("@service", service);
            command.Parameters.AddWithValue("@treatment", treatment);
            command.Parameters.AddWithValue("@comments", comments);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }

        //
        //Удаление
        //
        public void DeleteCard(int id)
        {
            command.Connection = ConnOpen();
            command.CommandText = "DELETE FROM `PatCard` WHERE id=@id";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
            //Очищает параметры 
            command.Parameters.Clear();
            ConnClose();
        }

        //Метод для добавления информации в combobox
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
        //Метод для добавления информации в combobox
        public DataTable listDoctors()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM Doctors";
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
        public DataTable listSymptoms()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM t_symptoms";
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
        public DataTable listDiagnoses()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            command.CommandText = "SELECT * FROM t_diagnoses";
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
        public DataTable listServices()
        {
            DataTable table = new DataTable();
            command.Connection = ConnOpen();
            //Формируем столбцы для комбобокса списка отделов
            table.Columns.Add(new DataColumn("id", System.Type.GetType("System.Int32")));
            table.Columns.Add(new DataColumn("name_service", System.Type.GetType("System.String")));
            command.CommandText = "SELECT id,name_service FROM t_services";
            //Исправляем. чтобы можно использовать несколько строк
            command.CommandType = CommandType.Text;
            try
            {
                leer = command.ExecuteReader();
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
                ConnClose();
            }
            return table;

            //table.Clear();
            //Таблица будет заполняться sql-запросом 
        }
    }
}
