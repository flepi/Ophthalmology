
namespace Ophthalmology
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelPass = new System.Windows.Forms.LinkLabel();
            this.iconBtnMaxLogin = new FontAwesome.Sharp.IconButton();
            this.iconBtnMinLogin = new FontAwesome.Sharp.IconButton();
            this.iconbtnExitLogin = new FontAwesome.Sharp.IconButton();
            this.labelError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.pictureBoxLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.Location = new System.Drawing.Point(34, 46);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(186, 202);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 0;
            this.pictureBoxLogin.TabStop = false;
            this.pictureBoxLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLogin_MouseDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 310;
            this.lineShape2.X2 = 717;
            this.lineShape2.Y1 = 182;
            this.lineShape2.Y2 = 182;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 310;
            this.lineShape1.X2 = 717;
            this.lineShape1.Y1 = 110;
            this.lineShape1.Y2 = 110;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLogin.BackColor = System.Drawing.Color.Black;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxLogin.Location = new System.Drawing.Point(310, 85);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(408, 20);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.Text = "Имя пользователя";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPass.BackColor = System.Drawing.Color.Black;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPass.Location = new System.Drawing.Point(310, 156);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(408, 20);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.Text = "Пароль";
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.DimGray;
            this.labelLogin.Location = new System.Drawing.Point(406, 4);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(186, 33);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Авторизация";
            this.labelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLogin_MouseDown);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.LightGray;
            this.buttonLogin.Location = new System.Drawing.Point(310, 239);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(408, 40);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabelPass
            // 
            this.linkLabelPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.linkLabelPass.AutoSize = true;
            this.linkLabelPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelPass.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabelPass.Location = new System.Drawing.Point(307, 282);
            this.linkLabelPass.Name = "linkLabelPass";
            this.linkLabelPass.Size = new System.Drawing.Size(118, 17);
            this.linkLabelPass.TabIndex = 0;
            this.linkLabelPass.TabStop = true;
            this.linkLabelPass.Text = "Забыли пароль?";
            // 
            // iconBtnMaxLogin
            // 
            this.iconBtnMaxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMaxLogin.FlatAppearance.BorderSize = 0;
            this.iconBtnMaxLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconBtnMaxLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMaxLogin.ForeColor = System.Drawing.Color.White;
            this.iconBtnMaxLogin.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconBtnMaxLogin.IconColor = System.Drawing.Color.White;
            this.iconBtnMaxLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMaxLogin.IconSize = 15;
            this.iconBtnMaxLogin.Location = new System.Drawing.Point(711, 3);
            this.iconBtnMaxLogin.Name = "iconBtnMaxLogin";
            this.iconBtnMaxLogin.Size = new System.Drawing.Size(34, 16);
            this.iconBtnMaxLogin.TabIndex = 7;
            this.iconBtnMaxLogin.UseVisualStyleBackColor = true;
            this.iconBtnMaxLogin.Click += new System.EventHandler(this.iconBtnMaxLogin_Click);
            // 
            // iconBtnMinLogin
            // 
            this.iconBtnMinLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtnMinLogin.FlatAppearance.BorderSize = 0;
            this.iconBtnMinLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconBtnMinLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMinLogin.ForeColor = System.Drawing.Color.White;
            this.iconBtnMinLogin.IconChar = FontAwesome.Sharp.IconChar.MinusSquare;
            this.iconBtnMinLogin.IconColor = System.Drawing.Color.White;
            this.iconBtnMinLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMinLogin.IconSize = 15;
            this.iconBtnMinLogin.Location = new System.Drawing.Point(677, 3);
            this.iconBtnMinLogin.Name = "iconBtnMinLogin";
            this.iconBtnMinLogin.Size = new System.Drawing.Size(34, 16);
            this.iconBtnMinLogin.TabIndex = 9;
            this.iconBtnMinLogin.UseVisualStyleBackColor = true;
            this.iconBtnMinLogin.Click += new System.EventHandler(this.iconBtnMinLogin_Click);
            // 
            // iconbtnExitLogin
            // 
            this.iconbtnExitLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnExitLogin.BackColor = System.Drawing.Color.Black;
            this.iconbtnExitLogin.FlatAppearance.BorderSize = 0;
            this.iconbtnExitLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.iconbtnExitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnExitLogin.ForeColor = System.Drawing.Color.White;
            this.iconbtnExitLogin.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconbtnExitLogin.IconColor = System.Drawing.Color.White;
            this.iconbtnExitLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnExitLogin.IconSize = 15;
            this.iconbtnExitLogin.Location = new System.Drawing.Point(746, 3);
            this.iconbtnExitLogin.Name = "iconbtnExitLogin";
            this.iconbtnExitLogin.Size = new System.Drawing.Size(34, 16);
            this.iconbtnExitLogin.TabIndex = 8;
            this.iconbtnExitLogin.UseVisualStyleBackColor = false;
            this.iconbtnExitLogin.Click += new System.EventHandler(this.iconbtnExitLogin_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkGray;
            this.labelError.Image = ((System.Drawing.Image)(resources.GetObject("labelError.Image")));
            this.labelError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelError.Location = new System.Drawing.Point(310, 193);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(34, 15);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "label";
            this.labelError.Visible = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.iconBtnMaxLogin);
            this.Controls.Add(this.iconBtnMinLogin);
            this.Controls.Add(this.iconbtnExitLogin);
            this.Controls.Add(this.linkLabelPass);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Authorization_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelPass;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private FontAwesome.Sharp.IconButton iconBtnMaxLogin;
        private FontAwesome.Sharp.IconButton iconBtnMinLogin;
        private FontAwesome.Sharp.IconButton iconbtnExitLogin;
        private System.Windows.Forms.Label labelError;
    }
}