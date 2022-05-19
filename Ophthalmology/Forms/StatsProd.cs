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
    public partial class StatsProd : Form
    {
        ClsRegisters OutPutReg = new ClsRegisters();
        public StatsProd()
        {
            InitializeComponent();
        }

        private void StatsProd_Load(object sender, EventArgs e)
        {
            //Вывод информации в combobox
            cmBoxDoc.DataSource = OutPutReg.listDoctors();
            cmBoxDoc.DisplayMember = "fio_doc"; // Вывод информации в cbmbox
            cmBoxDoc.ValueMember = "id";
        }

        private void BtnDoctorsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OutPutReg.ConnOpen();
                //OutPutReg.StatsTime(textBox1.Text, customDateTimePicker1.Value.ToString("yyyy-MM-dd"), customDateTimePicker2.Value.ToString("yyyy-MM-dd"));
                //MessageBox.Show(" Пользователь успешно добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Обновление  таблицы

                dataGridView1.DataSource = OutPutReg.StatsTime(cmBoxDoc.Text, customDateTimePicker1.Value.ToString("yyyy-MM-dd"), customDateTimePicker2.Value.ToString("yyyy-MM-dd"));
                //Видимость полей в гриде
                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[5].Visible = true;
                //Ширина полей
                dataGridView1.Columns[0].FillWeight = 5;
                dataGridView1.Columns[1].FillWeight = 30;
                dataGridView1.Columns[2].FillWeight = 25;
                dataGridView1.Columns[3].FillWeight = 25;
                dataGridView1.Columns[4].FillWeight = 15;
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
                dataGridView1.Columns[1].HeaderText = "ФИО Доктора";
                dataGridView1.Columns[2].HeaderText = "Должность";
                dataGridView1.Columns[3].HeaderText = "Пациент";
                dataGridView1.Columns[4].HeaderText = "День приёма";
                dataGridView1.Columns[5].HeaderText = "Время приёма";
                //Отражаем количество записей в ДатаГриде
                label4.Visible = true;
                int count_rows = dataGridView1.RowCount - 1;
                label4.Text = (count_rows).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выработки \n\n" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                OutPutReg.ConnClose();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
