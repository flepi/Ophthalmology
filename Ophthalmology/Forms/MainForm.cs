using Common.Cache;
using FontAwesome.Sharp;
using Ophthalmology.Forms;
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

namespace Ophthalmology
{
    public partial class MainForm : Form
    {
        //Поля для применения левой границы к кнопке 
        private IconButton currentBtn;
        private Panel leftBorderBtn;


        // Для закругления углов 
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);

        public MainForm()
        {
            InitializeComponent();


            // Для закругления углов 
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            //прозрачности формы
            this.Opacity = (0.95);


            // Форма
            //Левая панель 
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 60);
            panelMenu.Controls.Add(leftBorderBtn);


            customizeDesign();

            //Форма
            //Активируем двойной буфер, чтобы уменьшить мерцание в графике формы

            this.Text = string.Empty;
            ControlBox = false;
            this.DoubleBuffered = true;
            //ограничение в развернутой форме
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //
        //Метод, который скрывает панели главных кнопок
        //
        private void customizeDesign()
        {
            panelReferences.Visible = false;
            panelReports.Visible = false;
        }
        //
        //Метод, чтобы скрыть меню
        //
        private void hidePanel()
        {
            if (panelReferences.Visible == true)
            {
                panelReferences.Visible = false;
            }
            if (panelReports.Visible == true)
            {
                panelReports.Visible = false;
            }
        }

        
        //
        //Метод для отображения меню
        //
        private void showPanel(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidePanel();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }
        //Пофиксить
        //private void closePanel()
        //{
        //    if (panelReferences.Visible == true)
        //    {
        //        panelReferences.Visible = false;
        //    }
        //    if (panelServices.Visible == true)
        //    {
        //        panelServices.Visible = false;
        //    }
        //    if (panelReports.Visible == true)
        //    {
        //        panelReports.Visible = false;
        //    }
        //}



        // Структура для хранения количество цветов RGB
        private struct RBGColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(255, 158, 114);
            public static Color color4 = Color.FromArgb(141, 130, 217);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Кнопка
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //На панели слева изменение цвета фона на параметр цвета    
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);

                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // iconSetHome
                iconSetHome.IconChar = currentBtn.IconChar;
                iconSetHome.IconColor = color;

            }
        }


        //Кнопки для того, чтобы отключить выделение кнопки 
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            iconSetHome.IconChar = IconChar.ClinicMedical; ;
            iconSetHome.IconColor = Color.Orchid;

            labelSetHome.Text = "Офтальмологическая клиника";

        }
        //Перестановка формы
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Главные кнопки на левой панели
        //Справочник
        private void btnReferences_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color1);
            labelSetHome.Text = "Справочники";
            showPanel(panelReferences);
        }
        //Услуги
        private void btnServices_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color2);

            labelSetHome.Text = "Услуги";

            openForm(new Services());
            //Выше код
            hidePanel();

        }
        //Отчёты
        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color3);
            labelSetHome.Text = "Отчёты";


            showPanel(panelReports);
        }
        //Контакты
        private void btnContacts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color4);
            labelSetHome.Text = "Контакты";

            //Код выше писать........................

            hidePanel();
        }
        //О программе
        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RBGColors.color5);
            labelSetHome.Text = "О программе";


            //Код выше писать........................

            hidePanel();
        }
        //Выйти
        private void btnExitAccounts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Doctors());

            labelSetHome.Text = "Список врачей";

            //Выше код
            hidePanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openForm(new Patients());

            labelSetHome.Text = "Список пациентов";
            //Выше код
            hidePanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Выше код
            hidePanel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Выше код
            hidePanel();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            //Выше код
            hidePanel();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Выше код
            hidePanel();
        }

        #endregion

        #region Панели
        private void panelSetHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelCard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconSetHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelSetHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion 

        //Переменная типа Form, значение  активное имени формы и этому значению мы говорим нет!
        private Form activeForm = null;
        private void openForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }        
            //Указываем, что дочерняя форме является верхнем уровнем, т.е она будет вести себя как элемент управления
            //Удаляем границу формы 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //Связываем форму с панелью 
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #region ЗакрытьУвеличитьСвернуть
        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBtnMax_Click(object sender, EventArgs e)
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

        private void iconBtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        //Загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Метод, для загрузки данных в карточку
            LoadCard();

            //Управления разрешениями 
            //Услоавие, где спрашиваем, если ли права на пользователя при загрузке
            if (UserCache.Position == Positions.Guest)
            {
                btnReports.Enabled = false;
            }
            if (UserCache.Position == Positions.Employees)
            {
                btnReports.Enabled = false;
            }
            if (UserCache.Position == Positions.Administrator)
            {
            }
        }
        //Метод, для загрузки данных в карточку
        private void LoadCard()
        {
            labelAccessCard.Text = UserCache.Position;
            labelNameCard.Text = UserCache.Name;
            labelEmailCard.Text = UserCache.Email;
        }

        private void iconPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //Возращение на главную форму
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelFooter_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureGifMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
