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
    public partial class loginForm : Form
    {
        public static string username = "";
        public static string mailUser = "";
        public static bool admin = false;

        public loginForm()
        {
            InitializeComponent();
            error_text.Visible = false;
        }

        private void password_person_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_Click(object sender, EventArgs e)
        {

        }

        private void login_person_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_text_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string[] strs = System.IO.File.ReadAllLines("../../users/users.txt");
            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                if(login_person.Text == parts[2] && password_person.Text == parts[3])
                {   
                    username = parts[0] + " " + parts[1];
                    mailUser = parts[5];
                    if (parts[4] == "admin") {admin = true;}
                    MessageBox.Show("Вы вошли в аккаунт!");
                    Close();
                    GDZform gdzform = new GDZform();
                    gdzform.ShowDialog();
                    return;
                }
            }

            error_text.Visible = true;
            error_text.Text = "Введен неверный логин/пароль";

        }
    }
}
