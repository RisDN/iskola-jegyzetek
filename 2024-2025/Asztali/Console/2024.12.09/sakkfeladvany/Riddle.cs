﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sakkfeladvany
{
    internal class Riddle
    {
        public int MegoldasSorszama { get; set; }
        public int OszlopokSzama { get; set; }
        public int SorokSzama { get; set; }
        public int[,] Tabla { get; set; }


        public Riddle(int sorokSzama, int oszlopokSzama)
        {
            MegoldasSorszama = 0;
            SorokSzama = sorokSzama;
            OszlopokSzama = oszlopokSzama;
            Tabla = new int[sorokSzama, oszlopokSzama];

            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    Tabla[i, j] = 0;
                }
            }

        }


        public bool EzJoMezo(int sor, int oszlop)
        {
            
        }



        public void MegoldasokKeresese(int kiralynoSora)
        {
            if (kiralynoSora == SorokSzama)
            {
                MegoldasSorszama++;
                TablaKiir();
            }
            else
            {
                for (int aktOszlop = 0; aktOszlop < OszlopokSzama; aktOszlop++)
                {
                    if (EzJoMezo(kiralynoSora, aktOszlop))
                    {
                        Tabla[kiralynoSora, aktOszlop] = 1;
                        MegoldasokKeresese(kiralynoSora + 1);
                        Tabla[kiralynoSora, aktOszlop] = 0;
                    }
                }
            }
        }

        public void TablaKiir()
        {

            for (int i = 0; i < Tabla.GetLength(0); i++)
            {

                for (int j = 0; j < Tabla.GetLength(1); j++)
                {
                    Console.Write(Tabla[i, j]);

                }
                Console.WriteLine();

            }
        }

    }
}