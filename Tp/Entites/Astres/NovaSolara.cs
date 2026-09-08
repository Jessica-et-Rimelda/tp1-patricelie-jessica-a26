using System;
using System.Collections.Generic;
using System.Text;
using Modeles.Interfaces;

namespace Modeles.Entites.Astres
{
    public class NovaSolara : Astre, IDeplacement
    {
        const int vitesseDeplacement = 1;

        public double Luminosite { get; set; }
        public static bool peutSeDeplacer = true;
        public static int tranchesDeplacement;

        public NovaSolara(string Nom, int PositionX, int PositionY, double Luminosite) : base(Nom, PositionX, PositionY)
        {
            this.Luminosite = Luminosite;
        }

        public void Deplacer()
        {
            PeutSeDeplacer();
            if (peutSeDeplacer)
            {
                this.PositionX += vitesseDeplacement;
                this.PositionY += vitesseDeplacement;
                tranchesDeplacement++;
            }

            if(tranchesDeplacement > 3)
            {
                Luminosite -= Luminosite * 0.2;
                tranchesDeplacement = 0;

                PeutSeDeplacer();
            }
        }

        public void PeutSeDeplacer()
        {
            if (Luminosite < 1)
                peutSeDeplacer = false;
        }
    }
}
