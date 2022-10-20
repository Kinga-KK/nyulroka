using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace RokaMoka
{
    public partial class Form1 : Form
    {
        bool running = false;
        int seconds;
        //set maximum of numericupdowns to different values later
        int sor;
        int oszlop;
        JatekMatrix jatekMatrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (running == false)
            {
                elemekRejtese();
                sor = Convert.ToInt32(sorok.Value);
                oszlop = Convert.ToInt32(oszlopok.Value);
                jatekMatrix = new JatekMatrix(sor, oszlop, panel);
                timer1.Enabled = true;
                Start.Text = "Szünet";
                running = true;
            }
            else if (Start.Text == "Szünet")
            {
                timer1.Stop();
                Start.Text = "Folytat";
            }
            else
            {
                timer1.Start();
                Start.Text = "Szünet";
            }
        }

        private void elemekRejtese()
        {
            //Start.Visible = false;
            oszlopok.Visible = false;
            sorok.Visible = false;
            labelX.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"Eltelt idő: {++seconds}";
            jatekMatrix.ujNap(panel);
        }
    }
}
