using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RokaMoka
{
    class JatekMatrix
    {
        Random r = new Random();
        int sor;
        int oszlop;
        int magassag;
        int szelesseg;
        JatekCella[,] matrix;
        public JatekMatrix(int sorok, int oszlopok, ref Panel panel)
        {
            sor = sorok;
            oszlop = oszlopok;
            magassag = panel.Height / sor;
            szelesseg = panel.Width / oszlop;
            matrix = new JatekCella[sor, oszlop];
            JatekterGeneralas(ref panel);
        }

        private void JatekterGeneralas(ref Panel panel)
        {
            for (int n = 0; n < oszlop; n++)
            {
                for (int m = 0; m < sor; m++)
                {
                    //PictureBox p = new PictureBox();
                    Label p = new Label(); //take out later
                    p.Height = magassag;
                    p.Width = szelesseg;
                    p.Top = magassag * m;
                    p.Left = szelesseg * n;
                    //note: ezeket a játékcella osztályban kell talán hm
                    //p.BackgroundImage = //fűképe
                    //p.Image = //állatképe
                    p.Tag = $"{m}, {n}";
                    p.BorderStyle = BorderStyle.FixedSingle;

                    //placeholder for checking
                    p.Text = p.Tag.ToString();
                    p.ForeColor = System.Drawing.Color.Red;
                    p.Font = new System.Drawing.Font("Chiller", 16);
                    p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    matrix[m, n] = new JatekCella(p.Tag.ToString(), r.Next(1, 101));

                    panel.Controls.Add(p);
                }
            }
        }

    }
}
