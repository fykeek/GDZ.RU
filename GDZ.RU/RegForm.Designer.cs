﻿namespace GDZ.RU
{
    partial class RegForm
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
            this.text_name = new System.Windows.Forms.Label();
            this.name_person = new System.Windows.Forms.TextBox();
            this.secondname_person = new System.Windows.Forms.TextBox();
            this.secondname_text = new System.Windows.Forms.Label();
            this.password_person = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.Label();
            this.login_person = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.Label();
            this.return_password = new System.Windows.Forms.TextBox();
            this.return_text = new System.Windows.Forms.Label();
            this.reg_button = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.mail_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.AutoSize = true;
            this.text_name.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name.Location = new System.Drawing.Point(17, 19);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(96, 20);
            this.text_name.TabIndex = 0;
            this.text_name.Text = "Ваше имя";
            // 
            // name_person
            // 
            this.name_person.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_person.Location = new System.Drawing.Point(21, 55);
            this.name_person.Name = "name_person";
            this.name_person.Size = new System.Drawing.Size(227, 29);
            this.name_person.TabIndex = 1;
            // 
            // secondname_person
            // 
            this.secondname_person.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondname_person.Location = new System.Drawing.Point(21, 139);
            this.secondname_person.Name = "secondname_person";
            this.secondname_person.Size = new System.Drawing.Size(227, 29);
            this.secondname_person.TabIndex = 3;
            // 
            // secondname_text
            // 
            this.secondname_text.AutoSize = true;
            this.secondname_text.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondname_text.Location = new System.Drawing.Point(17, 103);
            this.secondname_text.Name = "secondname_text";
            this.secondname_text.Size = new System.Drawing.Size(141, 20);
            this.secondname_text.TabIndex = 2;
            this.secondname_text.Text = "Ваше фамилия";
            // 
            // password_person
            // 
            this.password_person.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_person.Location = new System.Drawing.Point(21, 310);
            this.password_person.Name = "password_person";
            this.password_person.PasswordChar = '*';
            this.password_person.Size = new System.Drawing.Size(227, 29);
            this.password_person.TabIndex = 7;
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_text.Location = new System.Drawing.Point(17, 274);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(111, 20);
            this.password_text.TabIndex = 6;
            this.password_text.Text = "Ваш пароль";
            // 
            // login_person
            // 
            this.login_person.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_person.Location = new System.Drawing.Point(21, 226);
            this.login_person.Name = "login_person";
            this.login_person.Size = new System.Drawing.Size(227, 29);
            this.login_person.TabIndex = 5;
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_text.Location = new System.Drawing.Point(17, 190);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(101, 20);
            this.login_text.TabIndex = 4;
            this.login_text.Text = "Ваш логин";
            // 
            // return_password
            // 
            this.return_password.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_password.Location = new System.Drawing.Point(21, 401);
            this.return_password.Name = "return_password";
            this.return_password.PasswordChar = '*';
            this.return_password.Size = new System.Drawing.Size(227, 29);
            this.return_password.TabIndex = 9;
            // 
            // return_text
            // 
            this.return_text.AutoSize = true;
            this.return_text.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.return_text.Location = new System.Drawing.Point(17, 365);
            this.return_text.Name = "return_text";
            this.return_text.Size = new System.Drawing.Size(205, 20);
            this.return_text.TabIndex = 8;
            this.return_text.Text = "Подтвердите пароль";
            // 
            // reg_button
            // 
            this.reg_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reg_button.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_button.Location = new System.Drawing.Point(0, 578);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(509, 61);
            this.reg_button.TabIndex = 10;
            this.reg_button.Text = "Зарегистрироватся";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_text.Location = new System.Drawing.Point(19, 531);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(109, 20);
            this.error_text.TabIndex = 11;
            this.error_text.Text = "error_text";
            this.error_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // mail_textbox
            // 
            this.mail_textbox.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mail_textbox.Location = new System.Drawing.Point(21, 487);
            this.mail_textbox.Name = "mail_textbox";
            this.mail_textbox.Size = new System.Drawing.Size(227, 29);
            this.mail_textbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ваша почта (необезательно)\r\n";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 639);
            this.Controls.Add(this.mail_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.return_password);
            this.Controls.Add(this.return_text);
            this.Controls.Add(this.password_person);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_person);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.secondname_person);
            this.Controls.Add(this.secondname_text);
            this.Controls.Add(this.name_person);
            this.Controls.Add(this.text_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регестрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_name;
        private System.Windows.Forms.TextBox name_person;
        private System.Windows.Forms.TextBox secondname_person;
        private System.Windows.Forms.Label secondname_text;
        private System.Windows.Forms.TextBox password_person;
        private System.Windows.Forms.Label password_text;
        private System.Windows.Forms.TextBox login_person;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.TextBox return_password;
        private System.Windows.Forms.Label return_text;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Label error_text;
        private System.Windows.Forms.TextBox mail_textbox;
        private System.Windows.Forms.Label label1;
    }
}