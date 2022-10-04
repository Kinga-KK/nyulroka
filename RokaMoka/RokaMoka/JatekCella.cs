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
        internal string ptag;
        internal Fu fu;
        public JatekCella(string pictureboxtag, int chance)
        {
            ptag = pictureboxtag;
            fu = new Fu(chance / 50);
        }
    }
}
