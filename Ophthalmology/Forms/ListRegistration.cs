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
    public partial class ListRegistration : Form
    {
        ClsRegisters OutPutReg = new ClsRegisters();
        private string idReg = null;
        //Переменная для применнеия редактирования на кнопке сохранить
        private bool EditReg = false;
        public ListRegistration()
        {
            InitializeComponent();

            //Свойства combobox-a для поиска 
            cmBoxPosition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxPosition.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Свойства combobox-a для поиска 
            cmBoxDoctors.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxDoctors.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void buttonExitDoctors_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListRegistration_Load(object sender, EventArgs e)
        {
            //Добавляем записи  
            dataGridView1.DataSource = OutPutReg.listRegisters();
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            //Ширина полей
            dataGridView1.Columns[0].FillWeight = 7;
            dataGridView1.Columns[1].FillWeight = 23;
            dataGridView1.Columns[2].FillWeight = 25;
            dataGridView1.Columns[3].FillWeight = 25;
            dataGridView1.Columns[4].FillWeight = 18;
            dataGridView1.Columns[5].FillWeight = 15;
            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Заголовки
            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "ФИО Пациента";
            dataGridView1.Columns[2].HeaderText = "Должность";
            dataGridView1.Columns[3].HeaderText = "Доктор";
            dataGridView1.Columns[4].HeaderText = "День";
            dataGridView1.Columns[5].HeaderText = "Время";
            //Убираем заголовки строк
            //dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;

            //Устанавливаем для ролей ограничения
            if (UserCache.role == Positions.Register)
            {

            }
            if (UserCache.role == Positions.Doctors)
            {
                BtnRegAdd.Enabled = false;
                BtnRegEdit.Enabled = false;
                BtnRegDel.Enabled = false;
            }
            //Вывод информации о должностях в combobox
            cmBoxPosition.DataSource = OutPutReg.listPosition();
            cmBoxPosition.DisplayMember = "position_name"; // Вывод информации в cbmbox
            cmBoxPosition.ValueMember = "id_position";

            //Вывод информации о должностях в combobox
            cmBoxPat.DataSource = OutPutReg.listPatients();
            cmBoxPat.DisplayMember = "fio_pat"; // Вывод информации в cbmbox
            cmBoxPat.ValueMember = "id";

            //Вывод информации о врачей по должностям combobox
            cmBoxDoctors.DataSource = OutPutReg.listDoctors();
            cmBoxDoctors.DisplayMember = "fio_doc"; // Вывод информации в cbmbox
            cmBoxDoctors.ValueMember = "id";
        }

        private void BtnRegAdd_Click(object sender, EventArgs e)
        {
            //
            //Добавление
            //
            //Условие, если редактирование ложно, то добавляется запись
            if (EditReg == false)
            {
                if (txtBoxTime.Text != " Время приёма" )
                {
                    try
                    {
                        OutPutReg.ConnOpen();
                        OutPutReg.AddRegisters(cmBoxPat.Text, cmBoxPosition.Text, cmBoxDoctors.Text, customDtPickerReg.Value.ToString("yyyy-MM-dd"), txtBoxTime.Text);
                        MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Обновление  таблицы
                        dataGridView1.DataSource = OutPutReg.listRegisters();
                        ClearTxt();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        OutPutReg.ConnClose();
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
            if (EditReg == true)
            {
                try
                {
                    OutPutReg.EditRegisters(cmBoxPat.Text, cmBoxPosition.Text, cmBoxDoctors.Text, customDtPickerReg.Value.ToString("yyyy-MM-dd"), txtBoxTime.Text, Convert.ToInt32(idReg));
                    MessageBox.Show(" Пользователь успешно изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutReg.listRegisters();
                    ClearTxt();
                    EditReg = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка изменения строки \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutReg.ConnClose();
                }
            }
        }

        private void BtnRegEdit_Click(object sender, EventArgs e)
        {
            //Перенос строк в текст боксы
            //Кнопка Изменить
            //Если выделены ячейки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditReg = true;
                //Имя тексового поля равно значению ячейки, выбранная в имя столбца 
                cmBoxPat.Text = dataGridView1.CurrentRow.Cells["fio"].Value.ToString();
                cmBoxPosition.Text = dataGridView1.CurrentRow.Cells["position"].Value.ToString();
                cmBoxDoctors.Text = dataGridView1.CurrentRow.Cells["doc"].Value.ToString();
                txtBoxTime.Text = dataGridView1.CurrentRow.Cells["time"].Value.ToString();
                //Переменная дата рождения
                DateTime dt_reg;
                dt_reg = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["date"].Value.ToString());
                customDtPickerReg.Value = dt_reg;
                idReg = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //Удалить
        private void BtnRegDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idReg = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                OutPutReg.DeleteRegisters(Convert.ToInt32(idReg));
                MessageBox.Show("Пользователь удалён");
                //Обновление  таблицы
                dataGridView1.DataSource = OutPutReg.listRegisters();
            }
            else
            {
                MessageBox.Show("Выберите строку, пожалуйста");
            }
        }
        //Метод на очистку txtbox-ов
        private void ClearTxt()
        {
            //txtBoxFio.Text = " ФИО";
            txtBoxTime.Text = " Время приёма";
            labelError.Visible = false;
        }
        //Метод для вывода ошибок
        private void ErrorMessage(string mes)
        {
            labelError.Text = "    " + mes;
            labelError.Visible = true;
        }
        #region !!==!! Надпись на txtbox-aх и чтобы она пропадала при нажатие на неё
        //private void txtBoxFio_Enter(object sender, EventArgs e)
        //{
        //    if (txtBoxFio.Text == " ФИО")
        //    {
        //        txtBoxFio.Text = "";
        //        txtBoxFio.ForeColor = Color.White;
        //    }
        //}

        //private void txtBoxFio_Leave(object sender, EventArgs e)
        //{
        //    if (txtBoxFio.Text == "")
        //    {
        //        txtBoxFio.Text = " ФИО";
        //        txtBoxFio.ForeColor = Color.DarkGray;
        //    }
        //}

        private void txtBoxTime_Enter(object sender, EventArgs e)
        {
            if (txtBoxTime.Text == " Время приёма")
            {
                txtBoxTime.Text = "";
                txtBoxTime.ForeColor = Color.White;
            }
        }

        private void txtBoxTime_Leave(object sender, EventArgs e)
        {
            if (txtBoxTime.Text == "")
            {
                txtBoxTime.Text = " Время приёма";
                txtBoxTime.ForeColor = Color.DarkGray;
            }
        }
        #endregion
        //Поиск
        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"fio LIKE '%{SearchTxt.Text}%'";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("\nФИО Пациента: " + dataGridView1.CurrentRow.Cells["fio"].Value.ToString()
                + "\nДолжность: " + dataGridView1.CurrentRow.Cells["position"].Value.ToString()
                + "\nФИО Врача: " + dataGridView1.CurrentRow.Cells["doc"].Value.ToString()
                + "\nДень приёма: " + dataGridView1.CurrentRow.Cells["date"].Value.ToString()
                + "\nВремя приёма: " + dataGridView1.CurrentRow.Cells["time"].Value.ToString(), "Информация о приёме ");
        }
    }
}
