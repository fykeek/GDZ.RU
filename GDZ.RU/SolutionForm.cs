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
        public SolutionForm(solution sol)
        {
            InitializeComponent();
            Solutionlabel.Text = sol.name;
            try
            {
                SolutionPic.Load("../../Pictures/" + sol.name + ".jpg");
            }
            catch (Exception) { }
            Text = sol.name;
            subjectLabel.Text = "Предмет: " + sol.subject;
            classLabel.Text = "Класс: " + sol.clas_s;
            priceLabel.Text = "Цена: " + sol.price.ToString();

            try
            {
                opisTextBox.Text = System.IO.File.ReadAllText("../../Pictures/" + sol.name + ".txt");
            }
            catch (Exception) { }
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
    }
}
