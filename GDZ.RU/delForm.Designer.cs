namespace GDZ.RU
{
    partial class delForm
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
            this.delComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delTextBox = new System.Windows.Forms.TextBox();
            this.delButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delComboBox
            // 
            this.delComboBox.FormattingEnabled = true;
            this.delComboBox.Location = new System.Drawing.Point(97, 119);
            this.delComboBox.Name = "delComboBox";
            this.delComboBox.Size = new System.Drawing.Size(332, 28);
            this.delComboBox.TabIndex = 0;
            this.delComboBox.SelectedIndexChanged += new System.EventHandler(this.delComboBox_SelectedIndexChanged);
            this.delComboBox.SelectedValueChanged += new System.EventHandler(this.delComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете обьект для удаления";
            // 
            // delTextBox
            // 
            this.delTextBox.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delTextBox.ForeColor = System.Drawing.Color.IndianRed;
            this.delTextBox.Location = new System.Drawing.Point(97, 186);
            this.delTextBox.Name = "delTextBox";
            this.delTextBox.ReadOnly = true;
            this.delTextBox.Size = new System.Drawing.Size(332, 32);
            this.delTextBox.TabIndex = 2;
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.Silver;
            this.delButton.Location = new System.Drawing.Point(151, 267);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(212, 64);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // delForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(537, 406);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.delTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delComboBox);
            this.Font = new System.Drawing.Font("asinastra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "delForm";
            this.Text = "delForm";
            this.Load += new System.EventHandler(this.delForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delTextBox;
        private System.Windows.Forms.Button delButton;
    }
}