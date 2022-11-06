using System;

namespace RokaMoka
{
    class Allat
    {
        private int hp;
        internal bool IsBunny;
        internal string ID;
        private static int idseged = 0;
        internal static int dead = 0;
        private int sor;
        private int oszlop;
        //internal string[] szabadmezok = new string[25];
        //internal string[] foglaltmezok = new string[25];
        internal Random r = new Random();
        internal string ltag;

        internal int HP
        {
            get 
            {
                return hp;
            } 
            set
            {

                //hp = value;
                //ha nyuszi és 5-nél nagyobb hp-t kapna, akkor csak 5-öt kap, egyébként az értéket 
                if (IsBunny && value > 5)
                {
                    hp = 5;
                }
                else if (IsBunny)
                {
                    hp = value;
                }
                //mint a fenti, csak róka és 10-nél nem lehet nagyobb
                if (!IsBunny && value > 10)
                {
                    hp = 10;
                }
                else if (!IsBunny)
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
            sor = n;
            oszlop = m;
            IsBunny = chance < BN;
            //IsBunny = (chance-20) > 50;
            HP = IsBunny ? 3 : 5;
            //hp = 5;
            IDmkr();
            ltag = sor + "," + oszlop;
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
        //private void Scan()
        //{
        //    int szmezo = 0;
        //    int fmezo = 0;
            
        //    if (IsBunny == true)
        //    {
        //        #region Bunny
        //        if (sor == 0)
        //        {
        //            for (int i = sor; i < sor++; i++)
        //            {
        //                if (oszlop == 0) //{0,0} left,up
        //                {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                }
        //                else if (oszlop+1==JatekMatrix.oszlop) //{0,49} left,down
        //                {
        //                        for (int d = oszlop; d < oszlop++; d++)
        //                        {
        //                            if (JatekCella.free == true)
        //                            {
        //                                szabadmezok[szmezo] = JatekCella.ltag;
        //                                szmezo++;
        //                            }
        //                            else
        //                            {
        //                                foglaltmezok[szmezo] = JatekCella.ltag;
        //                                fmezo++;
        //                            }
        //                        }

        //                }
        //                else //{0,1-48} in-between
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++) 
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //        if (sor == 0)
        //        {
        //            for (int i = sor; i < sor++; i++)
        //            {
        //                if (oszlop == 0) //{0,0} left,up
        //                {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                }
        //                else if (oszlop+1==JatekMatrix.oszlop) //{0,49} left,down
        //                {
        //                        for (int d = oszlop; d < oszlop++; d++)
        //                        {
        //                            if (JatekCella.free == true)
        //                            {
        //                                szabadmezok[szmezo] = JatekCella.ltag;
        //                                szmezo++;
        //                            }
        //                            else
        //                            {
        //                                foglaltmezok[szmezo] = JatekCella.ltag;
        //                                fmezo++;
        //                            }
        //                        }

        //                }
        //                else //{0,1-48} in-between
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++) 
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //        else if (sor+1 == JatekMatrix.sor)
        //        {
        //            for (int i = sor; i < sor++; i++)
        //            {
        //                if (oszlop == 0) //{49,0) right up
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }
        //                }
        //                else if (oszlop + 1 == JatekMatrix.oszlop) //{49,49} right down
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++) //{49,1-48} in-between
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        else //{1-49,1-49} anywhere not border
        //        {
        //            for (int i = sor; i < sor++; i++)
        //            {
        //                for (int d = oszlop; d < oszlop++; d++)
        //                {
        //                    if (JatekCella.free == true)
        //                    {
        //                        szabadmezok[szmezo] = JatekCella.ltag;
        //                        szmezo++;
        //                    }
        //                    else
        //                    {
        //                        foglaltmezok[szmezo] = JatekCella.ltag;
        //                        fmezo++;
        //                    }
        //                }
        //            }
        //        }
        //        #endregion
        //    }
        //    else
        //    {
        //        #region Fox
        //        if (sor == 0)
        //        {
        //            for (int i = sor; i < sor++; i++)
        //            {
        //                if (oszlop == 0) //{0,0} left,up
        //                {
        //                    if (JatekCella.free == true)
        //                    {
        //                        szabadmezok[szmezo] = JatekCella.ltag;
        //                        szmezo++;
        //                    }
        //                    else
        //                    {
        //                        foglaltmezok[szmezo] = JatekCella.ltag;
        //                        fmezo++;
        //                    }
        //                }
        //                if (oszlop == 1) //{0,1} left,up
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else if (oszlop + 2 == JatekMatrix.oszlop + 1) //{0,48} left,down
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else if (oszlop + 1 == JatekMatrix.oszlop) //{0,49} left,down
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else //{0,2-47} in-between
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //        else if (sor == 1)
        //        {
        //            for (int i = sor; i < sor++; i++)
        //            {
        //                if (oszlop == 0) //{0,0} left,up
        //                {
        //                    if (JatekCella.free == true)
        //                    {
        //                        szabadmezok[szmezo] = JatekCella.ltag;
        //                        szmezo++;
        //                    }
        //                    else
        //                    {
        //                        foglaltmezok[szmezo] = JatekCella.ltag;
        //                        fmezo++;
        //                    }
        //                }
        //                if (oszlop == 1) //{0,1} left,up
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else if (oszlop + 2 == JatekMatrix.oszlop + 1) //{0,48} left,down
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else if (oszlop + 1 == JatekMatrix.oszlop) //{0,49} left,down
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else //{0,2-47} in-between
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //        else if (sor + 1 == JatekMatrix.sor)
        //        {
        //            for (int i = sor-1; i < sor++; i++)
        //            {
        //                if (oszlop == 0) //{0,0} left,up
        //                {
        //                    if (JatekCella.free == true)
        //                    {
        //                        szabadmezok[szmezo] = JatekCella.ltag;
        //                        szmezo++;
        //                    }
        //                    else
        //                    {
        //                        foglaltmezok[szmezo] = JatekCella.ltag;
        //                        fmezo++;
        //                    }
        //                }
        //                if (oszlop == 1) //{0,1} left,up
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else if (oszlop + 2 == JatekMatrix.oszlop + 1) //{0,48} left,down
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else if (oszlop + 1 == JatekMatrix.oszlop) //{0,49} left,down
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else //{0,2-47} in-between
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //        else if (sor + 2 == JatekMatrix.sor+1)
        //        {
        //            for (int i = sor - 2; i < sor++; i++)
        //            {
        //                if (oszlop == 0) //{0,0} left,up
        //                {
        //                    if (JatekCella.free == true)
        //                    {
        //                        szabadmezok[szmezo] = JatekCella.ltag;
        //                        szmezo++;
        //                    }
        //                    else
        //                    {
        //                        foglaltmezok[szmezo] = JatekCella.ltag;
        //                        fmezo++;
        //                    }
        //                }
        //                if (oszlop == 1) //{0,1} left,up
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else if (oszlop + 2 == JatekMatrix.oszlop + 1) //{0,48} left,down
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else if (oszlop + 1 == JatekMatrix.oszlop) //{0,49} left,down
        //                {
        //                    for (int d = oszlop; d < oszlop++; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }

        //                }
        //                else //{0,2-47} in-between
        //                {
        //                    for (int d = oszlop - 1; d < oszlop + 2; d++)
        //                    {
        //                        if (JatekCella.free == true)
        //                        {
        //                            szabadmezok[szmezo] = JatekCella.ltag;
        //                            szmezo++;
        //                        }
        //                        else
        //                        {
        //                            foglaltmezok[szmezo] = JatekCella.ltag;
        //                            fmezo++;
        //                        }
        //                    }
        //                }

        //            }
        //        }
        //        else //{2-48,2-48} anywhere not border
        //        {
        //            for (int i = sor-2; i < sor+2; i++)
        //            {
        //                for (int d = oszlop-2; d < oszlop+2; d++)
        //                {
        //                    if (JatekCella.free == true)
        //                    {
        //                        szabadmezok[szmezo] = JatekCella.ltag;
        //                        szmezo++;
        //                    }
        //                    else
        //                    {
        //                        foglaltmezok[szmezo] = JatekCella.ltag;
        //                        fmezo++;
        //                    }
        //                }
        //            }
        //        }
        //        #endregion
        //    }


        //}
        internal void Mozog()
        {
            if (sor==0)
            {
                if (oszlop==0)
                {
                    if (r.Next(1, 3)%2==0)
                    {
                        if (JatekMatrix.allatok.Exists(x=>x.ltag!=(sor + "," + (oszlop+1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop+1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop+1].ID = ID;
                            oszlop++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor+1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor+1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor+1, oszlop].ID = ID;
                            sor++;
                        }
                    }
                    else
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor+1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor+1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor+1, oszlop].ID = ID;
                            sor++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop+1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop+1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop+1].ID = ID;
                            oszlop++;
                        }
                    }
                }
                else if (oszlop==JatekMatrix.oszlop-1)
                {
                    if (r.Next(1, 3) % 2 == 0)
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop-1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop-1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop-1].ID = ID;
                            oszlop--;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor+1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor+1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor+1, oszlop].ID = ID;
                            sor++;
                        }
                    }
                    else
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor+1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor+1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor+1, oszlop].ID = ID;
                            sor++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop-1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop-1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop-1].ID = ID;
                            oszlop--;
                        }

                    }
                }
                else
                {
                    if (r.Next(1, 3) % 2 == 0)
                    {
                        if (r.Next(1, 3) % 2 == 0)
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop+1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop+1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop+1].ID = ID;
                                oszlop++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor+1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor+1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor+1, oszlop].ID = ID;
                                sor++;
                            }
                        }
                        else
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor+1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor+1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor+1, oszlop].ID = ID;
                                sor++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop+1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop+1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop+1].ID = ID;
                                oszlop++;
                            }
                        }
                    }
                    else
                    {
                        if (r.Next(1, 3) % 2 == 0)
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop-1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop-1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop-1].ID = ID;
                                oszlop--;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor - 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor-1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor-1, oszlop].ID = ID;
                                sor--;
                            }
                        }
                        else
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor+1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor+1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor+1, oszlop].ID = ID;
                                sor++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop+1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop+1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop+1].ID = ID;
                                oszlop++;
                            }

                        }
                    }
                }
            }
            else if (sor==JatekMatrix.sor-1)
            {
                if (oszlop == 0)
                {
                    if (r.Next(1, 3) % 2 == 0)
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop + 1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                            oszlop++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                            sor++;
                        }
                    }
                    else
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                            sor++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop + 1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                            oszlop++;
                        }
                    }
                }
                else if (oszlop == JatekMatrix.oszlop - 1)
                {
                    if (r.Next(1, 3) % 2 == 0)
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop - 1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop - 1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop - 1].ID = ID;
                            oszlop--;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                            sor++;
                        }
                    }
                    else
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                            sor++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop - 1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop - 1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop - 1].ID = ID;
                            oszlop--;
                        }

                    }
                }
                else
                {
                    if (r.Next(1, 3) % 2 == 0)
                    {
                        if (r.Next(1, 3) % 2 == 0)
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop + 1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                                oszlop++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                                sor++;
                            }
                        }
                        else
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                                sor++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop + 1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                                oszlop++;
                            }
                        }
                    }
                    else
                    {
                        if (r.Next(1, 3) % 2 == 0)
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop - 1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop - 1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop - 1].ID = ID;
                                oszlop--;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor - 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor - 1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor - 1, oszlop].ID = ID;
                                sor--;
                            }
                        }
                        else
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                                sor++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop + 1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                                oszlop++;
                            }

                        }
                    }
                }
            }
            else
            {
                if (oszlop == 0)
                {
                    if (r.Next(1, 3) % 2 == 0)
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop + 1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                            oszlop++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                            sor++;
                        }
                    }
                    else
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                            sor++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop + 1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                            oszlop++;
                        }
                    }
                }
                else if (oszlop == JatekMatrix.oszlop - 1)
                {
                    if (r.Next(1, 3) % 2 == 0)
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop - 1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop - 1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop - 1].ID = ID;
                            oszlop--;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                            sor++;
                        }
                    }
                    else
                    {
                        if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                            JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                            sor++;
                        }
                        else if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop - 1))))
                        {
                            JatekMatrix.jmatrix[sor, oszlop].free = true;
                            JatekMatrix.jmatrix[sor, oszlop].ID = "";
                            JatekMatrix.jmatrix[sor, oszlop - 1].free = false;
                            JatekMatrix.jmatrix[sor, oszlop - 1].ID = ID;
                            oszlop--;
                        }

                    }
                }
                else
                {
                    if (r.Next(1, 3) % 2 == 0)
                    {
                        if (r.Next(1, 3) % 2 == 0)
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop + 1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                                oszlop++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                                sor++;
                            }
                        }
                        else
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                                sor++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != (sor + "," + (oszlop + 1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                                oszlop++;
                            }
                        }
                    }
                    else
                    {
                        if (r.Next(1, 3) % 2 == 0)
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop - 1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop - 1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop - 1].ID = ID;
                                oszlop--;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor - 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor - 1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor - 1, oszlop].ID = ID;
                                sor--;
                            }
                        }
                        else
                        {
                            if (JatekMatrix.allatok.Exists(x => x.ltag != ((sor + 1) + "," + oszlop)))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor + 1, oszlop].free = false;
                                JatekMatrix.jmatrix[sor + 1, oszlop].ID = ID;
                                sor++;
                            }
                            else if (JatekMatrix.allatok.Exists(x => x.ltag == (sor + "," + (oszlop + 1))))
                            {
                                JatekMatrix.jmatrix[sor, oszlop].free = true;
                                JatekMatrix.jmatrix[sor, oszlop].ID = "";
                                JatekMatrix.jmatrix[sor, oszlop + 1].free = false;
                                JatekMatrix.jmatrix[sor, oszlop + 1].ID = ID;
                                oszlop++;
                            }

                        }
                    }
                }
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
