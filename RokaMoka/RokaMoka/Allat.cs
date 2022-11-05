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
        internal bool IsBunny;
        internal string ID;
        internal string ltag;
        private static int idseged = 0;
        internal static int dead = 0;
        private int sor;
        private int oszlop;


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
        internal static int Live
        {
            get
            {
                return idseged - dead;
            }
        }

        public Allat(int n,int m, int chance,int BN, int FN)
        {
            IsBunny = chance < BN;
            //IsBunny = (chance-20) > 50;
            HP = IsBunny ? 3 : 5;
            IDmkr();
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
                if (sor<1)
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
            dead++;
        }






    }
}
