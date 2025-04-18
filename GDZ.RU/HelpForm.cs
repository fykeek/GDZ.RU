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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            if (loginForm.admin)
            {
                label1.Text = System.IO.File.ReadAllText("../../helptext/helpadmin.txt");
            }
            else
            {
                label1.Text = "you are moshonka";
            }
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
