using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        static int count_solution = 11;

        solution[] solutions = new solution[count_solution];

        public GDZform()
        {
            InitializeComponent();

            nickname.Visible = false;

            solutions[0] = new solution("Списование", "Русский", "1-11", 150);
            solutions[1] = new solution("Сообшение по истории 20 в", "История", "9-11", 200);
            solutions[2] = new solution("Сложение вычитание", "Математика", "1-4", 50);
            solutions[3] = new solution("Задания по биологии", "Биология", "9-11", 150);
            solutions[4] = new solution("Сочинение", "Литиратура", "1-11", 100);
            solutions[5] = new solution("Уравнения", "Алгебра", "5-8", 150);
            solutions[6] = new solution("Задачи по физике", "Физика", "7-11", 150);
            solutions[7] = new solution("Задачи по геометрии", "Геометрия", "7-11", 150);
            solutions[8] = new solution("Сообщение по биологии", "Биология", "5-11", 150);
            solutions[9] = new solution("Квадратные уравнения", "Алгебра", "8-11", 200);
            solutions[10] = new solution("Задачи по математике", "Математика", "1-4", 50);
        }

        public void GDZform_load(object sender, EventArgs e)
        {
            int x = 51;
            int y = 0;
            int n = 0;
            for (int i = 0; i < count_solution; i++)
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
            for(int i = 0; i < count_solution; i++)
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

        private void find_button_Click(object sender, EventArgs e)
        {
            int x = 51;
            int y = 0;
            int n = 0;
            for (int i = 0; i < count_solution; i++)
            {

                solutions[i].picture.Visible = true;
                solutions[i].label.Visible = true;

                if(comboBox_subject.Text != "" && comboBox_subject.Text != solutions[i].subject)
                {
                    solutions[i].picture.Visible = false;
                    solutions[i].label.Visible = false;
                }

                if (solutions[i].picture.Visible)
                {
                    solutions[i].picture.Location = new Point(x, 25 + y);
                    solutions[i].label.Location = new Point(x + 25, 220 + y);

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
        }   
    }
}
