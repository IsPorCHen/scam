namespace scaMarketPlays
{
    partial class Form1
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
            this.userSelect = new System.Windows.Forms.RadioButton();
            this.selectSaleman = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.passwordSaleman = new System.Windows.Forms.TextBox();
            this.loginSaleman = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userSelect
            // 
            this.userSelect.AutoSize = true;
            this.userSelect.Location = new System.Drawing.Point(15, 26);
            this.userSelect.Name = "userSelect";
            this.userSelect.Size = new System.Drawing.Size(45, 17);
            this.userSelect.TabIndex = 0;
            this.userSelect.TabStop = true;
            this.userSelect.Text = "user";
            this.userSelect.UseVisualStyleBackColor = true;
            this.userSelect.CheckedChanged += new System.EventHandler(this.userSelect_CheckedChanged);
            // 
            // selectSaleman
            // 
            this.selectSaleman.AutoSize = true;
            this.selectSaleman.Location = new System.Drawing.Point(15, 49);
            this.selectSaleman.Name = "selectSaleman";
            this.selectSaleman.Size = new System.Drawing.Size(66, 17);
            this.selectSaleman.TabIndex = 1;
            this.selectSaleman.TabStop = true;
            this.selectSaleman.Text = "Saleman";
            this.selectSaleman.UseVisualStyleBackColor = true;
            this.selectSaleman.CheckedChanged += new System.EventHandler(this.selectSaleman_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кто вы?";
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(234, 26);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(100, 20);
            this.userLogin.TabIndex = 3;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(234, 67);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(100, 20);
            this.userPassword.TabIndex = 4;
            // 
            // passwordSaleman
            // 
            this.passwordSaleman.Location = new System.Drawing.Point(234, 67);
            this.passwordSaleman.Name = "passwordSaleman";
            this.passwordSaleman.Size = new System.Drawing.Size(100, 20);
            this.passwordSaleman.TabIndex = 6;
            // 
            // loginSaleman
            // 
            this.loginSaleman.Location = new System.Drawing.Point(234, 26);
            this.loginSaleman.Name = "loginSaleman";
            this.loginSaleman.Size = new System.Drawing.Size(100, 20);
            this.loginSaleman.TabIndex = 5;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(234, 8);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(38, 13);
            this.login.TabIndex = 7;
            this.login.Text = "Логин";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(231, 51);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(45, 13);
            this.password.TabIndex = 8;
            this.password.Text = "Пароль";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(28, 115);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(109, 115);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(131, 23);
            this.registrationButton.TabIndex = 10;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordSaleman);
            this.Controls.Add(this.loginSaleman);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectSaleman);
            this.Controls.Add(this.userSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton userSelect;
        private System.Windows.Forms.RadioButton selectSaleman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox passwordSaleman;
        private System.Windows.Forms.TextBox loginSaleman;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registrationButton;
    }
}

