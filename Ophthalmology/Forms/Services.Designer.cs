
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.buttonExitDoctors = new System.Windows.Forms.Button();
            this.txtBoxService = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.BtnServicesEdit = new FontAwesome.Sharp.IconButton();
            this.BtnServicesDel = new FontAwesome.Sharp.IconButton();
            this.BtnServicesAdd = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxDoc = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
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
            this.buttonExitDoctors.Location = new System.Drawing.Point(2, 1);
            this.buttonExitDoctors.Name = "buttonExitDoctors";
            this.buttonExitDoctors.Size = new System.Drawing.Size(62, 25);
            this.buttonExitDoctors.TabIndex = 2;
            this.buttonExitDoctors.Text = "Закрыть";
            this.buttonExitDoctors.UseVisualStyleBackColor = true;
            this.buttonExitDoctors.Click += new System.EventHandler(this.buttonExitDoctors_Click);
            // 
            // txtBoxService
            // 
            this.txtBoxService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxService.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxService.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxService.Location = new System.Drawing.Point(629, 46);
            this.txtBoxService.Name = "txtBoxService";
            this.txtBoxService.Size = new System.Drawing.Size(146, 19);
            this.txtBoxService.TabIndex = 21;
            this.txtBoxService.Text = " Услуга";
            this.txtBoxService.Enter += new System.EventHandler(this.txtBoxService_Enter);
            this.txtBoxService.Leave += new System.EventHandler(this.txtBoxService_Leave);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.txtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxPrice.Location = new System.Drawing.Point(629, 72);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(146, 19);
            this.txtBoxPrice.TabIndex = 20;
            this.txtBoxPrice.Text = " Стоимость";
            this.txtBoxPrice.Enter += new System.EventHandler(this.txtBoxPrice_Enter);
            this.txtBoxPrice.Leave += new System.EventHandler(this.txtBoxPrice_Leave);
            // 
            // BtnServicesEdit
            // 
            this.BtnServicesEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnServicesEdit.FlatAppearance.BorderSize = 0;
            this.BtnServicesEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnServicesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicesEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnServicesEdit.ForeColor = System.Drawing.Color.LightGray;
            this.BtnServicesEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.BtnServicesEdit.IconColor = System.Drawing.Color.SandyBrown;
            this.BtnServicesEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnServicesEdit.IconSize = 25;
            this.BtnServicesEdit.Location = new System.Drawing.Point(22, 339);
            this.BtnServicesEdit.Name = "BtnServicesEdit";
            this.BtnServicesEdit.Size = new System.Drawing.Size(113, 36);
            this.BtnServicesEdit.TabIndex = 18;
            this.BtnServicesEdit.Text = "Изменить";
            this.BtnServicesEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServicesEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServicesEdit.UseVisualStyleBackColor = true;
            this.BtnServicesEdit.Click += new System.EventHandler(this.BtnServicesEdit_Click);
            // 
            // BtnServicesDel
            // 
            this.BtnServicesDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnServicesDel.FlatAppearance.BorderSize = 0;
            this.BtnServicesDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnServicesDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicesDel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnServicesDel.ForeColor = System.Drawing.Color.LightGray;
            this.BtnServicesDel.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.BtnServicesDel.IconColor = System.Drawing.Color.Red;
            this.BtnServicesDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnServicesDel.IconSize = 25;
            this.BtnServicesDel.Location = new System.Drawing.Point(151, 339);
            this.BtnServicesDel.Name = "BtnServicesDel";
            this.BtnServicesDel.Size = new System.Drawing.Size(113, 36);
            this.BtnServicesDel.TabIndex = 17;
            this.BtnServicesDel.Text = "Удалить";
            this.BtnServicesDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServicesDel.UseVisualStyleBackColor = true;
            this.BtnServicesDel.Click += new System.EventHandler(this.BtnServicesDel_Click);
            // 
            // BtnServicesAdd
            // 
            this.BtnServicesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnServicesAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.BtnServicesAdd.FlatAppearance.BorderSize = 0;
            this.BtnServicesAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(71)))), ((int)(((byte)(26)))));
            this.BtnServicesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicesAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnServicesAdd.ForeColor = System.Drawing.Color.LightGray;
            this.BtnServicesAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnServicesAdd.IconColor = System.Drawing.Color.Green;
            this.BtnServicesAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnServicesAdd.IconSize = 25;
            this.BtnServicesAdd.Location = new System.Drawing.Point(629, 138);
            this.BtnServicesAdd.Name = "BtnServicesAdd";
            this.BtnServicesAdd.Size = new System.Drawing.Size(146, 36);
            this.BtnServicesAdd.TabIndex = 16;
            this.BtnServicesAdd.Text = "Сохранить";
            this.BtnServicesAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServicesAdd.UseVisualStyleBackColor = false;
            this.BtnServicesAdd.Click += new System.EventHandler(this.BtnServicesAdd_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(129)))));
            this.dataGridView1.Location = new System.Drawing.Point(22, 46);
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
            this.dataGridView1.Size = new System.Drawing.Size(601, 266);
            this.dataGridView1.TabIndex = 15;
            // 
            // comboBoxDoc
            // 
            this.comboBoxDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.comboBoxDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDoc.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxDoc.FormattingEnabled = true;
            this.comboBoxDoc.Location = new System.Drawing.Point(629, 97);
            this.comboBoxDoc.Name = "comboBoxDoc";
            this.comboBoxDoc.Size = new System.Drawing.Size(146, 25);
            this.comboBoxDoc.TabIndex = 25;
            this.comboBoxDoc.Text = " Выполняет врач:";
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkGray;
            this.labelError.Image = ((System.Drawing.Image)(resources.GetObject("labelError.Image")));
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelError.Location = new System.Drawing.Point(629, 177);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 15);
            this.labelError.TabIndex = 71;
            this.labelError.Text = "label";
            this.labelError.Visible = false;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.DarkGray;
            this.Search.Location = new System.Drawing.Point(385, 7);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(97, 17);
            this.Search.TabIndex = 77;
            this.Search.Text = "Поиск услуги:";
            // 
            // SearchTxt
            // 
            this.SearchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            this.SearchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTxt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchTxt.Location = new System.Drawing.Point(486, 7);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(137, 19);
            this.SearchTxt.TabIndex = 76;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchTxt_TextChanged);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(787, 387);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxDoc);
            this.Controls.Add(this.txtBoxService);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.BtnServicesEdit);
            this.Controls.Add(this.BtnServicesDel);
            this.Controls.Add(this.BtnServicesAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExitDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtBoxService;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private FontAwesome.Sharp.IconButton BtnServicesEdit;
        private FontAwesome.Sharp.IconButton BtnServicesDel;
        private FontAwesome.Sharp.IconButton BtnServicesAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxDoc;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox SearchTxt;
    }
}