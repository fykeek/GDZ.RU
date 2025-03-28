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

        public likeForm()
        {
            InitializeComponent();

            int x = 51;
            int y = 0;
            foreach(KeyValuePair<solution, int> select_sol_ in select_solutions)
            {
                solution select_sol = select_sol_.Key;

                PictureBox pic = new PictureBox();
                pic.Location = new Point(x, 25 + y);
                pic.Size = new Size(275, 180);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = select_sol.picture.Image;
                Controls.Add(pic);

                Label lbl = new Label();
                lbl.Location = new Point(x + 300, y + 120);
                lbl.Size = new Size(275, 30);
                lbl.Text = "Кол-во:" + select_sol_.Value.ToString();
                Controls.Add(lbl);

                y += 260;

            }
        }

        private void likeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
