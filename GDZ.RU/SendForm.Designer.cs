namespace GDZ.RU
{
    partial class SendForm
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
            this.send_button = new System.Windows.Forms.Button();
            this.adress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // send_button
            // 
            this.send_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.send_button.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_button.Location = new System.Drawing.Point(0, 174);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(485, 94);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "Отправить";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(25, 95);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(448, 26);
            this.adress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("asinastra", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Укажите эл. почту";
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(485, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.send_button);
            this.Font = new System.Drawing.Font("asinastra", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sendForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Label label1;
    }
}