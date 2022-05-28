
namespace Ophthalmology.Forms
{
    partial class ListRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRegistration));
            this.buttonExitDoctors = new System.Windows.Forms.Button();
            this.cmBoxDoctors = new System.Windows.Forms.ComboBox();
            this.cmBoxPosition = new System.Windows.Forms.ComboBox();
            this.BtnRegAdd = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnRegEdit = new FontAwesome.Sharp.IconButton();
            this.BtnRegDel = new FontAwesome.Sharp.IconButton();
            this.customDtPickerReg = new Ophthalmology.CustomDateTimePicker();
            this.labelError = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.cmBoxPat = new System.Windows.Forms.ComboBox();
            this.txtBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.buttonExitDoctors.Location = new System.Drawing.Point(3, 2);
            this.buttonExitDoctors.Name = "buttonExitDoctors";
            this.buttonExitDoctors.Size = new System.Drawing.Size(62, 25);
            this.buttonExitDoctors.TabIndex = 2;
            this.buttonExitDoctors.Text = "Закрыть";
            this.buttonExitDoctors.UseVisualStyleBackColor = true;
            this.buttonExitDoctors.Click += new System.EventHandler(this.buttonExitDoctors_Click);
            // 
            // cmBoxDoctors
            // 
            this.cmBoxDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxDoctors.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxDoctors.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxDoctors.FormattingEnabled = true;
            this.cmBoxDoctors.Location = new System.Drawing.Point(630, 92);
            this.cmBoxDoctors.Name = "cmBoxDoctors";
            this.cmBoxDoctors.Size = new System.Drawing.Size(153, 25);
            this.cmBoxDoctors.TabIndex = 62;
            this.cmBoxDoctors.Text = "Выбрать врача";
            // 
            // cmBoxPosition
            // 
            this.cmBoxPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxPosition.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxPosition.FormattingEnabled = true;
            this.cmBoxPosition.Location = new System.Drawing.Point(630, 61);
            this.cmBoxPosition.Name = "cmBoxPosition";
            this.cmBoxPosition.Size = new System.Drawing.Size(153, 25);
            this.cmBoxPosition.TabIndex = 61;
            this.cmBoxPosition.Text = "Выбрать специальность";
            // 
            // BtnRegAdd
            // 
            this.BtnRegAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.BtnRegAdd.FlatAppearance.BorderSize = 0;
            this.BtnRegAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.BtnRegAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRegAdd.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRegAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnRegAdd.IconColor = System.Drawing.Color.Green;
            this.BtnRegAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegAdd.IconSize = 25;
            this.BtnRegAdd.Location = new System.Drawing.Point(630, 179);
            this.BtnRegAdd.Name = "BtnRegAdd";
            this.BtnRegAdd.Size = new System.Drawing.Size(153, 36);
            this.BtnRegAdd.TabIndex = 66;
            this.BtnRegAdd.Text = "Сохранить";
            this.BtnRegAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegAdd.UseVisualStyleBackColor = false;
            this.BtnRegAdd.Click += new System.EventHandler(this.BtnRegAdd_Click);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(621, 303);
            this.dataGridView1.TabIndex = 67;
            // 
            // BtnRegEdit
            // 
            this.BtnRegEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRegEdit.FlatAppearance.BorderSize = 0;
            this.BtnRegEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRegEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRegEdit.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRegEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnRegEdit.IconColor = System.Drawing.Color.SandyBrown;
            this.BtnRegEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegEdit.IconSize = 25;
            this.BtnRegEdit.Location = new System.Drawing.Point(12, 339);
            this.BtnRegEdit.Name = "BtnRegEdit";
            this.BtnRegEdit.Size = new System.Drawing.Size(113, 36);
            this.BtnRegEdit.TabIndex = 69;
            this.BtnRegEdit.Text = "Изменить";
            this.BtnRegEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegEdit.UseVisualStyleBackColor = true;
            this.BtnRegEdit.Click += new System.EventHandler(this.BtnRegEdit_Click);
            // 
            // BtnRegDel
            // 
            this.BtnRegDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRegDel.FlatAppearance.BorderSize = 0;
            this.BtnRegDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRegDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnRegDel.ForeColor = System.Drawing.Color.LightGray;
            this.BtnRegDel.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.BtnRegDel.IconColor = System.Drawing.Color.Red;
            this.BtnRegDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegDel.IconSize = 25;
            this.BtnRegDel.Location = new System.Drawing.Point(131, 339);
            this.BtnRegDel.Name = "BtnRegDel";
            this.BtnRegDel.Size = new System.Drawing.Size(113, 36);
            this.BtnRegDel.TabIndex = 68;
            this.BtnRegDel.Text = "Удалить";
            this.BtnRegDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegDel.UseVisualStyleBackColor = true;
            this.BtnRegDel.Click += new System.EventHandler(this.BtnRegDel_Click);
            // 
            // customDtPickerReg
            // 
            this.customDtPickerReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customDtPickerReg.BorderColors = System.Drawing.Color.PaleVioletRed;
            this.customDtPickerReg.BorderSize = 0;
            this.customDtPickerReg.CalendarTitleForeColor = System.Drawing.Color.Green;
            this.customDtPickerReg.CustomFormat = "";
            this.customDtPickerReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customDtPickerReg.Location = new System.Drawing.Point(670, 121);
            this.customDtPickerReg.MinimumSize = new System.Drawing.Size(4, 25);
            this.customDtPickerReg.Name = "customDtPickerReg";
            this.customDtPickerReg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customDtPickerReg.Size = new System.Drawing.Size(113, 25);
            this.customDtPickerReg.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.customDtPickerReg.TabIndex = 65;
            this.customDtPickerReg.TxtColor = System.Drawing.Color.DarkGray;
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkGray;
            this.labelError.Image = ((System.Drawing.Image)(resources.GetObject("labelError.Image")));
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelError.Location = new System.Drawing.Point(630, 218);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 15);
            this.labelError.TabIndex = 70;
            this.labelError.Text = "label";
            this.labelError.Visible = false;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.Location = new System.Drawing.Point(352, 6);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(104, 17);
            this.Search.TabIndex = 75;
            this.Search.Text = "Поиск записи:";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.SearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchTxt.Location = new System.Drawing.Point(464, 6);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(137, 19);
            this.SearchTxt.TabIndex = 74;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // cmBoxPat
            // 
            this.cmBoxPat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxPat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxPat.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxPat.FormattingEnabled = true;
            this.cmBoxPat.Location = new System.Drawing.Point(630, 30);
            this.cmBoxPat.Name = "cmBoxPat";
            this.cmBoxPat.Size = new System.Drawing.Size(153, 25);
            this.cmBoxPat.TabIndex = 76;
            this.cmBoxPat.Text = "Выбрать пациента:";
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxTime.BeepOnError = true;
            this.txtBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxTime.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxTime.Location = new System.Drawing.Point(670, 156);
            this.txtBoxTime.Mask = "00:00";
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(113, 20);
            this.txtBoxTime.TabIndex = 77;
            this.txtBoxTime.Text = "1300";
            this.txtBoxTime.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(629, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "День:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(629, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Время:";
            // 
            // ListRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(787, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxTime);
            this.Controls.Add(this.cmBoxPat);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.BtnRegEdit);
            this.Controls.Add(this.BtnRegDel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnRegAdd);
            this.Controls.Add(this.customDtPickerReg);
            this.Controls.Add(this.cmBoxDoctors);
            this.Controls.Add(this.cmBoxPosition);
            this.Controls.Add(this.buttonExitDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListRegistration";
            this.Load += new System.EventHandler(this.ListRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitDoctors;
        private CustomDateTimePicker customDtPickerReg;
        private System.Windows.Forms.ComboBox cmBoxDoctors;
        private System.Windows.Forms.ComboBox cmBoxPosition;
        private FontAwesome.Sharp.IconButton BtnRegAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton BtnRegEdit;
        private FontAwesome.Sharp.IconButton BtnRegDel;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.ComboBox cmBoxPat;
        private System.Windows.Forms.MaskedTextBox txtBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}