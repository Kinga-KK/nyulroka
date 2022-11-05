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
        internal JatekCella jatekCella;
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
                if (sor < 1)
                {
                    for (int i = sor; i < sor++; i++)
                    {
                        if (oszlop < 1)
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (jatekCella.Free == true)
                                {
                                    szabadmezok[szmezo] = jatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = jatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }
                        else if (oszlop+1==JatekMatrix.oszlop)
                        {
                                for (int d = oszlop; d < oszlop++; d++)
                                {
                                    if (jatekCella.Free == true)
                                    {
                                        szabadmezok[szmezo] = jatekCella.ltag;
                                        szmezo++;
                                    }
                                    else
                                    {
                                        foglaltmezok[szmezo] = jatekCella.ltag;
                                        fmezo++;
                                    }
                                }

                        }
                        else
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (jatekCella.Free == true)
                                {
                                    szabadmezok[szmezo] = jatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = jatekCella.ltag;
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
                        if (oszlop < 1)
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (jatekCella.Free == true)
                                {
                                    szabadmezok[szmezo] = jatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = jatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }
                        else if (oszlop + 1 == JatekMatrix.oszlop)
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (jatekCella.Free == true)
                                {
                                    szabadmezok[szmezo] = jatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = jatekCella.ltag;
                                    fmezo++;
                                }
                            }

                        }
                        else
                        {
                            for (int d = oszlop; d < oszlop++; d++)
                            {
                                if (jatekCella.Free == true)
                                {
                                    szabadmezok[szmezo] = jatekCella.ltag;
                                    szmezo++;
                                }
                                else
                                {
                                    foglaltmezok[szmezo] = jatekCella.ltag;
                                    fmezo++;
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int i = sor; i < sor++; i++)
                    {
                        for (int d = oszlop; d < oszlop++; d++)
                        {
                            if (jatekCella.Free == true)
                            {
                                szabadmezok[szmezo] = jatekCella.ltag;
                                szmezo++;
                            }
                            else
                            {
                                foglaltmezok[szmezo] = jatekCella.ltag;
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
                #endregion
            }


        }
        internal void Mozog()
        {
            //string[] szabadmezok = new string[9];
            
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
