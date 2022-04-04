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


using DataAccess;

namespace Ophthalmology
{
    public partial class Authorization : Form
    {
        ClsUsers users = new ClsUsers();
        public Authorization()
        {
            InitializeComponent();
        }
        #region ЗакрытьСвернутьУвелиичить
        //Закрыть
        private void iconbtnExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //В полный экран
        private void iconBtnMaxLogin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //Скрыть
        private void iconBtnMinLogin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Очищение поля имя пользователя
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Имя пользователя")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.LightGray;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Имя пользователя";
                textBoxLogin.ForeColor = Color.DimGray;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Пароль")
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.LightGray;
                textBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "Пароль";
                textBoxPass.ForeColor = Color.DimGray;
                textBoxPass.UseSystemPasswordChar = false;
            }
        }
        #endregion
        #region //Перестановка формы
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void labelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Проверка на пустые поля 
            if (textBoxLogin.Text != "Имя пользователя" && textBoxLogin.TextLength>2)
            {
                if (textBoxPass.Text != "Пароль")
                {
                    //Объявляем переменную неявного типа, для входа
                    var validLogin = users.LoginUser(textBoxLogin.Text, textBoxPass.Text);
                    //Проверка существует ли пользователь и пароль 
                    if (validLogin == true)
                    {
                        //Скрываем форму входа в следующий экземпляр 
                        this.Hide();
                        WelcomeForm welcome = new WelcomeForm();
                        welcome.ShowDialog();
                        MainForm mainMenu = new MainForm();
                        mainMenu.Show();
                        mainMenu.FormClosed += LogOutAccounts;
                    }
                    else
                    {
                        ErrorMessage("Некорректный логин или пароль. \n    Попробуйте снова. ");
                        textBoxPass.Text  =  "Пароль";
                        textBoxPass.UseSystemPasswordChar = false;
                        textBoxLogin.Focus();
                    }               
                }
                else
                {
                    ErrorMessage("Пожалуйста введите пароль.");
                }
            }
            else
            {
                ErrorMessage("Пожалуйста введите свой логин или имя пользователя.");
            }

        }
        //Метод для вывода ошибок об авторизации
        private void ErrorMessage(string mes)
        {
            labelError.Text = "    " + mes;
            labelError.Visible = true;
        }
        //Пустой частный метод для выхода, в параметрах объект и событие на закрытие формы
        private void LogOutAccounts(object sender, FormClosedEventArgs e)
        {
            textBoxLogin.Text = "Имя пользователя";
            textBoxPass.Text = "Пароль";
            textBoxPass.UseSystemPasswordChar = false;
            labelError.Visible = false;
            this.Show();
            //textBoxLogin.Focus();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           //textBox1.Text = users.sha256(textBoxPass.Text);
        }
    }
}

        
    

        
