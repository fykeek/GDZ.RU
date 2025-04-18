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
    public partial class likeForm : Form
    {
        public static Dictionary<solution, int> select_solutions = new Dictionary<solution, int>();

        int totalPrice = 0;

        public likeForm()
        {
            InitializeComponent();

            ReDraw();
        }

        void ReDraw()
        {   
            Controls.Clear();
            Controls.Add(label1);
            Calculate();
            label1.Text = "Итоговая стоимость: " + totalPrice.ToString();

            int x = 51;
            int y = 150;
            foreach (KeyValuePair<solution, int> select_sol_ in select_solutions)
            {
                solution select_sol = select_sol_.Key;

                #region 1 столбец - Картинка
                PictureBox pic = new PictureBox();
                pic.Location = new Point(x, 25 + y);
                pic.Size = new Size(275, 180);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = select_sol.picture.Image;
                Controls.Add(pic);
                #endregion

                #region 2 столбец - Характеристика
                Label name_lbl = new Label();
                name_lbl.Location = new Point(x + 300, y + 30);
                name_lbl.Size = new Size(400, 30);
                name_lbl.Text = "Название: " + select_sol_.Key.name;
                Controls.Add(name_lbl);

                Label sub_lbl = new Label();
                sub_lbl.Location = new Point(x + 300, y + 60);
                sub_lbl.Size = new Size(300, 30);
                sub_lbl.Text = "Категория: " + select_sol_.Key.subject;
                Controls.Add(sub_lbl);

                Label class_lbl = new Label();
                class_lbl.Location = new Point(x + 300, y + 90);
                class_lbl.Size = new Size(275, 30);
                class_lbl.Text = "Класс: " + select_sol_.Key.clas_s;
                Controls.Add(class_lbl);

                Label price_lbl = new Label();
                price_lbl.Location = new Point(x + 300, y + 120);
                price_lbl.Size = new Size(275, 30);
                price_lbl.Text = "Цена: " + select_sol_.Key.price.ToString();
                Controls.Add(price_lbl);

                Button opis_bt = new Button();
                opis_bt.Location = new Point(x + 300, y + 160);
                opis_bt.Size = new Size(300, 50);
                opis_bt.Text = "К описанию";
                opis_bt.Tag = name_lbl.Text;
                opis_bt.Click += new EventHandler(solution_Click);
                Controls.Add(opis_bt);
                #endregion

                #region 3 столбец - кол-во
                Label kol_lbl = new Label();
                kol_lbl.Location = new Point(x + 700, y + 30);
                kol_lbl.Size = new Size(275, 30);
                kol_lbl.Text = "Количество:";
                Controls.Add(kol_lbl);

                NumericUpDown kol = new NumericUpDown();
                kol.Location = new Point(x + 700, y + 60);
                kol.Size = new Size(75, 20);
                kol.Value = select_sol_.Value;
                kol.ValueChanged += new EventHandler(count_changed);
                Controls.Add(kol);

                Label sto_lbl = new Label();
                sto_lbl.Location = new Point(x + 700, y + 90);
                sto_lbl.Size = new Size(275, 30);
                sto_lbl.Text = "Стоимость: " + (select_sol_.Key.price * kol.Value).ToString();
                Controls.Add(sto_lbl);
                #endregion

                #region 4 столбец - удаление
                Button btn_del = new Button();
                btn_del.Location = new Point(x + 700, y + 130);
                btn_del.Size = new Size(300, 50);
                btn_del.Text = "Удалить";
                btn_del.Click += new EventHandler(delCLick);
                Controls.Add(btn_del);
                #endregion

                y += 260;

            }
        }

        private void count_changed(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;

            for(int i = 0; i < select_solutions.Count; i++)
            {

                if(num.Location == new Point(751, 260*i + 210 + AutoScrollPosition.Y))
                {
                    int price = 0;
                    String name = "";

                    foreach(Control ctrl in Controls)
                    {
                        if(ctrl is Label && ctrl.Location == new Point(351, 260 * i + 270 + AutoScrollPosition.Y))
                        {
                            price = Convert.ToInt32(ctrl.Text.Replace("Цена: ", ""));
                        }
                    }

                    foreach (Control ctrl in Controls)
                    {
                        if (ctrl is Label && ctrl.Location == new Point(751, 260 * i + 240 + AutoScrollPosition.Y))
                        {
                            ctrl.Text = "Стоимость: " + (price * num.Value).ToString();
                        }
                    }
                
                    foreach(Control ctrl in Controls)
                    {
                        if(ctrl is Label && ctrl.Location == new Point(351, 260 * i + 180 + AutoScrollPosition.Y))
                        {
                            name = ctrl.Text.Replace("Название: ", "");
                        }
                    }

                    foreach(solution sol in GDZform.solutions)
                    {
                        if(sol.name == name)
                        {
                            select_solutions[sol] = Convert.ToInt32(num.Value);
                        }
                    }
                }
            }
            Calculate();
            label1.Text = "Итоговая стоимость: " + totalPrice.ToString();
        }

        private void solution_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach(KeyValuePair<solution, int> select in select_solutions)
            {
                if (btn.Tag.ToString() == select.Key.name)
                {
                    SolutionForm solutionForm = new SolutionForm(select.Key);
                    solutionForm.Show();
                    break;
                }
            }

        }
        private void likeForm_Load(object sender, EventArgs e)
        {

        }

        void Calculate()
        {
            totalPrice = 0;

            foreach(KeyValuePair<solution, int> select in select_solutions)
            {
                totalPrice += select.Value * select.Key.price;
            }
        }
    
        private void delCLick(object sender, EventArgs e)
        {
            int i = 0;
            Dictionary<solution, int> selSol = new Dictionary<solution, int>();
            Button btn = (Button)sender;
            foreach(KeyValuePair<solution, int> selectSol1 in select_solutions)
            {
                solution select_sol = selectSol1.Key;
                if(btn.Location == new Point(751, 260 * i + 280 + AutoScrollPosition.Y))
                {
                
                }
                else
                {
                    selSol[selectSol1.Key] = selectSol1.Value;
                }
                i++;
            }
            select_solutions = selSol;
            ReDraw();
        }
    }
}
