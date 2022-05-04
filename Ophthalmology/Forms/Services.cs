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
    public partial class Services : Form
    {
        ClsServices OutPutService = new ClsServices();
        private string idService = null;
        //Переменная для применнеия редактирования на кнопке сохранить
        private bool EditService = false;
        public Services()
        {
            InitializeComponent();

            //Свойства combobox-a для поиска 
            comboBoxDoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDoc.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Services_Load(object sender, EventArgs e)
        {
            //Добавляем врачей 
            dataGridView1.DataSource = OutPutService.listServices();
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            //Ширина полей
            dataGridView1.Columns[0].FillWeight = 7;
            dataGridView1.Columns[1].FillWeight = 25;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 25;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Заголовки
            dataGridView1.Columns[0].HeaderText = "id";
            dataGridView1.Columns[1].HeaderText = "Услуга";
            dataGridView1.Columns[2].HeaderText = "Стоимость";
            dataGridView1.Columns[3].HeaderText = "Доктор";
            //Убираем заголовки строк
            //dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            //Устанавлием ограничения для ролей
            if (UserCache.role == Positions.Register)
            {
                BtnServicesAdd.Enabled = false;
                BtnServicesEdit.Enabled = false;
                BtnServicesDel.Enabled = false;
            }
            if (UserCache.role == Positions.Doctors)
            {
                BtnServicesAdd.Enabled = false;
                BtnServicesEdit.Enabled = false;
                BtnServicesDel.Enabled = false;
            }
            //Вывод информации в combobox
            comboBoxDoc.DataSource = OutPutService.listDoctors();
            comboBoxDoc.DisplayMember = "fio_doc"; // Вывод информации в cbmbox
            comboBoxDoc.ValueMember = "id";
        }

        private void buttonExitDoctors_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Кнопка сохранить
        private void BtnServicesAdd_Click(object sender, EventArgs e)
        {
            //
            //Добавление
            //
            //Условие, если редактирование ложно, то добавляется запись
            if (EditService == false)
            {
                if (txtBoxService.Text != " Услуга" && txtBoxPrice.Text != " Стоимость")
                {
                    try
                    {
                        OutPutService.ConnOpen();
                        OutPutService.AddServices(txtBoxService.Text, Convert.ToDecimal(txtBoxPrice.Text), comboBoxDoc.Text);
                        MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Обновление  таблицы
                        dataGridView1.DataSource = OutPutService.listServices();
                        ClearTxt();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        OutPutService.ConnClose();
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
            if (EditService == true)
            {
                try
                {
                    OutPutService.EditServices(txtBoxService.Text, Convert.ToDecimal(txtBoxPrice.Text), comboBoxDoc.Text, Convert.ToInt32(idService));
                    MessageBox.Show(" Пользователь успешно изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutService.listServices();
                    ClearTxt();
                    EditService = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка изменения строки \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutService.ConnClose();
                }
            }
        }
        //Перенос строк в текст боксы
        //Кнопка Изменить
        private void BtnServicesEdit_Click(object sender, EventArgs e)
        {
            //Если выделены ячейки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditService = true;
                //Имя тексового поля равно значению ячейки, выбранная в имя столбца 
                txtBoxService.Text = dataGridView1.CurrentRow.Cells["name_service"].Value.ToString();
                decimal price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["price"].Value.ToString());
                txtBoxPrice.Text = price.ToString();
                    //(dataGridView1.CurrentRow.Cells["price"].Value.ToString());
                comboBoxDoc.Text = dataGridView1.CurrentRow.Cells["doc"].Value.ToString();
                idService = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //Удалить
        private void BtnServicesDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idService = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                OutPutService.DeleteServices(Convert.ToInt32(idService));
                MessageBox.Show("Пользователь удалён");
                //Обновление  таблицы
                dataGridView1.DataSource = OutPutService.listServices();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //Метод на очистку txtbox-ов
        private void ClearTxt()
        {
            txtBoxService.Text = " Услуга";
            txtBoxPrice.Text = " Стоимость";
            labelError.Visible = false;
        }
        //Метод для вывода ошибок
        private void ErrorMessage(string mes)
        {
            labelError.Text = "    " + mes;
            labelError.Visible = true;
        }
        #region !!==!! Надпись на txtbox-aх и чтобы она пропадала при нажатие на неё
        private void txtBoxService_Enter(object sender, EventArgs e)
        {
            if (txtBoxService.Text == " Услуга")
            {
                txtBoxService.Text = "";
                txtBoxService.ForeColor = Color.White;
            }
        }

        private void txtBoxService_Leave(object sender, EventArgs e)
        {
            if (txtBoxService.Text == "")
            {
                txtBoxService.Text = " Услуга";
                txtBoxService.ForeColor = Color.DarkGray;
            }
        }

        private void txtBoxPrice_Enter(object sender, EventArgs e)
        {
            if (txtBoxPrice.Text == " Стоимость")
            {
                txtBoxPrice.Text = "";
                txtBoxPrice.ForeColor = Color.White;
            }
        }

        private void txtBoxPrice_Leave(object sender, EventArgs e)
        {
            if (txtBoxPrice.Text == "")
            {
                txtBoxPrice.Text = " Стоимость";
                txtBoxPrice.ForeColor = Color.DarkGray;
            }
        }
        #endregion
        //Поиск услуги
        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"name_service LIKE '%{SearchTxt.Text}%'";
        }
    }
}
