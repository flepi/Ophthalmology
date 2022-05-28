
namespace Ophthalmology.Forms
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.buttonExitRegistration = new System.Windows.Forms.Button();
            this.BtnRegistration = new FontAwesome.Sharp.IconButton();
            this.txtBoxCheckFio = new System.Windows.Forms.TextBox();
            this.cmBoxPosition = new System.Windows.Forms.ComboBox();
            this.cmBoxDoctors = new System.Windows.Forms.ComboBox();
            this.btnCheck = new FontAwesome.Sharp.IconButton();
            this.labelPriemAdd = new System.Windows.Forms.Label();
            this.txtNum_kv = new System.Windows.Forms.TextBox();
            this.txtNum_house = new System.Windows.Forms.TextBox();
            this.cmBoxStreets = new System.Windows.Forms.ComboBox();
            this.txtBoxMedPat = new System.Windows.Forms.TextBox();
            this.BtnPatientsAdd = new FontAwesome.Sharp.IconButton();
            this.labelCheckPolis = new System.Windows.Forms.Label();
            this.labelRegisration = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelPat = new System.Windows.Forms.Label();
            this.txtBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.txtBoxPhonePat = new System.Windows.Forms.MaskedTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelDataPriem = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.customDtPickerAdd = new Ophthalmology.CustomDateTimePicker();
            this.customDtPickerReg = new Ophthalmology.CustomDateTimePicker();
            this.SuspendLayout();
            // 
            // buttonExitRegistration
            // 
            this.buttonExitRegistration.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonExitRegistration.FlatAppearance.BorderSize = 0;
            this.buttonExitRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonExitRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitRegistration.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitRegistration.ForeColor = System.Drawing.Color.LightGray;
            this.buttonExitRegistration.Location = new System.Drawing.Point(2, -1);
            this.buttonExitRegistration.Name = "buttonExitRegistration";
            this.buttonExitRegistration.Size = new System.Drawing.Size(62, 25);
            this.buttonExitRegistration.TabIndex = 17;
            this.buttonExitRegistration.Text = "Закрыть";
            this.buttonExitRegistration.UseVisualStyleBackColor = true;
            this.buttonExitRegistration.Click += new System.EventHandler(this.buttonExitRegistration_Click);
            // 
            // BtnRegistration
            // 
            this.BtnRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(109)))));
            this.BtnRegistration.FlatAppearance.BorderSize = 0;
            this.BtnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.BtnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRegistration.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRegistration.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.BtnRegistration.IconColor = System.Drawing.Color.DarkGreen;
            this.BtnRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistration.IconSize = 25;
            this.BtnRegistration.Location = new System.Drawing.Point(33, 232);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(470, 30);
            this.BtnRegistration.TabIndex = 18;
            this.BtnRegistration.Text = "Записать";
            this.BtnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistration.UseVisualStyleBackColor = false;
            this.BtnRegistration.Visible = false;
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // txtBoxCheckFio
            // 
            this.txtBoxCheckFio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxCheckFio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCheckFio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxCheckFio.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxCheckFio.Location = new System.Drawing.Point(37, 65);
            this.txtBoxCheckFio.Name = "txtBoxCheckFio";
            this.txtBoxCheckFio.Size = new System.Drawing.Size(175, 19);
            this.txtBoxCheckFio.TabIndex = 26;
            this.txtBoxCheckFio.Text = " ФИО";
            this.txtBoxCheckFio.Enter += new System.EventHandler(this.txtBoxPolis_Enter);
            this.txtBoxCheckFio.Leave += new System.EventHandler(this.txtBoxPolis_Leave);
            // 
            // cmBoxPosition
            // 
            this.cmBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxPosition.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxPosition.FormattingEnabled = true;
            this.cmBoxPosition.Location = new System.Drawing.Point(33, 105);
            this.cmBoxPosition.Name = "cmBoxPosition";
            this.cmBoxPosition.Size = new System.Drawing.Size(470, 25);
            this.cmBoxPosition.TabIndex = 38;
            this.cmBoxPosition.Text = "Выбрать специальность";
            this.cmBoxPosition.Visible = false;
            this.cmBoxPosition.SelectedIndexChanged += new System.EventHandler(this.cmBoxPosition_SelectedIndexChanged);
            // 
            // cmBoxDoctors
            // 
            this.cmBoxDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxDoctors.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxDoctors.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxDoctors.FormattingEnabled = true;
            this.cmBoxDoctors.Location = new System.Drawing.Point(34, 141);
            this.cmBoxDoctors.Name = "cmBoxDoctors";
            this.cmBoxDoctors.Size = new System.Drawing.Size(470, 25);
            this.cmBoxDoctors.TabIndex = 39;
            this.cmBoxDoctors.Text = "Выбрать врача";
            this.cmBoxDoctors.Visible = false;
            this.cmBoxDoctors.SelectedIndexChanged += new System.EventHandler(this.cmBoxDoctors_SelectedIndexChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(109)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.ForeColor = System.Drawing.Color.LightGray;
            this.btnCheck.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnCheck.IconColor = System.Drawing.Color.DarkGreen;
            this.btnCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheck.IconSize = 20;
            this.btnCheck.Location = new System.Drawing.Point(37, 90);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(175, 42);
            this.btnCheck.TabIndex = 44;
            this.btnCheck.Text = "Поиск пациента в БД";
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labelPriemAdd
            // 
            this.labelPriemAdd.AutoSize = true;
            this.labelPriemAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriemAdd.ForeColor = System.Drawing.Color.LightGray;
            this.labelPriemAdd.Location = new System.Drawing.Point(136, 44);
            this.labelPriemAdd.Name = "labelPriemAdd";
            this.labelPriemAdd.Size = new System.Drawing.Size(370, 23);
            this.labelPriemAdd.TabIndex = 46;
            this.labelPriemAdd.Text = "Добавление пациента в базу данных";
            this.labelPriemAdd.Visible = false;
            // 
            // txtNum_kv
            // 
            this.txtNum_kv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtNum_kv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum_kv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNum_kv.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNum_kv.Location = new System.Drawing.Point(34, 186);
            this.txtNum_kv.Name = "txtNum_kv";
            this.txtNum_kv.Size = new System.Drawing.Size(466, 19);
            this.txtNum_kv.TabIndex = 53;
            this.txtNum_kv.Text = " Номер квартиры";
            this.txtNum_kv.Visible = false;
            this.txtNum_kv.Enter += new System.EventHandler(this.txtNum_kv_Enter);
            this.txtNum_kv.Leave += new System.EventHandler(this.txtNum_kv_Leave);
            // 
            // txtNum_house
            // 
            this.txtNum_house.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtNum_house.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum_house.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNum_house.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNum_house.Location = new System.Drawing.Point(34, 161);
            this.txtNum_house.Name = "txtNum_house";
            this.txtNum_house.Size = new System.Drawing.Size(466, 19);
            this.txtNum_house.TabIndex = 52;
            this.txtNum_house.Text = " Номер дома";
            this.txtNum_house.Visible = false;
            this.txtNum_house.Enter += new System.EventHandler(this.txtNum_house_Enter);
            this.txtNum_house.Leave += new System.EventHandler(this.txtNum_house_Leave);
            // 
            // cmBoxStreets
            // 
            this.cmBoxStreets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxStreets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxStreets.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxStreets.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxStreets.FormattingEnabled = true;
            this.cmBoxStreets.Location = new System.Drawing.Point(34, 130);
            this.cmBoxStreets.Name = "cmBoxStreets";
            this.cmBoxStreets.Size = new System.Drawing.Size(469, 25);
            this.cmBoxStreets.TabIndex = 51;
            this.cmBoxStreets.Visible = false;
            // 
            // txtBoxMedPat
            // 
            this.txtBoxMedPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxMedPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMedPat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxMedPat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxMedPat.Location = new System.Drawing.Point(33, 105);
            this.txtBoxMedPat.Name = "txtBoxMedPat";
            this.txtBoxMedPat.Size = new System.Drawing.Size(470, 19);
            this.txtBoxMedPat.TabIndex = 47;
            this.txtBoxMedPat.Text = " Мед.Полис";
            this.txtBoxMedPat.Visible = false;
            this.txtBoxMedPat.Enter += new System.EventHandler(this.txtBoxMedPat_Enter);
            this.txtBoxMedPat.Leave += new System.EventHandler(this.txtBoxMedPat_Leave);
            // 
            // BtnPatientsAdd
            // 
            this.BtnPatientsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(109)))));
            this.BtnPatientsAdd.FlatAppearance.BorderSize = 0;
            this.BtnPatientsAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.BtnPatientsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatientsAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPatientsAdd.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPatientsAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnPatientsAdd.IconColor = System.Drawing.Color.Green;
            this.BtnPatientsAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPatientsAdd.IconSize = 25;
            this.BtnPatientsAdd.Location = new System.Drawing.Point(32, 270);
            this.BtnPatientsAdd.Name = "BtnPatientsAdd";
            this.BtnPatientsAdd.Size = new System.Drawing.Size(468, 36);
            this.BtnPatientsAdd.TabIndex = 54;
            this.BtnPatientsAdd.Text = "Добавить пациента";
            this.BtnPatientsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatientsAdd.UseVisualStyleBackColor = false;
            this.BtnPatientsAdd.Visible = false;
            this.BtnPatientsAdd.Click += new System.EventHandler(this.BtnPatientsAdd_Click);
            // 
            // labelCheckPolis
            // 
            this.labelCheckPolis.AutoSize = true;
            this.labelCheckPolis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCheckPolis.ForeColor = System.Drawing.Color.LightGray;
            this.labelCheckPolis.Location = new System.Drawing.Point(33, 37);
            this.labelCheckPolis.Name = "labelCheckPolis";
            this.labelCheckPolis.Size = new System.Drawing.Size(191, 20);
            this.labelCheckPolis.TabIndex = 55;
            this.labelCheckPolis.Text = "Введите ФИО пациента:";
            // 
            // labelRegisration
            // 
            this.labelRegisration.AutoSize = true;
            this.labelRegisration.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegisration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelRegisration.Location = new System.Drawing.Point(193, 39);
            this.labelRegisration.Name = "labelRegisration";
            this.labelRegisration.Size = new System.Drawing.Size(173, 23);
            this.labelRegisration.TabIndex = 56;
            this.labelRegisration.Text = "Запись на приём";
            this.labelRegisration.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkGray;
            this.labelError.Image = ((System.Drawing.Image)(resources.GetObject("labelError.Image")));
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelError.Location = new System.Drawing.Point(37, 138);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 15);
            this.labelError.TabIndex = 61;
            this.labelError.Text = "label";
            this.labelError.Visible = false;
            // 
            // labelPat
            // 
            this.labelPat.AutoSize = true;
            this.labelPat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPat.ForeColor = System.Drawing.Color.LightGray;
            this.labelPat.Location = new System.Drawing.Point(36, 80);
            this.labelPat.Name = "labelPat";
            this.labelPat.Size = new System.Drawing.Size(0, 21);
            this.labelPat.TabIndex = 62;
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxTime.BeepOnError = true;
            this.txtBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxTime.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxTime.Location = new System.Drawing.Point(177, 205);
            this.txtBoxTime.Mask = "00:00";
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(327, 20);
            this.txtBoxTime.TabIndex = 63;
            this.txtBoxTime.Text = "1300";
            this.txtBoxTime.ValidatingType = typeof(System.DateTime);
            this.txtBoxTime.Visible = false;
            this.txtBoxTime.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.LightGray;
            this.labelTime.Location = new System.Drawing.Point(33, 205);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(127, 20);
            this.labelTime.TabIndex = 64;
            this.labelTime.Text = "Время приёма:";
            this.labelTime.Visible = false;
            // 
            // txtBoxPhonePat
            // 
            this.txtBoxPhonePat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxPhonePat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPhonePat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPhonePat.ForeColor = System.Drawing.Color.LightGray;
            this.txtBoxPhonePat.Location = new System.Drawing.Point(185, 216);
            this.txtBoxPhonePat.Mask = "+7(999) 999-9999";
            this.txtBoxPhonePat.Name = "txtBoxPhonePat";
            this.txtBoxPhonePat.Size = new System.Drawing.Size(315, 19);
            this.txtBoxPhonePat.TabIndex = 65;
            this.txtBoxPhonePat.Visible = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.ForeColor = System.Drawing.Color.LightGray;
            this.labelPhone.Location = new System.Drawing.Point(30, 215);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(149, 20);
            this.labelPhone.TabIndex = 66;
            this.labelPhone.Text = "Номер телефона:";
            this.labelPhone.Visible = false;
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDob.ForeColor = System.Drawing.Color.LightGray;
            this.labelDob.Location = new System.Drawing.Point(30, 238);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(129, 20);
            this.labelDob.TabIndex = 67;
            this.labelDob.Text = "Дата рождения:";
            this.labelDob.Visible = false;
            // 
            // labelDataPriem
            // 
            this.labelDataPriem.AutoSize = true;
            this.labelDataPriem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataPriem.ForeColor = System.Drawing.Color.LightGray;
            this.labelDataPriem.Location = new System.Drawing.Point(33, 172);
            this.labelDataPriem.Name = "labelDataPriem";
            this.labelDataPriem.Size = new System.Drawing.Size(179, 20);
            this.labelDataPriem.TabIndex = 68;
            this.labelDataPriem.Text = "Выбрать день приёма:";
            this.labelDataPriem.Visible = false;
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError2.ForeColor = System.Drawing.Color.DarkGray;
            this.labelError2.Image = ((System.Drawing.Image)(resources.GetObject("labelError2.Image")));
            this.labelError2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelError2.Location = new System.Drawing.Point(31, 309);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(34, 15);
            this.labelError2.TabIndex = 69;
            this.labelError2.Text = "label";
            this.labelError2.Visible = false;
            // 
            // customDtPickerAdd
            // 
            this.customDtPickerAdd.BorderColors = System.Drawing.Color.PaleVioletRed;
            this.customDtPickerAdd.BorderSize = 0;
            this.customDtPickerAdd.CalendarTitleForeColor = System.Drawing.Color.Green;
            this.customDtPickerAdd.CustomFormat = "";
            this.customDtPickerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customDtPickerAdd.Location = new System.Drawing.Point(185, 239);
            this.customDtPickerAdd.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDtPickerAdd.Name = "customDtPickerAdd";
            this.customDtPickerAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customDtPickerAdd.Size = new System.Drawing.Size(315, 25);
            this.customDtPickerAdd.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.customDtPickerAdd.TabIndex = 60;
            this.customDtPickerAdd.TxtColor = System.Drawing.Color.LightGray;
            this.customDtPickerAdd.Visible = false;
            // 
            // customDtPickerReg
            // 
            this.customDtPickerReg.BorderColors = System.Drawing.Color.PaleVioletRed;
            this.customDtPickerReg.BorderSize = 0;
            this.customDtPickerReg.CalendarTitleForeColor = System.Drawing.Color.Green;
            this.customDtPickerReg.CustomFormat = "";
            this.customDtPickerReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customDtPickerReg.Location = new System.Drawing.Point(177, 172);
            this.customDtPickerReg.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDtPickerReg.Name = "customDtPickerReg";
            this.customDtPickerReg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customDtPickerReg.Size = new System.Drawing.Size(327, 25);
            this.customDtPickerReg.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.customDtPickerReg.TabIndex = 59;
            this.customDtPickerReg.TxtColor = System.Drawing.Color.DarkGray;
            this.customDtPickerReg.Visible = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(615, 359);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.labelDataPriem);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.txtBoxPhonePat);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.labelPat);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.customDtPickerAdd);
            this.Controls.Add(this.customDtPickerReg);
            this.Controls.Add(this.labelRegisration);
            this.Controls.Add(this.labelCheckPolis);
            this.Controls.Add(this.BtnPatientsAdd);
            this.Controls.Add(this.txtNum_kv);
            this.Controls.Add(this.txtNum_house);
            this.Controls.Add(this.cmBoxStreets);
            this.Controls.Add(this.txtBoxMedPat);
            this.Controls.Add(this.labelPriemAdd);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cmBoxDoctors);
            this.Controls.Add(this.cmBoxPosition);
            this.Controls.Add(this.txtBoxCheckFio);
            this.Controls.Add(this.BtnRegistration);
            this.Controls.Add(this.buttonExitRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitRegistration;
        private FontAwesome.Sharp.IconButton BtnRegistration;
        private System.Windows.Forms.TextBox txtBoxCheckFio;
        private System.Windows.Forms.ComboBox cmBoxPosition;
        private System.Windows.Forms.ComboBox cmBoxDoctors;
        private FontAwesome.Sharp.IconButton btnCheck;
        private System.Windows.Forms.Label labelPriemAdd;
        private System.Windows.Forms.TextBox txtNum_kv;
        private System.Windows.Forms.TextBox txtNum_house;
        private System.Windows.Forms.ComboBox cmBoxStreets;
        private System.Windows.Forms.TextBox txtBoxMedPat;
        private FontAwesome.Sharp.IconButton BtnPatientsAdd;
        private System.Windows.Forms.Label labelCheckPolis;
        private System.Windows.Forms.Label labelRegisration;
        private CustomDateTimePicker customDtPickerReg;
        private CustomDateTimePicker customDtPickerAdd;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelPat;
        private System.Windows.Forms.MaskedTextBox txtBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.MaskedTextBox txtBoxPhonePat;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelDataPriem;
        private System.Windows.Forms.Label labelError2;
    }
}