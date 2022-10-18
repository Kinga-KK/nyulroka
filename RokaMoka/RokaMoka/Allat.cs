using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokaMoka
{
    class Allat
    {
        private int hp;
        internal int HP;
        internal bool IsBunny;
        internal string ID;
        internal string ltag;
        private int idseged;
        


        public Allat(string pictureboxtag, int chance)
        {
            ltag = pictureboxtag;
            IsBunny = (chance - 20) > 0;
        }
        internal void IDmkr() //Id maker
        {
            if (IsBunny==true)
            {
                ID = "B" + idseged;
                idseged++;
            }
            else
            {
                ID = "F" + idseged;
                idseged++;
            }
        }
        internal void Mozog()
        {
            if (IsBunny==true)
            {
                if (2>0)
                {

                }




            }
            else
            {

            }
        }
        internal void Sex()
        {
            if (true)
            {

            }
        }
        internal void Death()
        {
            if (HP<0)
            {

            }
        }






    }
}
