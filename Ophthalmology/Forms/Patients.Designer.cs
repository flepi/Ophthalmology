
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPhonePat = new System.Windows.Forms.TextBox();
            this.txtBoxFioPat = new System.Windows.Forms.TextBox();
            this.txtBoxAddressPat = new System.Windows.Forms.TextBox();
            this.txtBoxMedPat = new System.Windows.Forms.TextBox();
            this.BtnPatientsEdit = new FontAwesome.Sharp.IconButton();
            this.BtnPatientsDel = new FontAwesome.Sharp.IconButton();
            this.BtnPatientsAdd = new FontAwesome.Sharp.IconButton();
            this.buttonExitPatients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxGenderPat = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(667, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 23);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // txtBoxPhonePat
            // 
            this.txtBoxPhonePat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPhonePat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxPhonePat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPhonePat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPhonePat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxPhonePat.Location = new System.Drawing.Point(667, 113);
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
            // txtBoxAddressPat
            // 
            this.txtBoxAddressPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAddressPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxAddressPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddressPat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxAddressPat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxAddressPat.Location = new System.Drawing.Point(667, 61);
            this.txtBoxAddressPat.Name = "txtBoxAddressPat";
            this.txtBoxAddressPat.Size = new System.Drawing.Size(109, 19);
            this.txtBoxAddressPat.TabIndex = 21;
            this.txtBoxAddressPat.Text = " Адрес";
            this.txtBoxAddressPat.Enter += new System.EventHandler(this.txtBoxAddressPat_Enter);
            this.txtBoxAddressPat.Leave += new System.EventHandler(this.txtBoxAddressPat_Leave);
            // 
            // txtBoxMedPat
            // 
            this.txtBoxMedPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMedPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxMedPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMedPat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxMedPat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxMedPat.Location = new System.Drawing.Point(667, 87);
            this.txtBoxMedPat.Name = "txtBoxMedPat";
            this.txtBoxMedPat.Size = new System.Drawing.Size(109, 19);
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
            this.BtnPatientsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPatientsAdd.FlatAppearance.BorderSize = 0;
            this.BtnPatientsAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.BtnPatientsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPatientsAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPatientsAdd.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPatientsAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnPatientsAdd.IconColor = System.Drawing.Color.Green;
            this.BtnPatientsAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPatientsAdd.IconSize = 25;
            this.BtnPatientsAdd.Location = new System.Drawing.Point(667, 213);
            this.BtnPatientsAdd.Name = "BtnPatientsAdd";
            this.BtnPatientsAdd.Size = new System.Drawing.Size(109, 36);
            this.BtnPatientsAdd.TabIndex = 17;
            this.BtnPatientsAdd.Text = "Сохранить";
            this.BtnPatientsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPatientsAdd.UseVisualStyleBackColor = true;
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
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
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
            // txtBoxGenderPat
            // 
            this.txtBoxGenderPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxGenderPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxGenderPat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxGenderPat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxGenderPat.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxGenderPat.Location = new System.Drawing.Point(667, 139);
            this.txtBoxGenderPat.Name = "txtBoxGenderPat";
            this.txtBoxGenderPat.Size = new System.Drawing.Size(38, 19);
            this.txtBoxGenderPat.TabIndex = 25;
            this.txtBoxGenderPat.Text = " Пол";
            this.txtBoxGenderPat.Enter += new System.EventHandler(this.txtBoxGenderPat_Enter);
            this.txtBoxGenderPat.Leave += new System.EventHandler(this.txtBoxGenderPat_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBox1.Location = new System.Drawing.Point(711, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 21);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "М";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.checkBox2.Location = new System.Drawing.Point(736, 139);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(39, 21);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "Ж";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(787, 387);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtBoxGenderPat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBoxPhonePat);
            this.Controls.Add(this.txtBoxFioPat);
            this.Controls.Add(this.txtBoxAddressPat);
            this.Controls.Add(this.txtBoxMedPat);
            this.Controls.Add(this.BtnPatientsEdit);
            this.Controls.Add(this.BtnPatientsDel);
            this.Controls.Add(this.BtnPatientsAdd);
            this.Controls.Add(this.buttonExitPatients);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxPhonePat;
        private System.Windows.Forms.TextBox txtBoxFioPat;
        private System.Windows.Forms.TextBox txtBoxAddressPat;
        private System.Windows.Forms.TextBox txtBoxMedPat;
        private FontAwesome.Sharp.IconButton BtnPatientsEdit;
        private FontAwesome.Sharp.IconButton BtnPatientsDel;
        private FontAwesome.Sharp.IconButton BtnPatientsAdd;
        private System.Windows.Forms.Button buttonExitPatients;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxGenderPat;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}