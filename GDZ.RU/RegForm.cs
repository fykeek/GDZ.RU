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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            error_text.Visible = false; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            if(password_person.Text == return_password.Text)
            {
                if (name_person.Text != "" && secondname_person.Text != "" &&
                    login_person.Text != "" && password_person.Text != "")
                {
                    System.IO.File.AppendAllText("../../users/users.txt", name_person.Text + ", " +
                                                                    secondname_person.Text + ", " +
                                                                    login_person.Text + ", " +
                                                                    password_person.Text + ", user" +
                                                                    Environment.NewLine);
                    MessageBox.Show("Вы прошли регистрацию!");
                    Close();
                }
                else
                {
                    error_text.Visible = true;
                    error_text.Text = "Не заполнены обязательные поля";
                }
            }
            else if(password_person.Text != return_password.Text)
            {
                error_text.Visible = true;
                error_text.Text = "Пароли не совпадают";
            }
        }
    }
}
