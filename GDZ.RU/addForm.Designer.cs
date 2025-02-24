namespace GDZ.RU
{
    partial class addForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subject_CB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.price_NU = new System.Windows.Forms.NumericUpDown();
            this.class_min = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.class_max = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.class_TB = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.load_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.price_NU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("asinastra", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление обьекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название задачи:";
            // 
            // name_TB
            // 
            this.name_TB.Location = new System.Drawing.Point(247, 90);
            this.name_TB.Name = "name_TB";
            this.name_TB.Size = new System.Drawing.Size(246, 32);
            this.name_TB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Категория:";
            // 
            // subject_CB
            // 
            this.subject_CB.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject_CB.FormattingEnabled = true;
            this.subject_CB.Items.AddRange(new object[] {
            "",
            "Русский",
            "История",
            "Математика",
            "Биология",
            "Литиратура",
            "Алгебра",
            "Физика",
            "Геометрия"});
            this.subject_CB.Location = new System.Drawing.Point(247, 156);
            this.subject_CB.Name = "subject_CB";
            this.subject_CB.Size = new System.Drawing.Size(246, 28);
            this.subject_CB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Цена:";
            // 
            // price_NU
            // 
            this.price_NU.Location = new System.Drawing.Point(247, 217);
            this.price_NU.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.price_NU.Name = "price_NU";
            this.price_NU.Size = new System.Drawing.Size(246, 32);
            this.price_NU.TabIndex = 6;
            // 
            // class_min
            // 
            this.class_min.Location = new System.Drawing.Point(247, 345);
            this.class_min.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.class_min.Name = "class_min";
            this.class_min.Size = new System.Drawing.Size(246, 32);
            this.class_min.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Класс мин.";
            // 
            // class_max
            // 
            this.class_max.Location = new System.Drawing.Point(247, 408);
            this.class_max.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.class_max.Name = "class_max";
            this.class_max.Size = new System.Drawing.Size(246, 32);
            this.class_max.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Класс макс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Класс:";
            // 
            // class_TB
            // 
            this.class_TB.Location = new System.Drawing.Point(247, 278);
            this.class_TB.Name = "class_TB";
            this.class_TB.Size = new System.Drawing.Size(246, 32);
            this.class_TB.TabIndex = 12;
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkGray;
            this.add_button.Location = new System.Drawing.Point(580, 427);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(235, 64);
            this.add_button.TabIndex = 13;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(537, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // load_button
            // 
            this.load_button.BackColor = System.Drawing.Color.DarkGray;
            this.load_button.Location = new System.Drawing.Point(537, 297);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(290, 64);
            this.load_button.TabIndex = 15;
            this.load_button.Text = "Загрузить картинку";
            this.load_button.UseVisualStyleBackColor = false;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(862, 539);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.class_TB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.class_max);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.class_min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price_NU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subject_CB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "addForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "е";
            this.Load += new System.EventHandler(this.addForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.price_NU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox subject_CB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown price_NU;
        private System.Windows.Forms.NumericUpDown class_min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown class_max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox class_TB;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}