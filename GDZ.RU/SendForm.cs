using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GDZ.RU
{
    public partial class SendForm : Form
    {
        public SendForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromAdress = new MailAddress("gdz.ru322@mail.ru");

            if (adress.Text != "")
            {
                MailAddress toAdress = new MailAddress(adress.Text);

                using (MailMessage mail_message = new MailMessage(fromAdress, toAdress))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    mail_message.Subject = "Ваша корзина из приложения GDZ.RU";

                    mail_message.Body = "";
                    mail_message.IsBodyHtml = true;

                    System.IO.File.AppendAllText("Избранное_" + loginForm.username + ".csv", "Название;Количество;Цена");
                    foreach(KeyValuePair<solution, int> select_product in likeForm.select_solutions)
                    {
                        solution sol = select_product.Key;
                        System.IO.File.AppendAllText("Избранное_" + loginForm.username + ".csv", Environment.NewLine + sol.name + ";" +
                                                                                                select_product.Value + ";" + sol.price);
                    }

                    System.IO.File.AppendAllText("Избранное_" + loginForm.username + ".csv", Environment.NewLine + ";Общая стоимость;" + likeForm.totalPrice);

                    mail_message.Attachments.Add(new Attachment("Избранное_" + loginForm.username + ".csv"));

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
                MessageBox.Show("Напишите эл. почту");
            }
        }
    }
}
