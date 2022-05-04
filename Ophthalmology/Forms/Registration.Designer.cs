
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
            this.txtBoxPolis = new System.Windows.Forms.TextBox();
            this.cmBoxPosition = new System.Windows.Forms.ComboBox();
            this.cmBoxDoctors = new System.Windows.Forms.ComboBox();
            this.btnCheck = new FontAwesome.Sharp.IconButton();
            this.labelPriemAdd = new System.Windows.Forms.Label();
            this.txtNum_kv = new System.Windows.Forms.TextBox();
            this.txtNum_house = new System.Windows.Forms.TextBox();
            this.cmBoxStreets = new System.Windows.Forms.ComboBox();
            this.txtBoxPhonePat = new System.Windows.Forms.TextBox();
            this.txtBoxFioPat = new System.Windows.Forms.TextBox();
            this.txtBoxMedPat = new System.Windows.Forms.TextBox();
            this.BtnPatientsAdd = new FontAwesome.Sharp.IconButton();
            this.labelCheckPolis = new System.Windows.Forms.Label();
            this.labelRegisration = new System.Windows.Forms.Label();
            this.txtBoxFio = new System.Windows.Forms.TextBox();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
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
            this.BtnRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnRegistration.Location = new System.Drawing.Point(459, 196);
            this.BtnRegistration.Name = "BtnRegistration";
            this.BtnRegistration.Size = new System.Drawing.Size(327, 30);
            this.BtnRegistration.TabIndex = 18;
            this.BtnRegistration.Text = "Записать";
            this.BtnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistration.UseVisualStyleBackColor = false;
            this.BtnRegistration.Visible = false;
            this.BtnRegistration.Click += new System.EventHandler(this.BtnRegistration_Click);
            // 
            // txtBoxPolis
            // 
            this.txtBoxPolis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxPolis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPolis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPolis.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxPolis.Location = new System.Drawing.Point(12, 65);
            this.txtBoxPolis.Name = "txtBoxPolis";
            this.txtBoxPolis.Size = new System.Drawing.Size(173, 19);
            this.txtBoxPolis.TabIndex = 26;
            this.txtBoxPolis.Text = " Полис";
            this.txtBoxPolis.Enter += new System.EventHandler(this.txtBoxPolis_Enter);
            this.txtBoxPolis.Leave += new System.EventHandler(this.txtBoxPolis_Leave);
            // 
            // cmBoxPosition
            // 
            this.cmBoxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxPosition.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxPosition.FormattingEnabled = true;
            this.cmBoxPosition.Location = new System.Drawing.Point(459, 78);
            this.cmBoxPosition.Name = "cmBoxPosition";
            this.cmBoxPosition.Size = new System.Drawing.Size(327, 25);
            this.cmBoxPosition.TabIndex = 38;
            this.cmBoxPosition.Text = "Выбрать специальность";
            this.cmBoxPosition.Visible = false;
            // 
            // cmBoxDoctors
            // 
            this.cmBoxDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxDoctors.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxDoctors.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxDoctors.FormattingEnabled = true;
            this.cmBoxDoctors.Location = new System.Drawing.Point(459, 109);
            this.cmBoxDoctors.Name = "cmBoxDoctors";
            this.cmBoxDoctors.Size = new System.Drawing.Size(327, 25);
            this.cmBoxDoctors.TabIndex = 39;
            this.cmBoxDoctors.Text = "Выбрать врача";
            this.cmBoxDoctors.Visible = false;
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
            this.btnCheck.Location = new System.Drawing.Point(12, 90);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(173, 30);
            this.btnCheck.TabIndex = 44;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labelPriemAdd
            // 
            this.labelPriemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriemAdd.AutoSize = true;
            this.labelPriemAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriemAdd.ForeColor = System.Drawing.Color.LightGray;
            this.labelPriemAdd.Location = new System.Drawing.Point(455, 27);
            this.labelPriemAdd.Name = "labelPriemAdd";
            this.labelPriemAdd.Size = new System.Drawing.Size(263, 20);
            this.labelPriemAdd.TabIndex = 46;
            this.labelPriemAdd.Text = "Добавить пациента в базу данных";
            this.labelPriemAdd.Visible = false;
            // 
            // txtNum_kv
            // 
            this.txtNum_kv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum_kv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtNum_kv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum_kv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNum_kv.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNum_kv.Location = new System.Drawing.Point(455, 157);
            this.txtNum_kv.Name = "txtNum_kv";
            this.txtNum_kv.Size = new System.Drawing.Size(316, 19);
            this.txtNum_kv.TabIndex = 53;
            this.txtNum_kv.Text = " Номер квартиры";
            this.txtNum_kv.Visible = false;
            this.txtNum_kv.Enter += new System.EventHandler(this.txtNum_kv_Enter);
            this.txtNum_kv.Leave += new System.EventHandler(this.txtNum_kv_Leave);
            // 
            // txtNum_house
            // 
            this.txtNum_house.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum_house.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtNum_house.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum_house.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNum_house.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNum_house.Location = new System.Drawing.Point(455, 132);
            this.txtNum_house.Name = "txtNum_house";
            this.txtNum_house.Size = new System.Drawing.Size(316, 19);
            this.txtNum_house.TabIndex = 52;
            this.txtNum_house.Text = " Номер дома";
            this.txtNum_house.Visible = false;
            this.txtNum_house.Enter += new System.EventHandler(this.txtNum_house_Enter);
            this.txtNum_house.Leave += new System.EventHandler(this.txtNum_house_Leave);
            // 
            // cmBoxStreets
            // 
            this.cmBoxStreets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxStreets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxStreets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxStreets.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxStreets.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxStreets.FormattingEnabled = true;
            this.cmBoxStreets.Location = new System.Drawing.Point(455, 101);
            this.cmBoxStreets.Name = "cmBoxStreets";
            this.cmBoxStreets.Size = new System.Drawing.Size(316, 25);
            this.cmBoxStreets.TabIndex = 51;
            this.cmBoxStreets.Visible = false;
            // 
            // txtBoxPhonePat
            // 
            this.txtBoxPhonePat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPhonePat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxPhonePat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPhonePat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPhonePat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxPhonePat.Location = new System.Drawing.Point(455, 182);
            this.txtBoxPhonePat.Name = "txtBoxPhonePat";
            this.txtBoxPhonePat.Size = new System.Drawing.Size(316, 19);
            this.txtBoxPhonePat.TabIndex = 49;
            this.txtBoxPhonePat.Text = " Телефон";
            this.txtBoxPhonePat.Visible = false;
            this.txtBoxPhonePat.Enter += new System.EventHandler(this.txtBoxPhonePat_Enter);
            this.txtBoxPhonePat.Leave += new System.EventHandler(this.txtBoxPhonePat_Leave);
            // 
            // txtBoxFioPat
            // 
            this.txtBoxFioPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFioPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxFioPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFioPat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxFioPat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxFioPat.Location = new System.Drawing.Point(455, 50);
            this.txtBoxFioPat.Name = "txtBoxFioPat";
            this.txtBoxFioPat.Size = new System.Drawing.Size(316, 19);
            this.txtBoxFioPat.TabIndex = 48;
            this.txtBoxFioPat.Text = " ФИО Пациента";
            this.txtBoxFioPat.Visible = false;
            this.txtBoxFioPat.Enter += new System.EventHandler(this.txtBoxFioPat_Enter);
            this.txtBoxFioPat.Leave += new System.EventHandler(this.txtBoxFioPat_Leave);
            // 
            // txtBoxMedPat
            // 
            this.txtBoxMedPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMedPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxMedPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMedPat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxMedPat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxMedPat.Location = new System.Drawing.Point(454, 76);
            this.txtBoxMedPat.Name = "txtBoxMedPat";
            this.txtBoxMedPat.Size = new System.Drawing.Size(317, 19);
            this.txtBoxMedPat.TabIndex = 47;
            this.txtBoxMedPat.Text = " Мед.Полис";
            this.txtBoxMedPat.Visible = false;
            this.txtBoxMedPat.Enter += new System.EventHandler(this.txtBoxMedPat_Enter);
            this.txtBoxMedPat.Leave += new System.EventHandler(this.txtBoxMedPat_Leave);
            // 
            // BtnPatientsAdd
            // 
            this.BtnPatientsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.BtnPatientsAdd.Location = new System.Drawing.Point(456, 236);
            this.BtnPatientsAdd.Name = "BtnPatientsAdd";
            this.BtnPatientsAdd.Size = new System.Drawing.Size(315, 36);
            this.BtnPatientsAdd.TabIndex = 54;
            this.BtnPatientsAdd.Text = "Добавить";
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
            this.labelCheckPolis.Location = new System.Drawing.Point(8, 27);
            this.labelCheckPolis.Name = "labelCheckPolis";
            this.labelCheckPolis.Size = new System.Drawing.Size(165, 20);
            this.labelCheckPolis.TabIndex = 55;
            this.labelCheckPolis.Text = "Проверка по полису";
            // 
            // labelRegisration
            // 
            this.labelRegisration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegisration.AutoSize = true;
            this.labelRegisration.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegisration.ForeColor = System.Drawing.Color.LightGray;
            this.labelRegisration.Location = new System.Drawing.Point(551, 27);
            this.labelRegisration.Name = "labelRegisration";
            this.labelRegisration.Size = new System.Drawing.Size(141, 20);
            this.labelRegisration.TabIndex = 56;
            this.labelRegisration.Text = "Запись на приём";
            this.labelRegisration.Visible = false;
            // 
            // txtBoxFio
            // 
            this.txtBoxFio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxFio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxFio.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxFio.Location = new System.Drawing.Point(459, 50);
            this.txtBoxFio.Name = "txtBoxFio";
            this.txtBoxFio.Size = new System.Drawing.Size(327, 19);
            this.txtBoxFio.TabIndex = 57;
            this.txtBoxFio.Text = " ФИО";
            this.txtBoxFio.Visible = false;
            this.txtBoxFio.Enter += new System.EventHandler(this.txtBoxFio_Enter);
            this.txtBoxFio.Leave += new System.EventHandler(this.txtBoxFio_Leave);
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxTime.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxTime.Location = new System.Drawing.Point(459, 171);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(327, 19);
            this.txtBoxTime.TabIndex = 58;
            this.txtBoxTime.Text = " Время приёма";
            this.txtBoxTime.Visible = false;
            this.txtBoxTime.Enter += new System.EventHandler(this.txtBoxTime_Enter);
            this.txtBoxTime.Leave += new System.EventHandler(this.txtBoxTime_Leave);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkGray;
            this.labelError.Image = ((System.Drawing.Image)(resources.GetObject("labelError.Image")));
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelError.Location = new System.Drawing.Point(12, 132);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 15);
            this.labelError.TabIndex = 61;
            this.labelError.Text = "label";
            this.labelError.Visible = false;
            // 
            // customDtPickerAdd
            // 
            this.customDtPickerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customDtPickerAdd.BorderColors = System.Drawing.Color.PaleVioletRed;
            this.customDtPickerAdd.BorderSize = 0;
            this.customDtPickerAdd.CalendarTitleForeColor = System.Drawing.Color.Green;
            this.customDtPickerAdd.CustomFormat = "";
            this.customDtPickerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customDtPickerAdd.Location = new System.Drawing.Point(454, 207);
            this.customDtPickerAdd.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDtPickerAdd.Name = "customDtPickerAdd";
            this.customDtPickerAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customDtPickerAdd.Size = new System.Drawing.Size(317, 25);
            this.customDtPickerAdd.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.customDtPickerAdd.TabIndex = 60;
            this.customDtPickerAdd.TxtColor = System.Drawing.Color.DarkGray;
            this.customDtPickerAdd.Visible = false;
            // 
            // customDtPickerReg
            // 
            this.customDtPickerReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customDtPickerReg.BorderColors = System.Drawing.Color.PaleVioletRed;
            this.customDtPickerReg.BorderSize = 0;
            this.customDtPickerReg.CalendarTitleForeColor = System.Drawing.Color.Green;
            this.customDtPickerReg.CustomFormat = "";
            this.customDtPickerReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customDtPickerReg.Location = new System.Drawing.Point(459, 140);
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
            this.ClientSize = new System.Drawing.Size(810, 415);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.customDtPickerAdd);
            this.Controls.Add(this.customDtPickerReg);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.txtBoxFio);
            this.Controls.Add(this.labelRegisration);
            this.Controls.Add(this.labelCheckPolis);
            this.Controls.Add(this.BtnPatientsAdd);
            this.Controls.Add(this.txtNum_kv);
            this.Controls.Add(this.txtNum_house);
            this.Controls.Add(this.cmBoxStreets);
            this.Controls.Add(this.txtBoxPhonePat);
            this.Controls.Add(this.txtBoxFioPat);
            this.Controls.Add(this.txtBoxMedPat);
            this.Controls.Add(this.labelPriemAdd);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cmBoxDoctors);
            this.Controls.Add(this.cmBoxPosition);
            this.Controls.Add(this.txtBoxPolis);
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
        private System.Windows.Forms.TextBox txtBoxPolis;
        private System.Windows.Forms.ComboBox cmBoxPosition;
        private System.Windows.Forms.ComboBox cmBoxDoctors;
        private FontAwesome.Sharp.IconButton btnCheck;
        private System.Windows.Forms.Label labelPriemAdd;
        private System.Windows.Forms.TextBox txtNum_kv;
        private System.Windows.Forms.TextBox txtNum_house;
        private System.Windows.Forms.ComboBox cmBoxStreets;
        private System.Windows.Forms.TextBox txtBoxPhonePat;
        private System.Windows.Forms.TextBox txtBoxFioPat;
        private System.Windows.Forms.TextBox txtBoxMedPat;
        private FontAwesome.Sharp.IconButton BtnPatientsAdd;
        private System.Windows.Forms.Label labelCheckPolis;
        private System.Windows.Forms.Label labelRegisration;
        private System.Windows.Forms.TextBox txtBoxFio;
        private System.Windows.Forms.TextBox txtBoxTime;
        private CustomDateTimePicker customDtPickerReg;
        private CustomDateTimePicker customDtPickerAdd;
        private System.Windows.Forms.Label labelError;
    }
}