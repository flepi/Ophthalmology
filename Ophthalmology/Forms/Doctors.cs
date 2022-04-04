using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using Common.Cache;
using DataAccess;

namespace Ophthalmology
{
    public partial class Doctors : Form
    {
        ClsDoctors OutPutDoctors = new ClsDoctors();
        private string idDoc = null;
        //Переменная для применнеия редактирования на кнопке сохранить
        private bool EditDoc = false;
        
        public Doctors()
        {
            InitializeComponent();
            
            
            //Свойства combobox-a для поиска 
            cmBoxPosition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxPosition.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonExitDoctors_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void doctors_Load(object sender, EventArgs e)
        {
            //Добавляем врачей 
            dataGridView1.DataSource = OutPutDoctors.listDoctors();
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            //Ширина полей
            dataGridView1.Columns[0].FillWeight = 5;
            dataGridView1.Columns[1].FillWeight = 20;
            dataGridView1.Columns[2].FillWeight = 20;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;
            dataGridView1.Columns[5].FillWeight = 20;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Заголовки
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "ФИО Доктора";
            dataGridView1.Columns[2].HeaderText = "Должность";
            dataGridView1.Columns[3].HeaderText = "Кабинет";
            dataGridView1.Columns[4].HeaderText = "Телефон";
            dataGridView1.Columns[5].HeaderText = "Дата рождения";
            //Убираем заголовки строк
            //dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            //Устанавлием ограничения для ролей
            if (UserCache.role == Positions.Register)
            {
                BtnDoctorsAdd.Enabled = false;
                BtnDoctorsEdit.Enabled = false;
                BtnDoctorsDel.Enabled = false;
            }
            //Вывод информации в combobox
            cmBoxPosition.DataSource = OutPutDoctors.listPosition();
            cmBoxPosition.DisplayMember = "position_name"; // Вывод информации в cbmbox
            cmBoxPosition.ValueMember = "id_position";

        }

        //Кнопка сохранить
        private void BtnDoctorsAdd_Click(object sender, EventArgs e)
        {

            //
            //Добавление
            //
            //Условие, если редактирование ложно, то добавляется запись
            if (EditDoc == false)
             {
                try
                {
                    OutPutDoctors.ConnOpen();
                    OutPutDoctors.AddDoctor(txtBoxFioDoc.Text, cmBoxPosition.Text, txtBoxCabDoc.Text, txtBoxPhoneDoc.Text, customDateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutDoctors.listDoctors();
                    ClearTxt();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutDoctors.ConnClose();
                }
             }


            //РЕДАКТИРОВАНИЕ
            //Сохранений изменений
            //

            //Условие, при котором спрашиваем, если редактирование верно, то оно будет принимать меры, чтобы избежать ошибок
            if (EditDoc == true)
             {
                try
                {
                    OutPutDoctors.EditDoctor(txtBoxFioDoc.Text, cmBoxPosition.Text, txtBoxCabDoc.Text, txtBoxPhoneDoc.Text, customDateTimePicker1.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(idDoc));
                    MessageBox.Show(" Пользователь успешно изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutDoctors.listDoctors();
                    ClearTxt();
                    EditDoc = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка изменения строки \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutDoctors.ConnClose();
                }
            }
        }
        //Перенос строк в текст боксы
        //Кнопка Изменить
        private void BtnDoctorsEdit_Click(object sender, EventArgs e)
        {
            //Если выделены ячейки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditDoc = true;
                //Имя тексового поля равно значению ячейки, выбранная в имя столбца 
                txtBoxFioDoc.Text = dataGridView1.CurrentRow.Cells["fio_doc"].Value.ToString();
                cmBoxPosition.Text = dataGridView1.CurrentRow.Cells["position"].Value.ToString();
                txtBoxCabDoc.Text = dataGridView1.CurrentRow.Cells["cab"].Value.ToString();
                txtBoxPhoneDoc.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                //Переменная дата рождения
                DateTime dt_doc;
                dt_doc = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["dob"].Value.ToString());
                customDateTimePicker1.Value = dt_doc;
                idDoc = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //Метод на очистку txtbox-ов
        private void ClearTxt()
        {
            txtBoxFioDoc.Text = " ФИО Доктора";
            txtBoxCabDoc.Text = " Кабинет";
            txtBoxPhoneDoc.Text = " Телефон";
        }

        //
        //Удаление
        //
        private void BtnDoctorsDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idDoc = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                OutPutDoctors.DeleteDoctor(Convert.ToInt32(idDoc));
                MessageBox.Show("Пользователь удалён");
                //Обновление  таблицы
                dataGridView1.DataSource = OutPutDoctors.listDoctors();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }



        #region !!==!! Надпись на txtbox-aх и чтобы она пропадала при нажатие на неё
        private void txtBoxFioDoc_Enter(object sender, EventArgs e)
        {
            if (txtBoxFioDoc.Text == " ФИО Доктора")
            {
                txtBoxFioDoc.Text = "";
                txtBoxFioDoc.ForeColor = Color.White;
            }
        }

        private void txtBoxFioDoc_Leave(object sender, EventArgs e)
        {
            if (txtBoxFioDoc.Text == "")
            {
                txtBoxFioDoc.Text = " ФИО Доктора";
                txtBoxFioDoc.ForeColor = Color.DarkGray;
            }
        }

        //private void txtBoxPositionDoc_Enter(object sender, EventArgs e)
        //{
        //    if (txtBoxPositionDoc.Text == " Должность")
        //    {
        //        txtBoxPositionDoc.Text = "";
        //        txtBoxPositionDoc.ForeColor = Color.White;
        //    }
        //}

        //private void txtBoxPositionDoc_Leave(object sender, EventArgs e)
        //{
        //    if (txtBoxPositionDoc.Text == "")
        //    {
        //        txtBoxPositionDoc.Text = " Должность";
        //        txtBoxPositionDoc.ForeColor = Color.DarkGray;
        //    }
        //}

        private void txtBoxCabDoc_Enter(object sender, EventArgs e)
        {
            if (txtBoxCabDoc.Text == " Кабинет")
            {
                txtBoxCabDoc.Text = "";
                txtBoxCabDoc.ForeColor = Color.White;
            }
        }

        private void txtBoxCabDoc_Leave(object sender, EventArgs e)
        {
            if (txtBoxCabDoc.Text == "")
            {
                txtBoxCabDoc.Text = " Кабинет";
                txtBoxCabDoc.ForeColor = Color.DarkGray;
            }
        }

        private void txtBoxPhoneDoc_Enter(object sender, EventArgs e)
        {
            if (txtBoxPhoneDoc.Text == " Телефон")
            {
                txtBoxPhoneDoc.Text = "";
                txtBoxPhoneDoc.ForeColor = Color.White;
            }
        }

        private void txtBoxPhoneDoc_Leave(object sender, EventArgs e)
        {
            if (txtBoxPhoneDoc.Text == "")
            {
                txtBoxPhoneDoc.Text = " Телефон";
                txtBoxPhoneDoc.ForeColor = Color.DarkGray;
            }
        }
        #endregion
    }
}
