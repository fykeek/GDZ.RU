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
            try
            {
                picture.Load("../../Pictures/" + name + ".jpg");
            }
            catch (Exception) { }
            label = new Label();
            label.Text = name;
            picture.Tag = name;
        }

    }

    public partial class GDZform : System.Windows.Forms.Form
    {
        solution[] solutions = new solution[6];

        public GDZform()
        {
            InitializeComponent();

            nickname.Visible = false;

            solutions[0] = new solution("Русский списование", "Русский", "1-11", 150);
            solutions[1] = new solution("Сообшение по истории 20 в", "История", "9-11", 200);
            solutions[2] = new solution("Русский списование", "Русский", "1-11", 150);
            solutions[3] = new solution("Сообшение по истории 20 в", "История", "9-11", 200);
            solutions[4] = new solution("Русский списование", "Русский", "1-11", 150);
            solutions[5] = new solution("Сообшение по истории 20 в", "История", "9-11", 200);
        }

        public void GDZform_load(object sender, EventArgs e)
        {
            int x = 30;
            int y = 0;
            int n = 0;
            for (int i = 0; i < 6; i++)
            {
                solutions[i].picture.Location = new Point(x, 25 + y);
                solutions[i].picture.Size = new Size(275, 180);
                solutions[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                solutions[i].picture.Click += new EventHandler(solution_Click);
                result.Controls.Add(solutions[i].picture);

                solutions[i].label.Location = new Point(x + 25, 220 + y);
                solutions[i].label.Size = new Size(275, 25);
                result.Controls.Add(solutions[i].label);

                x += 295;
                n++;
                if (n == 4)
                {
                    y += 260;
                    n = 0;
                    x = 30;
                }

            }

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
            for(int i = 0; i<5; i++)
            {
                if(pb.Tag == solutions[i].name)
                {
                    SolutionForm solutionForm = new SolutionForm(solutions[i]);
                    solutionForm.Show();
                    break;
                }
            }
            ;
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
