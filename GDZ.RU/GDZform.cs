using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDZ.RU
{
    public partial class GDZform : System.Windows.Forms.Form
    {
        public GDZform()
        {
            InitializeComponent();

            nickname.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nickname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void solution_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            SolutionForm solutionForm = new SolutionForm(pb.Tag.ToString());
            solutionForm.Show();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if(filters.Height == hide_filters.Height + 20) 
            {
                filters.Height = 200;
                hide_filters.Text = "Скрыть";
            }
            else
            {
                filters.Height = hide_filters.Height + 20;
                hide_filters.Text = "Развернуть";
            }
        }

        private void filters_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
