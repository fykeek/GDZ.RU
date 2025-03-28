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
        public int from_class;
        public int to_class;
        public PictureBox picture;
        public Label label;

        public solution(string _name, string _subject, string _clas_s, int _price, int _fromc, int _toc)
        {
            name = _name;
            subject = _subject;
            clas_s = _clas_s;
            price = _price;
            from_class = _fromc;
            to_class = _toc;
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
        public static List<solution> solutions = new List<solution>();

        public GDZform()
        {
            InitializeComponent();

            nickname.Text = loginForm.username;

            if(loginForm.admin)
            {
                nickname.Text += " Админ";
                help_button.Visible = true;
            }
            else
            {
                help_button.Visible = false;
            }

            if (loginForm.username != "Гость")
            {
                like_button.Visible = true;
            }
            else 
            {
                like_button.Visible = false;
            }
        }

        public void GDZform_load(object sender, EventArgs e)
        {
            solutions.Clear();
            string[] strs = System.IO.File.ReadAllLines("../../Pictures/solution.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                solution solutio = new solution(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]),
                                                 Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]));
                solutions.Add(solutio);
            }
            result.Controls.Clear();

            int x = 51;
            int y = 0;
            for (int i = 0; i < solutions.Count; i++)
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
                if (x + 295 > result.Width)
                {
                    y += 260;
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
            for(int i = 0; i < solutions.Count; i++)
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
            if(filters_panel.Height == hide_filters.Height + 20) 
            {
                filters_panel.Height = 200;
                hide_filters.Text = "Скрыть";
            }
            else
            {
                filters_panel.Height = hide_filters.Height + 20;
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
            for (int i = 0; i < solutions.Count; i++)
            {

                solutions[i].picture.Visible = true;
                solutions[i].label.Visible = true;

                if((comboBox_subject.Text != "" && comboBox_subject.Text != solutions[i].subject) ||
                    (write_name_ans.Text != "" && !solutions[i].name.Contains(write_name_ans.Text)) ||
                    (class_box.Text != "" && (solutions[i].from_class > Convert.ToInt32(class_box.Text) ||
                    solutions[i].to_class < Convert.ToInt32(class_box.Text))))
                {
                    solutions[i].picture.Visible = false;
                    solutions[i].label.Visible = false;
                }

                if (solutions[i].picture.Visible)
                {
                    solutions[i].picture.Location = new Point(x, 25 + y);
                    solutions[i].label.Location = new Point(x + 25, 220 + y);

                    x += 295;
                    if (x + 295 > result.Width)
                    {
                        y += 260;
                        x = 30;
                    }
                }
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GDZ_Resize(object sender, EventArgs e)
        {
            find_button_Click(null, null);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            loginForm.username = "Гость";
            loginForm.admin = false;
            MessageBox.Show("Вы вышли из аккаунта");
            Close();
        }

        private void addSolutiun_Click(object sender, EventArgs e)
        {
            if (loginForm.admin)
            {
                addForm addform = new addForm();
                addform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно прав");
            }
            GDZform_load(null, null);
        }

        private void help_Click(object sender, EventArgs e)
        {
            HelpForm helpform = new HelpForm();
            helpform.Show();
        }

        private void deleteSolution_Click(object sender, EventArgs e)
        {
            if (loginForm.admin)
            {
                delForm deleForm = new delForm();
                deleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Недостаточно прав");
            }
            GDZform_load(null, null);
        }

        private void like_button_Click(object sender, EventArgs e)
        {
            likeForm likeForm = new likeForm();
            likeForm.ShowDialog();
        }
    }
}
