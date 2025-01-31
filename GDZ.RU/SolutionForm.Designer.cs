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
            ((System.ComponentModel.ISupportInitialize)(this.SolutionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Solutionlabel
            // 
            this.Solutionlabel.AutoSize = true;
            this.Solutionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solutionlabel.Location = new System.Drawing.Point(35, 270);
            this.Solutionlabel.Name = "Solutionlabel";
            this.Solutionlabel.Size = new System.Drawing.Size(70, 25);
            this.Solutionlabel.TabIndex = 0;
            this.Solutionlabel.Text = "label1";
            // 
            // SolutionPic
            // 
            this.SolutionPic.Location = new System.Drawing.Point(29, 32);
            this.SolutionPic.Name = "SolutionPic";
            this.SolutionPic.Size = new System.Drawing.Size(297, 211);
            this.SolutionPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SolutionPic.TabIndex = 1;
            this.SolutionPic.TabStop = false;
            this.SolutionPic.Click += new System.EventHandler(this.SolutionPic_Click);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjectLabel.Location = new System.Drawing.Point(359, 32);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(70, 25);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "label1";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classLabel.Location = new System.Drawing.Point(359, 73);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(70, 25);
            this.classLabel.TabIndex = 3;
            this.classLabel.Text = "label1";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(359, 114);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(70, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "label2";
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(786, 446);
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
    }
}