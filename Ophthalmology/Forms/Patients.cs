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
        DataAccess.ClsPatients OutPutPatients = new DataAccess.ClsPatients();
        private string idPat = null;
        //Переменная для применнеия редактирования на кнопке сохранить
        private bool EditPat = false;

        public Patients()
        {
            InitializeComponent();
        }

        private void buttonExitPatients_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OutPutPatients.listPatients();
            //Видимость полей в гриде
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;
            dataGridView1.Columns[6].Visible = true;
            //Ширина полей
            dataGridView1.Columns[0].FillWeight = 7;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 25;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;
            dataGridView1.Columns[5].FillWeight = 8;
            dataGridView1.Columns[6].FillWeight = 13;

            //Растягивание полей грида
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Убираем заголовки строк
            //dataGridView1.RowHeadersVisible = false;
            //Показываем заголовки столбцов
            dataGridView1.ColumnHeadersVisible = true;

            if (UserCache.Position == Positions.Guest)
            {
                BtnPatientsAdd.Enabled = false;
                BtnPatientsEdit.Enabled = false;
                BtnPatientsDel.Enabled = false;
            }

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
                try
                {
                    OutPutPatients.ConnOpen();
                    OutPutPatients.AddDoctor(txtBoxFioPat.Text, txtBoxAddressPat.Text, txtBoxMedPat.Text, txtBoxPhonePat.Text, txtBoxGenderPat.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Обновление  таблицы
                    dataGridView1.DataSource = OutPutPatients.listPatients();
                    ClearTxt();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OutPutPatients.ConnClose();
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
                    OutPutPatients.EditDoctor(txtBoxFioPat.Text, txtBoxAddressPat.Text, txtBoxMedPat.Text, txtBoxPhonePat.Text, txtBoxGenderPat.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(idPat));
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

        //Изменить
        private void BtnPatientsEdit_Click(object sender, EventArgs e)
        {
            //Если выделены ячейки
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditPat = true;
                //Имя тексового поля равно значению ячейки, выбранная в имя столбца 
                txtBoxFioPat.Text = dataGridView1.CurrentRow.Cells["fio_pat"].Value.ToString();
                txtBoxAddressPat.Text = dataGridView1.CurrentRow.Cells["address"].Value.ToString();
                txtBoxMedPat.Text = dataGridView1.CurrentRow.Cells["med_policy"].Value.ToString();
                txtBoxPhonePat.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();

                //combobox в datagrid
                //DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
                //combo.HeaderText = "gender";
                //combo.Name = "combo";
                //ArrayList row = new ArrayList();
                //row = new ArrayList();
                //row.AddRange(new string[] { "М", "Ж" });
                //combo.Items.AddRange(row.ToArray());

                //dataGridView1.Columns.Add(combo);

                txtBoxGenderPat.Text = dataGridView1.CurrentRow.Cells["gender"].Value.ToString();
                //Переменная дата рождения
                DateTime dt_pat;
                dt_pat = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["dob"].Value.ToString());
                dateTimePicker1.Value = dt_pat;
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
            txtBoxAddressPat.Text = " Адрес";
            txtBoxMedPat.Text = " Мед.Полис";
            txtBoxPhonePat.Text = " Телефон";
            txtBoxGenderPat.Text = " Пол";
        }



        //
        //Удаление
        //
        private void BtnPatientsDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idPat = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                OutPutPatients.DeleteDoctor(Convert.ToInt32(idPat));
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

        private void txtBoxAddressPat_Enter(object sender, EventArgs e)
        {
            if (txtBoxAddressPat.Text == " Адрес")
            {
                txtBoxAddressPat.Text = "";
                txtBoxAddressPat.ForeColor = Color.White;
            }
        }

        private void txtBoxAddressPat_Leave(object sender, EventArgs e)
        {
            if (txtBoxAddressPat.Text == "")
            {
                txtBoxAddressPat.Text = " Адрес";
                txtBoxAddressPat.ForeColor = Color.DarkGray;
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

        private void txtBoxGenderPat_Enter(object sender, EventArgs e)
        {
            if (txtBoxGenderPat.Text == " Пол")
            {
                txtBoxGenderPat.Text = "";
                txtBoxGenderPat.ForeColor = Color.White;
            }
        }

        private void txtBoxGenderPat_Leave(object sender, EventArgs e)
        {
            if(txtBoxGenderPat.Text == "")
            {
                txtBoxGenderPat.Text = " Пол";
                txtBoxGenderPat.ForeColor = Color.DarkGray;
            }
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxGenderPat.Text = "Муж";
            }
            else
                txtBoxGenderPat.Text = " Пол";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtBoxGenderPat.Text = "Жен";
            }
            else
                txtBoxGenderPat.Text = " Пол";
        }
    }
}
