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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GDZform));
            this.filters = new System.Windows.Forms.Panel();
            this.find_button = new System.Windows.Forms.Button();
            this.choose_subjet = new System.Windows.Forms.Label();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.name_ans = new System.Windows.Forms.Label();
            this.write_name_ans = new System.Windows.Forms.TextBox();
            this.hide_filters = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nickname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filters.SuspendLayout();
            this.result.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.filters.Size = new System.Drawing.Size(1163, 208);
            this.filters.TabIndex = 0;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(10, 162);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(253, 37);
            this.find_button.TabIndex = 5;
            this.find_button.Text = "Найти";
            this.find_button.UseVisualStyleBackColor = true;
            // 
            // choose_subjet
            // 
            this.choose_subjet.AutoSize = true;
            this.choose_subjet.Location = new System.Drawing.Point(13, 69);
            this.choose_subjet.Name = "choose_subjet";
            this.choose_subjet.Size = new System.Drawing.Size(162, 24);
            this.choose_subjet.TabIndex = 4;
            this.choose_subjet.Text = "Выбор предмета";
            this.choose_subjet.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Location = new System.Drawing.Point(181, 66);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(163, 32);
            this.comboBox_subject.TabIndex = 3;
            this.comboBox_subject.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // name_ans
            // 
            this.name_ans.AutoSize = true;
            this.name_ans.BackColor = System.Drawing.Color.PaleGreen;
            this.name_ans.Location = new System.Drawing.Point(208, 21);
            this.name_ans.Name = "name_ans";
            this.name_ans.Size = new System.Drawing.Size(165, 24);
            this.name_ans.TabIndex = 2;
            this.name_ans.Text = "Название задачи";
            // 
            // write_name_ans
            // 
            this.write_name_ans.Location = new System.Drawing.Point(379, 18);
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
            this.hide_filters.Size = new System.Drawing.Size(178, 47);
            this.hide_filters.TabIndex = 0;
            this.hide_filters.Text = "Скрыть";
            this.hide_filters.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.LightBlue;
            this.result.Controls.Add(this.label2);
            this.result.Controls.Add(this.pictureBox2);
            this.result.Controls.Add(this.label1);
            this.result.Controls.Add(this.pictureBox1);
            this.result.Dock = System.Windows.Forms.DockStyle.Top;
            this.result.Location = new System.Drawing.Point(0, 208);
            this.result.Margin = new System.Windows.Forms.Padding(6);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(1163, 400);
            this.result.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.nickname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 608);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "          Списование\r\nс пропушеными буквами";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(355, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сообшение по истории 20 в.";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}