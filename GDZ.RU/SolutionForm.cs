using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GDZ.RU
{   

    public partial class SolutionForm : System.Windows.Forms.Form
    {
        string solut = "";
        solution sol;

        public SolutionForm(solution _sol)
        {
            InitializeComponent();

            sol = _sol;

            Solutionlabel.Text = _sol.name;
            try
            {
                SolutionPic.Load("../../Pictures/" + _sol.name + ".jpg");
            }
            catch (Exception) { }
            Text = _sol.name;
            subjectLabel.Text = "Предмет: " + _sol.subject;
            classLabel.Text = "Класс: " + _sol.clas_s;
            priceLabel.Text = "Цена: " + _sol.price.ToString();

            try
            {
                opisTextBox.Text = System.IO.File.ReadAllText("../../Pictures/" + _sol.name + ".txt");
            }
            catch (Exception) { }

            if(loginForm.admin)
            {
                opisTextBox.ReadOnly = false;
                sol_replase.Visible = true;
                toclassTB.Visible = true;
                fronclassTB.Visible = true;
                label1.Visible = true;
                rename_opis.Visible = true;
                subject_TextBox.Visible = true;
                class_TextBox.Visible = true;
                price_TextBox.Visible = true;
                select_button.Visible = true;
            }
            else
            {
                opisTextBox.ReadOnly = true;
                sol_replase.Visible = false;
                toclassTB.Visible = false;
                fronclassTB.Visible = false;
                label1.Visible = false;
                rename_opis.Visible = false;
                subject_TextBox.Visible = false;
                class_TextBox.Visible = false;
                price_TextBox.Visible = false;
                select_button.Visible = false;
            }

            solut = _sol.name;
        }

        private void SolutionPic_Click(object sender, EventArgs e)
        {

        }

        private void SolutionForm_Load(object sender, EventArgs e)
        {

        }

        private void Solutionlabel_Click(object sender, EventArgs e)
        {

        }

        private void rename_opis_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("../../Pictures/" + solut + ".txt", opisTextBox.Text);
        }

        private void sol_replase_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("../../Pictures/solution.txt");
            for (int i = 0; i < GDZform.solutions.Count; i++)
            {
                if (solut != GDZform.solutions[i].name)
                {
                    System.IO.File.AppendAllText("../../Pictures/solution.txt", GDZform.solutions[i].name + ", " +
                                                                                GDZform.solutions[i].subject + ", " +
                                                                                GDZform.solutions[i].clas_s + ", " +
                                                                                GDZform.solutions[i].price + ", " +
                                                                                GDZform.solutions[i].from_class + ", " +
                                                                                GDZform.solutions[i].to_class +
                                                                                Environment.NewLine);
                }
                else
                {
                    System.IO.File.AppendAllText("../../Pictures/solution.txt", GDZform.solutions[i].name + ", " +
                                                                                subject_TextBox.Text + ", " +
                                                                                class_TextBox.Text + ", " +
                                                                                price_TextBox.Text + ", " +
                                                                                toclassTB.Text + ", " +
                                                                                fronclassTB.Text +
                                                                                Environment.NewLine);
                }
            }
            MessageBox.Show("Вы заменили параметры");
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            if (likeForm.select_solutions.ContainsKey(sol))
            {
                likeForm.select_solutions[sol]++;
            }
            else
            {
                likeForm.select_solutions.Add(sol, 1);
            }
        }
    }
}
