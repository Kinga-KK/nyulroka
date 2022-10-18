using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokaMoka
{
    class Fu
    {
        private int tp;
        internal int TP 
        { 
            get => tp; 
            private set
            {
                if (value >= 0 && value <= 2)
                {
                    tp = value;
                }
                else
                {
                    tp = 0;
                }
            }
        }
        public Fu(int kezdoTP)
        {
            TP = kezdoTP;
        }

        internal void No()
        {
            if (TP != 2)
            {
                TP++;
            }
        }

        internal void Csokken()
        {
            if (TP != 0)
            {
                TP--;
            }
        }
    }
}
