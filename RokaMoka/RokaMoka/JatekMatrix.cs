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
        JatekCella[,] jmatrix;
        public JatekMatrix(int sorok, int oszlopok, Panel panel)
        {
            sor = sorok;
            oszlop = oszlopok;
            magassag = panel.Height / sor;
            szelesseg = panel.Width / oszlop;
            jmatrix = new JatekCella[sor, oszlop];
            JatekterGeneralas(panel);
        }

        private void JatekterGeneralas(Panel panel)
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

                    //placeholder for checking correct matrix numbers
                    //p.Text = p.Tag.ToString();
                    p.ForeColor = System.Drawing.Color.Red;
                    p.Font = new System.Drawing.Font("Chiller", 16);
                    p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    jmatrix[m, n] = new JatekCella(p.Tag.ToString(), r.Next(1, 101));
                    p.Text = jmatrix[m, n].fu.TP.ToString();

                    panel.Controls.Add(p);
                }
            }
        }

        public void ujNap(Panel panel)
        {
            foreach (Control p in panel.Controls)
            {
                string[] vs = p.Tag.ToString().Trim().Split(',').ToArray();
                int m = Convert.ToInt32(vs[0]);
                int n = Convert.ToInt32(vs[1]);
                jmatrix[m, n].fu.No();
                p.Text = jmatrix[m, n].fu.TP.ToString();
            }
        }
        
    }
}
