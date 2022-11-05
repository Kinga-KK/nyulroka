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
        internal bool IsBunny;
        internal string ID;
        //internal string ltag;
        private static int idseged = 0;
        internal static int dead = 0;
        private int sor;
        private int oszlop;
        //internal JatekCella jatekCella;
        internal string[] szabadmezok = new string[25];
        internal string[] foglaltmezok = new string[25];

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
            sor = n-1;
            oszlop = m-1;
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
        private void Scan()
        {
            int szmezo = 0;
            int fmezo = 0;
            
            if (IsBunny == true)
            {
                #region Bunny
                if (sor == 0)
                {
                    for (int i = sor; i < sor++; i++)
                    {
                        if (oszlop == 0) //{0,0} left,up
                        {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                        }
                        else if (oszlop+1==JatekMatrix.oszlop) //{0,49} left,down
                        {
                                for (int d = oszlop; d < oszlop++; d++)
                                {
                                    if (JatekCella.free == true)
                                    {
                                        szabadmezok[szmezo] = JatekCella.ltag;
                                        szmezo++;
                                    }
                                    else
                                    {
                                        foglaltmezok[szmezo] = JatekCella.ltag;
                                        fmezo++;
                                    }
                                }

                        }
                        else //{0,1-48} in-between
                        {
                            for (int d = oszlop; d < oszlop++; d++) 
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }

                    }
                }
                if (sor == 0)
                {
                    for (int i = sor; i < sor++; i++)
                    {
                        if (oszlop == 0) //{0,0} left,up
                        {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                        }
                        else if (oszlop+1==JatekMatrix.oszlop) //{0,49} left,down
                        {
                                for (int d = oszlop; d < oszlop++; d++)
                                {
                                    if (JatekCella.free == true)
                                    {
                                        szabadmezok[szmezo] = JatekCella.ltag;
                                        szmezo++;
                                    }
                                    else
                                    {
                                        foglaltmezok[szmezo] = JatekCella.ltag;
                                        fmezo++;
                                    }
                                }

                        }
                        else //{0,1-48} in-between
                        {
                            for (int d = oszlop; d < oszlop++; d++) 
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }

                    }
                }
                else if (sor+1 == JatekMatrix.sor)
                {
                    for (int i = sor; i < sor++; i++)
                    {
                        if (oszlop == 0) //{49,0) right up
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }
                        else if (oszlop + 1 == JatekMatrix.oszlop) //{49,49} right down
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else
                        {
                            for (int d = oszlop; d < oszlop++; d++) //{49,1-48} in-between
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }
                    }
                }
                else //{1-49,1-49} anywhere not border
                {
                    for (int i = sor; i < sor++; i++)
                    {
                        for (int d = oszlop; d < oszlop++; d++)
                        {
                            if (JatekCella.free == true)
                            {
                                szabadmezok[szmezo] = JatekCella.ltag;
                                szmezo++;
                            }
                            else
                            {
                                foglaltmezok[szmezo] = JatekCella.ltag;
                                fmezo++;
                            }
                        }
                    }
                }
                #endregion
            }
            else
            {
                #region Fox
                if (sor == 0)
                {
                    for (int i = sor; i < sor++; i++)
                    {
                        if (oszlop == 0) //{0,0} left,up
                        {
                            if (JatekCella.free == true)
                            {
                                szabadmezok[szmezo] = JatekCella.ltag;
                                szmezo++;
                            }
                            else
                            {
                                foglaltmezok[szmezo] = JatekCella.ltag;
                                fmezo++;
                            }
                        }
                        if (oszlop == 1) //{0,1} left,up
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else if (oszlop + 2 == JatekMatrix.oszlop + 1) //{0,48} left,down
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else if (oszlop + 1 == JatekMatrix.oszlop) //{0,49} left,down
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else //{0,2-47} in-between
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }

                    }
                }
                if (sor == 1)
                {
                    for (int i = sor; i < sor++; i++)
                    {
                        if (oszlop == 0) //{0,0} left,up
                        {
                            if (JatekCella.free == true)
                            {
                                szabadmezok[szmezo] = JatekCella.ltag;
                                szmezo++;
                            }
                            else
                            {
                                foglaltmezok[szmezo] = JatekCella.ltag;
                                fmezo++;
                            }
                        }
                        if (oszlop == 1) //{0,1} left,up
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else if (oszlop + 2 == JatekMatrix.oszlop + 1) //{0,48} left,down
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else if (oszlop + 1 == JatekMatrix.oszlop) //{0,49} left,down
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else //{0,2-47} in-between
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }

                    }
                }
                else if (sor + 1 == JatekMatrix.sor)
                {
                    for (int i = sor-1; i < sor++; i++)
                    {
                        if (oszlop == 0) //{0,0} left,up
                        {
                            if (JatekCella.free == true)
                            {
                                szabadmezok[szmezo] = JatekCella.ltag;
                                szmezo++;
                            }
                            else
                            {
                                foglaltmezok[szmezo] = JatekCella.ltag;
                                fmezo++;
                            }
                        }
                        if (oszlop == 1) //{0,1} left,up
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else if (oszlop + 2 == JatekMatrix.oszlop + 1) //{0,48} left,down
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else if (oszlop + 1 == JatekMatrix.oszlop) //{0,49} left,down
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else //{0,2-47} in-between
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }

                    }
                }
                else if (sor + 2 == JatekMatrix.sor+1)
                {
                    for (int i = sor - 2; i < sor++; i++)
                    {
                        if (oszlop == 0) //{0,0} left,up
                        {
                            if (JatekCella.free == true)
                            {
                                szabadmezok[szmezo] = JatekCella.ltag;
                                szmezo++;
                            }
                            else
                            {
                                foglaltmezok[szmezo] = JatekCella.ltag;
                                fmezo++;
                            }
                        }
                        if (oszlop == 1) //{0,1} left,up
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else if (oszlop + 2 == JatekMatrix.oszlop + 1) //{0,48} left,down
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else if (oszlop + 1 == JatekMatrix.oszlop) //{0,49} left,down
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else //{0,2-47} in-between
                        {
                            for (int d = oszlop - 1; d < oszlop + 2; d++)
                            {
                                if (JatekCella.free == true)
                                {
                                    szabadmezok[szmezo] = JatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = JatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }

                    }
                }
                else //{2-48,2-48} anywhere not border
                {
                    for (int i = sor-2; i < sor+2; i++)
                    {
                        for (int d = oszlop-2; d < oszlop+2; d++)
                        {
                            if (JatekCella.free == true)
                            {
                                szabadmezok[szmezo] = JatekCella.ltag;
                                szmezo++;
                            }
                            else
                            {
                                foglaltmezok[szmezo] = JatekCella.ltag;
                                fmezo++;
                            }
                        }
                    }
                }
                #endregion
            }


        }
        internal void Mozog()
        {
            
            
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
