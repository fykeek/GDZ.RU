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
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        string FileName = "";

        private void add_button_Click(object sender, EventArgs e)
        {
            if (name_TB.Text == "" || subject_CB.Text == "" || class_TB.Text == "" || price_NU.Value == 0 ||
                class_min.Value <= 0 || class_max.Value > 11 || class_max.Value == 0 || FileName == "")
            {
                MessageBox.Show("Не введены все данные, картинка или класс не входит в промежуток 1-11");
                return;
            }
            else
            {
                System.IO.File.AppendAllText("../../Pictures/solution.txt", name_TB.Text + ", " +
                                                                            subject_CB.Text + ", " +
                                                                            class_TB.Text + ", " +
                                                                            price_NU.Value + ", " +
                                                                            class_min.Value + ", " +
                                                                            class_max.Value + 
                                                                            Environment.NewLine);
                System.IO.File.Copy(FileName, "../../Pictures/" + name_TB.Text + ".jpg");
                MessageBox.Show("Вы добавили задачу. Чтобы она появилась войдите в аккаунт заново");
                Close();
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                pictureBox1.Load(FileName);
            }
        }
    }
}
