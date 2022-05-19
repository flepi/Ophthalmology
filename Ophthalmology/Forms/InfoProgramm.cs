using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ophthalmology.Forms
{
    public partial class InfoProgramm : Form
    {
        public InfoProgramm()
        {
            InitializeComponent();
        }

        private void buttonExitDoctors_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
