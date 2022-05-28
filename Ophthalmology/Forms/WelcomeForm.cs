using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Common.Cache;

namespace Ophthalmology
{
    public partial class WelcomeForm : Form
    {
        // Для закругления углов 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);

        //Перестановка формы
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public WelcomeForm()
        {
            InitializeComponent();


            // Для закругления углов 
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }
        #region Перестановка формы
        //Для перестановки формы
        private void WelcomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Для перестановки формы
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //Переменная для плавного отображения label
        int counter = 0;
        int len = 0;
        string text;
        //Загрузка формы
        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            //Выводим в label роль пользователя
            label2.Text = "Ваша роль: " + UserCache.role;
            this.Opacity = 0.0;
            //Устанавливаем усвойства для ProgressBar1
            ProgressBar1.Value = 0;
            ProgressBar1.Minimum = 0;
            ProgressBar1.Maximum = 100;
            timer2.Start();

            label2.Hide();
            text = label1.Text;
            len = text.Length;
            label1.Text = "";
            timer1.Start();
        }
        //Таймер на "Добро пожаловать"
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = text.Substring(0, counter);
            ++counter;
            if (counter > len)
            {
                label2.Show();
                timer1.Stop();
            }
        }
        //Таймер на прозрачность формы
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Установка прозрачности 
            if (this.Opacity < 0.95)
            {
                this.Opacity += 0.05;
            }
            ProgressBar1.Value += 1;
            ProgressBar1.Text = ProgressBar1.Value.ToString();
            if (ProgressBar1.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
    }
}
