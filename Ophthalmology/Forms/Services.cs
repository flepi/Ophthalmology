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
        ClsServices service = new ClsServices();
        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {

            // Убрать в класс!
            comboBox1.DataSource = service.listServices();
            comboBox1.DisplayMember = "name"; // Вывод информации в cbmbox
            comboBox1.ValueMember = "id";


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                //dataGridView1.DataSource = service.Addqwe(comboBox1);




            //comboBox1.SelectedValue = dataGridView1.DataSource = service.listDiagnostics();
            //dataGridView1.DataSource = service.listLaser();
            //dataGridView1.DataSource = service.listLaser();
        }

        private void buttonExitDoctors_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
