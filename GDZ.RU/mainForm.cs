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
    public partial class mainForm : System.Windows.Forms.Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void secret_Click(object sender, EventArgs e)
        {
            GDZform mainform = new GDZform();
            mainform.ShowDialog();
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginForm logForm = new loginForm();
            logForm.ShowDialog();
        }

        private void register_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.ShowDialog();
        }
    }
}
