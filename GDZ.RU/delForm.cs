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
    public partial class delForm : Form
    {
        public delForm()
        {
            InitializeComponent();
            for(int i = 0;  i < GDZform.solutions.Count; i++)
            {
                delComboBox.Items.Add(GDZform.solutions[i].name);
            }
        }

        private void delForm_Load(object sender, EventArgs e)
        {
            
        }

        private void delComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            delTextBox.Text = delComboBox.Text;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите удалить обьект?", "Удаление обьекта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.IO.File.Delete("../../Pictures/solution.txt");
                for (int i = 0; i < GDZform.solutions.Count; i++)
                {
                    if (delTextBox.Text != GDZform.solutions[i].name)
                    {
                        System.IO.File.AppendAllText("../../Pictures/solution.txt", GDZform.solutions[i].name + ", " +
                                                                                    GDZform.solutions[i].subject + ", " +
                                                                                    GDZform.solutions[i].clas_s + ", " +
                                                                                    GDZform.solutions[i].price + ", " +
                                                                                    GDZform.solutions[i].from_class + ", " +
                                                                                    GDZform.solutions[i].to_class +
                                                                                    Environment.NewLine);
                    }
                }
                MessageBox.Show("Вы удалили задачу");
                Close();
            }
        }
    }
}
