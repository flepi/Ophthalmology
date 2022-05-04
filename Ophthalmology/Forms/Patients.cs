using System;
using System.Collections;
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
    public partial class Patients : Form
    {
        ClsPatients OutPutPatients = new ClsPatients();
        private string idPat = null;
        //Переменная для применнеия редактирования на кнопке сохранить
        private bool EditPat = false;

        public Patients()
        {
            InitializeComponent();
            //Свойства combobox-a для поиска 
            cmBoxStreets.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxStreets.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonExitPatients_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            //Заполнение данных из бд
            dataGridView1.DataSource = OutPutPatients.listPatients();
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = true;
            dataGridView1.Columns[7].Visible = true;
            //Ширина полей
            dataGridView1.Columns[0].FillWeight = 7;
            dataGridView1.Columns[1].FillWeight = 23;
            dataGridView1.Columns[2].FillWeight = 20;
            dataGridView1.Columns[3].FillWeight = 20;
            dataGridView1.Columns[4].FillWeight = 8;
            dataGridView1.Columns[5].FillWeight = 8;
            dataGridView1.Columns[6].FillWeight = 15;
            dataGridView1.Columns[7].FillWeight = 15;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Наименование заголовок
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "ФИО Пациента";
            dataGridView1.Columns[2].HeaderText = "Мед.Полис";
            dataGridView1.Columns[3].HeaderText = "Улица";
            dataGridView1.Columns[4].HeaderText = "Дом";
            dataGridView1.Columns[5].HeaderText = "Кв.";
            dataGridView1.Columns[6].HeaderText = "Телефон";
            dataGridView1.Columns[7].HeaderText = "Дата рождения";
            //Убираем заголовки строк
            //dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            //Устанавливаем ограничения для роли
            if (UserCache.role == Positions.Register)
            {

            }
            if (UserCache.role == Positions.Doctors)
            {
                BtnPatientsAdd.Enabled = false;
                BtnPatientsEdit.Enabled = false;
                BtnPatientsDel.Enabled = false;
            }
            //Вывод информации в combobox
            cmBoxStreets.DataSource = OutPutPatients.listStreets();
            cmBoxStreets.DisplayMember = "street_name"; // Вывод информации в cbmbox
            cmBoxStreets.ValueMember = "id";
        }



        //Кнопка сохранить
        private void BtnPatientsAdd_Click(object sender, EventArgs e)
        {
            
            //
            //Добавление
            //
            //Условие, если редактирование ложно, то добавляется запись
            if (EditPat == false)
            {
                if (txtBoxFioPat.Text != " ФИО Пациента" && txtBoxMedPat.Text != " Мед.Полис" && txtNum_house.Text != " Номер дома"
                    && txtNum_kv.Text != " Номер квартиры" && txtBoxPhonePat.Text != " Телефон")
                {
                    try
                    {
                        OutPutPatients.ConnOpen();
                        OutPutPatients.AddPatients(txtBoxFioPat.Text, txtBoxMedPat.Text, cmBoxStreets.Text, txtNum_house.Text, txtNum_kv.Text, txtBoxPhonePat.Text, customDateTimePicker1.Value.ToString("yyyy-MM-dd"));
                        MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Обновление  таблицы
                        dataGridView1.DataSource = OutPutPatients.listPatients();
                        ClearTxt();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        OutPutPatients.ConnClose();
                    }
                }
                else
                {
                    ErrorMessage("Заполните все поля!");
                }
            }


            //РЕДАКТИРОВАНИЕ
            //Сохранений изменений
            //

            //Условие, при котором спрашиваем, если редактирование верно, то оно будет принимать меры, чтобы избежать ошибок
            if (EditPat == true)
             {
                try
                {
                    OutPutPatients.EditPatients(txtBoxFioPat.Text, txtBoxMedPat.Text, cmBoxStreets.Text, txtNum_house.Text, txtNum_kv.Text, txtBoxPhonePat.Text, customDateTimePicker1.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(idPat));
                    MessageBox.Show(" Пользователь успешно изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutPatients.listPatients();
                    ClearTxt();
                    EditPat = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка изменения строки \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutPatients.ConnClose();
                }
            }
        }

        //Кнопка Изменить
        private void BtnPatientsEdit_Click(object sender, EventArgs e)
        {
            //Если выделены ячейки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditPat = true;
                //Имя тексового поля равно значению ячейки, выбранная в имя столбца 
                txtBoxFioPat.Text = dataGridView1.CurrentRow.Cells["fio_pat"].Value.ToString();
                txtBoxMedPat.Text = dataGridView1.CurrentRow.Cells["med_polis"].Value.ToString();
                cmBoxStreets.Text = dataGridView1.CurrentRow.Cells["street"].Value.ToString();
                txtNum_house.Text = dataGridView1.CurrentRow.Cells["num_house"].Value.ToString();
                txtNum_kv.Text = dataGridView1.CurrentRow.Cells["num_kv"].Value.ToString();
                txtBoxPhonePat.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                //Переменная дата рождения
                DateTime dt_pat;
                dt_pat = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["dob"].Value.ToString());
                customDateTimePicker1.Value = dt_pat;
                idPat = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //Метод на очистку txtbox-ов
        private void ClearTxt()
        {
            txtBoxFioPat.Text = " ФИО Пациента";
            txtBoxMedPat.Text = " Мед.Полис";
            txtNum_house.Text = " Номер дома";
            txtNum_kv.Text = " Номер квартиры";
            txtBoxPhonePat.Text = " Телефон";
            labelError.Visible = false;
        }
        //Метод для вывода ошибок
        private void ErrorMessage(string mes)
        {
            labelError.Text = "    " + mes;
            labelError.Visible = true;
        }
        //
        //Удаление
        //
        private void BtnPatientsDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idPat = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                OutPutPatients.DeletePatients(Convert.ToInt32(idPat));
                MessageBox.Show("Пользователь удалён");
                //Обновление  таблицы
                dataGridView1.DataSource = OutPutPatients.listPatients();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }


        #region !!==!! Надпись на txtbox-aх и чтобы она пропадала при нажатие на неё
        private void txtBoxFioPat_Enter(object sender, EventArgs e)
        {
            if (txtBoxFioPat.Text == " ФИО Пациента")
            {
                txtBoxFioPat.Text = "";
                txtBoxFioPat.ForeColor = Color.White;
            }
        }

        private void txtBoxFioPat_Leave(object sender, EventArgs e)
        {
            if (txtBoxFioPat.Text == "")
            {
                txtBoxFioPat.Text = " ФИО Пациента";
                txtBoxFioPat.ForeColor = Color.DarkGray;
            }
        }
        private void txtBoxMedPat_Enter(object sender, EventArgs e)
        {
            if (txtBoxMedPat.Text == " Мед.Полис")
            {
                txtBoxMedPat.Text = "";
                txtBoxMedPat.ForeColor = Color.White;
            }
        }

        private void txtBoxMedPat_Leave(object sender, EventArgs e)
        {
            if (txtBoxMedPat.Text == "")
            {
                txtBoxMedPat.Text = " Мед.Полис";
                txtBoxMedPat.ForeColor = Color.DarkGray;
            }
        }

        private void txtBoxPhonePat_Enter(object sender, EventArgs e)
        {
            if (txtBoxPhonePat.Text == " Телефон")
            {
                txtBoxPhonePat.Text = "";
                txtBoxPhonePat.ForeColor = Color.White;
            }
        }

        private void txtBoxPhonePat_Leave(object sender, EventArgs e)
        {
            if (txtBoxPhonePat.Text == "")
            {
                txtBoxPhonePat.Text = " Телефон";
                txtBoxPhonePat.ForeColor = Color.DarkGray;
            }
        }

        private void txtNum_house_Enter(object sender, EventArgs e)
        {
            if (txtNum_house.Text == " Номер дома")
            {
                txtNum_house.Text = "";
                txtNum_house.ForeColor = Color.White;
            }
        }

        private void txtNum_house_Leave(object sender, EventArgs e)
        {
            if (txtNum_house.Text == "")
            {
                txtNum_house.Text = " Номер дома";
                txtNum_house.ForeColor = Color.DarkGray;
            }
        }

        private void txtNum_kv_Enter(object sender, EventArgs e)
        {
            if (txtNum_kv.Text == " Номер квартиры")
            {
                txtNum_kv.Text = "";
                txtNum_kv.ForeColor = Color.White;
            }
        }

        private void txtNum_kv_Leave(object sender, EventArgs e)
        {
            if (txtNum_kv.Text == "")
            {
                txtNum_kv.Text = " Номер квартиры";
                txtNum_kv.ForeColor = Color.DarkGray;
            }
        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"fio_pat LIKE '%{SearchTxt.Text}%'";
        }
    }
}
