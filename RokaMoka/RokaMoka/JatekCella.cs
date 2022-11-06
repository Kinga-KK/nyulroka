using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RokaMoka
{
    class JatekCella
    {
        internal static string ltag;
        internal Fu fu;
        internal Allat allat;
        internal bool free;
        internal string ID;
        private readonly int sor;
        private readonly int oszlop;






        public JatekCella(int n,int m, int chance,int BN, int FN)
        {
            ltag = n+","+m;
            sor = n;
            oszlop = m;
            fu = new Fu(chance / 50);

            if (chance>50)
            {
                allat = new Allat(sor,oszlop, chance, BN, FN);
                Free = false;
                ID = allat.ID;
            }
            else
            {
                free = true;
            }

            
        }
        internal bool Free
        {
            get { return free; }
            set { free = value; }
        }
        internal void MakeFree()
        {
            Free = true;
            ID = "";

        }
        internal void MakeBusy(string id)
        {
            ID = id;
            Free = false;
        }

    }
}
