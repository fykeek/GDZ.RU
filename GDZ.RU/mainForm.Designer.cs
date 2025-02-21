namespace GDZ.RU
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.web = new System.Windows.Forms.Panel();
            this.web_name = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.log_in = new System.Windows.Forms.Panel();
            this.secret = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.web.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.log_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // web
            // 
            this.web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.web.Controls.Add(this.web_name);
            this.web.Dock = System.Windows.Forms.DockStyle.Top;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(1027, 141);
            this.web.TabIndex = 0;
            // 
            // web_name
            // 
            this.web_name.AutoSize = true;
            this.web_name.Font = new System.Drawing.Font("asinastra", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.web_name.Location = new System.Drawing.Point(329, 19);
            this.web_name.Name = "web_name";
            this.web_name.Size = new System.Drawing.Size(348, 100);
            this.web_name.TabIndex = 0;
            this.web_name.Text = "GDZ.RU\r\n";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.Controls.Add(this.pictureBox1);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 141);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1027, 314);
            this.logo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // log_in
            // 
            this.log_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.log_in.Controls.Add(this.secret);
            this.log_in.Controls.Add(this.register);
            this.log_in.Controls.Add(this.login);
            this.log_in.Dock = System.Windows.Forms.DockStyle.Top;
            this.log_in.Location = new System.Drawing.Point(0, 455);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(1027, 258);
            this.log_in.TabIndex = 2;
            // 
            // secret
            // 
            this.secret.Font = new System.Drawing.Font("asinastra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secret.Location = new System.Drawing.Point(426, 18);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(174, 148);
            this.secret.TabIndex = 2;
            this.secret.Text = "Войти как гость";
            this.secret.UseVisualStyleBackColor = true;
            this.secret.Click += new System.EventHandler(this.secret_Click);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("asinastra", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.Location = new System.Drawing.Point(617, 18);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(398, 148);
            this.register.TabIndex = 1;
            this.register.Text = "Регистрация";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("asinastra", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(12, 18);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(387, 148);
            this.login.TabIndex = 0;
            this.login.Text = "Войти";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 633);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.web);
            this.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.web.ResumeLayout(false);
            this.web.PerformLayout();
            this.logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.log_in.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel web;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel log_in;
        private System.Windows.Forms.Label web_name;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button secret;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

