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

    public struct solution
    {
        public string name;
        public string subject;
        public string clas_s;
        public int price;
        public PictureBox picture;
        public Label label;

        public solution(string _name, string _subject, string _clas_s, int _price)
        {
            name = _name;
            subject = _subject;
            clas_s = _clas_s;
            price = _price;
            picture = new PictureBox();
            picture.Load("../../Pictures/" + name + ".jpg");
            label = new Label();
            label.Text = name;
        }

    }

    public partial class GDZform : System.Windows.Forms.Form
    {
        List<solution> solutions = new List<solution>;

        public GDZform()
        {
            InitializeComponent();

            nickname.Visible = false;
            solutions[0] = new solution("Русский списование", "Русский", "1-11", 150);
            solutions[1] = new solution("Сообшение по истории 20 в.", "История", "9-11", 200);
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
