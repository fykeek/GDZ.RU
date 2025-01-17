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
            ((System.ComponentModel.ISupportInitialize)(this.SolutionPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Solutionlabel
            // 
            this.Solutionlabel.AutoSize = true;
            this.Solutionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solutionlabel.Location = new System.Drawing.Point(93, 273);
            this.Solutionlabel.Name = "Solutionlabel";
            this.Solutionlabel.Size = new System.Drawing.Size(70, 25);
            this.Solutionlabel.TabIndex = 0;
            this.Solutionlabel.Text = "label1";
            // 
            // SolutionPic
            // 
            this.SolutionPic.Location = new System.Drawing.Point(29, 32);
            this.SolutionPic.Name = "SolutionPic";
            this.SolutionPic.Size = new System.Drawing.Size(198, 211);
            this.SolutionPic.TabIndex = 1;
            this.SolutionPic.TabStop = false;
            // 
            // SolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 446);
            this.Controls.Add(this.SolutionPic);
            this.Controls.Add(this.Solutionlabel);
            this.Name = "SolutionForm";
            this.Text = "GDZ.RU";
            ((System.ComponentModel.ISupportInitialize)(this.SolutionPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Solutionlabel;
        private System.Windows.Forms.PictureBox SolutionPic;
    }
}