namespace GDZ.RU
{
    partial class SolutionForm
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
            this.Solutionlabel = new System.Windows.Forms.Label();
            this.SolutionPic = new System.Windows.Forms.PictureBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.rename_opis = new System.Windows.Forms.Button();
            this.price_TextBox = new System.Windows.Forms.TextBox();
            this.sol_replase = new System.Windows.Forms.Button();
            this.class_TextBox = new System.Windows.Forms.TextBox();
            this.subject_TextBox = new System.Windows.Forms.TextBox();
            this.select_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Solutionlabel
            // 
            this.Solutionlabel.AutoSize = true;
            this.Solutionlabel.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solutionlabel.Location = new System.Drawing.Point(24, 352);
            this.Solutionlabel.Name = "Solutionlabel";
            this.Solutionlabel.Size = new System.Drawing.Size(73, 22);
            this.Solutionlabel.TabIndex = 0;
            this.Solutionlabel.Text = "label1";
            this.Solutionlabel.Click += new System.EventHandler(this.Solutionlabel_Click);
            // 
            // SolutionPic
            // 
            this.SolutionPic.Location = new System.Drawing.Point(29, 32);
            this.SolutionPic.Name = "SolutionPic";
            this.SolutionPic.Size = new System.Drawing.Size(396, 294);
            this.SolutionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SolutionPic.TabIndex = 1;
            this.SolutionPic.TabStop = false;
            this.SolutionPic.Click += new System.EventHandler(this.SolutionPic_Click);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectLabel.Location = new System.Drawing.Point(453, 32);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(73, 22);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "label1";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classLabel.Location = new System.Drawing.Point(453, 73);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(73, 22);
            this.classLabel.TabIndex = 3;
            this.classLabel.Text = "label1";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(453, 114);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(73, 22);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "label2";
            // 
            // opisTextBox
            // 
            this.opisTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.opisTextBox.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opisTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.opisTextBox.Location = new System.Drawing.Point(458, 244);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.ReadOnly = true;
            this.opisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.opisTextBox.Size = new System.Drawing.Size(370, 362);
            this.opisTextBox.TabIndex = 5;
            // 
            // rename_opis
            // 
            this.rename_opis.BackColor = System.Drawing.Color.Gray;
            this.rename_opis.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rename_opis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rename_opis.Location = new System.Drawing.Point(283, 402);
            this.rename_opis.Name = "rename_opis";
            this.rename_opis.Size = new System.Drawing.Size(142, 100);
            this.rename_opis.TabIndex = 6;
            this.rename_opis.Text = "Заменить описание";
            this.rename_opis.UseVisualStyleBackColor = false;
            this.rename_opis.Click += new System.EventHandler(this.rename_opis_Click);
            // 
            // price_TextBox
            // 
            this.price_TextBox.Location = new System.Drawing.Point(671, 118);
            this.price_TextBox.Name = "price_TextBox";
            this.price_TextBox.Size = new System.Drawing.Size(157, 20);
            this.price_TextBox.TabIndex = 7;
            // 
            // sol_replase
            // 
            this.sol_replase.BackColor = System.Drawing.Color.Gray;
            this.sol_replase.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sol_replase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sol_replase.Location = new System.Drawing.Point(458, 154);
            this.sol_replase.Name = "sol_replase";
            this.sol_replase.Size = new System.Drawing.Size(233, 59);
            this.sol_replase.TabIndex = 8;
            this.sol_replase.Text = "Заменить все";
            this.sol_replase.UseVisualStyleBackColor = false;
            this.sol_replase.Click += new System.EventHandler(this.sol_replase_Click);
            // 
            // class_TextBox
            // 
            this.class_TextBox.Location = new System.Drawing.Point(671, 77);
            this.class_TextBox.Name = "class_TextBox";
            this.class_TextBox.Size = new System.Drawing.Size(157, 20);
            this.class_TextBox.TabIndex = 9;
            // 
            // subject_TextBox
            // 
            this.subject_TextBox.Location = new System.Drawing.Point(671, 32);
            this.subject_TextBox.Name = "subject_TextBox";
            this.subject_TextBox.Size = new System.Drawing.Size(157, 20);
            this.subject_TextBox.TabIndex = 10;
            // 
            // select_button
            // 
            this.select_button.BackColor = System.Drawing.Color.PaleGreen;
            this.select_button.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_button.Location = new System.Drawing.Point(29, 527);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(396, 79);
            this.select_button.TabIndex = 11;
            this.select_button.Text = "В корзину";
            this.select_button.UseVisualStyleBackColor = false;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(850, 629);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.subject_TextBox);
            this.Controls.Add(this.class_TextBox);
            this.Controls.Add(this.sol_replase);
            this.Controls.Add(this.price_TextBox);
            this.Controls.Add(this.rename_opis);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.SolutionPic);
            this.Controls.Add(this.Solutionlabel);
            this.Name = "SolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDZ.RU";
            this.Load += new System.EventHandler(this.SolutionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SolutionPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Solutionlabel;
        private System.Windows.Forms.PictureBox SolutionPic;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Button rename_opis;
        private System.Windows.Forms.TextBox price_TextBox;
        private System.Windows.Forms.Button sol_replase;
        private System.Windows.Forms.TextBox class_TextBox;
        private System.Windows.Forms.TextBox subject_TextBox;
        private System.Windows.Forms.Button select_button;
    }
}