using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RokaMoka
{
    class JatekMatrix
    {
        Random r = new Random();
        internal static int sor;
        internal static int oszlop;
        int magassag;
        int szelesseg;
        JatekCella[,] jmatrix;
        List<Allat> allatok = new List<Allat>();
        public JatekMatrix(int sorok, int oszlopok, Panel panel,int BN, int FN)
        {
            sor = sorok;
            oszlop = oszlopok;
            magassag = panel.Height / sor;
            szelesseg = panel.Width / oszlop;
            jmatrix = new JatekCella[sor, oszlop];
            JatekterGeneralas(panel, BN, FN);
        }

        private void JatekterGeneralas(Panel panel, int BN, int FN)
        {
            for (int n = 0; n < oszlop; n++)
            {
                for (int m = 0; m < sor; m++)
                {
                    Label p = new Label();
                    tulajdonsagokBeallitasa(p, m, n);
                    jmatrix[m, n] = new JatekCella(n,m, r.Next(0, 100),BN,FN);
                    p.BackColor = fuSzinBeallitas(jmatrix[m, n].fu.TP);
                    if (!jmatrix[m, n].Free)
                      {
                            allatok.Add(jmatrix[m, n].allat);
                            p.Image = jmatrix[m, n].allat.ID[0] == 'B' ?
                            Image.FromFile(@"..\..\img\nyuszi1.png") :
                            Image.FromFile(@"..\..\img\roka1.png");
                      }
                    

                    //can put pictures on like this
                    /* p.Image = r.Next(0, 2) == 1 ? 
                        Image.FromFile(@"..\..\img\nyuszi1.png") : 
                        Image.FromFile(@"..\..\img\roka1.png"); */
                    //can clear like this
                    //p.Image = null;

                    panel.Controls.Add(p);
                }
            }
        }

        private void tulajdonsagokBeallitasa(Label p, int m, int n)
        {
            p.Height = magassag;
            p.Width = szelesseg;
            p.Top = magassag * m;
            p.Left = szelesseg * n;
            p.Tag = $"{m}, {n}";
            p.BorderStyle = BorderStyle.FixedSingle;
            p.ForeColor = System.Drawing.Color.Red;
            p.Font = new System.Drawing.Font("Chiller", 16);
            p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //placeholder for checking correct matrix numbers
            //p.Text = p.Tag.ToString();
        }

        public void ujNap(Panel panel)
        {
            foreach (Label p in panel.Controls)
            {
                string[] vs = p.Tag.ToString().Trim().Split(',').ToArray();
                int m = Convert.ToInt32(vs[0]);
                int n = Convert.ToInt32(vs[1]);
                jmatrix[m, n].fu.No();
                p.BackColor = fuSzinBeallitas(jmatrix[m, n].fu.TP);
                if (!jmatrix[m,n].Free)
                {
                    if (jmatrix[m, n].allat.HP<0)
                    {
                        jmatrix[m, n].allat.Death();
                        jmatrix[m, n].Free=true;
                        jmatrix[m, n].ID = "";
                    };
                    p.Image = jmatrix[m, n].allat.ID[0] == 'B' ?
                            Image.FromFile(@"..\..\img\nyuszi1.png") :
                            Image.FromFile(@"..\..\img\roka1.png");


                    
                    jmatrix[m, n].allat.HP--;
                }
                else
                {

                }
            }
        }

        private Color fuSzinBeallitas(int tp)
        {
            if (tp == 0)
            {
                return Color.FromArgb(220, 123, 67);
            }
            else if (tp == 1)
            {
                return Color.FromArgb(109, 223, 109);
            }
            else
            {
                return Color.FromArgb(0, 127, 0);
            }
        }
        
    }
}
