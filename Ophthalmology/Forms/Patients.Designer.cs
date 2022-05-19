
namespace Ophthalmology
{
    partial class Patients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.txtBoxPhonePat = new System.Windows.Forms.TextBox();
            this.txtBoxFioPat = new System.Windows.Forms.TextBox();
            this.txtBoxMedPat = new System.Windows.Forms.TextBox();
            this.BtnPatientsEdit = new FontAwesome.Sharp.IconButton();
            this.BtnPatientsDel = new FontAwesome.Sharp.IconButton();
            this.BtnPatientsAdd = new FontAwesome.Sharp.IconButton();
            this.buttonExitPatients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmBoxStreets = new System.Windows.Forms.ComboBox();
            this.txtNum_house = new System.Windows.Forms.TextBox();
            this.txtNum_kv = new System.Windows.Forms.TextBox();
            this.customDateTimePicker1 = new Ophthalmology.CustomDateTimePicker();
            this.labelError = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPhonePat
            // 
            this.txtBoxPhonePat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPhonePat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxPhonePat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPhonePat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPhonePat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxPhonePat.Location = new System.Drawing.Point(667, 163);
            this.txtBoxPhonePat.Name = "txtBoxPhonePat";
            this.txtBoxPhonePat.Size = new System.Drawing.Size(109, 19);
            this.txtBoxPhonePat.TabIndex = 23;
            this.txtBoxPhonePat.Text = " Телефон";
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
            this.txtBoxFioPat.Location = new System.Drawing.Point(667, 33);
            this.txtBoxFioPat.Name = "txtBoxFioPat";
            this.txtBoxFioPat.Size = new System.Drawing.Size(109, 19);
            this.txtBoxFioPat.TabIndex = 22;
            this.txtBoxFioPat.Text = " ФИО Пациента";
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
            this.txtBoxMedPat.Location = new System.Drawing.Point(666, 58);
            this.txtBoxMedPat.Name = "txtBoxMedPat";
            this.txtBoxMedPat.Size = new System.Drawing.Size(110, 19);
            this.txtBoxMedPat.TabIndex = 20;
            this.txtBoxMedPat.Text = " Мед.Полис";
            this.txtBoxMedPat.Enter += new System.EventHandler(this.txtBoxMedPat_Enter);
            this.txtBoxMedPat.Leave += new System.EventHandler(this.txtBoxMedPat_Leave);
            // 
            // BtnPatientsEdit
            // 
            this.BtnPatientsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPatientsEdit.FlatAppearance.BorderSize = 0;
            this.BtnPatientsEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnPatientsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatientsEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPatientsEdit.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPatientsEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnPatientsEdit.IconColor = System.Drawing.Color.SandyBrown;
            this.BtnPatientsEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPatientsEdit.IconSize = 25;
            this.BtnPatientsEdit.Location = new System.Drawing.Point(13, 341);
            this.BtnPatientsEdit.Name = "BtnPatientsEdit";
            this.BtnPatientsEdit.Size = new System.Drawing.Size(113, 36);
            this.BtnPatientsEdit.TabIndex = 19;
            this.BtnPatientsEdit.Text = "Изменить";
            this.BtnPatientsEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPatientsEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatientsEdit.UseVisualStyleBackColor = true;
            this.BtnPatientsEdit.Click += new System.EventHandler(this.BtnPatientsEdit_Click);
            // 
            // BtnPatientsDel
            // 
            this.BtnPatientsDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPatientsDel.FlatAppearance.BorderSize = 0;
            this.BtnPatientsDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPatientsDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatientsDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPatientsDel.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPatientsDel.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.BtnPatientsDel.IconColor = System.Drawing.Color.Red;
            this.BtnPatientsDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPatientsDel.IconSize = 25;
            this.BtnPatientsDel.Location = new System.Drawing.Point(132, 341);
            this.BtnPatientsDel.Name = "BtnPatientsDel";
            this.BtnPatientsDel.Size = new System.Drawing.Size(113, 36);
            this.BtnPatientsDel.TabIndex = 18;
            this.BtnPatientsDel.Text = "Удалить";
            this.BtnPatientsDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatientsDel.UseVisualStyleBackColor = true;
            this.BtnPatientsDel.Click += new System.EventHandler(this.BtnPatientsDel_Click);
            // 
            // BtnPatientsAdd
            // 
            this.BtnPatientsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPatientsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.BtnPatientsAdd.FlatAppearance.BorderSize = 0;
            this.BtnPatientsAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.BtnPatientsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatientsAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPatientsAdd.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPatientsAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnPatientsAdd.IconColor = System.Drawing.Color.Green;
            this.BtnPatientsAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPatientsAdd.IconSize = 25;
            this.BtnPatientsAdd.Location = new System.Drawing.Point(666, 229);
            this.BtnPatientsAdd.Name = "BtnPatientsAdd";
            this.BtnPatientsAdd.Size = new System.Drawing.Size(109, 36);
            this.BtnPatientsAdd.TabIndex = 17;
            this.BtnPatientsAdd.Text = "Сохранить";
            this.BtnPatientsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatientsAdd.UseVisualStyleBackColor = false;
            this.BtnPatientsAdd.Click += new System.EventHandler(this.BtnPatientsAdd_Click);
            // 
            // buttonExitPatients
            // 
            this.buttonExitPatients.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonExitPatients.FlatAppearance.BorderSize = 0;
            this.buttonExitPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonExitPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitPatients.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitPatients.ForeColor = System.Drawing.Color.LightGray;
            this.buttonExitPatients.Location = new System.Drawing.Point(2, 3);
            this.buttonExitPatients.Name = "buttonExitPatients";
            this.buttonExitPatients.Size = new System.Drawing.Size(62, 25);
            this.buttonExitPatients.TabIndex = 16;
            this.buttonExitPatients.Text = "Закрыть";
            this.buttonExitPatients.UseVisualStyleBackColor = true;
            this.buttonExitPatients.Click += new System.EventHandler(this.buttonExitPatients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.dataGridView1.Location = new System.Drawing.Point(2, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 301);
            this.dataGridView1.TabIndex = 15;
            // 
            // cmBoxStreets
            // 
            this.cmBoxStreets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxStreets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxStreets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxStreets.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxStreets.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxStreets.FormattingEnabled = true;
            this.cmBoxStreets.Location = new System.Drawing.Point(666, 82);
            this.cmBoxStreets.Name = "cmBoxStreets";
            this.cmBoxStreets.Size = new System.Drawing.Size(109, 25);
            this.cmBoxStreets.TabIndex = 40;
            // 
            // txtNum_house
            // 
            this.txtNum_house.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum_house.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtNum_house.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum_house.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNum_house.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNum_house.Location = new System.Drawing.Point(666, 113);
            this.txtNum_house.Name = "txtNum_house";
            this.txtNum_house.Size = new System.Drawing.Size(109, 19);
            this.txtNum_house.TabIndex = 41;
            this.txtNum_house.Text = " Номер дома";
            this.txtNum_house.Enter += new System.EventHandler(this.txtNum_house_Enter);
            this.txtNum_house.Leave += new System.EventHandler(this.txtNum_house_Leave);
            // 
            // txtNum_kv
            // 
            this.txtNum_kv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum_kv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtNum_kv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum_kv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNum_kv.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNum_kv.Location = new System.Drawing.Point(667, 138);
            this.txtNum_kv.Name = "txtNum_kv";
            this.txtNum_kv.Size = new System.Drawing.Size(109, 19);
            this.txtNum_kv.TabIndex = 42;
            this.txtNum_kv.Text = " Номер квартиры";
            this.txtNum_kv.Enter += new System.EventHandler(this.txtNum_kv_Enter);
            this.txtNum_kv.Leave += new System.EventHandler(this.txtNum_kv_Leave);
            // 
            // customDateTimePicker1
            // 
            this.customDateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customDateTimePicker1.BorderColors = System.Drawing.Color.PaleVioletRed;
            this.customDateTimePicker1.BorderSize = 0;
            this.customDateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Green;
            this.customDateTimePicker1.CustomFormat = "";
            this.customDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.customDateTimePicker1.Location = new System.Drawing.Point(667, 188);
            this.customDateTimePicker1.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDateTimePicker1.Name = "customDateTimePicker1";
            this.customDateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customDateTimePicker1.Size = new System.Drawing.Size(109, 25);
            this.customDateTimePicker1.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.customDateTimePicker1.TabIndex = 43;
            this.customDateTimePicker1.TxtColor = System.Drawing.Color.DarkGray;
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkGray;
            this.labelError.Image = ((System.Drawing.Image)(resources.GetObject("labelError.Image")));
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelError.Location = new System.Drawing.Point(667, 278);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 15);
            this.labelError.TabIndex = 71;
            this.labelError.Text = "label";
            this.labelError.Visible = false;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.SearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchTxt.Location = new System.Drawing.Point(524, 9);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(137, 19);
            this.SearchTxt.TabIndex = 72;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            this.SearchTxt.Enter += new System.EventHandler(this.SearchTxt_Enter);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.Location = new System.Drawing.Point(411, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(120, 17);
            this.Search.TabIndex = 73;
            this.Search.Text = "Поиск пациента:";
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(787, 387);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.customDateTimePicker1);
            this.Controls.Add(this.txtNum_kv);
            this.Controls.Add(this.txtNum_house);
            this.Controls.Add(this.cmBoxStreets);
            this.Controls.Add(this.txtBoxPhonePat);
            this.Controls.Add(this.txtBoxFioPat);
            this.Controls.Add(this.txtBoxMedPat);
            this.Controls.Add(this.BtnPatientsEdit);
            this.Controls.Add(this.BtnPatientsDel);
            this.Controls.Add(this.BtnPatientsAdd);
            this.Controls.Add(this.buttonExitPatients);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxPhonePat;
        private System.Windows.Forms.TextBox txtBoxFioPat;
        private System.Windows.Forms.TextBox txtBoxMedPat;
        private FontAwesome.Sharp.IconButton BtnPatientsEdit;
        private FontAwesome.Sharp.IconButton BtnPatientsDel;
        private FontAwesome.Sharp.IconButton BtnPatientsAdd;
        private System.Windows.Forms.Button buttonExitPatients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmBoxStreets;
        private System.Windows.Forms.TextBox txtNum_house;
        private System.Windows.Forms.TextBox txtNum_kv;
        private CustomDateTimePicker customDateTimePicker1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Label Search;
    }
}