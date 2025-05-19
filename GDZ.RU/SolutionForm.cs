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
                //sol_replase.Visible = true;
                rename_opis.Visible = true;
                subject_TextBox.Visible = true;
                class_TextBox.Visible = true;
                price_TextBox.Visible = true;
            }
            else
            {
                opisTextBox.ReadOnly = true;
                //sol_replase.Visible = false;
                rename_opis.Visible = false;
                subject_TextBox.Visible = false;
                class_TextBox.Visible = false;
                price_TextBox.Visible = false;
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
            /*string[] strs = System.IO.File.ReadAllLines("../../Pictures/solution.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                if(solut == parts[0])
                {
                    parts[1] = subject_TextBox.Text;
                    parts[2] = class_TextBox.Text;
                    parts[3] = price_TextBox.Text;
                }
            }*/
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
