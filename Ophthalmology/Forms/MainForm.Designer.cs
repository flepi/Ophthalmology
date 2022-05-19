
namespace Ophthalmology
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExitAccounts = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.btnContacts = new FontAwesome.Sharp.IconButton();
            this.panelReports = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.panelReferences = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReferences = new FontAwesome.Sharp.IconButton();
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnRegistration = new FontAwesome.Sharp.IconButton();
            this.labelNameCard = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelSetHome = new System.Windows.Forms.Panel();
            this.iconBtnMax = new FontAwesome.Sharp.IconButton();
            this.iconBtnMin = new FontAwesome.Sharp.IconButton();
            this.iconbtnExit = new FontAwesome.Sharp.IconButton();
            this.labelSetHome = new System.Windows.Forms.Label();
            this.iconSetHome = new FontAwesome.Sharp.IconPictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.pictureGifMainForm = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelReports.SuspendLayout();
            this.panelReferences.SuspendLayout();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelSetHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSetHome)).BeginInit();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGifMainForm)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.btnExitAccounts);
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnContacts);
            this.panelMenu.Controls.Add(this.panelReports);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.panelReferences);
            this.panelMenu.Controls.Add(this.btnReferences);
            this.panelMenu.Controls.Add(this.panelCard);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 661);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // btnExitAccounts
            // 
            this.btnExitAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExitAccounts.FlatAppearance.BorderSize = 0;
            this.btnExitAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitAccounts.ForeColor = System.Drawing.Color.White;
            this.btnExitAccounts.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnExitAccounts.IconColor = System.Drawing.Color.IndianRed;
            this.btnExitAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExitAccounts.IconSize = 32;
            this.btnExitAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitAccounts.Location = new System.Drawing.Point(0, 732);
            this.btnExitAccounts.Name = "btnExitAccounts";
            this.btnExitAccounts.Padding = new System.Windows.Forms.Padding(17, 0, 29, 0);
            this.btnExitAccounts.Size = new System.Drawing.Size(234, 78);
            this.btnExitAccounts.TabIndex = 8;
            this.btnExitAccounts.Text = "Выйти";
            this.btnExitAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitAccounts.UseVisualStyleBackColor = true;
            this.btnExitAccounts.Click += new System.EventHandler(this.btnExitAccounts_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.Medapps;
            this.btnAbout.IconColor = System.Drawing.Color.IndianRed;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 32;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 672);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(17, 0, 29, 0);
            this.btnAbout.Size = new System.Drawing.Size(234, 60);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContacts.FlatAppearance.BorderSize = 0;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.ForeColor = System.Drawing.Color.White;
            this.btnContacts.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btnContacts.IconColor = System.Drawing.Color.IndianRed;
            this.btnContacts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContacts.IconSize = 32;
            this.btnContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.Location = new System.Drawing.Point(0, 612);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Padding = new System.Windows.Forms.Padding(17, 0, 29, 0);
            this.btnContacts.Size = new System.Drawing.Size(234, 60);
            this.btnContacts.TabIndex = 4;
            this.btnContacts.Text = "Контакты";
            this.btnContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // panelReports
            // 
            this.panelReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelReports.Controls.Add(this.button13);
            this.panelReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReports.Location = new System.Drawing.Point(0, 568);
            this.panelReports.Name = "panelReports";
            this.panelReports.Padding = new System.Windows.Forms.Padding(35, 0, 30, 0);
            this.panelReports.Size = new System.Drawing.Size(234, 44);
            this.panelReports.TabIndex = 4;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(35, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(169, 37);
            this.button13.TabIndex = 1;
            this.button13.Text = "Выработка врачей";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.btnReports.IconColor = System.Drawing.Color.IndianRed;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 32;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 508);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(17, 0, 29, 0);
            this.btnReports.Size = new System.Drawing.Size(234, 60);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Отчёты";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panelReferences
            // 
            this.panelReferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelReferences.Controls.Add(this.button6);
            this.panelReferences.Controls.Add(this.button5);
            this.panelReferences.Controls.Add(this.button4);
            this.panelReferences.Controls.Add(this.button3);
            this.panelReferences.Controls.Add(this.button2);
            this.panelReferences.Controls.Add(this.button1);
            this.panelReferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReferences.Location = new System.Drawing.Point(0, 288);
            this.panelReferences.Name = "panelReferences";
            this.panelReferences.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.panelReferences.Size = new System.Drawing.Size(234, 220);
            this.panelReferences.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(35, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(179, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "Пользователи";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(35, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Услуги";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(35, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Карточки пациентов";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(35, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Список приёмов";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(35, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Список пациентов";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Список врачей";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReferences
            // 
            this.btnReferences.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReferences.FlatAppearance.BorderSize = 0;
            this.btnReferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReferences.ForeColor = System.Drawing.Color.White;
            this.btnReferences.IconChar = FontAwesome.Sharp.IconChar.LaptopMedical;
            this.btnReferences.IconColor = System.Drawing.Color.IndianRed;
            this.btnReferences.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReferences.IconSize = 32;
            this.btnReferences.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferences.Location = new System.Drawing.Point(0, 228);
            this.btnReferences.Name = "btnReferences";
            this.btnReferences.Padding = new System.Windows.Forms.Padding(15, 0, 29, 0);
            this.btnReferences.Size = new System.Drawing.Size(234, 60);
            this.btnReferences.TabIndex = 1;
            this.btnReferences.Text = "Справочники\r\n";
            this.btnReferences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReferences.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReferences.UseVisualStyleBackColor = true;
            this.btnReferences.Click += new System.EventHandler(this.btnReferences_Click);
            // 
            // panelCard
            // 
            this.panelCard.Controls.Add(this.btnRegistration);
            this.panelCard.Controls.Add(this.labelNameCard);
            this.panelCard.Controls.Add(this.iconPictureBox1);
            this.panelCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCard.Location = new System.Drawing.Point(0, 0);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(234, 228);
            this.panelCard.TabIndex = 1;
            this.panelCard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCard_MouseDown);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            this.btnRegistration.IconColor = System.Drawing.Color.IndianRed;
            this.btnRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistration.IconSize = 32;
            this.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.Location = new System.Drawing.Point(0, 168);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Padding = new System.Windows.Forms.Padding(17, 0, 29, 0);
            this.btnRegistration.Size = new System.Drawing.Size(234, 60);
            this.btnRegistration.TabIndex = 4;
            this.btnRegistration.Text = "Запись на приём";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // labelNameCard
            // 
            this.labelNameCard.AutoSize = true;
            this.labelNameCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.labelNameCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNameCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameCard.ForeColor = System.Drawing.Color.LightGray;
            this.labelNameCard.Location = new System.Drawing.Point(94, 18);
            this.labelNameCard.Name = "labelNameCard";
            this.labelNameCard.Size = new System.Drawing.Size(47, 21);
            this.labelNameCard.TabIndex = 2;
            this.labelNameCard.Text = "Имя:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconPictureBox1.IconColor = System.Drawing.Color.IndianRed;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 106;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(234, 106);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconPictureBox1_MouseDown);
            // 
            // panelSetHome
            // 
            this.panelSetHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelSetHome.Controls.Add(this.iconBtnMax);
            this.panelSetHome.Controls.Add(this.iconBtnMin);
            this.panelSetHome.Controls.Add(this.iconbtnExit);
            this.panelSetHome.Controls.Add(this.labelSetHome);
            this.panelSetHome.Controls.Add(this.iconSetHome);
            this.panelSetHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSetHome.Location = new System.Drawing.Point(251, 0);
            this.panelSetHome.Name = "panelSetHome";
            this.panelSetHome.Size = new System.Drawing.Size(766, 104);
            this.panelSetHome.TabIndex = 1;
            this.panelSetHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSetHome_MouseDown);
            // 
            // iconBtnMax
            // 
            this.iconBtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMax.FlatAppearance.BorderSize = 0;
            this.iconBtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconBtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMax.ForeColor = System.Drawing.Color.White;
            this.iconBtnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconBtnMax.IconColor = System.Drawing.Color.White;
            this.iconBtnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMax.IconSize = 15;
            this.iconBtnMax.Location = new System.Drawing.Point(697, 3);
            this.iconBtnMax.Name = "iconBtnMax";
            this.iconBtnMax.Size = new System.Drawing.Size(34, 16);
            this.iconBtnMax.TabIndex = 3;
            this.iconBtnMax.UseVisualStyleBackColor = true;
            this.iconBtnMax.Click += new System.EventHandler(this.iconBtnMax_Click);
            // 
            // iconBtnMin
            // 
            this.iconBtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMin.FlatAppearance.BorderSize = 0;
            this.iconBtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconBtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMin.ForeColor = System.Drawing.Color.White;
            this.iconBtnMin.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.iconBtnMin.IconColor = System.Drawing.Color.White;
            this.iconBtnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMin.IconSize = 15;
            this.iconBtnMin.Location = new System.Drawing.Point(663, 3);
            this.iconBtnMin.Name = "iconBtnMin";
            this.iconBtnMin.Size = new System.Drawing.Size(34, 16);
            this.iconBtnMin.TabIndex = 4;
            this.iconBtnMin.UseVisualStyleBackColor = true;
            this.iconBtnMin.Click += new System.EventHandler(this.iconBtnMin_Click);
            // 
            // iconbtnExit
            // 
            this.iconbtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconbtnExit.FlatAppearance.BorderSize = 0;
            this.iconbtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.iconbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconbtnExit.IconColor = System.Drawing.Color.White;
            this.iconbtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnExit.IconSize = 15;
            this.iconbtnExit.Location = new System.Drawing.Point(732, 3);
            this.iconbtnExit.Name = "iconbtnExit";
            this.iconbtnExit.Size = new System.Drawing.Size(34, 16);
            this.iconbtnExit.TabIndex = 3;
            this.iconbtnExit.UseVisualStyleBackColor = false;
            this.iconbtnExit.Click += new System.EventHandler(this.iconbtnExit_Click);
            // 
            // labelSetHome
            // 
            this.labelSetHome.AutoSize = true;
            this.labelSetHome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSetHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelSetHome.Location = new System.Drawing.Point(99, 16);
            this.labelSetHome.Name = "labelSetHome";
            this.labelSetHome.Size = new System.Drawing.Size(178, 30);
            this.labelSetHome.TabIndex = 2;
            this.labelSetHome.Text = "Регистратура";
            this.labelSetHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSetHome_MouseDown);
            // 
            // iconSetHome
            // 
            this.iconSetHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconSetHome.ForeColor = System.Drawing.Color.Orchid;
            this.iconSetHome.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical;
            this.iconSetHome.IconColor = System.Drawing.Color.Orchid;
            this.iconSetHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSetHome.IconSize = 45;
            this.iconSetHome.Location = new System.Drawing.Point(21, 12);
            this.iconSetHome.Name = "iconSetHome";
            this.iconSetHome.Size = new System.Drawing.Size(62, 45);
            this.iconSetHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSetHome.TabIndex = 0;
            this.iconSetHome.TabStop = false;
            this.iconSetHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconSetHome_MouseDown);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelChild.Controls.Add(this.pictureGifMainForm);
            this.panelChild.Controls.Add(this.panelFooter);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(251, 104);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(766, 557);
            this.panelChild.TabIndex = 2;
            // 
            // pictureGifMainForm
            // 
            this.pictureGifMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureGifMainForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureGifMainForm.Image")));
            this.pictureGifMainForm.Location = new System.Drawing.Point(0, 0);
            this.pictureGifMainForm.Name = "pictureGifMainForm";
            this.pictureGifMainForm.Size = new System.Drawing.Size(766, 453);
            this.pictureGifMainForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGifMainForm.TabIndex = 1;
            this.pictureGifMainForm.TabStop = false;
            this.pictureGifMainForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureGifMainForm_MouseDown);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelFooter.Controls.Add(this.labelDate);
            this.panelFooter.Controls.Add(this.labelTime);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 453);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(766, 104);
            this.panelFooter.TabIndex = 0;
            this.panelFooter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFooter_MouseDown);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.LightGray;
            this.labelDate.Location = new System.Drawing.Point(590, 60);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 31);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(582, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(118, 42);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1017, 661);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelSetHome);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optics";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelReports.ResumeLayout(false);
            this.panelReferences.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelSetHome.ResumeLayout(false);
            this.panelSetHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSetHome)).EndInit();
            this.panelChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGifMainForm)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnReferences;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Panel panelReferences;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton btnExitAccounts;
        private FontAwesome.Sharp.IconButton btnContacts;
        private System.Windows.Forms.Panel panelReports;
        private System.Windows.Forms.Button button13;
        private FontAwesome.Sharp.IconButton btnReports;
        private System.Windows.Forms.Panel panelSetHome;
        private FontAwesome.Sharp.IconPictureBox iconSetHome;
        private System.Windows.Forms.Label labelSetHome;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panelFooter;
        private FontAwesome.Sharp.IconButton iconBtnMax;
        private FontAwesome.Sharp.IconButton iconBtnMin;
        private FontAwesome.Sharp.IconButton iconbtnExit;
        private System.Windows.Forms.Label labelNameCard;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.PictureBox pictureGifMainForm;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private FontAwesome.Sharp.IconButton btnRegistration;
        private FontAwesome.Sharp.IconButton btnAbout;
    }
}

