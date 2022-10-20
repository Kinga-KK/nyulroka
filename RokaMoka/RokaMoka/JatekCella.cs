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
        internal string ltag;
        internal Fu fu;
        internal Allat allat;
        private bool free;
        private bool isbunny;






        public JatekCella(string pictureboxtag, int chance)
        {
            ltag = pictureboxtag;
            fu = new Fu(chance / 50);
            allat = new Allat(ltag, chance);  //mindenhova garantáltan generál
            free = false;
        }
        internal bool Free
        {
            get { return free; }
            set { free = value; }
        }

    }
}
