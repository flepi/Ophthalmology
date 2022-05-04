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

namespace Ophthalmology.Forms
{
    public partial class PatCard : Form
    {
        ClsPatCard OutPutCard = new ClsPatCard();
        private string idCard = null;
        //Переменная для применнеия редактирования на кнопке сохранить
        private bool EditCard = false;
        public PatCard()
        {
            InitializeComponent();

            //Свойства combobox-a для поиска 
            cmBoxPatients.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxPatients.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Свойства combobox-a для поиска 
            cmBoxDoctors.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxDoctors.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Свойства combobox-a для поиска 
            cmBoxSymptoms.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxSymptoms.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Свойства combobox-a для поиска 
            cmBoxDiagnoses.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxDiagnoses.AutoCompleteSource = AutoCompleteSource.ListItems;

            //Свойства combobox-a для поиска 
            cmBoxServices.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxServices.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonExitDoctors_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatCard_Load(object sender, EventArgs e)
        {
            //Добавляем карточки 
            dataGridView1.DataSource = OutPutCard.listCard();
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            //Ширина полей
            dataGridView1.Columns[0].FillWeight = 7;
            dataGridView1.Columns[1].FillWeight = 20;
            dataGridView1.Columns[2].FillWeight = 20;
            dataGridView1.Columns[3].FillWeight = 23;
            dataGridView1.Columns[4].FillWeight = 20;
            dataGridView1.Columns[5].FillWeight = 25;
            //dataGridView1.Columns[6].FillWeight = 20;
            //dataGridView1.Columns[7].FillWeight = 20;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "ФИО Пациента";
            dataGridView1.Columns[2].HeaderText = "ФИО Доктора";
            dataGridView1.Columns[3].HeaderText = "Симптом";
            dataGridView1.Columns[4].HeaderText = "Диагноз";
            dataGridView1.Columns[5].HeaderText = "Услуга";
            //dataGridView1.Columns[6].HeaderText = "Лечение";
            //dataGridView1.Columns[7].HeaderText = "Комментарий";
            //Убираем заголовки строк
            //dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            //Устанавлием ограничения для ролей
            if (UserCache.role == Positions.Register)
            {
                
            }
            //Вывод информации в combobox
            cmBoxPatients.DataSource = OutPutCard.listPatients();
            cmBoxPatients.DisplayMember = "fio_pat"; // Вывод информации в cbmbox
            cmBoxPatients.ValueMember = "id";
            //Вывод информации в combobox
            cmBoxDoctors.DataSource = OutPutCard.listDoctors();
            cmBoxDoctors.DisplayMember = "fio_doc"; // Вывод информации в cbmbox
            cmBoxDoctors.ValueMember = "id";
            //Вывод информации в combobox
            cmBoxSymptoms.DataSource = OutPutCard.listSymptoms();
            cmBoxSymptoms.DisplayMember = "name_symptom"; // Вывод информации в cbmbox
            cmBoxSymptoms.ValueMember = "id";
            //Вывод информации в combobox
            cmBoxDiagnoses.DataSource = OutPutCard.listDiagnoses();
            cmBoxDiagnoses.DisplayMember = "name_diagnosis"; // Вывод информации в cbmbox
            cmBoxDiagnoses.ValueMember = "id";
            //Вывод информации в combobox
            cmBoxServices.DataSource = OutPutCard.listServices();
            cmBoxServices.DisplayMember = "name_service"; // Вывод информации в cbmbox
            cmBoxServices.ValueMember = "id";

        }
        //Кнопка сохранить
        private void BtnCardAdd_Click(object sender, EventArgs e)
        {
            //
            //Добавление
            //
            //Условие, если редактирование ложно, то добавляется запись
            if (EditCard == false)
            {
                try
                {
                    OutPutCard.ConnOpen();
                    OutPutCard.AddCard(cmBoxPatients.Text, cmBoxDoctors.Text, cmBoxSymptoms.Text, cmBoxDiagnoses.Text, cmBoxServices.Text, txtBoxTreatment.Text, txtBoxComment.Text);
                    MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutCard.listCard();
                    //ClearTxt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutCard.ConnClose();
                }
            }


            //РЕДАКТИРОВАНИЕ
            //Сохранений изменений
            //

            //Условие, при котором спрашиваем, если редактирование верно, то оно будет принимать меры, чтобы избежать ошибок
            if (EditCard == true)
            {
                try
                {
                    OutPutCard.EditCard(cmBoxPatients.Text, cmBoxDoctors.Text, cmBoxSymptoms.Text, cmBoxDiagnoses.Text, cmBoxServices.Text, txtBoxTreatment.Text, txtBoxComment.Text, Convert.ToInt32(idCard));
                    MessageBox.Show(" Пользователь успешно изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutCard.listCard();
                    //ClearTxt();
                    EditCard = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка изменения строки \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutCard.ConnClose();
                }
            }
        }
        //Перенос строк в текст боксы
        //Кнопка Изменить
        private void BtnCardEdit_Click(object sender, EventArgs e)
        {
            //Если выделены ячейки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditCard = true;
                //Имя тексового поля равно значению ячейки, выбранная в имя столбца 
                cmBoxPatients.Text = dataGridView1.CurrentRow.Cells["fio_pat"].Value.ToString();
                cmBoxDoctors.Text = dataGridView1.CurrentRow.Cells["fio_doc"].Value.ToString();
                cmBoxSymptoms.Text = dataGridView1.CurrentRow.Cells["symptoms"].Value.ToString();
                cmBoxDiagnoses.Text = dataGridView1.CurrentRow.Cells["diagnoses"].Value.ToString();
                cmBoxServices.Text = dataGridView1.CurrentRow.Cells["service"].Value.ToString();
                txtBoxTreatment.Text = dataGridView1.CurrentRow.Cells["treatment"].Value.ToString();
                txtBoxComment.Text = dataGridView1.CurrentRow.Cells["comments"].Value.ToString();
                idCard = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //
        //Удаление
        //
        private void BtnCardDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idCard = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                OutPutCard.DeleteCard(Convert.ToInt32(idCard));
                MessageBox.Show("Пользователь удалён");
                //Обновление  таблицы
                dataGridView1.DataSource = OutPutCard.listCard();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }

        private void txtBoxTreatment_Enter(object sender, EventArgs e)
        {
            if (txtBoxTreatment.Text == " Прописать лечение")
            {
                txtBoxTreatment.Text = "";
                txtBoxTreatment.ForeColor = Color.White;
            }
        }

        private void txtBoxTreatment_Leave(object sender, EventArgs e)
        {
            if (txtBoxTreatment.Text == "")
            {
                txtBoxTreatment.Text = " Прописать лечение";
                txtBoxTreatment.ForeColor = Color.DarkGray;
            }
        }

        private void txtBoxComment_Enter(object sender, EventArgs e)
        {
            if (txtBoxComment.Text == " Комментарий")
            {
                txtBoxComment.Text = "";
                txtBoxComment.ForeColor = Color.White;
            }
        }

        private void txtBoxComment_Leave(object sender, EventArgs e)
        {
            if (txtBoxComment.Text == "")
            {
                txtBoxComment.Text = " Комментарий";
                txtBoxComment.ForeColor = Color.DarkGray;
            }
        }
        //Поиск карточки пациента
        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"fio_pat LIKE '%{SearchTxt.Text}%'";
        }
    }
}
