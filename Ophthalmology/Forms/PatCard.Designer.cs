
namespace Ophthalmology.Forms
{
    partial class PatCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatCard));
            this.buttonExitDoctors = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmBoxPatients = new System.Windows.Forms.ComboBox();
            this.cmBoxSymptoms = new System.Windows.Forms.ComboBox();
            this.cmBoxDiagnoses = new System.Windows.Forms.ComboBox();
            this.cmBoxServices = new System.Windows.Forms.ComboBox();
            this.txtBoxTreatment = new System.Windows.Forms.TextBox();
            this.txtBoxComment = new System.Windows.Forms.TextBox();
            this.BtnCardAdd = new FontAwesome.Sharp.IconButton();
            this.BtnCardEdit = new FontAwesome.Sharp.IconButton();
            this.BtnCardDel = new FontAwesome.Sharp.IconButton();
            this.cmBoxDoctors = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.Label();
            this.SearchTxt = new System.Windows.Forms.TextBox();
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
            this.buttonExitDoctors.Location = new System.Drawing.Point(0, -1);
            this.buttonExitDoctors.Name = "buttonExitDoctors";
            this.buttonExitDoctors.Size = new System.Drawing.Size(62, 25);
            this.buttonExitDoctors.TabIndex = 2;
            this.buttonExitDoctors.Text = "Закрыть";
            this.buttonExitDoctors.UseVisualStyleBackColor = true;
            this.buttonExitDoctors.Click += new System.EventHandler(this.buttonExitDoctors_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
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
            this.dataGridView1.Size = new System.Drawing.Size(642, 303);
            this.dataGridView1.TabIndex = 3;
            // 
            // cmBoxPatients
            // 
            this.cmBoxPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxPatients.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxPatients.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxPatients.FormattingEnabled = true;
            this.cmBoxPatients.Location = new System.Drawing.Point(648, 30);
            this.cmBoxPatients.Name = "cmBoxPatients";
            this.cmBoxPatients.Size = new System.Drawing.Size(136, 25);
            this.cmBoxPatients.TabIndex = 40;
            // 
            // cmBoxSymptoms
            // 
            this.cmBoxSymptoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxSymptoms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxSymptoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxSymptoms.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxSymptoms.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxSymptoms.FormattingEnabled = true;
            this.cmBoxSymptoms.Location = new System.Drawing.Point(648, 84);
            this.cmBoxSymptoms.Name = "cmBoxSymptoms";
            this.cmBoxSymptoms.Size = new System.Drawing.Size(136, 25);
            this.cmBoxSymptoms.TabIndex = 41;
            // 
            // cmBoxDiagnoses
            // 
            this.cmBoxDiagnoses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxDiagnoses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxDiagnoses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxDiagnoses.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxDiagnoses.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxDiagnoses.FormattingEnabled = true;
            this.cmBoxDiagnoses.Location = new System.Drawing.Point(648, 114);
            this.cmBoxDiagnoses.Name = "cmBoxDiagnoses";
            this.cmBoxDiagnoses.Size = new System.Drawing.Size(136, 25);
            this.cmBoxDiagnoses.TabIndex = 42;
            // 
            // cmBoxServices
            // 
            this.cmBoxServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxServices.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxServices.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxServices.FormattingEnabled = true;
            this.cmBoxServices.Location = new System.Drawing.Point(648, 145);
            this.cmBoxServices.Name = "cmBoxServices";
            this.cmBoxServices.Size = new System.Drawing.Size(136, 25);
            this.cmBoxServices.TabIndex = 43;
            // 
            // txtBoxTreatment
            // 
            this.txtBoxTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTreatment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxTreatment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTreatment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxTreatment.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxTreatment.Location = new System.Drawing.Point(648, 176);
            this.txtBoxTreatment.Multiline = true;
            this.txtBoxTreatment.Name = "txtBoxTreatment";
            this.txtBoxTreatment.Size = new System.Drawing.Size(136, 65);
            this.txtBoxTreatment.TabIndex = 44;
            this.txtBoxTreatment.Text = " Прописать лечение";
            this.txtBoxTreatment.Enter += new System.EventHandler(this.txtBoxTreatment_Enter);
            this.txtBoxTreatment.Leave += new System.EventHandler(this.txtBoxTreatment_Leave);
            // 
            // txtBoxComment
            // 
            this.txtBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxComment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxComment.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxComment.Location = new System.Drawing.Point(648, 247);
            this.txtBoxComment.Multiline = true;
            this.txtBoxComment.Name = "txtBoxComment";
            this.txtBoxComment.Size = new System.Drawing.Size(136, 68);
            this.txtBoxComment.TabIndex = 45;
            this.txtBoxComment.Text = " Комментарий";
            this.txtBoxComment.Enter += new System.EventHandler(this.txtBoxComment_Enter);
            this.txtBoxComment.Leave += new System.EventHandler(this.txtBoxComment_Leave);
            // 
            // BtnCardAdd
            // 
            this.BtnCardAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCardAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.BtnCardAdd.FlatAppearance.BorderSize = 0;
            this.BtnCardAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.BtnCardAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCardAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCardAdd.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCardAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnCardAdd.IconColor = System.Drawing.Color.Green;
            this.BtnCardAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCardAdd.IconSize = 25;
            this.BtnCardAdd.Location = new System.Drawing.Point(648, 321);
            this.BtnCardAdd.Name = "BtnCardAdd";
            this.BtnCardAdd.Size = new System.Drawing.Size(136, 36);
            this.BtnCardAdd.TabIndex = 46;
            this.BtnCardAdd.Text = "Сохранить";
            this.BtnCardAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCardAdd.UseVisualStyleBackColor = false;
            this.BtnCardAdd.Click += new System.EventHandler(this.BtnCardAdd_Click);
            // 
            // BtnCardEdit
            // 
            this.BtnCardEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCardEdit.FlatAppearance.BorderSize = 0;
            this.BtnCardEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCardEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCardEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCardEdit.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCardEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnCardEdit.IconColor = System.Drawing.Color.SandyBrown;
            this.BtnCardEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCardEdit.IconSize = 25;
            this.BtnCardEdit.Location = new System.Drawing.Point(12, 339);
            this.BtnCardEdit.Name = "BtnCardEdit";
            this.BtnCardEdit.Size = new System.Drawing.Size(113, 36);
            this.BtnCardEdit.TabIndex = 48;
            this.BtnCardEdit.Text = "Изменить";
            this.BtnCardEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCardEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCardEdit.UseVisualStyleBackColor = true;
            this.BtnCardEdit.Click += new System.EventHandler(this.BtnCardEdit_Click);
            // 
            // BtnCardDel
            // 
            this.BtnCardDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCardDel.FlatAppearance.BorderSize = 0;
            this.BtnCardDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCardDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCardDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCardDel.ForeColor = System.Drawing.Color.LightGray;
            this.BtnCardDel.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.BtnCardDel.IconColor = System.Drawing.Color.Red;
            this.BtnCardDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCardDel.IconSize = 25;
            this.BtnCardDel.Location = new System.Drawing.Point(142, 339);
            this.BtnCardDel.Name = "BtnCardDel";
            this.BtnCardDel.Size = new System.Drawing.Size(113, 36);
            this.BtnCardDel.TabIndex = 47;
            this.BtnCardDel.Text = "Удалить";
            this.BtnCardDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCardDel.UseVisualStyleBackColor = true;
            this.BtnCardDel.Click += new System.EventHandler(this.BtnCardDel_Click);
            // 
            // cmBoxDoctors
            // 
            this.cmBoxDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmBoxDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.cmBoxDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmBoxDoctors.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmBoxDoctors.ForeColor = System.Drawing.Color.LightGray;
            this.cmBoxDoctors.FormattingEnabled = true;
            this.cmBoxDoctors.Location = new System.Drawing.Point(648, 57);
            this.cmBoxDoctors.Name = "cmBoxDoctors";
            this.cmBoxDoctors.Size = new System.Drawing.Size(136, 25);
            this.cmBoxDoctors.TabIndex = 49;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.Location = new System.Drawing.Point(382, 7);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(117, 17);
            this.Search.TabIndex = 75;
            this.Search.Text = "Поиск карточки:";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.SearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchTxt.Location = new System.Drawing.Point(505, 5);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(137, 19);
            this.SearchTxt.TabIndex = 74;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // PatCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(787, 387);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.cmBoxDoctors);
            this.Controls.Add(this.BtnCardEdit);
            this.Controls.Add(this.BtnCardDel);
            this.Controls.Add(this.BtnCardAdd);
            this.Controls.Add(this.txtBoxComment);
            this.Controls.Add(this.txtBoxTreatment);
            this.Controls.Add(this.cmBoxServices);
            this.Controls.Add(this.cmBoxDiagnoses);
            this.Controls.Add(this.cmBoxSymptoms);
            this.Controls.Add(this.cmBoxPatients);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExitDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatCard";
            this.Load += new System.EventHandler(this.PatCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitDoctors;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmBoxPatients;
        private System.Windows.Forms.ComboBox cmBoxSymptoms;
        private System.Windows.Forms.ComboBox cmBoxDiagnoses;
        private System.Windows.Forms.ComboBox cmBoxServices;
        private System.Windows.Forms.TextBox txtBoxTreatment;
        private System.Windows.Forms.TextBox txtBoxComment;
        private FontAwesome.Sharp.IconButton BtnCardAdd;
        private FontAwesome.Sharp.IconButton BtnCardEdit;
        private FontAwesome.Sharp.IconButton BtnCardDel;
        private System.Windows.Forms.ComboBox cmBoxDoctors;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchTxt;
    }
}