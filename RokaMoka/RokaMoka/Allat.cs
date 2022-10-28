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
        //ő nincsen hozzákötve a hp-hoz, ezért automatikusan legenerál magának egy privát adattagot.
        //ha nem kéne lekezelni/konstruktorban kezeljük le, akkor lehet sima publikus/internal automatikus tulajdonság
        // -> internal int HP { get; set; }
        //internal int HP; 
        internal bool IsBunny; //todo: ami ezekből tulajdonság az kapjon { get; set; }-et
        internal string ID;
        internal string ltag;
        private int idseged;
        
        internal int HP
        {
            get 
            {
                return hp;
            } 
            set
            {   //ha nyuszi és 5-nél nagyobb hp-t kapna, akkor csak 5-öt kap, egyébként az értéket 
                if(IsBunny && value > 5)
                {
                    hp = 5;
                }
                else if(IsBunny)
                {
                    hp = value;
                }
                //mint a fenti, csak róka és 10-nél nem lehet nagyobb
                if(!IsBunny && value > 10)
                {
                    hp = 10;
                }
                else if(!IsBunny)
                {
                    hp = value;
                }
            }
        }

        public Allat(string pictureboxtag, int chance)
        {
            ltag = pictureboxtag;
            IsBunny = (chance - 20) > 0;
            HP = IsBunny ? 3 : 5;
        }
        internal void IDmkr() //Id maker
        {
            if (IsBunny==true)
            {
                ID = "B" + idseged; //Bunny
                idseged++;
            }
            else
            {
                ID = "F" + idseged; //Fox
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
