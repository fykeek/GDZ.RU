namespace GDZ.RU
{
    partial class loginForm
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
            this.password_person = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.Label();
            this.login_person = new System.Windows.Forms.TextBox();
            this.login_text = new System.Windows.Forms.Label();
            this.name_person = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_person
            // 
            this.password_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_person.Location = new System.Drawing.Point(12, 223);
            this.password_person.Name = "password_person";
            this.password_person.PasswordChar = '*';
            this.password_person.Size = new System.Drawing.Size(227, 29);
            this.password_person.TabIndex = 13;
            this.password_person.TextChanged += new System.EventHandler(this.password_person_TextChanged);
            // 
            // password_text
            // 
            this.password_text.AutoSize = true;
            this.password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_text.Location = new System.Drawing.Point(8, 177);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(115, 24);
            this.password_text.TabIndex = 12;
            this.password_text.Text = "Ваш пароль";
            this.password_text.Click += new System.EventHandler(this.password_text_Click);
            // 
            // login_person
            // 
            this.login_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_person.Location = new System.Drawing.Point(12, 129);
            this.login_person.Name = "login_person";
            this.login_person.Size = new System.Drawing.Size(227, 29);
            this.login_person.TabIndex = 11;
            this.login_person.TextChanged += new System.EventHandler(this.login_person_TextChanged);
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_text.Location = new System.Drawing.Point(8, 93);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(103, 24);
            this.login_text.TabIndex = 10;
            this.login_text.Text = "Ваш логин";
            this.login_text.Click += new System.EventHandler(this.login_text_Click);
            // 
            // name_person
            // 
            this.name_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_person.Location = new System.Drawing.Point(12, 48);
            this.name_person.Name = "name_person";
            this.name_person.Size = new System.Drawing.Size(227, 29);
            this.name_person.TabIndex = 9;
            // 
            // text_name
            // 
            this.text_name.AutoSize = true;
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name.Location = new System.Drawing.Point(8, 12);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(96, 24);
            this.text_name.TabIndex = 8;
            this.text_name.Text = "Ваше имя";
            // 
            // login_button
            // 
            this.login_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(0, 309);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(495, 79);
            this.login_button.TabIndex = 14;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 388);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_person);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.login_person);
            this.Controls.Add(this.login_text);
            this.Controls.Add(this.name_person);
            this.Controls.Add(this.text_name);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_person;
        private System.Windows.Forms.Label password_text;
        private System.Windows.Forms.TextBox login_person;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.TextBox name_person;
        private System.Windows.Forms.Label text_name;
        private System.Windows.Forms.Button login_button;
    }
}