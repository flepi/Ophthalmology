
namespace Ophthalmology.Forms
{
    partial class Services
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
            this.buttonExitDoctors = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxPhoneDoc = new System.Windows.Forms.TextBox();
            this.txtBoxFioDoc = new System.Windows.Forms.TextBox();
            this.txtBoxPositionDoc = new System.Windows.Forms.TextBox();
            this.txtBoxCabDoc = new System.Windows.Forms.TextBox();
            this.BtnDoctorsEdit = new FontAwesome.Sharp.IconButton();
            this.BtnDoctorsDel = new FontAwesome.Sharp.IconButton();
            this.BtnDoctorsAdd = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExitDoctors
            // 
            this.buttonExitDoctors.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonExitDoctors.FlatAppearance.BorderSize = 0;
            this.buttonExitDoctors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.buttonExitDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitDoctors.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitDoctors.ForeColor = System.Drawing.Color.LightGray;
            this.buttonExitDoctors.Location = new System.Drawing.Point(2, 1);
            this.buttonExitDoctors.Name = "buttonExitDoctors";
            this.buttonExitDoctors.Size = new System.Drawing.Size(62, 25);
            this.buttonExitDoctors.TabIndex = 2;
            this.buttonExitDoctors.Text = "Закрыть";
            this.buttonExitDoctors.UseVisualStyleBackColor = true;
            this.buttonExitDoctors.Click += new System.EventHandler(this.buttonExitDoctors_Click);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 23);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // txtBoxPhoneDoc
            // 
            this.txtBoxPhoneDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPhoneDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxPhoneDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPhoneDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPhoneDoc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxPhoneDoc.Location = new System.Drawing.Point(648, 108);
            this.txtBoxPhoneDoc.Name = "txtBoxPhoneDoc";
            this.txtBoxPhoneDoc.Size = new System.Drawing.Size(127, 19);
            this.txtBoxPhoneDoc.TabIndex = 22;
            this.txtBoxPhoneDoc.Text = " Телефон";
            // 
            // txtBoxFioDoc
            // 
            this.txtBoxFioDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFioDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxFioDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxFioDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxFioDoc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxFioDoc.Location = new System.Drawing.Point(648, 32);
            this.txtBoxFioDoc.Name = "txtBoxFioDoc";
            this.txtBoxFioDoc.Size = new System.Drawing.Size(127, 19);
            this.txtBoxFioDoc.TabIndex = 21;
            this.txtBoxFioDoc.Text = " ФИО Доктора";
            // 
            // txtBoxPositionDoc
            // 
            this.txtBoxPositionDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPositionDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxPositionDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPositionDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPositionDoc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxPositionDoc.Location = new System.Drawing.Point(648, 58);
            this.txtBoxPositionDoc.Name = "txtBoxPositionDoc";
            this.txtBoxPositionDoc.Size = new System.Drawing.Size(127, 19);
            this.txtBoxPositionDoc.TabIndex = 20;
            this.txtBoxPositionDoc.Text = " Должность";
            // 
            // txtBoxCabDoc
            // 
            this.txtBoxCabDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCabDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxCabDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCabDoc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxCabDoc.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxCabDoc.Location = new System.Drawing.Point(648, 84);
            this.txtBoxCabDoc.Name = "txtBoxCabDoc";
            this.txtBoxCabDoc.Size = new System.Drawing.Size(127, 19);
            this.txtBoxCabDoc.TabIndex = 19;
            this.txtBoxCabDoc.Text = " Кабинет";
            // 
            // BtnDoctorsEdit
            // 
            this.BtnDoctorsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDoctorsEdit.FlatAppearance.BorderSize = 0;
            this.BtnDoctorsEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnDoctorsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoctorsEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDoctorsEdit.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDoctorsEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnDoctorsEdit.IconColor = System.Drawing.Color.SandyBrown;
            this.BtnDoctorsEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDoctorsEdit.IconSize = 25;
            this.BtnDoctorsEdit.Location = new System.Drawing.Point(12, 339);
            this.BtnDoctorsEdit.Name = "BtnDoctorsEdit";
            this.BtnDoctorsEdit.Size = new System.Drawing.Size(113, 36);
            this.BtnDoctorsEdit.TabIndex = 18;
            this.BtnDoctorsEdit.Text = "Изменить";
            this.BtnDoctorsEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDoctorsEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDoctorsEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDoctorsDel
            // 
            this.BtnDoctorsDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDoctorsDel.FlatAppearance.BorderSize = 0;
            this.BtnDoctorsDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDoctorsDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoctorsDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDoctorsDel.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDoctorsDel.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.BtnDoctorsDel.IconColor = System.Drawing.Color.Red;
            this.BtnDoctorsDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDoctorsDel.IconSize = 25;
            this.BtnDoctorsDel.Location = new System.Drawing.Point(131, 339);
            this.BtnDoctorsDel.Name = "BtnDoctorsDel";
            this.BtnDoctorsDel.Size = new System.Drawing.Size(113, 36);
            this.BtnDoctorsDel.TabIndex = 17;
            this.BtnDoctorsDel.Text = "Удалить";
            this.BtnDoctorsDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDoctorsDel.UseVisualStyleBackColor = true;
            // 
            // BtnDoctorsAdd
            // 
            this.BtnDoctorsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDoctorsAdd.FlatAppearance.BorderSize = 0;
            this.BtnDoctorsAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.BtnDoctorsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoctorsAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDoctorsAdd.ForeColor = System.Drawing.Color.LightGray;
            this.BtnDoctorsAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnDoctorsAdd.IconColor = System.Drawing.Color.Green;
            this.BtnDoctorsAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDoctorsAdd.IconSize = 25;
            this.BtnDoctorsAdd.Location = new System.Drawing.Point(648, 176);
            this.BtnDoctorsAdd.Name = "BtnDoctorsAdd";
            this.BtnDoctorsAdd.Size = new System.Drawing.Size(127, 36);
            this.BtnDoctorsAdd.TabIndex = 16;
            this.BtnDoctorsAdd.Text = "Сохранить";
            this.BtnDoctorsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDoctorsAdd.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(621, 266);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Выберите категорию:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.LightGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 25);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(787, 387);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBoxPhoneDoc);
            this.Controls.Add(this.txtBoxFioDoc);
            this.Controls.Add(this.txtBoxPositionDoc);
            this.Controls.Add(this.txtBoxCabDoc);
            this.Controls.Add(this.BtnDoctorsEdit);
            this.Controls.Add(this.BtnDoctorsDel);
            this.Controls.Add(this.BtnDoctorsAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExitDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitDoctors;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxPhoneDoc;
        private System.Windows.Forms.TextBox txtBoxFioDoc;
        private System.Windows.Forms.TextBox txtBoxPositionDoc;
        private System.Windows.Forms.TextBox txtBoxCabDoc;
        private FontAwesome.Sharp.IconButton BtnDoctorsEdit;
        private FontAwesome.Sharp.IconButton BtnDoctorsDel;
        private FontAwesome.Sharp.IconButton BtnDoctorsAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}