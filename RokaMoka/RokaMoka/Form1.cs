using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RokaMoka
{
    public partial class Form1 : Form
    {
        int sor;
        int oszlop;
        JatekMatrix jatekMatrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            sor = Convert.ToInt32(sorok.Value);
            oszlop = Convert.ToInt32(oszlopok.Value);
            jatekMatrix = new JatekMatrix(sor, oszlop, ref panel);
        }
    }
}
