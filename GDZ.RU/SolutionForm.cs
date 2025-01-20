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
    public partial class SolutionForm : System.Windows.Forms.Form
    {
        public SolutionForm(string solutin_Text)
        {
            InitializeComponent();
            Solutionlabel.Text = solutin_Text;
            SolutionPic.Load("../../Pictures/" + solutin_Text + ".jpg");
            Text = solutin_Text;
        }

        private void SolutionPic_Click(object sender, EventArgs e)
        {

        }

        private void SolutionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
