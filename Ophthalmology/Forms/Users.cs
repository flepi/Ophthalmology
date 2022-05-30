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
    public partial class Users : Form
    {
        ClsUsers OutPutUser = new ClsUsers();

        private string idUser = null;
        //Переменная для применнеия редактирования на кнопке сохранить
        private bool EditService = false;
        public Users()
        {
            InitializeComponent();

            //Свойства combobox-a для поиска 
            comboBoxRole.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxRole.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            //Добавляем врачей 
            dataGridView1.DataSource = OutPutUser.listUsers();
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
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Логин";
            dataGridView1.Columns[3].HeaderText = "Пароль";
            dataGridView1.Columns[4].HeaderText = "Роль";
            //Убираем заголовки строк
            //dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;
            //Устанавлием ограничения для ролей
            if (UserCache.role == Positions.Register)
            {

            }
            //Вывод информации в combobox
            comboBoxRole.DataSource = OutPutUser.listRole();
            comboBoxRole.DisplayMember = "name_role"; // Вывод информации в cbmbox
            comboBoxRole.ValueMember = "id";
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
                if (txtBoxUsername.Text != " Имя" && txtBoxLogin.Text != " Логин" && txtBoxPassword.Text != " Пароль")
                {
                    try
                    {
                        OutPutUser.ConnOpen();
                        OutPutUser.AddUsers(txtBoxUsername.Text, txtBoxLogin.Text, txtBoxPassword.Text, comboBoxRole.Text);
                        MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Обновление  таблицы
                        dataGridView1.DataSource = OutPutUser.listUsers();
                        //ClearTxt();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        OutPutUser.ConnClose();
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
                    OutPutUser.EditUsers(txtBoxUsername.Text, txtBoxLogin.Text, txtBoxPassword.Text, comboBoxRole.Text, Convert.ToInt32(idUser));
                    MessageBox.Show(" Пользователь успешно изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutUser.listUsers();
                    //ClearTxt();
                    EditService = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка изменения строки \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutUser.ConnClose();
                }
            }
        }
        //Кнопка изменить
        private void BtnServicesEdit_Click(object sender, EventArgs e)
        {
            //Если выделены ячейки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditService = true;
                //Имя тексового поля равно значению ячейки, выбранная в имя столбца 
                txtBoxUsername.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                txtBoxLogin.Text = dataGridView1.CurrentRow.Cells["login"].Value.ToString();
                txtBoxPassword.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
                comboBoxRole.Text = dataGridView1.CurrentRow.Cells["role"].Value.ToString();
                idUser = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //Кнопка удалить
        private void BtnServicesDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idUser = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                OutPutUser.DeleteUsers(Convert.ToInt32(idUser));
                MessageBox.Show("Пользователь удалён");
                //Обновление  таблицы
                dataGridView1.DataSource = OutPutUser.listUsers();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //Метод на очистку txtbox-ов
        private void ClearTxt()
        {
            txtBoxUsername.Text = " Имя";
            txtBoxLogin.Text = " Логин";
            txtBoxPassword.Text = " Пароль";
            labelError.Visible = false;
        }
        //Метод для вывода ошибок
        private void ErrorMessage(string mes)
        {
            labelError.Text = "    " + mes;
            labelError.Visible = true;
        }
        #region !!==!! Надпись на txtbox-aх и чтобы она пропадала при нажатие на неё
        private void txtBoxUsername_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text == " Имя")
            {
                txtBoxUsername.Text = "";
                txtBoxUsername.ForeColor = Color.White;
            }
        }

        private void txtBoxUsername_Leave(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text == "")
            {
                txtBoxUsername.Text = " Имя";
                txtBoxUsername.ForeColor = Color.DarkGray;
            }
        }

        private void txtBoxLogin_Enter(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text == " Логин")
            {
                txtBoxLogin.Text = "";
                txtBoxLogin.ForeColor = Color.White;
            }
        }

        private void txtBoxLogin_Leave(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text == "")
            {
                txtBoxLogin.Text = " Логин";
                txtBoxLogin.ForeColor = Color.DarkGray;
            }
        }

        private void txtBoxPassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == " Пароль")
            {
                txtBoxPassword.Text = "";
                txtBoxPassword.ForeColor = Color.White;
            }
        }

        private void txtBoxPassword_Leave(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "")
            {
                txtBoxPassword.Text = " Пароль";
                txtBoxPassword.ForeColor = Color.DarkGray;
            }
        }
        #endregion
        //Поиск пользователя по имени
        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE '%{SearchTxt.Text}%'";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("\nИмя пользователя: " + dataGridView1.CurrentRow.Cells["name"].Value.ToString()
                + "\nЛогин: " + dataGridView1.CurrentRow.Cells["login"].Value.ToString()
                + "\nПароль: " + dataGridView1.CurrentRow.Cells["password"].Value.ToString()
                + "\nРоль: " + dataGridView1.CurrentRow.Cells["role"].Value.ToString(), "Информация о пользователе");
        }
    }
}
