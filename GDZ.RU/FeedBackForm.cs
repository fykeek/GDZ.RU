using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Net;

namespace GDZ.RU
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }
        private void mes_button_Click(object sender, EventArgs e)
        {
            MailAddress fromAdress = new MailAddress("gdz.ru322@mail.ru");

            if(comboBox1.Text != "")
            {
                MailAddress toAdress = new MailAddress("gdz.ru322@mail.ru");

                using (MailMessage mail_message = new MailMessage(fromAdress, toAdress))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    mail_message.Subject = comboBox1.Text;

                    mail_message.Body = textBox1.Text;
                    mail_message.IsBodyHtml = true;

                    smtpClient.Host = "smtp.mail.ru";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "mhf9zjaQ6xb7cLsNeGtt");

                    smtpClient.Send(mail_message);

                }

                MessageBox.Show("Вы отправили сообщение");
                Close();
            }
            else
            {
                MessageBox.Show("Выберете категорию");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FeedBackForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
