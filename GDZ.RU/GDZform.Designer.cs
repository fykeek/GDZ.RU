namespace GDZ.RU
{
    partial class GDZform
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
            this.components = new System.ComponentModel.Container();
            this.filters_panel = new System.Windows.Forms.Panel();
            this.class_text = new System.Windows.Forms.Label();
            this.class_box = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.choose_subjet = new System.Windows.Forms.Label();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.name_ans = new System.Windows.Forms.Label();
            this.write_name_ans = new System.Windows.Forms.TextBox();
            this.hide_filters = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.help_button = new System.Windows.Forms.Button();
            this.exit_account = new System.Windows.Forms.Button();
            this.nickname = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.result = new System.Windows.Forms.Panel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addSolutiun = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.filters_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filters_panel
            // 
            this.filters_panel.BackColor = System.Drawing.Color.PaleGreen;
            this.filters_panel.Controls.Add(this.class_text);
            this.filters_panel.Controls.Add(this.class_box);
            this.filters_panel.Controls.Add(this.find_button);
            this.filters_panel.Controls.Add(this.choose_subjet);
            this.filters_panel.Controls.Add(this.comboBox_subject);
            this.filters_panel.Controls.Add(this.name_ans);
            this.filters_panel.Controls.Add(this.write_name_ans);
            this.filters_panel.Controls.Add(this.hide_filters);
            this.filters_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filters_panel.Location = new System.Drawing.Point(0, 0);
            this.filters_panel.Margin = new System.Windows.Forms.Padding(6);
            this.filters_panel.Name = "filters_panel";
            this.filters_panel.Size = new System.Drawing.Size(1306, 200);
            this.filters_panel.TabIndex = 0;
            this.filters_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.filters_Paint);
            // 
            // class_text
            // 
            this.class_text.AutoSize = true;
            this.class_text.BackColor = System.Drawing.Color.PaleGreen;
            this.class_text.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_text.Location = new System.Drawing.Point(472, 77);
            this.class_text.Name = "class_text";
            this.class_text.Size = new System.Drawing.Size(64, 20);
            this.class_text.TabIndex = 10;
            this.class_text.Text = "Класс";
            this.class_text.Click += new System.EventHandler(this.label3_Click);
            // 
            // class_box
            // 
            this.class_box.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class_box.Location = new System.Drawing.Point(540, 77);
            this.class_box.Name = "class_box";
            this.class_box.Size = new System.Drawing.Size(259, 29);
            this.class_box.TabIndex = 6;
            this.class_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // find_button
            // 
            this.find_button.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_button.Location = new System.Drawing.Point(10, 154);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(253, 37);
            this.find_button.TabIndex = 5;
            this.find_button.Text = "Найти";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // choose_subjet
            // 
            this.choose_subjet.AutoSize = true;
            this.choose_subjet.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_subjet.Location = new System.Drawing.Point(8, 115);
            this.choose_subjet.Name = "choose_subjet";
            this.choose_subjet.Size = new System.Drawing.Size(162, 20);
            this.choose_subjet.TabIndex = 4;
            this.choose_subjet.Text = "Выбор предмета";
            this.choose_subjet.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Items.AddRange(new object[] {
            "",
            "Русский",
            "История",
            "Математика",
            "Биология",
            "Литиратура",
            "Алгебра",
            "Физика",
            "Геометрия",
            "Английский"});
            this.comboBox_subject.Location = new System.Drawing.Point(176, 112);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(163, 28);
            this.comboBox_subject.TabIndex = 3;
            this.comboBox_subject.Text = "  ";
            this.comboBox_subject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // name_ans
            // 
            this.name_ans.AutoSize = true;
            this.name_ans.BackColor = System.Drawing.Color.PaleGreen;
            this.name_ans.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_ans.Location = new System.Drawing.Point(5, 80);
            this.name_ans.Name = "name_ans";
            this.name_ans.Size = new System.Drawing.Size(169, 20);
            this.name_ans.TabIndex = 2;
            this.name_ans.Text = "Название задачи";
            // 
            // write_name_ans
            // 
            this.write_name_ans.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.write_name_ans.Location = new System.Drawing.Point(176, 77);
            this.write_name_ans.Name = "write_name_ans";
            this.write_name_ans.Size = new System.Drawing.Size(259, 29);
            this.write_name_ans.TabIndex = 1;
            this.write_name_ans.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hide_filters
            // 
            this.hide_filters.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide_filters.Location = new System.Drawing.Point(10, 10);
            this.hide_filters.Margin = new System.Windows.Forms.Padding(6);
            this.hide_filters.Name = "hide_filters";
            this.hide_filters.Size = new System.Drawing.Size(178, 45);
            this.hide_filters.TabIndex = 0;
            this.hide_filters.Text = "Скрыть";
            this.hide_filters.UseVisualStyleBackColor = true;
            this.hide_filters.Click += new System.EventHandler(this.hide_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.help_button);
            this.panel1.Controls.Add(this.exit_account);
            this.panel1.Controls.Add(this.nickname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 725);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 82);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // help_button
            // 
            this.help_button.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_button.Location = new System.Drawing.Point(1084, 9);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(160, 61);
            this.help_button.TabIndex = 2;
            this.help_button.Text = "Справочник для админа";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_Click);
            // 
            // exit_account
            // 
            this.exit_account.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_account.Location = new System.Drawing.Point(14, 9);
            this.exit_account.Name = "exit_account";
            this.exit_account.Size = new System.Drawing.Size(160, 61);
            this.exit_account.TabIndex = 1;
            this.exit_account.Text = "Выйти из аккаунта";
            this.exit_account.UseVisualStyleBackColor = true;
            this.exit_account.Click += new System.EventHandler(this.exit_Click);
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.Font = new System.Drawing.Font("asinastra", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickname.Location = new System.Drawing.Point(203, 26);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(81, 25);
            this.nickname.TabIndex = 0;
            this.nickname.Text = "Гость";
            this.nickname.Click += new System.EventHandler(this.nickname_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // result
            // 
            this.result.AutoScroll = true;
            this.result.BackColor = System.Drawing.Color.LightBlue;
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(0, 200);
            this.result.Margin = new System.Windows.Forms.Padding(6);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(1306, 525);
            this.result.TabIndex = 1;
            this.result.Paint += new System.Windows.Forms.PaintEventHandler(this.result_Paint);
            this.result.Resize += new System.EventHandler(this.GDZ_Resize);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 20);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSolutiun,
            this.deleteSolution});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 48);
            // 
            // addSolutiun
            // 
            this.addSolutiun.Name = "addSolutiun";
            this.addSolutiun.Size = new System.Drawing.Size(178, 22);
            this.addSolutiun.Text = "Добавить задачку";
            this.addSolutiun.Click += new System.EventHandler(this.addSolutiun_Click);
            // 
            // deleteSolution
            // 
            this.deleteSolution.Name = "deleteSolution";
            this.deleteSolution.Size = new System.Drawing.Size(178, 22);
            this.deleteSolution.Text = "Удалить задачу";
            this.deleteSolution.Click += new System.EventHandler(this.deleteSolution_Click);
            // 
            // GDZform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 807);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.result);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.filters_panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GDZform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDZ.RU";
            this.Load += new System.EventHandler(this.GDZform_load);
            this.filters_panel.ResumeLayout(false);
            this.filters_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filters_panel;
        private System.Windows.Forms.Button hide_filters;
        private System.Windows.Forms.Label name_ans;
        private System.Windows.Forms.TextBox write_name_ans;
        private System.Windows.Forms.Label choose_subjet;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel result;
        private System.Windows.Forms.TextBox class_box;
        private System.Windows.Forms.Label class_text;
        private System.Windows.Forms.Button exit_account;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addSolutiun;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.ToolStripMenuItem deleteSolution;
    }
}