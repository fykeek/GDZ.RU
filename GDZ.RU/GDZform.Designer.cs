﻿namespace GDZ.RU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GDZform));
            this.filters = new System.Windows.Forms.Panel();
            this.find_button = new System.Windows.Forms.Button();
            this.choose_subjet = new System.Windows.Forms.Label();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.name_ans = new System.Windows.Forms.Label();
            this.write_name_ans = new System.Windows.Forms.TextBox();
            this.hide_filters = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Panel();
            this.solutionText2 = new System.Windows.Forms.Label();
            this.solutionFoto2 = new System.Windows.Forms.PictureBox();
            this.solutionText1 = new System.Windows.Forms.Label();
            this.solutionFoto1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nickname = new System.Windows.Forms.Label();
            this.filters.SuspendLayout();
            this.result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionFoto1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filters
            // 
            this.filters.BackColor = System.Drawing.Color.PaleGreen;
            this.filters.Controls.Add(this.find_button);
            this.filters.Controls.Add(this.choose_subjet);
            this.filters.Controls.Add(this.comboBox_subject);
            this.filters.Controls.Add(this.name_ans);
            this.filters.Controls.Add(this.write_name_ans);
            this.filters.Controls.Add(this.hide_filters);
            this.filters.Dock = System.Windows.Forms.DockStyle.Top;
            this.filters.Location = new System.Drawing.Point(0, 0);
            this.filters.Margin = new System.Windows.Forms.Padding(6);
            this.filters.Name = "filters";
            this.filters.Size = new System.Drawing.Size(1163, 200);
            this.filters.TabIndex = 0;
            this.filters.Paint += new System.Windows.Forms.PaintEventHandler(this.filters_Paint);
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(10, 154);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(253, 37);
            this.find_button.TabIndex = 5;
            this.find_button.Text = "Найти";
            this.find_button.UseVisualStyleBackColor = true;
            // 
            // choose_subjet
            // 
            this.choose_subjet.AutoSize = true;
            this.choose_subjet.Location = new System.Drawing.Point(8, 115);
            this.choose_subjet.Name = "choose_subjet";
            this.choose_subjet.Size = new System.Drawing.Size(162, 24);
            this.choose_subjet.TabIndex = 4;
            this.choose_subjet.Text = "Выбор предмета";
            this.choose_subjet.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Location = new System.Drawing.Point(176, 112);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(163, 32);
            this.comboBox_subject.TabIndex = 3;
            this.comboBox_subject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // name_ans
            // 
            this.name_ans.AutoSize = true;
            this.name_ans.BackColor = System.Drawing.Color.PaleGreen;
            this.name_ans.Location = new System.Drawing.Point(5, 80);
            this.name_ans.Name = "name_ans";
            this.name_ans.Size = new System.Drawing.Size(165, 24);
            this.name_ans.TabIndex = 2;
            this.name_ans.Text = "Название задачи";
            // 
            // write_name_ans
            // 
            this.write_name_ans.Location = new System.Drawing.Point(176, 77);
            this.write_name_ans.Name = "write_name_ans";
            this.write_name_ans.Size = new System.Drawing.Size(259, 29);
            this.write_name_ans.TabIndex = 1;
            this.write_name_ans.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hide_filters
            // 
            this.hide_filters.Location = new System.Drawing.Point(10, 10);
            this.hide_filters.Margin = new System.Windows.Forms.Padding(6);
            this.hide_filters.Name = "hide_filters";
            this.hide_filters.Size = new System.Drawing.Size(178, 45);
            this.hide_filters.TabIndex = 0;
            this.hide_filters.Text = "Скрыть";
            this.hide_filters.UseVisualStyleBackColor = true;
            this.hide_filters.Click += new System.EventHandler(this.hide_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.LightBlue;
            this.result.Controls.Add(this.solutionText2);
            this.result.Controls.Add(this.solutionFoto2);
            this.result.Controls.Add(this.solutionText1);
            this.result.Controls.Add(this.solutionFoto1);
            this.result.Dock = System.Windows.Forms.DockStyle.Top;
            this.result.Location = new System.Drawing.Point(0, 200);
            this.result.Margin = new System.Windows.Forms.Padding(6);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(1163, 584);
            this.result.TabIndex = 1;
            // 
            // solutionText2
            // 
            this.solutionText2.AutoSize = true;
            this.solutionText2.Location = new System.Drawing.Point(339, 220);
            this.solutionText2.Name = "solutionText2";
            this.solutionText2.Size = new System.Drawing.Size(267, 24);
            this.solutionText2.TabIndex = 3;
            this.solutionText2.Text = "Сообшение по истории 20 в.";
            // 
            // solutionFoto2
            // 
            this.solutionFoto2.Image = ((System.Drawing.Image)(resources.GetObject("solutionFoto2.Image")));
            this.solutionFoto2.Location = new System.Drawing.Point(355, 20);
            this.solutionFoto2.Name = "solutionFoto2";
            this.solutionFoto2.Size = new System.Drawing.Size(230, 181);
            this.solutionFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.solutionFoto2.TabIndex = 2;
            this.solutionFoto2.TabStop = false;
            this.solutionFoto2.Tag = "Сообшение по истории 20 в.";
            this.solutionFoto2.Click += new System.EventHandler(this.solution_Click);
            // 
            // solutionText1
            // 
            this.solutionText1.AutoSize = true;
            this.solutionText1.Location = new System.Drawing.Point(59, 220);
            this.solutionText1.Name = "solutionText1";
            this.solutionText1.Size = new System.Drawing.Size(194, 24);
            this.solutionText1.TabIndex = 1;
            this.solutionText1.Tag = "russki1";
            this.solutionText1.Text = "Русский списование";
            this.solutionText1.Click += new System.EventHandler(this.label1_Click);
            // 
            // solutionFoto1
            // 
            this.solutionFoto1.Image = ((System.Drawing.Image)(resources.GetObject("solutionFoto1.Image")));
            this.solutionFoto1.Location = new System.Drawing.Point(10, 20);
            this.solutionFoto1.Name = "solutionFoto1";
            this.solutionFoto1.Size = new System.Drawing.Size(285, 181);
            this.solutionFoto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.solutionFoto1.TabIndex = 0;
            this.solutionFoto1.TabStop = false;
            this.solutionFoto1.Tag = "Русский списование";
            this.solutionFoto1.Click += new System.EventHandler(this.solution_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.nickname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 597);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 77);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nickname
            // 
            this.nickname.AutoSize = true;
            this.nickname.Location = new System.Drawing.Point(27, 17);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(60, 24);
            this.nickname.TabIndex = 0;
            this.nickname.Text = "label1";
            this.nickname.Click += new System.EventHandler(this.nickname_Click);
            // 
            // GDZform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.filters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GDZform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDZ.RU";
            this.filters.ResumeLayout(false);
            this.filters.PerformLayout();
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionFoto1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filters;
        private System.Windows.Forms.Panel result;
        private System.Windows.Forms.Button hide_filters;
        private System.Windows.Forms.Label name_ans;
        private System.Windows.Forms.TextBox write_name_ans;
        private System.Windows.Forms.Label choose_subjet;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nickname;
        private System.Windows.Forms.Label solutionText1;
        private System.Windows.Forms.PictureBox solutionFoto1;
        private System.Windows.Forms.PictureBox solutionFoto2;
        private System.Windows.Forms.Label solutionText2;
    }
}