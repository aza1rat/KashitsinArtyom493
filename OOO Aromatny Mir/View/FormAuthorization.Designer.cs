namespace OOO_Aromatny_Mir
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.TablePanelTempUpper = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.LabelTempNameForm = new System.Windows.Forms.Label();
            this.ButtonAuthExit = new System.Windows.Forms.Button();
            this.TablePanelTempDown = new System.Windows.Forms.TableLayoutPanel();
            this.TablePanelAuthMain = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxLogin = new System.Windows.Forms.TextBox();
            this.TablePanelAuthCtrlBut = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonGuestLogin = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.TablePanelAuthCaptcha = new System.Windows.Forms.TableLayoutPanel();
            this.PictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.TextBoxCaptcha = new System.Windows.Forms.TextBox();
            this.TimerCaptha = new System.Windows.Forms.Timer(this.components);
            this.TablePanelTempUpper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.TablePanelAuthMain.SuspendLayout();
            this.TablePanelAuthCtrlBut.SuspendLayout();
            this.TablePanelAuthCaptcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // TablePanelTempUpper
            // 
            this.TablePanelTempUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.TablePanelTempUpper.ColumnCount = 3;
            this.TablePanelTempUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.TablePanelTempUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.875F));
            this.TablePanelTempUpper.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.125F));
            this.TablePanelTempUpper.Controls.Add(this.PictureBoxLogo, 0, 0);
            this.TablePanelTempUpper.Controls.Add(this.LabelTempNameForm, 1, 0);
            this.TablePanelTempUpper.Controls.Add(this.ButtonAuthExit, 2, 0);
            this.TablePanelTempUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.TablePanelTempUpper.Location = new System.Drawing.Point(0, 0);
            this.TablePanelTempUpper.Name = "TablePanelTempUpper";
            this.TablePanelTempUpper.RowCount = 1;
            this.TablePanelTempUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelTempUpper.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TablePanelTempUpper.Size = new System.Drawing.Size(486, 49);
            this.TablePanelTempUpper.TabIndex = 0;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxLogo.Image = global::OOO_Aromatny_Mir.Properties.Resources.logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxLogo.MaximumSize = new System.Drawing.Size(42, 43);
            this.PictureBoxLogo.MinimumSize = new System.Drawing.Size(42, 43);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(42, 43);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxLogo.TabIndex = 0;
            this.PictureBoxLogo.TabStop = false;
            // 
            // LabelTempNameForm
            // 
            this.LabelTempNameForm.AutoSize = true;
            this.LabelTempNameForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTempNameForm.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTempNameForm.Location = new System.Drawing.Point(32, 0);
            this.LabelTempNameForm.Name = "LabelTempNameForm";
            this.LabelTempNameForm.Size = new System.Drawing.Size(357, 49);
            this.LabelTempNameForm.TabIndex = 1;
            this.LabelTempNameForm.Text = "Авторизация";
            this.LabelTempNameForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAuthExit
            // 
            this.ButtonAuthExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAuthExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAuthExit.Location = new System.Drawing.Point(395, 3);
            this.ButtonAuthExit.Name = "ButtonAuthExit";
            this.ButtonAuthExit.Size = new System.Drawing.Size(88, 43);
            this.ButtonAuthExit.TabIndex = 2;
            this.ButtonAuthExit.Text = "Выход";
            this.ButtonAuthExit.UseVisualStyleBackColor = true;
            this.ButtonAuthExit.Click += new System.EventHandler(this.ButtonAuthExit_Click);
            // 
            // TablePanelTempDown
            // 
            this.TablePanelTempDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.TablePanelTempDown.ColumnCount = 1;
            this.TablePanelTempDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelTempDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanelTempDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TablePanelTempDown.Location = new System.Drawing.Point(0, 389);
            this.TablePanelTempDown.Name = "TablePanelTempDown";
            this.TablePanelTempDown.RowCount = 1;
            this.TablePanelTempDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelTempDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TablePanelTempDown.Size = new System.Drawing.Size(486, 40);
            this.TablePanelTempDown.TabIndex = 1;
            // 
            // TablePanelAuthMain
            // 
            this.TablePanelAuthMain.ColumnCount = 2;
            this.TablePanelAuthMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablePanelAuthMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablePanelAuthMain.Controls.Add(this.TextBoxPassword, 1, 1);
            this.TablePanelAuthMain.Controls.Add(this.LabelLogin, 0, 0);
            this.TablePanelAuthMain.Controls.Add(this.LabelPassword, 0, 1);
            this.TablePanelAuthMain.Controls.Add(this.TextBoxLogin, 1, 0);
            this.TablePanelAuthMain.Controls.Add(this.TablePanelAuthCtrlBut, 1, 2);
            this.TablePanelAuthMain.Controls.Add(this.TablePanelAuthCaptcha, 0, 2);
            this.TablePanelAuthMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelAuthMain.Location = new System.Drawing.Point(0, 49);
            this.TablePanelAuthMain.Name = "TablePanelAuthMain";
            this.TablePanelAuthMain.RowCount = 3;
            this.TablePanelAuthMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelAuthMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelAuthMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TablePanelAuthMain.Size = new System.Drawing.Size(486, 340);
            this.TablePanelAuthMain.TabIndex = 2;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TextBoxPassword.Location = new System.Drawing.Point(246, 116);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(237, 30);
            this.TextBoxPassword.TabIndex = 5;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(3, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(237, 113);
            this.LabelLogin.TabIndex = 2;
            this.LabelLogin.Text = "Логин:";
            this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.LabelPassword.Location = new System.Drawing.Point(3, 113);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(237, 113);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Пароль:";
            this.LabelPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TextBoxLogin
            // 
            this.TextBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TextBoxLogin.Location = new System.Drawing.Point(246, 3);
            this.TextBoxLogin.Name = "TextBoxLogin";
            this.TextBoxLogin.Size = new System.Drawing.Size(237, 30);
            this.TextBoxLogin.TabIndex = 4;
            // 
            // TablePanelAuthCtrlBut
            // 
            this.TablePanelAuthCtrlBut.ColumnCount = 1;
            this.TablePanelAuthCtrlBut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelAuthCtrlBut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanelAuthCtrlBut.Controls.Add(this.ButtonGuestLogin, 0, 1);
            this.TablePanelAuthCtrlBut.Controls.Add(this.ButtonLogin, 0, 0);
            this.TablePanelAuthCtrlBut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelAuthCtrlBut.Location = new System.Drawing.Point(246, 229);
            this.TablePanelAuthCtrlBut.Name = "TablePanelAuthCtrlBut";
            this.TablePanelAuthCtrlBut.RowCount = 2;
            this.TablePanelAuthCtrlBut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablePanelAuthCtrlBut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablePanelAuthCtrlBut.Size = new System.Drawing.Size(237, 108);
            this.TablePanelAuthCtrlBut.TabIndex = 6;
            // 
            // ButtonGuestLogin
            // 
            this.ButtonGuestLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonGuestLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGuestLogin.Location = new System.Drawing.Point(3, 57);
            this.ButtonGuestLogin.Name = "ButtonGuestLogin";
            this.ButtonGuestLogin.Size = new System.Drawing.Size(231, 48);
            this.ButtonGuestLogin.TabIndex = 4;
            this.ButtonGuestLogin.Text = "Вход как гость";
            this.ButtonGuestLogin.UseVisualStyleBackColor = true;
            this.ButtonGuestLogin.Click += new System.EventHandler(this.ButtonGuestLogin_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.Location = new System.Drawing.Point(3, 3);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(231, 48);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Вход";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // TablePanelAuthCaptcha
            // 
            this.TablePanelAuthCaptcha.ColumnCount = 1;
            this.TablePanelAuthCaptcha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablePanelAuthCaptcha.Controls.Add(this.PictureBoxCaptcha, 0, 0);
            this.TablePanelAuthCaptcha.Controls.Add(this.TextBoxCaptcha, 0, 1);
            this.TablePanelAuthCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanelAuthCaptcha.Location = new System.Drawing.Point(3, 229);
            this.TablePanelAuthCaptcha.Name = "TablePanelAuthCaptcha";
            this.TablePanelAuthCaptcha.RowCount = 2;
            this.TablePanelAuthCaptcha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TablePanelAuthCaptcha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TablePanelAuthCaptcha.Size = new System.Drawing.Size(237, 108);
            this.TablePanelAuthCaptcha.TabIndex = 7;
            // 
            // PictureBoxCaptcha
            // 
            this.PictureBoxCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxCaptcha.Location = new System.Drawing.Point(3, 3);
            this.PictureBoxCaptcha.Name = "PictureBoxCaptcha";
            this.PictureBoxCaptcha.Size = new System.Drawing.Size(231, 69);
            this.PictureBoxCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCaptcha.TabIndex = 0;
            this.PictureBoxCaptcha.TabStop = false;
            // 
            // TextBoxCaptcha
            // 
            this.TextBoxCaptcha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxCaptcha.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.TextBoxCaptcha.Location = new System.Drawing.Point(3, 78);
            this.TextBoxCaptcha.Name = "TextBoxCaptcha";
            this.TextBoxCaptcha.Size = new System.Drawing.Size(231, 30);
            this.TextBoxCaptcha.TabIndex = 1;
            // 
            // TimerCaptha
            // 
            this.TimerCaptha.Interval = 1000;
            this.TimerCaptha.Tick += new System.EventHandler(this.TimerCaptha_Tick);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 429);
            this.Controls.Add(this.TablePanelAuthMain);
            this.Controls.Add(this.TablePanelTempDown);
            this.Controls.Add(this.TablePanelTempUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.MinimumSize = new System.Drawing.Size(502, 468);
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuthorization_FormClosed);
            this.TablePanelTempUpper.ResumeLayout(false);
            this.TablePanelTempUpper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.TablePanelAuthMain.ResumeLayout(false);
            this.TablePanelAuthMain.PerformLayout();
            this.TablePanelAuthCtrlBut.ResumeLayout(false);
            this.TablePanelAuthCaptcha.ResumeLayout(false);
            this.TablePanelAuthCaptcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablePanelTempUpper;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTempNameForm;
        private System.Windows.Forms.Button ButtonAuthExit;
        private System.Windows.Forms.TableLayoutPanel TablePanelTempDown;
        private System.Windows.Forms.TableLayoutPanel TablePanelAuthMain;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxLogin;
        private System.Windows.Forms.TableLayoutPanel TablePanelAuthCtrlBut;
        private System.Windows.Forms.Button ButtonGuestLogin;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TableLayoutPanel TablePanelAuthCaptcha;
        private System.Windows.Forms.PictureBox PictureBoxCaptcha;
        private System.Windows.Forms.TextBox TextBoxCaptcha;
        private System.Windows.Forms.Timer TimerCaptha;
    }
}

