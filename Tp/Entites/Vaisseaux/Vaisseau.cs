using Modeles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modeles.Entites.Vaisseaux
{
    public class Vaisseau : Entite, IDeplacement
    {
        public int Vitesse { get; set; }

        public Vaisseau(string Nom, int PositionX, int PositionY, int Vitesse) : base(Nom, PositionX, PositionY)
        {
            this.Vitesse = Vitesse;
        }

        public virtual void Deplacer()
        {
            this.PositionX += Vitesse;
            this.PositionY += Vitesse;
        }
    }
}
