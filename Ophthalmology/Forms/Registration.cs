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
    public partial class Registration : Form
    {
        ClsRegisters Registers = new ClsRegisters();
        private BindingSource bSource = new BindingSource();
        public Registration()
        {
            InitializeComponent();
            //Свойства combobox-a для поиска 
            cmBoxDoctors.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxDoctors.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Свойства combobox-a для поиска 
            cmBoxPosition.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxPosition.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Свойства combobox-a для поиска 
            cmBoxStreets.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmBoxStreets.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        //Кнопка проверить
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtBoxPolis.Text != " Полис")
            {
                //Объявляем переменную неявного типа, для проверки
                var validPolis = Registers.Check(txtBoxPolis.Text);
                if (validPolis == true)
                {
                    MessageBox.Show("Пациент есть в базе данных");
                    labelRegisration.Visible = true;
                    txtBoxFio.Visible = true;
                    customDtPickerReg.Visible = true;
                    cmBoxPosition.Visible = true;
                    cmBoxDoctors.Visible = true;
                    BtnRegistration.Visible = true;
                    txtBoxTime.Visible = true;
                    labelError.Visible = false;
                }
                else
                {
                    MessageBox.Show("Пациента нет в базе данных");
                    labelPriemAdd.Visible = true;
                    txtBoxFioPat.Visible = true;
                    txtBoxMedPat.Visible = true;
                    txtBoxPhonePat.Visible = true;
                    txtBoxPolis.Visible = true;
                    txtNum_house.Visible = true;
                    txtNum_kv.Visible = true;
                    BtnPatientsAdd.Visible = true;
                    customDtPickerAdd.Visible = true;
                    cmBoxStreets.Visible = true;
                    labelError.Visible = false;
                }
            }
            else
            {
                ErrorMessage("Пожалуйста введите полис");
            }
        }
        //Метод для вывода ошибок
        private void ErrorMessage(string mes)
        {
            labelError.Text = "    " + mes;
            labelError.Visible = true;
        }
        //Метод на очистку txtbox-ов
        private void ClearTxt()
        {
            txtBoxFioPat.Text = " ФИО Пациента";
            txtBoxMedPat.Text = " Мед.Полис";
            txtNum_house.Text = " Номер дома";
            txtNum_kv.Text = " Номер квартиры";
            txtBoxPhonePat.Text = " Телефон";
            txtBoxPolis.Text = " Полис";
            txtBoxFio.Text = " ФИО";
            txtBoxTime.Text = " Время приёма";
            labelError.Visible = false;
        }
        private void buttonExitRegistration_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Кнопка записать
        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            if (txtBoxFio.Text != " ФИО" && txtBoxTime.Text!=" Время приёма")
            {
                try
                {
                    Registers.ConnOpen();
                    Registers.AddRegisters(txtBoxFio.Text, cmBoxPosition.Text, cmBoxDoctors.Text, customDtPickerReg.Value.ToString("yyyy-MM-dd"), txtBoxTime.Text);
                    MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    labelRegisration.Visible = false;
                    txtBoxFio.Visible = false;
                    customDtPickerReg.Visible = false;
                    cmBoxPosition.Visible = false;
                    cmBoxDoctors.Visible = false;
                    BtnRegistration.Visible = false;
                    txtBoxTime.Visible = false;
             
                    ClearTxt();
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Registers.ConnClose();
                }
            }
            else
            {
                ErrorMessage("Заполните все поля!");
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            ////Вывод информации о должностях в combobox
            cmBoxPosition.DataSource = Registers.listPosition();
            cmBoxPosition.DisplayMember = "position_name"; // Вывод информации в cbmbox
            cmBoxPosition.ValueMember = "id_position";

            //Вывод информации о врачей по должностям combobox
            cmBoxDoctors.DataSource = Registers.listDoctors();
            cmBoxDoctors.DisplayMember = "fio_doc"; // Вывод информации в cbmbox
            cmBoxDoctors.ValueMember = "id";

            //Вывод информации в combobox
            cmBoxStreets.DataSource = Registers.listStreets();
            cmBoxStreets.DisplayMember = "street_name"; // Вывод информации в cbmbox
            cmBoxStreets.ValueMember = "id";
        }
        #region !!==!! Надпись на txtbox-aх и чтобы она пропадала при нажатие на неё
        private void txtBoxPolis_Enter(object sender, EventArgs e)
        {
            if (txtBoxPolis.Text == " Полис")
            {
                txtBoxPolis.Text = "";
                txtBoxPolis.ForeColor = Color.White;
            }
        }

        private void txtBoxPolis_Leave(object sender, EventArgs e)
        {
            if (txtBoxPolis.Text == "")
            {
                txtBoxPolis.Text = " Полис";
                txtBoxPolis.ForeColor = Color.DarkGray;
            }
        }

        private void txtBoxFio_Enter(object sender, EventArgs e)
        {
            if (txtBoxFio.Text == " ФИО")
            {
                txtBoxFio.Text = "";
                txtBoxFio.ForeColor = Color.White;
            }
        }

        private void txtBoxFio_Leave(object sender, EventArgs e)
        {
            if (txtBoxFio.Text == "")
            {
                txtBoxFio.Text = " ФИО";
                txtBoxFio.ForeColor = Color.DarkGray;
            }
        }

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
        //Кнопка добавить 
        private void BtnPatientsAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxFioPat.Text != " ФИО Пациента" && txtBoxMedPat.Text != " Мед.Полис" && txtNum_house.Text != " Номер дома"
                && txtBoxPhonePat.Text != " Телефон" && txtNum_kv.Text != " Номер квартиры" && txtNum_kv.Text != " Номер квартиры")
            {
                try
                {
                    Registers.ConnOpen();
                    Registers.AddPatients(txtBoxFioPat.Text, txtBoxMedPat.Text, cmBoxStreets.Text, txtNum_house.Text, txtNum_kv.Text, txtBoxPhonePat.Text, customDtPickerAdd.Value.ToString("yyyy-MM-dd"));
                    MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelPriemAdd.Visible = false;
                    txtBoxFioPat.Visible = false;
                    txtBoxMedPat.Visible = false;
                    txtBoxPhonePat.Visible = false;
                    txtNum_house.Visible = false;
                    txtNum_kv.Visible = false;
                    BtnPatientsAdd.Visible = false;
                    customDtPickerAdd.Visible = false;
                    cmBoxStreets.Visible = false;

                    labelRegisration.Visible = true;
                    txtBoxFio.Visible = true;
                    customDtPickerReg.Visible = true;
                    cmBoxPosition.Visible = true;
                    cmBoxDoctors.Visible = true;
                    BtnRegistration.Visible = true;
                    txtBoxTime.Visible = true;
                    ClearTxt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавление  пользователя \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Registers.ConnClose();
                }
            }
            else
            {
                ErrorMessage("Заполните все поля!");
            }
        }

        private void cmBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void cmBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmBoxDoctors.DataSource = "position Like '" + cmBoxPosition.Text;
        }
    }
}
